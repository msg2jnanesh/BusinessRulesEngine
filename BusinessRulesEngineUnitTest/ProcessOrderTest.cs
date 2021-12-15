using Buine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessRulesEngineUnitTest
{
    [TestClass]
    public class ProcessOrderTest
    {
        private readonly ProcessOrderEngine _processOrderEngine;
        public ProcessOrderTest()
        {
            _processOrderEngine = new ProcessOrderEngine();
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void ProcessOrderEngine_ProcessOrder_ForInvalidOrderType()
        {
            _processOrderEngine.ProcessOrder("invalidOrderType");
        }
        [TestMethod]
        public void ProcessOrderEngine_ProcessOrder_ForPackingSlipForShipping()
        {
            var result = _processOrderEngine.ProcessOrder("PackingSlipForShipping");
            Assert.AreEqual(result, "PackingSlipForShipping Called");
        }

        [TestMethod]
        public void ProcessOrderEngine_ProcessOrder_ForPackingSlipFortheRoyaltyDepartment()
        {
            var result = _processOrderEngine.ProcessOrder("PackingSlipFortheRoyaltyDepartment");
            Assert.AreEqual(result, "PackingSlipFortheRoyaltyDepartment Called");
        }
    }
}
