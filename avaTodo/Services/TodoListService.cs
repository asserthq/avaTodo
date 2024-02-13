using System.Collections.Generic;
using avaTodo.Models;

namespace avaTodo.Services
{
    public class TodoListService
    {
        public IEnumerable<TodoItem> GetItems() => new[]
        {
            new TodoItem { Description = "Workat'" },
            new TodoItem { Description = "Uchit'", IsDone = true },
            new TodoItem { Description = "Ezdit'" }
        };
    }
}
