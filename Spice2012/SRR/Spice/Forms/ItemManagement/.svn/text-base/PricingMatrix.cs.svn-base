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
    public partial class PricingMatrix : Disney.iDash.SPICE.Forms.Common.BaseParameters
    {
        public PricingMatrix()
        {
            InitializeComponent();
        }
        
        public override void ShowDetailedForm()
        {
            //this.MdiParent = FormUtils.FindMdiParent();
            this.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add   !");
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit !");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit !");
            this.Close();
        }

        private void PricingMatrix_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            ds.Tables.Add("pricematrixtbl");

            DataColumn col = new DataColumn("colSelect", typeof(Boolean));
            col.ReadOnly = false;
            ds.Tables["pricematrixtbl"].Columns.Add(col);

            col = new DataColumn("colFrom", typeof(Decimal));
            col.ReadOnly = false;
            ds.Tables["pricematrixtbl"].Columns.Add(col);

            col = new DataColumn("colTo", typeof(Decimal));
            col.ReadOnly = false;
            ds.Tables["pricematrixtbl"].Columns.Add(col);

            col = new DataColumn("colTarget", typeof(Decimal));
            col.ReadOnly = false;
            ds.Tables["pricematrixtbl"].Columns.Add(col);

            DataRow dr = ds.Tables["pricematrixtbl"].NewRow();
            dr[0] = true;
            dr[1] = 1;
            dr[2] = 2;
            dr[3] = 3;

            ds.Tables["pricematrixtbl"].Rows.Add(dr);

            dr = ds.Tables["pricematrixtbl"].NewRow();
            dr[0] = false;
            dr[1] = 11;
            dr[2] = 22;
            dr[3] = 33;

            ds.Tables["pricematrixtbl"].Rows.Add(dr);

            this.gcSizeGroupMaint.DataSource = ds.Tables["pricematrixtbl"];

        }
        
        
    }
}
