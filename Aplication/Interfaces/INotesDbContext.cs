using Domain;
using Microsoft.EntityFrameworkCore;

namespace Aplication;

public interface INotesDbContext
{
    DbSet<Note> Notes { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}