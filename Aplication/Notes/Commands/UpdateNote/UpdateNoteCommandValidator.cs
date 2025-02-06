using FluentValidation;

namespace Aplication.Notes.Commands.UpdateNote;

public class UpdateNoteCommandValidator : AbstractValidator<UpdateNoteCommand>
{
    public UpdateNoteCommandValidator()
    {
        RuleFor(updateNoteCommand => updateNoteCommand.UserId)
            .NotNull()
            .NotEmpty();
        RuleFor(updateNoteCommand => updateNoteCommand.Id)
            .NotNull()
            .NotEmpty();
        RuleFor(updateNoteCommand => updateNoteCommand.Title)
            .NotNull()
            .NotEmpty()
            .MaximumLength(250);

    }
}