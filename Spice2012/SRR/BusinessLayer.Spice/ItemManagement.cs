using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;

using Disney.iDash.DataLayer;
using Disney.iDash.LocalData;
using Disney.iDash.Shared;

/*
 * Add a style 
 * Add sizes / Add a size
 * 
 * 
 * */
namespace Disney.iDash.SRR.BusinessLayer.Spice
{
    public class ItemManagement   
    {
        private string _varA = string.Empty;
        private string _varB = string.Empty;

        public ItemManagement()
        {
            _varA = "A";
            _varB = "B";
        }

        public ItemManagement(string param1)
        {
            _varA = param1;
            _varB = param1;
        }

        public ItemManagement(string param1, string param2)
        {
            _varA = param1;
            _varB = param2;
        }

        public string VarA
        {
            get { return _varA; }
            internal set { _varA = value.ToUpper(); }
        }

        public string VarB
        {
            get { return _varB; }
            internal set { _varB = value.ToUpper(); }
        }

        public string DoSomething(string actionMessage)
        {
            string result;

            switch (actionMessage)
            {
                case "itsamess":
                    result = "itsamess";
                    break;
                default:
                    result = "itsgood";
                    break;
            }

            return result;
        }



    }

    public class Item
    {        
        public Item()
        {
        }

        public int Division { get; set; }
        public int Department { get; set; }
        public int ItemClass { get; set; }
        public int Vendor { get; set; }
        public int Style { get; set; }
        public int Colour { get; set; }

    }

    public class ItemStyle
    {
    }

    public class ItemSize : Item
    {
        private DB2Factory _factory = new DB2Factory();

        public ItemSize()
        {
        }

        public int Size { get; set; }
        public string Description { get; set; }
        public int VendorUPC { get; set; }
        public string CasePackType { get; set; } //e.g. "E"
        public int CaseQuantity { get; set; }
        public int DistroQuantity { get; set; }
        public decimal CartonWeight { get; set; }
        public decimal CartonHeight { get; set; }
        public decimal CartonWidth { get; set; }
        public decimal CartonLength { get; set; }
        public int DisneyUPC { get; set; }
        public int SKU { get; set; }
        public int SKUCheckDigit { get; set; }
        public bool IsAPP { get; set; }
        public bool CaseDetailsLocked { get; set; }
        public int SellingChannel { get; set; }
        public bool SuppressBOCard { get; set; }
        public int SelloutControl { get; set; }
        public DateTime OfferEffectiveDate { get; set; }


                /// <summary>
        /// Save the ItemSize to the DB.
        /// </summary>
        public bool Save()
        {
            string userId = Session.User.NetworkId.ToUpper();
            bool result = false;
            //if (_factory.OpenConnection())
            //{
            //    try
            //    {
            //        var cmd = _factory.CreateCommand("DS888BS1", System.Data.CommandType.StoredProcedure,
            //            _factory.CreateParameter("P_ERR", " ", System.Data.OleDb.OleDbType.Char, 1, System.Data.ParameterDirection.InputOutput));
            //        cmd.ExecuteNonQuery();
            //        isRunning = cmd.Parameters["P_ERR"].Value != null && cmd.Parameters["P_ERR"].Value.ToString() == "Y";
            //    }
            //    catch (Exception ex)
            //    {
            //        ExceptionHandler.RaiseException(ex, "IsExtractRunning", false);
            //    }
            //    finally
            //    {
            //        _factory.CloseConnection();
            //    }
            //}
            return result;
            
        }

    }

    public class ItemSizes : IEnumerable
    {
        private List<ItemSize> elements = new List<ItemSize>();

        public ItemSizes()
        {
        }

        public ItemSize Add(int division, int department, int itemClass, int vendor,
               int style, int colour, int size)
        {
            // Check to see if the ItemMarket already exists in collection
            // and add if not yet added.
            ItemSize itemSize = elements.Find(x => x.ItemClass == itemClass &&
                                         x.Vendor == vendor &&
                                         x.Style == style &&
                                         x.Colour == colour &&
                                         x.Size == size);
            if (itemSize == null)
            {
                itemSize = new ItemSize();
                itemSize.Division = division;
                itemSize.Department = department;
                itemSize.ItemClass = itemClass;
                itemSize.Vendor = vendor;
                itemSize.Style = style;
                itemSize.Colour = colour;
                itemSize.Size = size;

                elements.Add(itemSize);
            }
            return itemSize;
        }

        public ItemSize Add(ItemSize itemSize)
        {
            // Check to see if the ItemMarket already exists in collection
            // and add if not yet added.
            ItemSize size = elements.Find(x => x.ItemClass == itemSize.ItemClass &&
                                         x.Vendor == itemSize.Vendor &&
                                         x.Style == itemSize.Style &&
                                         x.Colour == itemSize.Colour &&
                                         x.Size == itemSize.Size);
            if (size == null)
            {
                size = itemSize;
                elements.Add(size);
            }
            return size;
        }

        public int Count
        {
            get
            {
                return elements.Count;
            }
        }

        public void Remove(int size)
        {
            elements.RemoveAll(x => x.Size == size);
        }

        public ItemSize this[int size]
        {
            get
            {
                return elements.Find(x => x.Size == size);
            }
        }

        //public ItemSize this[int index]
        //{
        //    get
        //    {
        //        return elements[index];
        //    }
        //}

        public void Remove(ItemSize itemSize)
        {
            elements.Remove(itemSize);
        }

        public IEnumerator GetEnumerator()
        {
            return new ItemSizesEnumerator(this);
        }

        public class ItemSizesEnumerator : IEnumerator
        {
            private int position = -1;
            private ItemSizes t;

            public ItemSizesEnumerator(ItemSizes t)
            {
                this.t = t;
            }

            // Declare the MoveNext method required by IEnumerator:
            public bool MoveNext()
            {
                if (position < t.elements.Count - 1)
                {
                    position++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            // Declare the Reset method required by IEnumerator:
            public void Reset()
            {
                position = -1;
            }

            // Declare the Current property required by IEnumerator:
            public object Current
            {
                get
                {
                    return t.elements[position];
                }
            }
        }


        /// <summary>
        /// Save all Item markets.
        /// </summary>
        public bool Save()
        {
            bool result = false;
            foreach (ItemSize size in elements)
            {
                size.Save();
            }

            return result;
        }

    }

    public class ItemMarket : Item
    {
        private DB2Factory _factory = new DB2Factory();

        public ItemMarket()
        {
            
        }

        public int Size { get; set; }
        public string MarketCode { get; set; } //e.g. 'CA'
        public string MarketName { get; set; } //e.g. Canada
        public string MarketCurrency { get; set; } //e.g. CAD or GBP
        public decimal CostPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal ListPrice { get; set; } //for "ECOM" items
        public string VATCode { get; set; } //Only applicable for UK
        public int VendorUPC { get; set; }
        public int SKU { get; set; }
        public int SKUCheckDigit { get; set; }

        /// <summary>
        /// Save the ItemMarket to the DB.
        /// </summary>
        public bool Save()
        {
            string userId = Session.User.NetworkId.ToUpper();
            bool result = false;
            //if (_factory.OpenConnection())
            //{
            //    try
            //    {
            //        var cmd = _factory.CreateCommand("DS888BS1", System.Data.CommandType.StoredProcedure,
            //            _factory.CreateParameter("P_ERR", " ", System.Data.OleDb.OleDbType.Char, 1, System.Data.ParameterDirection.InputOutput));
            //        cmd.ExecuteNonQuery();
            //        isRunning = cmd.Parameters["P_ERR"].Value != null && cmd.Parameters["P_ERR"].Value.ToString() == "Y";
            //    }
            //    catch (Exception ex)
            //    {
            //        ExceptionHandler.RaiseException(ex, "IsExtractRunning", false);
            //    }
            //    finally
            //    {
            //        _factory.CloseConnection();
            //    }
            //}
            return result;
            
        }

    }

    public class ItemMarkets : IEnumerable
    {
        private List<ItemMarket> elements = new List<ItemMarket>();

        public ItemMarkets()
        {
        }
        
        public ItemMarket Add(int division, int department, int itemClass, int vendor,
            int style, int colour, int size, string marketCode)
        {
            // Check to see if the ItemMarket already exists in collection
            // and add if not yet added.
            ItemMarket mkt = elements.Find(x => x.ItemClass == itemClass &&
                                         x.Vendor == vendor &&
                                         x.Style == style &&
                                         x.Colour == colour &&
                                         x.Size == size &&
                                         x.MarketCode == marketCode);
            if (mkt == null)
            {
                mkt = new ItemMarket();
                mkt.Division = division;
                mkt.Department = department;
                mkt.ItemClass = itemClass;
                mkt.Vendor = vendor;
                mkt.Style = style;
                mkt.Colour = colour;
                mkt.Size = size;
                mkt.MarketCode = marketCode;

                elements.Add(mkt);
            }
            return mkt;
        }

        public ItemMarket Add(ItemMarket itemMarket)
        {
            // Check to see if the ItemMarket already exists in collection
            // and add if not yet added.
            ItemMarket mkt = elements.Find(x => x.ItemClass == itemMarket.ItemClass &&
                                         x.Vendor == itemMarket.Vendor &&
                                         x.Style == itemMarket.Style &&
                                         x.Colour == itemMarket.Colour &&
                                         x.Size == itemMarket.Size &&
                                         x.MarketCode == itemMarket.MarketCode);
            if (mkt == null)
            {
                mkt = itemMarket;
                elements.Add(mkt);
            }
            return mkt;
        }

        public int Count
        {
            get
            {
                return elements.Count;
            }
        }
        
        public void Remove(string marketCode)
        {
            elements.RemoveAll(x => x.MarketCode == marketCode);
        }

        public ItemMarket this[string marketCode]
        {
            get
            {
                return elements.Find(x => x.MarketCode == marketCode);
            }
        }

        public ItemMarket this[int index]
        {
            get
            {
                return elements[index];
            }
        }

        public void Remove(ItemMarket itemMarket)
        {
            elements.Remove(itemMarket);
        }

        public IEnumerator GetEnumerator()
        {
            return new ItemMarketsEnumerator(this);
        }

        public class ItemMarketsEnumerator : IEnumerator
        {
            private int position = -1;
            private ItemMarkets t;

            public ItemMarketsEnumerator(ItemMarkets t)
            {
                this.t = t;
            }

            // Declare the MoveNext method required by IEnumerator:
            public bool MoveNext()
            {
                if (position < t.elements.Count - 1)
                {
                    position++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            // Declare the Reset method required by IEnumerator:
            public void Reset()
            {
                position = -1;
            }

            // Declare the Current property required by IEnumerator:
            public object Current
            {
                get
                {
                    return t.elements[position];
                }
            }
        }

        /// <summary>
        /// Save all Item markets.
        /// </summary>
        public bool Save()
        {
            bool result = false;
            foreach (ItemMarket market in elements)
            {
                market.Save();
            }

            return result;
        }
    }

}
