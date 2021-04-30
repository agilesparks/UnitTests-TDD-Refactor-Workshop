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

        public virtual int GetMyInt()
        {
            return myInt;
        }

        public virtual int CallMe(int x)
        {
            return x;
        }
    }

    [TestClass]
    public class MoqExample
    {
       
        [TestMethod]
        public void MoqTest()
        {
            var mock = new Mock<ToBeMocked>(3);
            mock.Setup(x => x.GetMyInt()).Returns(3);

            Assert.AreEqual(3, mock.Object.GetMyInt());
        }
        
        [TestMethod]
        public void MoqTestSequence()
        {
            var mock = new Mock<ToBeMocked>(3);
            mock.SetupSequence(x => x.GetMyInt()).Returns(3).Returns(2);

            Assert.AreEqual(3, mock.Object.GetMyInt());
            Assert.AreEqual(2, mock.Object.GetMyInt());
        }

        [TestMethod]
        public void MoqCalled()
        {
            var mock = new Mock<ToBeMocked>(4);
            int param = 0;
           
            mock.Setup(x => x.CallMe(It.IsAny<int>()))
                .Callback<int>(r => param = r);

            mock.Object.CallMe(17);
            Assert.AreEqual(17,param);
            mock.Verify(x => x.CallMe(17), Times.Exactly(1));

        }
    }
}
