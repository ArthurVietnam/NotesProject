using MediatR;

namespace Aplication.Notes.Queries.GetNoteList;

public class GetNoteListQuery : IRequest<NoteListVm>
{
    public Guid UserId { get; set; }
}