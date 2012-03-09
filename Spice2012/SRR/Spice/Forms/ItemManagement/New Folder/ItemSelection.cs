using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Disney.iDash.LocalData;
using Disney.iDash.Shared;
using Disney.iDash.BusinessLayer;

namespace Disney.iDash.SPICE.Forms.ItemManagement
{
    public partial class ItemSelection : Disney.iDash.SPICE.Forms.Common.BaseParameters
    {
        public ItemSelection()
        {
            InitializeComponent();
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


        private void ClientPanel_Resize(object sender, EventArgs e)
        {
        }

        private void ItemSelection_Resize(object sender, EventArgs e)
        {

        }


    }
}
