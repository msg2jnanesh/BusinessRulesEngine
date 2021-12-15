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

        [TestMethod]
        public void ProcessOrderEngine_ProcessOrder_ForActivateMembership()
        {
            var result = _processOrderEngine.ProcessOrder("ActivateMembership");
            Assert.AreEqual(result, "ActivateMembership Called");
        }


        [TestMethod]
        public void ProcessOrderEngine_ProcessOrder_ForApplyUpgrade()
        {
            var result = _processOrderEngine.ProcessOrder("ForApplyUpgrade");
            Assert.AreEqual(result, "ForApplyUpgrade Called");
        }

        [TestMethod]
        public void ProcessOrderEngine_ProcessOrder_ForActivationUpgradeEmail()
        {
            var result = _processOrderEngine.ProcessOrder("ForActivationUpgradeEmail");
            Assert.AreEqual(result, "ForActivationUpgradeEmail Called");
        }

        [TestMethod]
        public void ProcessOrderEngine_ProcessOrder_ForFreeVideo()
        {
            var result = _processOrderEngine.ProcessOrder("ForFreeVideo");
            Assert.AreEqual(result, "ForFreeVideo Called");
        }
    }
}
