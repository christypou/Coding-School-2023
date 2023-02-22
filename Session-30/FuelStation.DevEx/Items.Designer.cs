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
			this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvItems)).BeginInit();
			this.SuspendLayout();
			// 
			// grdItems
			// 
			this.grdItems.Location = new System.Drawing.Point(23, 30);
			this.grdItems.MainView = this.grvItems;
			this.grdItems.Name = "grdItems";
			this.grdItems.Size = new System.Drawing.Size(732, 343);
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
			this.colPrice.FieldName = "Price";
			this.colPrice.MinWidth = 30;
			this.colPrice.Name = "colPrice";
			this.colPrice.Visible = true;
			this.colPrice.VisibleIndex = 3;
			this.colPrice.Width = 112;
			// 
			// colCost
			// 
			this.colCost.Caption = "Cost";
			this.colCost.FieldName = "Cost";
			this.colCost.MinWidth = 30;
			this.colCost.Name = "colCost";
			this.colCost.Visible = true;
			this.colCost.VisibleIndex = 4;
			this.colCost.Width = 112;
			// 
			// Items
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.grdItems);
			this.Name = "Items";
			this.Text = "Items";
			this.Load += new System.EventHandler(this.Items_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvItems)).EndInit();
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
	}
}