using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using System.Reflection;
using System.Linq;

namespace MyBook.Tests
{
    [TestClass]
    public class NinjectTests
    {
        [TestMethod]
        public void TestBindings()
        {           
            //Create kernel and Load assembly Application.Web
            var kernel = new Standardkernel();
            kernel.Load(new Assembly[] { Assembly.Load("MyBook.Web") });

            var query = from types in Assembly.Load("MyBook.Core").GetExportedTypes()
                        where types.IsInterface
                        where types.Namespace.StartsWith("MyBook.Core.Interface")
                        select types;
            foreach (var i in query.ToList())
            {
                kernel.Get(i);
            }                        
        }
    }
}
