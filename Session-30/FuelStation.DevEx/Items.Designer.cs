namespace FuelStation.DevEx
{
	partial class Items
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
            this.grdItems = new DevExpress.XtraGrid.GridControl();
            this.grvItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.btnToIndex = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // grdItems
            // 
            this.grdItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdItems.Location = new System.Drawing.Point(23, 30);
            this.grdItems.MainView = this.grvItems;
            this.grdItems.Name = "grdItems";
            this.grdItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2});
            this.grdItems.Size = new System.Drawing.Size(732, 368);
            this.grdItems.TabIndex = 0;
            this.grdItems.UseEmbeddedNavigator = true;
            this.grdItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvItems});
            // 
            // grvItems
            // 
            this.grvItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colDescription,
            this.colItemType,
            this.colPrice,
            this.colCost});
            this.grvItems.GridControl = this.grdItems;
            this.grvItems.Name = "grvItems";
            this.grvItems.OptionsView.ShowGroupPanel = false;
            this.grvItems.BeforeLeaveRow += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler(this.grvItems_BeforeLeaveRow);
            this.grvItems.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.grvItems_RowDeleting);
            this.grvItems.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvItems_ValidateRow);
            // 
            // colCode
            // 
            this.colCode.Caption = "Code";
            this.colCode.FieldName = "Code";
            this.colCode.MinWidth = 30;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 112;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 30;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 112;
            // 
            // colItemType
            // 
            this.colItemType.Caption = "Type";
            this.colItemType.FieldName = "ItemType";
            this.colItemType.MinWidth = 30;
            this.colItemType.Name = "colItemType";
            this.colItemType.Visible = true;
            this.colItemType.VisibleIndex = 2;
            this.colItemType.Width = 112;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 30;
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            this.colPrice.Width = 112;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // colCost
            // 
            this.colCost.Caption = "Cost";
            this.colCost.ColumnEdit = this.repositoryItemSpinEdit2;
            this.colCost.FieldName = "Cost";
            this.colCost.MinWidth = 30;
            this.colCost.Name = "colCost";
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 4;
            this.colCost.Width = 112;
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // btnToIndex
            // 
            this.btnToIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnToIndex.Location = new System.Drawing.Point(23, 404);
            this.btnToIndex.Name = "btnToIndex";
            this.btnToIndex.Size = new System.Drawing.Size(136, 34);
            this.btnToIndex.TabIndex = 1;
            this.btnToIndex.Text = "Back To Home";
            this.btnToIndex.UseVisualStyleBackColor = true;
            this.btnToIndex.Click += new System.EventHandler(this.btnToIndex_Click);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToIndex);
            this.Controls.Add(this.grdItems);
            this.Name = "Items";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl grdItems;
		private DevExpress.XtraGrid.Views.Grid.GridView grvItems;
		private DevExpress.XtraGrid.Columns.GridColumn colCode;
		private DevExpress.XtraGrid.Columns.GridColumn colDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colItemType;
		private DevExpress.XtraGrid.Columns.GridColumn colPrice;
		private DevExpress.XtraGrid.Columns.GridColumn colCost;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private Button btnToIndex;
    }
}