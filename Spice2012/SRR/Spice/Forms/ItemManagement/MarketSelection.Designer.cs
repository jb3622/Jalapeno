namespace Disney.iDash.SPICE.Forms.ItemManagement
{
    partial class MarketSelection
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
            this.bttnOK = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit3 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnHelp = new DevExpress.XtraEditors.SimpleButton();
            this.gcMarkets = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bttnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPanel)).BeginInit();
            this.ClientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxStyles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMarkets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientPanel
            // 
            this.ClientPanel.Controls.Add(this.bttnCancel);
            this.ClientPanel.Controls.Add(this.gcMarkets);
            this.ClientPanel.Controls.Add(this.btnHelp);
            this.ClientPanel.Controls.Add(this.bttnOK);
            this.ClientPanel.Size = new System.Drawing.Size(386, 354);
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 381);
            this.ribbonStatusBar.Size = new System.Drawing.Size(386, 31);
            // 
            // bttnOK
            // 
            this.bttnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnOK.Location = new System.Drawing.Point(223, 323);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(75, 23);
            this.bttnOK.TabIndex = 7;
            this.bttnOK.Text = "&Ok";
            this.bttnOK.ToolTip = "Ok";
            this.bttnOK.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click);
            // 
            // comboBoxEdit3
            // 
            this.comboBoxEdit3.EditValue = "All";
            this.comboBoxEdit3.Location = new System.Drawing.Point(10, 19);
            this.comboBoxEdit3.Name = "comboBoxEdit3";
            this.comboBoxEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit3.Size = new System.Drawing.Size(174, 20);
            this.comboBoxEdit3.TabIndex = 25;
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.EditValue = "All Authorised Departments";
            this.comboBoxEdit2.Location = new System.Drawing.Point(10, 19);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Size = new System.Drawing.Size(174, 20);
            this.comboBoxEdit2.TabIndex = 25;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "All";
            this.comboBoxEdit1.Location = new System.Drawing.Point(10, 19);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(174, 20);
            this.comboBoxEdit1.TabIndex = 25;
            // 
            // btnHelp
            // 
            this.btnHelp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHelp.Location = new System.Drawing.Point(5, 323);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 21;
            this.btnHelp.Text = "&Help";
            this.btnHelp.ToolTip = "Help - Item Selection";
            this.btnHelp.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // gcMarkets
            // 
            this.gcMarkets.Location = new System.Drawing.Point(5, 6);
            this.gcMarkets.MainView = this.gridView1;
            this.gcMarkets.Name = "gcMarkets";
            this.gcMarkets.Size = new System.Drawing.Size(374, 311);
            this.gcMarkets.TabIndex = 56;
            this.gcMarkets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcMarkets;
            this.gridView1.Name = "gridView1";
            // 
            // bttnCancel
            // 
            this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancel.Location = new System.Drawing.Point(304, 323);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(75, 23);
            this.bttnCancel.TabIndex = 57;
            this.bttnCancel.Text = "&Cancel";
            this.bttnCancel.ToolTip = "Cancel";
            this.bttnCancel.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // MarketSelection
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(386, 412);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MarketSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Management - Market Selection";
            ((System.ComponentModel.ISupportInitialize)(this.ClientPanel)).EndInit();
            this.ClientPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BoxStyles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMarkets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bttnOK;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl3;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit3;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton btnHelp;
        private DevExpress.XtraGrid.GridControl gcMarkets;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton bttnCancel;

    }
}
