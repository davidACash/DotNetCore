using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCore.Models;

namespace DotNetCore.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync();
    }
}