using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegisterEngineV2.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterEngineV2.Facade.Tests
{
    [TestClass()]
    public class InventoryFacadeTests
    {
        [TestMethod()]
        public void GetInventoryTest()
        {
            InventoryFacade facade = new InventoryFacade();
            Assert.AreEqual(6, facade.GetInventory().Count);
        }
    }
}