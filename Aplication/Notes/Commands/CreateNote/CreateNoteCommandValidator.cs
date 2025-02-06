using FluentValidation;

namespace Aplication.Notes.Commands.CreateNote;

public class CreateNoteCommandValidator : AbstractValidator<CreateNoteCommand>
{
    public CreateNoteCommandValidator()
    {
        RuleFor(createNoteCommand => createNoteCommand.Title)
            .NotNull()
            .NotEmpty()
            .MaximumLength(250);
        RuleFor(createNoteCommand => createNoteCommand.UserId)
            .NotNull()
            .NotEmpty();
    }
}