using MediatR;

namespace Aplication.Notes.Commands.DeleteCommand;

public class DeleteNoteCommand : IRequest<Unit>
{
    public Guid UserId { get; set; }
    public Guid Id { get; set; }
}