using BlazorNet10Demo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorNet10Demo.DataAccess.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<TaskItem> TaskItems { get; set; }
}
