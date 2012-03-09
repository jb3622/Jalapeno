using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Disney.iDash.Shared;
using Disney.iDash.SRR.BusinessLayer;

namespace Disney.iDash.SPICE.Controls
{
    public partial class ItemNumberControl : DevExpress.XtraEditors.XtraUserControl
    {
        private List<string> _validationErrors = new List<string>();

        public event EventHandler EditValueChanged;

        public ItemNumberControl()
        {
            InitializeComponent();
            cboItemClass.ExceptionHandler.ExceptionEvent+=((ex, extraInfo, terminateApplication)=>
                {
                    ErrorDialog.Show(ex, extraInfo, terminateApplication);
                });

            cboItemVendor.ExceptionHandler.ExceptionEvent += ((ex, extraInfo, terminateApplication) =>
				{
					ErrorDialog.Show(ex, extraInfo, terminateApplication);
				});
            
        }

        public decimal DepartmentId { get; set; }
        public bool ShowZeros { get; set; }

        internal void Clear()
        {
            ItemClass = 0;
            ItemVendor = 0;
            ItemStyle = 0;
            ItemColour = 0;
            ItemSize = 0;
        }

        public decimal? ItemClass
        {
            get
            {
				if (cboItemClass.EditValue == null || cboItemClass.EditValue.ToString() == string.Empty)
                    return null;
                else
                    return (decimal)cboItemClass.EditValue;
            }
            set
            {
                cboItemClass.EditValue = (value == 0 && !ShowZeros ? null : value);
            }
        }

        public decimal? ItemVendor
        {
            get
            {
				if (cboItemVendor.EditValue == null || cboItemVendor.EditValue.ToString() == string.Empty)
                    return null;
                else
                    return (decimal) cboItemVendor.EditValue;
            }
            set
            {
                cboItemVendor.EditValue = (value == 0 && !ShowZeros ? null : value); 
            }
        }

        public bool ItemStyleVisible
        {
            get { return txtItemStyle.Visible; }
            set 
            { 
                txtItemStyle.Visible = value;
                if (!value)   
                    ItemColourVisible = false;
           }
        }

        public decimal? ItemStyle
        {
            get
            {
				if (txtItemStyle.EditValue == null || txtItemStyle.EditValue.ToString() == string.Empty)
                    return null;
                else
                    return Convert.ToDecimal(txtItemStyle.EditValue);
            }
            set
            {
                txtItemStyle.EditValue = (value == 0 && !ShowZeros ? null : value);
            }
        }

        public bool ItemColourVisible
        {
            get { return txtItemColour.Visible; }
            set 
            { 
                txtItemColour.Visible = value;
                if (value)
                    ItemStyleVisible = true;
                else
                    ItemSizeVisible = false;
            }
        }

        public decimal? ItemColour
        {
            get
            {
				if (txtItemColour.EditValue == null || txtItemColour.EditValue.ToString() == string.Empty)
                    return null;
                else
                    return Convert.ToDecimal(txtItemColour.EditValue);
            }
            set
            {
                txtItemColour.EditValue = (value == 0 && !ShowZeros ? null : value);
            }
        }

        public bool ItemSizeVisible
        {
            get { return txtItemSize.Visible; }
            set 
            { 
                txtItemSize.Visible = value;
                if (value)
                    ItemColourVisible = true;
            }
        }

        public decimal? ItemSize
        {
            get
            {
				if (txtItemSize.EditValue == null || txtItemSize.EditValue.ToString() == string.Empty)
                    return null;
                else
                    return Convert.ToDecimal(txtItemSize.EditValue);
            }
            set
            {
                txtItemSize.EditValue = (value == 0 && !ShowZeros ? null : value);
            }
        }

        public StockItem StockItem
        {
            get
            {
				var stockItem = new StockItem(this.ItemClass, this.ItemVendor, this.ItemStyle, this.ItemColour, this.ItemSize);
				stockItem.ExceptionHandler.ExceptionEvent += ((ex, extraInfo, terminateApplication) =>
					{
						ErrorDialog.Show(ex, extraInfo, terminateApplication);
					});

				return stockItem;
            }
        }

        public bool HasValue
        {
            get { return this.ItemClass.HasValue || this.ItemVendor.HasValue || this.ItemStyle.HasValue || this.ItemColour.HasValue || this.ItemSize.HasValue; }
        }

        public IStyleController StyleController
        {
            get { return cboItemClass.StyleController; }
            set 
            { 
                cboItemClass.StyleController = value;
                txtItemColour.StyleController = value;
                txtItemSize.StyleController = value;
                txtItemStyle.StyleController = value;
                cboItemVendor.StyleController = value; 
            }
        }

        public void RefreshCombos()
        {
			
            if (this.DepartmentId == -1)
                cboItemClass.WhereClause = "1=1";
            else
                cboItemClass.WhereClause = "CDPT=" + this.DepartmentId.ToString();               

            if (this.DepartmentId == -1)
                cboItemVendor.WhereClause = "1=1";
            else
                cboItemVendor.WhereClause = "VENDPT=" + this.DepartmentId.ToString();
			cboItemClass.RefreshControl();
//			cboItemClass.RefreshControl();
			cboItemVendor.RefreshControl();
//			cboItemVendor.RefreshControl();
        }

        public bool IsValid()
        {
            _validationErrors.Clear();
            if (cboItemClass.EditValue == null && cboItemVendor.EditValue != null)
                _validationErrors.Add("Please enter a class");

            if (cboItemVendor.EditValue == null && !IsObjectNullOrEmpty(txtItemStyle.EditValue))
               _validationErrors.Add("Please enter a vendor");

            if (IsObjectNullOrEmpty(txtItemStyle.EditValue) && !IsObjectNullOrEmpty(txtItemColour.EditValue))
               _validationErrors.Add("Please enter a style");

            if (IsObjectNullOrEmpty(txtItemColour.EditValue) && !IsObjectNullOrEmpty(txtItemSize.EditValue))
                _validationErrors.Add("Please enter a colour");

            return _validationErrors.Count == 0;
        }
        
        public string GetValidationErrors()
        {
            return string.Join("\n", _validationErrors);
        }

        public new string ToString()
        {
            var result = new List<string>();
            AddElement(result, cboItemClass.EditValue, cboItemClass.MaxLength);
            AddElement(result, cboItemVendor.EditValue, cboItemVendor.MaxLength);
            AddElement(result, txtItemStyle.EditValue, txtItemStyle.Properties.MaxLength);
            AddElement(result, txtItemColour.EditValue, txtItemColour.Properties.MaxLength);
            AddElement(result, txtItemSize.EditValue, txtItemSize.Properties.MaxLength);
            return string.Join("-", result.ToArray());
        }

        private bool IsObjectNullOrEmpty(object value)
        {
            return (value == null || (value.GetType() == typeof(string) && value.ToString() == string.Empty));
        }

        private void AddElement(List<string> elements, object value, int length)
        {
            var result = string.Empty;
            if (value != null && value.ToString() != string.Empty)
                result = value.ToString().PadLeft(length, '0');
            else
                result = result.PadLeft(length, '0');
            elements.Add(result);
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var ctrl = (TextEdit)sender;
            if (ctrl.SelectionStart == ctrl.Properties.MaxLength)
                SelectNextControl(ctrl, true, false, false, false);
        }

        private void TextEdit_Enter(object sender, EventArgs e)
        {
            TextEdit textedit = (TextEdit)sender;
            textedit.SelectAll();
        }

        private void ItemControl_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValid())
            {
                MessageBox.Show(this.GetValidationErrors(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Cancel = true;
            }
        }

        private void cboItemClass_EditValueChanged(object sender, EventArgs e)
        {
            if (cboItemClass.EditValue == null)
                this.Clear();
            if (EditValueChanged != null)
                EditValueChanged(sender, e);
        }

        private void cboItemVendor_EditValueChanged(object sender, EventArgs e)
        {
            if (EditValueChanged != null)
                EditValueChanged(sender, e);
        }

        private void txtItemStyle_EditValueChanged(object sender, EventArgs e)
        {
            if (EditValueChanged != null)
                EditValueChanged(sender, e);
        }

        private void txtItemColour_EditValueChanged(object sender, EventArgs e)
        {
            if (EditValueChanged != null)
                EditValueChanged(sender, e);
        }

        private void txtItemSize_EditValueChanged(object sender, EventArgs e)
        {
            if (EditValueChanged != null)
                EditValueChanged(sender, e);
        }

    }
}
