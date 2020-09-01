using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PromotionEngine.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestcallAPromotionMethod()
        {  
            //Test with all scenarios
            Assert.IsTrue(callAPromotion(1, 50, 30, 20, 15)) ? Assert.Equals("Pass") : Assert.Fail();
            Assert.IsTrue(callAPromotion(2, 50, 30, 20, 15)) ? Assert.Equals("Pass") : Assert.Fail();
            Assert.IsTrue(callAPromotion(3, 50, 30, 20, 15)) ? Assert.Equals("Pass") : Assert.Fail();
            Assert.IsTrue(callAPromotion(4, 50, 30, 20, 15)) ? Assert.Equals("Pass") : Assert.Fail();
            Assert.IsTrue(callAPromotion(5, 50, 30, 20, 15)) ? Assert.Equals("Pass") : Assert.Fail();
            Assert.IsTrue(callAPromotion(6, 50, 30, 20, 15)) ? Assert.Equals("Pass") : Assert.Fail();
            Assert.IsTrue(callAPromotion(7, 50, 30, 20, 15)) ? Assert.Equals("Pass") : Assert.Fail();
            Assert.IsTrue(callAPromotion(8, 50, 30, 20, 15)) ? Assert.Equals("Pass") : Assert.Fail();
            Assert.IsTrue(callAPromotion(9, 50, 30, 20, 15)) ? Assert.Equals("Pass") : Assert.Fail();
            Assert.IsTrue(callAPromotion(10, 50, 30, 20, 15)) ? Assert.Equals("Pass") : Assert.Fail();

            Assert.IsTrue(callBPromotion(1, 50, 30, 20, 15)) ? Assert.Equals("Pass") : Assert.Fail();
            Assert.IsTrue(callBPromotion(2, 50, 30, 20, 15)) ? Assert.Equals("Pass") : Assert.Fail();
            Assert.IsTrue(callBPromotion(3, 50, 30, 20, 15)) ? Assert.Equals("Pass") : Assert.Fail();

            Assert.IsTrue(callCPromotion(1, 50, 30, 20, 15)) ? Assert.Equals("Pass") : Assert.Fail();
            Assert.IsTrue(callCPromotion(2, 50, 30, 20, 15)) ? Assert.Equals("Pass") : Assert.Fail();
        }
    }
}
