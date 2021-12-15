﻿using Buine.OrderProcessing;
using System;

namespace Buine.OrderProcessingFactory
{
    internal static class OrderProcessingFactory
    {
        public static OrderProcessingBase GetInstance(string type)
        {
            switch (type)
            {
                case "PackingSlipForShipping":
                    return new PackingSlipForShipping();
                case "PackingSlipFortheRoyaltyDepartment":
                    return new PackingSlipFortheRoyaltyDepartment();
                case "ActivateMembership":
                    return new ActivateMembership();
                case "ForApplyUpgrade":
                    return new ForApplyUpgrade();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
