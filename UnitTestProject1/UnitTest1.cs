using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TC_ToDo;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var temp = ToDoCategory.Important | ToDoCategory.NotUrgency;
            Assert.AreEqual(9, (byte)temp);
           
        }


        [TestMethod]
        public void TestTodoEvent()
        {
            var todo = new ToDo
            {
                 Id= Guid.NewGuid(),
                 Category= ToDoCategory.NotImportant,
                 State= ToDoState.NotStarted
            };
            var consumer = new Consumer(todo);
            todo.ChangeCategory(ToDoCategory.Urgency);


            Assert.AreEqual("", consumer.Temp);


        }

       


    }
}
