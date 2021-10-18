 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Core;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoApp.DAL;

namespace TodoApp.WebServer.Pages
{
    public class AddTodoModel : PageModel
    {
        [BindProperty]

        public TodoItem AddedTodo { get; set; }
        private TodoService _service;

        public AddTodoModel(TodoService service)
        {
            this._service = service;
        }
    

         public void OnGet()
         {

         }


          
        public void OnPost()
        {
            if (this.ModelState.IsValid)
            {
                //add to db
                this._service.AddTodo(this.AddedTodo);
             
            }
        }
    }
}
