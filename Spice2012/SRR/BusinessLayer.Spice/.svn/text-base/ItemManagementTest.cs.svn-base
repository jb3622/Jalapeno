using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Disney.iDash.SRR.BusinessLayer.Spice
{
    [TestFixture]
    public class ItemManagementTest
    {
        private ItemMarket itemMarket101;
        private ItemMarkets itemMarkets101;

        //private ItemManagement itemM121;
        //private ItemManagement itemM222;
        //private ItemManagement itemM22A;


        /// <summary>
        /// 
        /// </summary>
        [SetUp]
        protected void Setup()
        {
            itemMarkets101 = new ItemMarkets();
            itemMarket101 = new ItemMarket();

        }

        /// <summary>
        /// 
        /// </summary>
        /// 
        [Test]
        public void AddNewMarket()
        {
            //taken off TDS2
            itemMarket101.Division = 1;
            itemMarket101.Department = 16;
            itemMarket101.ItemClass = 1006;
            itemMarket101.Vendor = 1258;
            itemMarket101.Style = 1124;
            itemMarket101.Colour = 0;
            itemMarket101.Size = 0;
            itemMarket101.MarketCode = "AU";
            itemMarket101.MarketCurrency = "PE";
            itemMarket101.CostPrice = 50.00M;
            itemMarket101.RetailPrice = 60.00M;
            itemMarket101.ListPrice = 60.00M;
            itemMarket101.SKU = 111;
            itemMarket101.VATCode = "U";
            itemMarket101.VendorUPC = 12345678;
            itemMarket101.SKUCheckDigit = 987656789;
                        
            Assert.IsTrue(itemMarket101.Save());
   
            //Assert.AreEqual("itsamess", "itsamess");
            //Assert.IsTrue(fMB1.Multiply(0).IsZero);
            //Assert.IsFalse(f12CHF.Equals(f14CHF));

        }

        /// <summary>
        /// 
        /// </summary>
        /// 
        [Test]
        public void AddNewMarket2()
        {
            //taken off TDS2
            itemMarket101.Division = 1;
            itemMarket101.Department = 16;
            itemMarket101.ItemClass = 1006;
            itemMarket101.Vendor = 1258;
            itemMarket101.Style = 1124;
            itemMarket101.Colour = 0;
            itemMarket101.Size = 0;
            itemMarket101.MarketCode = "AU";
            itemMarket101.MarketCurrency = "PE";
            itemMarket101.CostPrice = 50.00M;
            itemMarket101.RetailPrice = 60.00M;
            itemMarket101.ListPrice = 60.00M;
            itemMarket101.SKU = 111;
            itemMarket101.VATCode = "U";
            itemMarket101.VendorUPC = 12345678;
            itemMarket101.SKUCheckDigit = 987656789;

            itemMarkets101.Add(itemMarket101);
            Assert.IsTrue(itemMarkets101.Save());

            //Assert.AreEqual("itsamess", "itsamess");
            //Assert.IsTrue(itemMarkets101.Save());
            //Assert.IsFalse(f12CHF.Equals(f14CHF));

        }

        /// <summary>
        /// 
        /// </summary>
        /// 
        [Test]
        public void TestDoSomething()
        {
            //Assert.AreEqual("itsamess", itemM111.DoSomething("itsamess"));
            //Assert.AreEqual("itsgood", itemM111.DoSomething("itsgood"));
        }



    }
}
