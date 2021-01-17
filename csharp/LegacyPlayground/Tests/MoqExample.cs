using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Legacycodeplaygroundtests
{
    public class ToBeMocked
    {
        int myInt;

        public ToBeMocked(int initialInt)
        {
            myInt = initialInt;
        }

        virtual public int getMyInt()
        {
            return myInt;
        }
    }

    [TestClass]
    public class MoqExample
    {
       
        [TestMethod]
        public void MoqTest()
        {
            var mock = new Mock<ToBeMocked>(3);
            mock.Setup(x => x.getMyInt()).Returns(3);

            Assert.AreEqual(3, mock.Object.getMyInt());
        }
        
        [TestMethod]
        public void MoqTestSequence()
        {
            var mock = new Mock<ToBeMocked>(3);
            mock.SetupSequence(x => x.getMyInt()).Returns(3).Returns(2);

            Assert.AreEqual(3, mock.Object.getMyInt());
            Assert.AreEqual(2, mock.Object.getMyInt());
        }
    }
}
