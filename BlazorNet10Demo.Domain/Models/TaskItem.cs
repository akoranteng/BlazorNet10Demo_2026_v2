using BlazorNet10Demo.Domain.Enums;
namespace BlazorNet10Demo.Domain.Models;

public class TaskItem
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    public TaskPriority Priority { get; set; } = TaskPriority.Medium;

    public BlazorNet10Demo.Domain.Enums.TaskStatus Status { get; set; }
    = BlazorNet10Demo.Domain.Enums.TaskStatus.NotStarted;


    //public TaskStatus Status { get; set; } = TaskStatus.NotStarted;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? CompletedAt { get; set; }
}
