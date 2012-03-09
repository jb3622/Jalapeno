using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using Disney.iDash.BusinessLayer;
using Disney.iDash.SRR.Forms.Workbench;

namespace Disney.iDash.SRR.Browsers
{
    public class ClassBrowser : BrowserControl
    {
        public ClassBrowser()
        {
            base.Caption = "Select Class";
            base.Name = "Class";
            base.ColumnPanelRowHeight = 50;
        }

        public override object GetDataSource()
        {
            base.WorkbenchInfo.Stage = BusinessLayer.WorkbenchInfo.Stages.SelectClass;
            return base.WorkbenchInfo.GetData();
        }

        public override void FormatColumns(GridView view)
        {
            base.FormatColumns(view);
            view.Columns["CLASS"].Caption = "Class";
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

        public override bool ShowItem(object row)
        {
            var frm = new DetailedWorkbench();
            base.WorkbenchInfo.Item.Class = this.BrowserListView.GetFocusedRowCellValue("CLASS").ToString();
            frm.ParentFormType = typeof(Forms.Workbench.DetailedFocusGroups);
            frm.ShowForm(base.WorkbenchInfo);
            return true;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using Disney.iDash.BusinessLayer;
using Disney.iDash.SRR.Forms.Workbench;

namespace Disney.iDash.SRR.Browsers
{
    public class ClassBrowser : BrowserControl
    {
        public ClassBrowser()
        {
            base.Caption = "Select Class";
            base.Name = "Class";
        }

        public override object GetDataSource()
        {
            base.WorkbenchInfo.Stage = BusinessLayer.WorkbenchInfo.Stages.SelectClass;
            return base.WorkbenchInfo.GetData();
        }

        public override void FormatColumns(GridView view)
        {
            base.FormatColumns(view);
            view.Columns["CLASS"].Caption = "Class";
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

        public override void ShowItem(object row)
        {
            var frm = new DetailedWorkbench();
            frm.ParentFormType = this.GetType();
            frm.ShowForm(base.WorkbenchInfo);
        }
    }
}
