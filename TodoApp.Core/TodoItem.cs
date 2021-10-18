using System;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Core
{
    public class TodoItem
    {
        
        public int ID { get; set;  }
        public string Title { get; set; }
        public bool IsComplete { get; set; }


        public TodoItem()
        {
            this.Title = "Default";
            this.IsComplete = false;
        }

        public TodoItem (string title)
        {
            this.Title = title;
            this.IsComplete = false;
        }

        public TodoItem(string title, bool isComplete)
        {
            this.Title = title;
            this.IsComplete = isComplete;
        }

        public void MarkComplete()
        {
            this.IsComplete = true;
        }
    }
}
