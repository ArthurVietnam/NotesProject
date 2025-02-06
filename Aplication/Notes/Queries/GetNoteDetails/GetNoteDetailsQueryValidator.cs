using FluentValidation;

namespace Aplication.Notes.Queries.GetNoteDetails;

public class GetNoteDetailsQueryValidator : AbstractValidator<GetNoteDetailsQuery>
{
    public GetNoteDetailsQueryValidator()
    {
        RuleFor(getNoteDetailsQueryValidator => getNoteDetailsQueryValidator.UserId)
            .NotNull()
            .NotEqual(Guid.Empty);
        RuleFor(getNoteDetailsQueryValidator => getNoteDetailsQueryValidator.Id)
            .NotNull()
            .NotEqual(Guid.Empty);
    }
}