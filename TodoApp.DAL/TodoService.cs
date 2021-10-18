
using System;
using System.Collections.Generic;
using System.Linq;
using TodoApp.Core;

namespace TodoApp.DAL
{
    public class TodoService
    {
        TodoDbContext _context;


        public TodoService()
        {
            _context = new TodoDbContext();
        }


        public TodoItem GetTodoById(int id)
        {
            return this._context.Todos.Where(todoitem => todoitem.ID == id).FirstOrDefault();
        }

        public List<TodoItem> GetAllTodoItems()
        {
            return this._context.Todos.ToList();
        }

        public TodoItem TodoItem(TodoItem todoitem)
        {
            this._context.Todos.Add(todoitem);
            this._context.SaveChanges();
            return todoitem;
        }

        public void AddTodo(TodoItem todoItem)
        {
            this._context.Todos.Add(todoItem);
        }

        public TodoItem MarkComplete(int id)
        {
            TodoItem todoitem = this.GetTodoById(id);
            if(todoitem != null)
            {
                todoitem.MarkComplete();
                this._context.SaveChanges();
            }
            
            return todoitem;
        }

        public TodoItem RemoveTodoItem(int id)
        {
            TodoItem todoitem = this.GetTodoById(id);
            if(todoitem != null)
            {
                this._context.Todos.Remove(todoitem);
                this._context.SaveChanges();
            }
            return todoitem;
        }
    }
}
