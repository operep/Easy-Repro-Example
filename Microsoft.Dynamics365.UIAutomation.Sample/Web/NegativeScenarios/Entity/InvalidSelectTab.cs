﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Microsoft.Dynamics365.UIAutomation.Sample.Web
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class InvalidSelectTab : TestBase
    {
        [TestInitialize]
        public override void TestSetup()
        {
            XrmTestBrowser.ThinkTime(500);
            OpenEntity("Sales", "Accounts", "Active Accounts");
            HasData = OpenEntityGrid();
        }

        [TestMethod]
        public void WEBTestInvalidSelectTab()
        {
            if (!HasData) return;
            try
            {
                XrmTestBrowser.Entity.SelectTab("Summarry");
                Assert.Fail("Summarry is an invalid Tab name and hence should have failed");
            }
            catch (Exception e)
            {
                Assert.IsTrue(true, String.Format("Exception expected: {0}", e.Message));
            }
        }
    }
}