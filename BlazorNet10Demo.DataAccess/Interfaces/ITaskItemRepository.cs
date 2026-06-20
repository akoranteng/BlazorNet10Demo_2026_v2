using BlazorNet10Demo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using BlazorNet10Demo.Domain.Models;
namespace BlazorNet10Demo.DataAccess.Interfaces
{
    public interface ITaskItemRepository
    {
        Task<IEnumerable<TaskItem>> GetAllAsync();
        Task<TaskItem?> GetByIdAsync(int id);
        Task AddAsync(TaskItem task);
        Task UpdateAsync(TaskItem task);
        Task DeleteAsync(int id);
    }

}