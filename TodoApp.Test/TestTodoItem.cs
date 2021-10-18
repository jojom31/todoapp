using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TodoApp.Core.Test
{
    [TestClass]
    public class TestTodoItem
    {
        [TestMethod]
        public void TodoItemTest()
        {
            TodoItem todoitem = new TodoItem("Finish Work");
            Assert.IsFalse(todoitem.IsComplete);
            Assert.AreEqual("Finish Work", todoitem.Title);


            todoitem.MarkComplete();
            Assert.IsTrue(todoitem.IsComplete);
        }
    }
}
