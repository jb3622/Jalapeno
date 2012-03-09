namespace Disney.iDash.SPICE.Forms.ItemManagement
{
    partial class PricingMatrix
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
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.gcSizeGroupMaint = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColFromPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColToPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbPriceMatrix = new System.Windows.Forms.GroupBox();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblClass = new DevExpress.XtraEditors.LabelControl();
            this.btnHelp = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPanel)).BeginInit();
            this.ClientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxStyles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSizeGroupMaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbPriceMatrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientPanel
            // 
            this.ClientPanel.Controls.Add(this.btnRefresh);
            this.ClientPanel.Controls.Add(this.btnHelp);
            this.ClientPanel.Controls.Add(this.gbPriceMatrix);
            this.ClientPanel.Controls.Add(this.btnExit);
            this.ClientPanel.Controls.Add(this.gcSizeGroupMaint);
            this.ClientPanel.Controls.Add(this.btnAdd);
            this.ClientPanel.Size = new System.Drawing.Size(776, 451);
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
            this.ribbonStatusBar.Size = new System.Drawing.Size(776, 31);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.Location = new System.Drawing.Point(614, 421);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add";
            this.btnAdd.ToolTip = "Add a new Item.";
            this.btnAdd.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(694, 421);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "&Exit";
            this.btnExit.ToolTip = "Exit Pricing Matrix.";
            this.btnExit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gcSizeGroupMaint
            // 
            this.gcSizeGroupMaint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gcSizeGroupMaint.Location = new System.Drawing.Point(12, 85);
            this.gcSizeGroupMaint.MainView = this.gridView1;
            this.gcSizeGroupMaint.Name = "gcSizeGroupMaint";
            this.gcSizeGroupMaint.Size = new System.Drawing.Size(754, 330);
            this.gcSizeGroupMaint.TabIndex = 13;
            this.gcSizeGroupMaint.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColSelect,
            this.gridColFromPrice,
            this.gridColToPrice,
            this.gridColTarget});
            this.gridView1.GridControl = this.gcSizeGroupMaint;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Pricing Matrix";
            // 
            // gridColSelect
            // 
            this.gridColSelect.Caption = "Select";
            this.gridColSelect.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColSelect.FieldName = "gridColSelect";
            this.gridColSelect.Name = "gridColSelect";
            this.gridColSelect.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColSelect.Visible = true;
            this.gridColSelect.VisibleIndex = 0;
            this.gridColSelect.Width = 53;
            // 
            // gridColFromPrice
            // 
            this.gridColFromPrice.Caption = "From (market Currency)";
            this.gridColFromPrice.FieldName = "gridColFromPrice";
            this.gridColFromPrice.Name = "gridColFromPrice";
            this.gridColFromPrice.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColFromPrice.Visible = true;
            this.gridColFromPrice.VisibleIndex = 1;
            this.gridColFromPrice.Width = 191;
            // 
            // gridColToPrice
            // 
            this.gridColToPrice.Caption = "To (market currency)";
            this.gridColToPrice.FieldName = "gridColToPrice";
            this.gridColToPrice.Name = "gridColToPrice";
            this.gridColToPrice.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColToPrice.Visible = true;
            this.gridColToPrice.VisibleIndex = 2;
            this.gridColToPrice.Width = 206;
            // 
            // gridColTarget
            // 
            this.gridColTarget.Caption = "Target price (target currency)";
            this.gridColTarget.FieldName = "gridColTarget";
            this.gridColTarget.Name = "gridColTarget";
            this.gridColTarget.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColTarget.Visible = true;
            this.gridColTarget.VisibleIndex = 3;
            this.gridColTarget.Width = 230;
            // 
            // gbPriceMatrix
            // 
            this.gbPriceMatrix.Controls.Add(this.comboBoxEdit1);
            this.gbPriceMatrix.Controls.Add(this.lblClass);
            this.gbPriceMatrix.Location = new System.Drawing.Point(12, 8);
            this.gbPriceMatrix.Name = "gbPriceMatrix";
            this.gbPriceMatrix.Size = new System.Drawing.Size(754, 60);
            this.gbPriceMatrix.TabIndex = 18;
            this.gbPriceMatrix.TabStop = false;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(107, 23);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(78, 20);
            this.comboBoxEdit1.TabIndex = 2;
            // 
            // lblClass
            // 
            this.lblClass.Location = new System.Drawing.Point(18, 26);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(79, 13);
            this.lblClass.TabIndex = 1;
            this.lblClass.Text = "Target Currency";
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
            this.btnHelp.ToolTip = "Help - Pricing Matrix";
            this.btnHelp.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRefresh.Location = new System.Drawing.Point(533, 421);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.ToolTip = "Refresh sizes view";
            this.btnRefresh.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // PricingMatrix
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(776, 509);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(694, 510);
            this.Name = "PricingMatrix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Management - Pricing Matrix";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PricingMatrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientPanel)).EndInit();
            this.ClientPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BoxStyles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSizeGroupMaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbPriceMatrix.ResumeLayout(false);
            this.gbPriceMatrix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraGrid.GridControl gcSizeGroupMaint;
        private System.Windows.Forms.GroupBox gbPriceMatrix;
        private DevExpress.XtraEditors.SimpleButton btnHelp;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.LabelControl lblClass;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColFromPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColToPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColTarget;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.Columns.GridColumn gridColSelect;
    }
}
