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

            UnbelivableComplexClass myUnbelivable = new UnbelivableComplexClass();
            UnInstantiableClass myClass = new UnInstantiableClass(myUnbelivable);
            myClass.methodA(30);
            myClass.methodB(50);
            Assert.AreEqual(1004, myClass.getAmount());
        }
    }
       
}

