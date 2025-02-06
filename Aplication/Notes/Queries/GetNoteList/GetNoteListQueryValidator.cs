using FluentValidation;

namespace Aplication.Notes.Queries.GetNoteList;

public class GetNoteListQueryValidator : AbstractValidator<GetNoteListQuery>
{
    public GetNoteListQueryValidator()
    {
        RuleFor(getNoteListQueryValidator => getNoteListQueryValidator.UserId)
            .NotNull()
            .NotEqual(Guid.Empty);
    }
}