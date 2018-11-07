using System;
using System.ComponenetModel.DataAnnotations;

namespace DotNetCore.Models
{
    public class TodoViewModel
    {
        public TodoItem[] Items { get; set; }
    }

    public class TodoItem
    {
        public Guid Id { get; set; }

        public bool IsDone { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTimeOffset? DueAt { get; set; }
    }
}