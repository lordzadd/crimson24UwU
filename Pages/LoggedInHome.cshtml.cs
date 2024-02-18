// LoggedInHome.cshtml.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Auth0_Blazor.Pages
{
    public class LoggedInHomeModel : PageModel
    {

            private readonly ILogger<LoggedInHomeModel> _logger;

            public LoggedInHomeModel(ILogger<LoggedInHomeModel> logger)
            {
                _logger = logger;
            }

        [BindProperty]
        public string NewTodo { get; set; } = string.Empty;

        [BindProperty]
        public List<Todo> Todos { get; set; } = new List<Todo>();

        public void OnGet()
        {
        }

        //public void OnPostAddTodo()
        //{
        //    if (!string.IsNullOrWhiteSpace(NewTodo))
        //    {
        //        Todos.Add(new Todo { Text = NewTodo });
        //        NewTodo = string.Empty;
        //    }
        //}
        public void OnPostAddTodo()
        {
            _logger.LogInformation("OnPostAddTodo called with NewTodo: {NewTodo}", NewTodo);

            if (!string.IsNullOrWhiteSpace(NewTodo))
            {
                Todos.Add(new Todo { Text = NewTodo });
                NewTodo = string.Empty;
            }
        }

        public class Todo
        {
            public string Text { get; set; } = string.Empty;
            public bool IsDone { get; set; }
        }
    }
}
