using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using TeamCollaboration.Data.UnitOfWork;

namespace TeamCollaboration.Data.Test.Initializers
{
    [TestClass]
    public class AssemblyTestsInitialize
    {

        /// <summary>
        ///    所有测试方法执行前的基础代码
        /// </summary>
        /// <param name="context"></param>
        [AssemblyInitialize()]
        public static void RebuildUnitOfWork(TestContext context)
        {
            Database.SetInitializer<MainTCUnitOfWork>(new MainTCUnitOfWorkInitializers());
        }

    }
}
