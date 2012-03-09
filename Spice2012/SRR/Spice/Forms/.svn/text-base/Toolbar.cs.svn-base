using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Disney.iDash.SRR.BusinessLayer;
using Disney.iDash.Shared;

namespace Disney.iDash.SPICE.Forms
{
    public partial class SpiceToolbar : Disney.iDash.BaseClasses.Forms.AddinMenu
    {
		private SysInfo _sysInfo = new SysInfo();

        public SpiceToolbar()
        {
            InitializeComponent();
			_sysInfo.ExceptionHandler.ExceptionEvent += ((ex, extraInfo, terminateApplication)=>
				{
					ErrorDialog.Show(ex, extraInfo, terminateApplication);
				});
        }

        private void barIMItemSelection_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!IsLoading)
            {
                IsLoading = true;
                var frm = new Forms.ItemManagement.ItemSelection();
                frm.Tag = rpSpice.Text;
                frm.ShowDetailedForm();
                IsLoading = false;
            }
        }

        //private void barIMCreateAPP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (!IsLoading)
        //    {
        //        IsLoading = true;
        //        var frm = new Forms.ItemManagement.APPForm();
        //        frm.Tag = rpSpice.Text;
        //        frm.ShowDetailedForm();
        //        IsLoading = false;
        //    }
        //}

        private void barIMSizeGroupMaintenance_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!IsLoading)
            {
                IsLoading = true;
                var frm = new Forms.ItemManagement.SizeGroupMaintenance();
                frm.Tag = rpSpice.Text;
                frm.ShowDetailedForm();
                IsLoading = false;
            }
        }

        private void barIMPricingMatrix_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!IsLoading)
            {
                IsLoading = true;
                var frm = new Forms.ItemManagement.PricingMatrix();
                frm.Tag = rpSpice.Text;
                frm.ShowDetailedForm();
                IsLoading = false;                
            }
        }

        //private void barPOPOForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (!IsLoading)
        //    {
        //        IsLoading = true;
        //        var frm = new Forms.POManagement.POForm();
        //        frm.Tag = rpSpice.Text;
        //        frm.ShowDetailedForm();
        //        IsLoading = false;
        //    }
        //}

        //private void barPOPOSelectionForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (!IsLoading)
        //    {
        //        IsLoading = true;
        //        var frm = new Forms.POManagement.POSelectionForm();
        //        frm.Tag = rpSpice.Text;
        //        frm.ShowDetailedForm();
        //        IsLoading = false;
        //    }
        //}

        private void barPOPOStageSetDates_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!IsLoading)
            {
                IsLoading = true;
                var frm = new Forms.POManagement.StageSetDatesForm();
                frm.Tag = rpSpice.Text;
                frm.ShowDetailedForm();
                IsLoading = false;
            }
        }

        private void barEASApproverRequests_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!IsLoading)
            {
                IsLoading = true;
                var frm = new Forms.EAS.ApproverRequestsForm();
                frm.Tag = rpSpice.Text;
                frm.ShowDetailedForm();
                IsLoading = false;
            }
        }

        private void barEASSubmitetdRequests_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!IsLoading)
            {
                IsLoading = true;
                var frm = new Forms.EAS.SubmittedRequestsForm();
                frm.Tag = rpSpice.Text;
                frm.ShowDetailedForm();
                IsLoading = false;
            }
        }

        private void barListItemNewItems_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {
            string selectedItem = this.barListItemNewItems.Strings[e.Index];

            switch (this.barListItemNewItems.Strings[e.Index])
            {
                case "Item":
                    if (!IsLoading)
                    {
                        IsLoading = true;
                        var frm = new Forms.ItemManagement.NewItemForm();
                        frm.Tag = rpSpice.Text;
                        frm.ShowDetailedForm();
                        IsLoading = false;
                    }
                    break;
                case "Assorted Pre-Pack (APP)":
                    if (!IsLoading)
                    {
                        IsLoading = true;
                        var frm = new Forms.ItemManagement.NewAPPForm();
                        frm.Tag = rpSpice.Text;
                        frm.ShowDetailedForm();
                        IsLoading = false;
                    }
                    break;
                default:
                    break;
            }
        }

        private void barListItemFindItems_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {
            string selectedItem = this.barListItemFindItems.Strings[e.Index];

            switch (this.barListItemFindItems.Strings[e.Index])
            {
                case "Item":
                    if (!IsLoading)
                    {
                        IsLoading = true;
                        var frm = new Forms.ItemManagement.ItemSelection();
                        frm.Tag = rpSpice.Text;
                        frm.ShowDetailedForm();
                        IsLoading = false;
                    }
                    break;
                case "Assorted Pre-Pack (APP)":
                    if (!IsLoading)
                    {
                        IsLoading = true;
                        var frm = new Forms.ItemManagement.ItemSelection();
                        frm.Tag = rpSpice.Text;
                        frm.Text = "Item Management - Find APP";
                        frm.ShowDetailedForm();
                        IsLoading = false;
                    }
                    break;
                default:
                    break;
            }
        }

        //private void barPOEntry_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (!IsLoading)
        //    {
        //        IsLoading = true;
        //        var frm = new Forms.POManagement.NewPOForm();
        //        frm.Tag = rpSpice.Text;
        //        frm.ShowDetailedForm();
        //        IsLoading = false;
        //    }
        //}

        private void barListItemNewPO_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {
            string selectedItem = this.barListItemNewPO.Strings[e.Index];

            switch (this.barListItemNewPO.Strings[e.Index])
            {
                case "Purchase Order":
                    if (!IsLoading)
                    {                        
                        if (!IsLoading)
                        {
                            IsLoading = true;
                            //var frm = new Forms.POManagement.POForm();
                            var frm = new Forms.POManagement.NewPOForm();
                            frm.Tag = rpSpice.Text;
                            frm.ShowDetailedForm();
                            IsLoading = false;
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void barListItemFindPO_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {
            string selectedItem = this.barListItemFindPO.Strings[e.Index];

            switch (this.barListItemFindPO.Strings[e.Index])
            {
                case "Purchase Order":
                    if (!IsLoading)
                    {
                        if (!IsLoading)
                        {
                            IsLoading = true;
                            var frm = new Forms.POManagement.POSelectionForm();
                            frm.Tag = rpSpice.Text;
                            frm.ShowDetailedForm();
                            IsLoading = false;
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    
    }
}
