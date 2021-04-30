using System;
using Legacycodeplayground;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Legacycodeplaygroundtests
{
    [TestClass]
    public class Sanity
    {
        [TestMethod]
        public void TestMethod1()
        {

            UnbelievableComplexClass myUnbelievable = new UnbelievableComplexClass();
            UnInstantiableClass myClass = new UnInstantiableClass(myUnbelievable);
            myClass.MethodA(30);
            myClass.MethodB(50);
            Assert.AreEqual(1004, myClass.GetAmount());
        }
    }
       
}

