using FluentValidation;

namespace Aplication.Notes.Queries.GetNoteDetails;

public class GetNoteDetailsQueryValidator : AbstractValidator<GetNoteDetailsQuery>
{
    public GetNoteDetailsQueryValidator()
    {
        RuleFor(getNoteDetailsQueryValidator => getNoteDetailsQueryValidator.UserId)
            .NotNull()
            .NotEmpty();
        RuleFor(getNoteDetailsQueryValidator => getNoteDetailsQueryValidator.Id)
            .NotNull()
            .NotEmpty();
    }
}