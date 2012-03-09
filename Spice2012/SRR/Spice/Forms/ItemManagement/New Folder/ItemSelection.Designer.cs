namespace Disney.iDash.SPICE.Forms.ItemManagement
{
    partial class ItemSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnCopy = new DevExpress.XtraEditors.SimpleButton();
            this.btnHelp = new DevExpress.XtraEditors.SimpleButton();
            this.gbStandardSearch = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gbUPC = new System.Windows.Forms.GroupBox();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.gbVendorStyle = new System.Windows.Forms.GroupBox();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gbItemNumber = new System.Windows.Forms.GroupBox();
            this.itemNumberControl1 = new Disney.iDash.SPICE.Controls.ItemNumberControl();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPanel)).BeginInit();
            this.ClientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxStyles)).BeginInit();
            this.gbStandardSearch.SuspendLayout();
            this.gbUPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.gbVendorStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.gbItemNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientPanel
            // 
            this.ClientPanel.Controls.Add(this.gbStandardSearch);
            this.ClientPanel.Controls.Add(this.btnHelp);
            this.ClientPanel.Controls.Add(this.btnCopy);
            this.ClientPanel.Controls.Add(this.btnExit);
            this.ClientPanel.Controls.Add(this.btnEdit);
            this.ClientPanel.Controls.Add(this.btnAdd);
            this.ClientPanel.Size = new System.Drawing.Size(913, 451);
            this.ClientPanel.Resize += new System.EventHandler(this.ClientPanel_Resize);
            // 
            // BoxStyles
            // 
            this.BoxStyles.Appearance.BackColor = System.Drawing.Color.White;
            this.BoxStyles.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.BoxStyles.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BoxStyles.Appearance.Options.UseBackColor = true;
            this.BoxStyles.Appearance.Options.UseFont = true;
            this.BoxStyles.Appearance.Options.UseForeColor = true;
            this.BoxStyles.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.BoxStyles.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.BoxStyles.AppearanceDisabled.ForeColor = System.Drawing.Color.Silver;
            this.BoxStyles.AppearanceDisabled.Options.UseBackColor = true;
            this.BoxStyles.AppearanceDisabled.Options.UseFont = true;
            this.BoxStyles.AppearanceDisabled.Options.UseForeColor = true;
            this.BoxStyles.AppearanceDropDown.BackColor = System.Drawing.Color.White;
            this.BoxStyles.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxStyles.AppearanceDropDown.ForeColor = System.Drawing.Color.Black;
            this.BoxStyles.AppearanceDropDown.Options.UseBackColor = true;
            this.BoxStyles.AppearanceDropDown.Options.UseFont = true;
            this.BoxStyles.AppearanceDropDown.Options.UseForeColor = true;
            this.BoxStyles.AppearanceDropDownHeader.BackColor = System.Drawing.Color.White;
            this.BoxStyles.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.BoxStyles.AppearanceDropDownHeader.ForeColor = System.Drawing.Color.Blue;
            this.BoxStyles.AppearanceDropDownHeader.Options.UseBackColor = true;
            this.BoxStyles.AppearanceDropDownHeader.Options.UseFont = true;
            this.BoxStyles.AppearanceDropDownHeader.Options.UseForeColor = true;
            this.BoxStyles.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.BoxStyles.AppearanceFocused.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.BoxStyles.AppearanceFocused.ForeColor = System.Drawing.Color.Black;
            this.BoxStyles.AppearanceFocused.Options.UseBackColor = true;
            this.BoxStyles.AppearanceFocused.Options.UseFont = true;
            this.BoxStyles.AppearanceFocused.Options.UseForeColor = true;
            this.BoxStyles.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.BoxStyles.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.BoxStyles.AppearanceReadOnly.ForeColor = System.Drawing.Color.Red;
            this.BoxStyles.AppearanceReadOnly.Options.UseBackColor = true;
            this.BoxStyles.AppearanceReadOnly.Options.UseFont = true;
            this.BoxStyles.AppearanceReadOnly.Options.UseForeColor = true;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 478);
            this.ribbonStatusBar.Size = new System.Drawing.Size(913, 31);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.Location = new System.Drawing.Point(591, 421);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add";
            this.btnAdd.ToolTip = "Add a new Item.";
            this.btnAdd.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEdit.Location = new System.Drawing.Point(671, 421);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.ToolTip = "Edit an existing Item.";
            this.btnEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(831, 421);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "&Exit";
            this.btnExit.ToolTip = "Exit Item Selection.";
            this.btnExit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCopy.Location = new System.Drawing.Point(751, 421);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 19;
            this.btnCopy.Text = "&Copy";
            this.btnCopy.ToolTip = "Copy an existing Item.";
            this.btnCopy.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHelp.Location = new System.Drawing.Point(9, 421);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 20;
            this.btnHelp.Text = "&Help";
            this.btnHelp.ToolTip = "Help - Item Selection";
            this.btnHelp.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // gbStandardSearch
            // 
            this.gbStandardSearch.Controls.Add(this.simpleButton1);
            this.gbStandardSearch.Controls.Add(this.gbUPC);
            this.gbStandardSearch.Controls.Add(this.gbVendorStyle);
            this.gbStandardSearch.Controls.Add(this.gbItemNumber);
            this.gbStandardSearch.Location = new System.Drawing.Point(12, 16);
            this.gbStandardSearch.Name = "gbStandardSearch";
            this.gbStandardSearch.Size = new System.Drawing.Size(711, 189);
            this.gbStandardSearch.TabIndex = 21;
            this.gbStandardSearch.TabStop = false;
            this.gbStandardSearch.Text = "Standard Search";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton1.Location = new System.Drawing.Point(564, 61);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 30;
            this.simpleButton1.Text = "&Search";
            this.simpleButton1.ToolTip = "Search for items.";
            this.simpleButton1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // gbUPC
            // 
            this.gbUPC.Controls.Add(this.textEdit2);
            this.gbUPC.Location = new System.Drawing.Point(434, 26);
            this.gbUPC.Name = "gbUPC";
            this.gbUPC.Size = new System.Drawing.Size(124, 58);
            this.gbUPC.TabIndex = 29;
            this.gbUPC.TabStop = false;
            this.gbUPC.Text = "UPC";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(11, 23);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 28;
            // 
            // gbVendorStyle
            // 
            this.gbVendorStyle.Controls.Add(this.textEdit1);
            this.gbVendorStyle.Location = new System.Drawing.Point(304, 26);
            this.gbVendorStyle.Name = "gbVendorStyle";
            this.gbVendorStyle.Size = new System.Drawing.Size(124, 58);
            this.gbVendorStyle.TabIndex = 25;
            this.gbVendorStyle.TabStop = false;
            this.gbVendorStyle.Text = "Vendor Style";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(11, 23);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 28;
            // 
            // gbItemNumber
            // 
            this.gbItemNumber.Controls.Add(this.itemNumberControl1);
            this.gbItemNumber.Location = new System.Drawing.Point(12, 26);
            this.gbItemNumber.Name = "gbItemNumber";
            this.gbItemNumber.Size = new System.Drawing.Size(286, 58);
            this.gbItemNumber.TabIndex = 24;
            this.gbItemNumber.TabStop = false;
            this.gbItemNumber.Text = "Item Number";
            // 
            // itemNumberControl1
            // 
            this.itemNumberControl1.DepartmentId = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.itemNumberControl1.ItemClass = null;
            this.itemNumberControl1.ItemColour = null;
            this.itemNumberControl1.ItemColourVisible = true;
            this.itemNumberControl1.ItemSize = null;
            this.itemNumberControl1.ItemSizeVisible = true;
            this.itemNumberControl1.ItemStyle = null;
            this.itemNumberControl1.ItemStyleVisible = true;
            this.itemNumberControl1.ItemVendor = null;
            this.itemNumberControl1.Location = new System.Drawing.Point(11, 23);
            this.itemNumberControl1.Margin = new System.Windows.Forms.Padding(0);
            this.itemNumberControl1.MaximumSize = new System.Drawing.Size(261, 20);
            this.itemNumberControl1.MinimumSize = new System.Drawing.Size(140, 20);
            this.itemNumberControl1.Name = "itemNumberControl1";
            this.itemNumberControl1.ShowZeros = false;
            this.itemNumberControl1.Size = new System.Drawing.Size(261, 20);
            this.itemNumberControl1.StyleController = null;
            this.itemNumberControl1.TabIndex = 1;
            // 
            // ItemSelection
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(913, 509);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(694, 510);
            this.Name = "ItemSelection";
            this.Text = "Item Management - Item Selection";
            this.Resize += new System.EventHandler(this.ItemSelection_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ClientPanel)).EndInit();
            this.ClientPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BoxStyles)).EndInit();
            this.gbStandardSearch.ResumeLayout(false);
            this.gbUPC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.gbVendorStyle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.gbItemNumber.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
                
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnCopy;
        private DevExpress.XtraEditors.SimpleButton btnHelp;
        private System.Windows.Forms.GroupBox gbStandardSearch;
        private System.Windows.Forms.GroupBox gbVendorStyle;
        private System.Windows.Forms.GroupBox gbItemNumber;
        private Controls.ItemNumberControl itemNumberControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox gbUPC;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;

    }
}
