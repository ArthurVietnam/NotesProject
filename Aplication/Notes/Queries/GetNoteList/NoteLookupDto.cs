﻿using AutoMapper;
using Domain;
using Persistence.Common.Mappings;

namespace Aplication.Notes.Queries.GetNoteList;

public class NoteLookupDto : IMapWith<Note>
{
    public Guid Id { get; set; }
    public string Title { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Note, NoteLookupDto>()
            .ForMember(noteDto => noteDto.Id,
                opt => opt.MapFrom(note => note.Id))
            .ForMember(noteDto => noteDto.Title,
                opt => opt.MapFrom(note => note.Title));
    }
}