namespace Disney.iDash.SPICE.Forms
{
    partial class SpiceToolbar
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
            DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem5 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem5 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            this.rpSpice = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgPurchaseOrders = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barListItemNewPO = new DevExpress.XtraBars.BarListItem();
            this.barListItemFindPO = new DevExpress.XtraBars.BarListItem();
            this.barPOStageSetDate = new DevExpress.XtraBars.BarButtonItem();
            this.rpgItemManagement = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barListItemNewItems = new DevExpress.XtraBars.BarListItem();
            this.barListItemFindItems = new DevExpress.XtraBars.BarListItem();
            this.barIMSizeGroupMaintenance = new DevExpress.XtraBars.BarButtonItem();
            this.barIMPricingMatrix = new DevExpress.XtraBars.BarButtonItem();
            this.rpgEAS = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barEASApproverRequests = new DevExpress.XtraBars.BarButtonItem();
            this.barEASSubmittedRequests = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            ((System.ComponentModel.ISupportInitialize)(this.addinRibbon)).BeginInit();
            this.SuspendLayout();
            // 
            // addinRibbon
            // 
            // 
            // 
            // 
            this.addinRibbon.ExpandCollapseItem.Id = 0;
            this.addinRibbon.ExpandCollapseItem.Name = "";
            this.addinRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barIMSizeGroupMaintenance,
            this.barIMPricingMatrix,
            this.barEASApproverRequests,
            this.barEASSubmittedRequests,
            this.barPOStageSetDate,
            this.barListItemNewItems,
            this.barListItemFindItems,
            this.barSubItem2,
            this.barSubItem3,
            this.barListItemNewPO,
            this.barListItemFindPO});
            this.addinRibbon.MaxItemId = 42;
            this.addinRibbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpSpice});
            this.addinRibbon.SelectedPage = this.rpSpice;
            this.addinRibbon.Size = new System.Drawing.Size(1043, 147);
            // 
            // rpSpice
            // 
            this.rpSpice.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgPurchaseOrders,
            this.rpgItemManagement,
            this.rpgEAS});
            this.rpSpice.MergeOrder = 1;
            this.rpSpice.Name = "rpSpice";
            this.rpSpice.Text = "SPICE";
            // 
            // rpgPurchaseOrders
            // 
            this.rpgPurchaseOrders.ItemLinks.Add(this.barListItemNewPO, true);
            this.rpgPurchaseOrders.ItemLinks.Add(this.barListItemFindPO);
            this.rpgPurchaseOrders.ItemLinks.Add(this.barPOStageSetDate);
            this.rpgPurchaseOrders.Name = "rpgPurchaseOrders";
            this.rpgPurchaseOrders.ShowCaptionButton = false;
            this.rpgPurchaseOrders.Text = "Purchase Orders";
            // 
            // barListItemNewPO
            // 
            this.barListItemNewPO.Caption = "New";
            this.barListItemNewPO.Id = 37;
            this.barListItemNewPO.LargeGlyph = global::Disney.iDash.SPICE.Properties.Resources.Summary;
            this.barListItemNewPO.Name = "barListItemNewPO";
            this.barListItemNewPO.Strings.AddRange(new object[] {
            "Purchase Order"});
            this.barListItemNewPO.ListItemClick += new DevExpress.XtraBars.ListItemClickEventHandler(this.barListItemNewPO_ListItemClick);
            // 
            // barListItemFindPO
            // 
            this.barListItemFindPO.Caption = "Find";
            this.barListItemFindPO.Id = 41;
            this.barListItemFindPO.LargeGlyph = global::Disney.iDash.SPICE.Properties.Resources.Summary;
            this.barListItemFindPO.Name = "barListItemFindPO";
            this.barListItemFindPO.Strings.AddRange(new object[] {
            "Purchase Order"});
            this.barListItemFindPO.ListItemClick += new DevExpress.XtraBars.ListItemClickEventHandler(this.barListItemFindPO_ListItemClick);
            // 
            // barPOStageSetDate
            // 
            this.barPOStageSetDate.Caption = "Stage Set Dates";
            this.barPOStageSetDate.Id = 40;
            this.barPOStageSetDate.LargeGlyph = global::Disney.iDash.SPICE.Properties.Resources.Stowaway_Stores;
            this.barPOStageSetDate.Name = "barPOStageSetDate";
            this.barPOStageSetDate.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipTitleItem5.Text = "Stage Set Dates";
            toolTipItem5.Text = "Stage Set Dates";
            superToolTip5.Items.Add(toolTipTitleItem5);
            superToolTip5.Items.Add(toolTipItem5);
            this.barPOStageSetDate.SuperTip = superToolTip5;
            this.barPOStageSetDate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barPOPOStageSetDates_ItemClick);
            // 
            // rpgItemManagement
            // 
            this.rpgItemManagement.ItemLinks.Add(this.barListItemNewItems);
            this.rpgItemManagement.ItemLinks.Add(this.barListItemFindItems);
            this.rpgItemManagement.ItemLinks.Add(this.barIMSizeGroupMaintenance);
            this.rpgItemManagement.ItemLinks.Add(this.barIMPricingMatrix);
            this.rpgItemManagement.Name = "rpgItemManagement";
            this.rpgItemManagement.ShowCaptionButton = false;
            this.rpgItemManagement.Text = "Item Management";
            // 
            // barListItemNewItems
            // 
            this.barListItemNewItems.Caption = "New";
            this.barListItemNewItems.Id = 27;
            this.barListItemNewItems.LargeGlyph = global::Disney.iDash.SPICE.Properties.Resources.Summary;
            this.barListItemNewItems.Name = "barListItemNewItems";
            this.barListItemNewItems.Strings.AddRange(new object[] {
            "Item",
            "Assorted Pre-Pack (APP)"});
            this.barListItemNewItems.ListItemClick += new DevExpress.XtraBars.ListItemClickEventHandler(this.barListItemNewItems_ListItemClick);
            // 
            // barListItemFindItems
            // 
            this.barListItemFindItems.Caption = "Find";
            this.barListItemFindItems.Id = 32;
            this.barListItemFindItems.LargeGlyph = global::Disney.iDash.SPICE.Properties.Resources.Summary;
            this.barListItemFindItems.Name = "barListItemFindItems";
            this.barListItemFindItems.Strings.AddRange(new object[] {
            "Item",
            "Assorted Pre-Pack (APP)"});
            this.barListItemFindItems.ListItemClick += new DevExpress.XtraBars.ListItemClickEventHandler(this.barListItemFindItems_ListItemClick);
            // 
            // barIMSizeGroupMaintenance
            // 
            this.barIMSizeGroupMaintenance.Caption = "Size Group Maintenance";
            this.barIMSizeGroupMaintenance.Id = 35;
            this.barIMSizeGroupMaintenance.LargeGlyph = global::Disney.iDash.SPICE.Properties.Resources.Summary;
            this.barIMSizeGroupMaintenance.Name = "barIMSizeGroupMaintenance";
            this.barIMSizeGroupMaintenance.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipTitleItem1.Text = "Size Group Maintenance";
            toolTipItem1.Text = "Size Group Maintenance";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.barIMSizeGroupMaintenance.SuperTip = superToolTip1;
            this.barIMSizeGroupMaintenance.Tag = "Size Group Maintenance";
            this.barIMSizeGroupMaintenance.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barIMSizeGroupMaintenance_ItemClick);
            // 
            // barIMPricingMatrix
            // 
            this.barIMPricingMatrix.Caption = "Pricing Matrix";
            this.barIMPricingMatrix.Id = 35;
            this.barIMPricingMatrix.LargeGlyph = global::Disney.iDash.SPICE.Properties.Resources.Summary;
            this.barIMPricingMatrix.Name = "barIMPricingMatrix";
            this.barIMPricingMatrix.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipTitleItem2.Text = "Pricing Matrix";
            toolTipItem2.Text = "Pricing Matrix";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.barIMPricingMatrix.SuperTip = superToolTip2;
            this.barIMPricingMatrix.Tag = "Pricing Matrix";
            this.barIMPricingMatrix.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barIMPricingMatrix_ItemClick);
            // 
            // rpgEAS
            // 
            this.rpgEAS.ItemLinks.Add(this.barEASApproverRequests);
            this.rpgEAS.ItemLinks.Add(this.barEASSubmittedRequests);
            this.rpgEAS.Name = "rpgEAS";
            this.rpgEAS.ShowCaptionButton = false;
            this.rpgEAS.Text = "EAS";
            // 
            // barEASApproverRequests
            // 
            this.barEASApproverRequests.Caption = "Pending Approval Requests";
            this.barEASApproverRequests.Id = 9;
            this.barEASApproverRequests.LargeGlyph = global::Disney.iDash.SPICE.Properties.Resources.User__Department_Authority;
            this.barEASApproverRequests.Name = "barEASApproverRequests";
            this.barEASApproverRequests.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipTitleItem3.Text = "Pending Approval Requests";
            toolTipItem3.Text = "Pending Approval Requests";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            this.barEASApproverRequests.SuperTip = superToolTip3;
            this.barEASApproverRequests.Tag = "Pending Approval Requests";
            this.barEASApproverRequests.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barEASApproverRequests_ItemClick);
            // 
            // barEASSubmittedRequests
            // 
            this.barEASSubmittedRequests.Caption = "Approved Requests";
            this.barEASSubmittedRequests.Id = 10;
            this.barEASSubmittedRequests.LargeGlyph = global::Disney.iDash.SPICE.Properties.Resources.User__Department_Authority;
            this.barEASSubmittedRequests.Name = "barEASSubmittedRequests";
            this.barEASSubmittedRequests.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipTitleItem4.Text = "Approved Requests";
            toolTipItem4.LeftIndent = 6;
            toolTipItem4.Text = "Approved Requests";
            superToolTip4.Items.Add(toolTipTitleItem4);
            superToolTip4.Items.Add(toolTipItem4);
            this.barEASSubmittedRequests.SuperTip = superToolTip4;
            this.barEASSubmittedRequests.Tag = "Approved Requests";
            this.barEASSubmittedRequests.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barEASSubmitetdRequests_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "barSubItem2";
            this.barSubItem2.Id = 35;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "barSubItem3";
            this.barSubItem3.Id = 36;
            this.barSubItem3.Name = "barSubItem3";
            // 
            // SpiceToolbar
            // 
            this.ApplicationId = 2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1043, 460);
            this.Name = "SpiceToolbar";
            this.Tag = "SPICE";
            ((System.ComponentModel.ISupportInitialize)(this.addinRibbon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage rpSpice;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPurchaseOrders;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgItemManagement;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgEAS;
        private DevExpress.XtraBars.BarButtonItem barPOStageSetDate;
        private DevExpress.XtraBars.BarButtonItem barIMSizeGroupMaintenance;
        private DevExpress.XtraBars.BarButtonItem barIMPricingMatrix;
        private DevExpress.XtraBars.BarButtonItem barEASApproverRequests;
        private DevExpress.XtraBars.BarButtonItem barEASSubmittedRequests;
        private DevExpress.XtraBars.BarListItem barListItemNewItems;
        private DevExpress.XtraBars.BarListItem barListItemFindItems;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarListItem barListItemNewPO;
        private DevExpress.XtraBars.BarListItem barListItemFindPO;    
        
    }
}
