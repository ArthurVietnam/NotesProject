using FluentValidation;

namespace Aplication.Notes.Commands.DeleteCommand;

public class DeleteNoteCommandValidator : AbstractValidator<DeleteNoteCommand>
{
    public DeleteNoteCommandValidator()
    {
        RuleFor(deleteNoteCommand => deleteNoteCommand.UserId)
            .NotNull()
            .NotEqual(Guid.Empty);
        RuleFor(deleteNoteCommand => deleteNoteCommand.Id)
            .NotNull()
            .NotEqual(Guid.Empty);
    }
}