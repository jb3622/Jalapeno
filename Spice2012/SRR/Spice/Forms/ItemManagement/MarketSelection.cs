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

namespace Disney.iDash.SPICE.Forms.ItemManagement
{
    public partial class MarketSelection : Disney.iDash.SPICE.Forms.Common.BaseParameters
    {
        public MarketSelection()
        {
            InitializeComponent();
        }


        public override void ShowDetailedForm()
        {
            //this.MdiParent = FormUtils.FindMdiParent();
            this.Show();
        }



        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void bttnOK_Click(object sender, EventArgs e)
        {
            //IsLoading = true;
            var frm = new Forms.ItemManagement.NewItemForm();
            frm.Tag = "SPICE";
            frm.ShowDetailedForm();            
            //IsLoading = false;
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

    }
}
