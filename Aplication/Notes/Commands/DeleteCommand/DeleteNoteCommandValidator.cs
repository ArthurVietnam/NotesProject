using FluentValidation;

namespace Aplication.Notes.Commands.DeleteCommand;

public class DeleteNoteCommandValidator : AbstractValidator<DeleteNoteCommand>
{
    public DeleteNoteCommandValidator()
    {
        RuleFor(deleteNoteCommand => deleteNoteCommand.UserId)
            .NotNull()
            .NotEmpty();
        RuleFor(deleteNoteCommand => deleteNoteCommand.Id)
            .NotNull()
            .NotEmpty();
    }
}