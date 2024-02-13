using System;

namespace avaTodo.Models
{
    public class TodoItem
    {
        public string Description { get; set; } = String.Empty;
        public bool IsDone { get; set; } = false;
    }
}
