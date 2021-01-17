using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApprovalTests.Reporters;
using ApprovalTests;
using System;
using System.Collections.Generic;



namespace Legacycodeplaygroundtests
{

    public class ForApprovalDemonstration
    {
        public int first = 3;
        public List<String> myList = new List<String> { "first", "second", "third" };
        public override string ToString()
        {
            
            return "For Approval: first=" + first.ToString() + "\nmyList="   + "\n" +  string.Join("\n", myList.ToArray())    ;
        }
    }


    [TestClass]
    public class ApprovalTestsExamples
    {
        [ApprovalTests.Namers.UseApprovalSubdirectory("Approvals")]
        [UseReporter(typeof(VisualStudioReporter))]
        [TestMethod]
        public void SimpleVerify()
        {
            int myNumber = 8;
            Approvals.Verify(myNumber);
        }

        [ApprovalTests.Namers.UseApprovalSubdirectory("Approvals")]
        [UseReporter(typeof(VisualStudioReporter))]
        [TestMethod]
        public void ComplexVerify()
        {
            ForApprovalDemonstration complexClass = new ForApprovalDemonstration();
            Approvals.Verify(complexClass);
         }
    }
}

