﻿using MediatR;

namespace Aplication.Notes.Commands.UpdateNote;

public class UpdateNoteCommand : IRequest<Unit>
{
    public Guid UserId { get; set; }
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Details { get; set; }
}