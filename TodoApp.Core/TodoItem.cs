using System;

namespace TodoApp.Core
{
    public class TodoItem
    {
        public int TodoId { get; set;  }
        public string Title { get; set; }
        public bool IsComplete { get; set; }


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

        void MarkComplete()
        {
            this.IsComplete = true;
        }
    }
}
