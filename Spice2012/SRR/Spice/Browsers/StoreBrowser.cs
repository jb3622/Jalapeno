using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using Disney.iDash.BusinessLayer;
using System.Windows.Forms;

namespace Disney.iDash.SRR.Browsers
{
    public class StoreBrowser : BrowserControl
    {
        public StoreBrowser()
        {
            base.Caption = "Select Store";
            base.Name = "Stores";
            base.ColumnPanelRowHeight = 50;
        }

        public override object GetDataSource()
        {
            WorkbenchInfo.Stage = BusinessLayer.WorkbenchInfo.Stages.SelectStore;
            return WorkbenchInfo.GetData();
        }

        public override void FormatColumns(GridView view)
        {
            base.FormatColumns(view);
            view.Columns["STORE"].Caption = "Store";
            view.Columns["STORENAME"].Caption = "Store Name";
            view.Columns["MARKET"].Caption = "Market";
            view.Columns["SALESLW"].Caption = "Sales LW";
            view.Columns["SALESTW"].Caption = "Sales TW";
            view.Columns["CURRENTROS"].Caption = "Current ROS";
            view.Columns["STOCKONHAND"].Caption = "Stock on Hand";
            view.Columns["SMOOTHEDSTORECOVER"].Caption = "Smoothed Store Cover";
            view.Columns["ALLOCATED"].Caption = "Allocated";
            view.Columns["SHIPPED"].Caption = "Shipped";
            view.Columns["TOTALSTOCKREQUIRED"].Caption = "Total Stock Required";
            view.Columns["IDEALALLOCQTY"].Caption = "Ideal Alloc. Qty.";
            view.Columns["PROPOSEDALLOCQTY"].Caption = "Proposed Alloc. Qty.";
            view.Columns["OUTOFSTOCK"].Caption = "Out of Stock";
            view.BestFitColumns();
        }

        public override List<ToolStripItem> CustomMenus()
        {
            var menus = new List<ToolStripItem>();

            var menu = new ToolStripMenuItem();
            var row = base.BrowserListView.GetFocusedRow();

            if (row != null)
            {
                menu = new ToolStripMenuItem();
                menu.Text = "Workbench...";
                menu.Click += ((sender, e) =>
                {
                    OpenWorkbench(row);
                });
                menus.Add(menu);
            }

            return menus;
        }

        public override bool ShowItem(object row)
        {
            //TODO - will need to obtain the store id from the row object to feed through
            var browser = new ClassBrowser();
            browser.WorkbenchInfo = base.WorkbenchInfo;
            browser.WorkbenchInfo.StoreId = (decimal) this.BrowserListView.GetFocusedRowCellValue("STORE");
            browser.WorkbenchInfo.StoreText = this.BrowserListView.GetFocusedRowCellValue("STORENAME").ToString();
            browser.Caption = "Store: " + browser.WorkbenchInfo.StoreId.ToString() + " - " + browser.WorkbenchInfo.StoreText;

            var frm = new Disney.iDash.SRR.Forms.Common.StandardBrowser(browser);
            frm.ShowForm();
            return true;
            
        }

        private void OpenWorkbench(object row)
        {
            //TODO - will need to obtain the class id from the row object to feed through
            var frm = new Disney.iDash.SRR.Forms.Workbench.DetailedWorkbench();
            frm.ParentFormType = typeof(Forms.Workbench.DetailedFocusGroups);
            base.WorkbenchInfo.StoreId = (decimal)this.BrowserListView.GetFocusedRowCellValue("STORE");
            frm.ShowForm(base.WorkbenchInfo);           
        }
    }
}
