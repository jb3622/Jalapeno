using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Disney.iDash.LocalData;
using Disney.iDash.Shared;
using Disney.iDash.SRR.BusinessLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;


namespace Disney.iDash.SPICE.Forms.ItemManagement
{
    public partial class NewItemForm : Disney.iDash.SPICE.Forms.Common.BaseParameters
    {
        public NewItemForm()
        {
            InitializeComponent();
            PopulateGrids();
        }



        public override void ShowDetailedForm()
        {
            this.MdiParent = FormUtils.FindMdiParent();
            this.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add !");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit !");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit !");
        }

        private void bttnHelp_Click(object sender, EventArgs e)
        {
        }

        private void bttnOnlineEcom_Click(object sender, EventArgs e)
        {
            ECOMDetail frm = new ECOMDetail();

            frm.ShowDialog();
        }

        private void bttnSizes_Click(object sender, EventArgs e)
        {
            ECOMDetail frm = new ECOMDetail();

            frm.ShowDialog();
        }

        private void bttnMarkets_Click(object sender, EventArgs e)
        {
            ECOMDetail frm = new ECOMDetail();

            frm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        public void PopulateGrids()
        {
            CountryInfo[] countryArray = new CountryInfo[5];
            CountryInfo cn = new CountryInfo("Finland",5000, true);
            countryArray[0] = cn;
            cn = new CountryInfo("New Zealand",200, false);
            countryArray[1] = cn;
            cn = new CountryInfo("Russia",500000, true);
            countryArray[2] = cn;
            cn = new CountryInfo("USA",5000000, true);
            countryArray[3] = cn;
            cn = new CountryInfo("Brazil",80000, false);
            countryArray[4] = cn;

            this.gcSizes.DataSource = countryArray;
            this.gridControl2.DataSource = countryArray;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            
            var source = new LookupSource();
            if (Session.User.Department == String.Empty)
            {
                MessageBox.Show("The currently logged in user is not assigned to a department.", "Error - User Department", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            var items = source.GetItems(LookupSource.LookupTypes.ItemClass, "CDPT=" + Session.User.Department.ToString());
            lookUpItemClass.Properties.DataSource = items;
            lookUpItemClass.Enabled = true;
            lookUpItemClass.Properties.DisplayMember = "Description";
            lookUpItemClass.Properties.ValueMember = "Id";
            //lookUpItemClass.EditValue = System.Convert.ToInt32(1204);
//            lookUpItemClass.AutoSizeInLayoutControl = true;
            lookUpItemClass.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            lookUpItemClass.Properties.AutoSearchColumnIndex = 1;
            lookUpItemClass.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            lookUpItemClass.Properties.DropDownRows = 12;


            lookUpItemVendor.Properties.DataSource = source.GetItems(LookupSource.LookupTypes.ItemVendor, "VENDPT=" + Session.User.Department.ToString());
            lookUpItemVendor.Enabled = true;
            lookUpItemVendor.EditValue = "Id";


           
        }

        private void bttnHelp_Click_1(object sender, EventArgs e)
        {

        }

        private void lookUpItemClass_EditValueChanged(object sender, EventArgs e)
        {

        }
    }

    public class CountryInfo
    {
        public CountryInfo(string countryName,int population, bool northOfEquator)
        {
            this.CountryName = countryName;
            this.Population = population;
            this.InNorthernHemisphere = northOfEquator;
        }
        public string CountryName { get; set; }
        public int Population { get; set; }
        public bool InNorthernHemisphere { get; set; }
    }

}
