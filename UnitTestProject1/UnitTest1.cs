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
    }
}
