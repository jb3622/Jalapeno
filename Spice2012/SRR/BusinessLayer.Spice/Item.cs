using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Disney.iDash.DataLayer;
using Disney.iDash.LocalData;
using Disney.iDash.Shared;
using System.Data;
using System.Data.OleDb;

namespace Disney.iDash.BusinessLayer.Spice
{
    public class Item
    {
        private DB2Factory _factory = new DB2Factory();


        #region Constructors
        public Item()
        { }
        #endregion


        #region Properties

        public int VendorUPC { get; set; }

        public int DisneyUPC { get; set; }

        public string Description { get; set; }

        public decimal CartonWeight { get; set; }

        public decimal CartonHeight { get; set; }

        public decimal CartonLength { get; set; }

        public decimal CartonWidth { get; set; }

        public decimal PendingCartonWeight { get; set; }

        public decimal PendingCartonHeight { get; set; }

        public decimal PendingCartonLength { get; set; }

        public decimal PendingCartonWidth { get; set; }

        public int Sku { get; set; }

        public int DistroQty { get; set; }

        public int CasePackQty { get; set; }

        public string CasePackType { get; set; }

        public char CaseLocked { get; set; }

        public int SellingChannel { get; set; }

        #endregion


        #region Methods

        public bool Save()
        {
            if (_factory.OpenConnection())
            {
                try
                {
                    String sql = Properties.Resources.SQLInsertItem.ToString();                

                    OleDbCommand cmdSave = _factory.CreateCommand(sql);
                    cmdSave.ExecuteNonQuery();
                    return true;
                }
                catch (Exception exc)
                {
                    return false;
                }                
            }
            else
            {
                return false;
            }
        }
        

        #endregion



    }


}





