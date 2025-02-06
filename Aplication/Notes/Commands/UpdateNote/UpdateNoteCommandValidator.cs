using FluentValidation;

namespace Aplication.Notes.Commands.UpdateNote;

public class UpdateNoteCommandValidator : AbstractValidator<UpdateNoteCommand>
{
    public UpdateNoteCommandValidator()
    {
        RuleFor(updateNoteCommand => updateNoteCommand.UserId)
            .NotNull()
            .NotEqual(Guid.Empty);
        RuleFor(updateNoteCommand => updateNoteCommand.Id)
            .NotNull()
            .NotEqual(Guid.Empty);
        RuleFor(updateNoteCommand => updateNoteCommand.Title)
            .NotNull()
            .NotEmpty()
            .MaximumLength(250);

    }
}