﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Aplication.Notes.Queries.GetNoteList;

public class GetNoteListQueryHandler:IRequestHandler<GetNoteListQuery,NoteListVm>
{
    private readonly INotesDbContext _dbContext;
    private readonly IMapper _mapper;

    public GetNoteListQueryHandler(INotesDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<NoteListVm> Handle(GetNoteListQuery request, CancellationToken cancellationToken)
    {
        var notesQuery = await _dbContext.Notes
            .Where(note => note.UserId == request.UserId)
            .ProjectTo<NoteLookupDto>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        return new NoteListVm { Notes = notesQuery };
    }
}