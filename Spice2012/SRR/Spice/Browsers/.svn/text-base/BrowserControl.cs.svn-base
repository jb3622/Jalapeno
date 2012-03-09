using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using System.Data;
using Disney.iDash.BusinessLayer;

namespace Disney.iDash.SRR.Browsers
{
    public class BrowserControl
    {
        public string Caption { get; set; }
        public string Name { get; set; }
        public WorkbenchInfo WorkbenchInfo { get; set; }
        public int ColumnPanelRowHeight { get; set; }
        public GridView BrowserListView { get; internal set; }

        public BrowserControl()
        {
            Caption = "Set the browser caption";
            Name = "Grid";
            ColumnPanelRowHeight = -1;
        }
        
        virtual public List<System.Windows.Forms.ToolStripItem> CustomMenus()
        {
            return null;
        }
        
        public virtual object GetDataSource()
        {
            return null;
        }

        public virtual bool ShowItem(object row)
        {
            var result = false;
            return result;
        }

        public virtual void FormatColumns(GridView view)
        {
            foreach (GridColumn col in view.Columns)
            {
                switch (col.ColumnType.Name)
                {
                    case "Boolean":
                        col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        break;

                    case "Int":
                        col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        col.DisplayFormat.FormatString = "#,##0";
                        break;

                    case "Float":
                    case "Double":
                        col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        col.DisplayFormat.FormatString = "#,##0.00";
                        break;

                    case "DateTime":
                        col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                            col.DisplayFormat.FormatString = "dd-MMM-yyyy";
                            break;

                }
            }
        }
    }
}
