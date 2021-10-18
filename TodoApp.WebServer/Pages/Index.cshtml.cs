using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TodoApp.Core;
using TodoApp.DAL;

namespace TodoApp.WebServer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly TodoService _todoService;
        public List<TodoItem> Items = new List<TodoItem>();

        public IndexModel(ILogger<IndexModel> logger, TodoService todoService)
        {
            _logger = logger;
            this._todoService = todoService;
        }

        public void OnGet()
        {
            this.Items = this._todoService.GetAllTodoItems();
        }
    }
}
