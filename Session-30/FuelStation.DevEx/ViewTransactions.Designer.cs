namespace FuelStation.DevEx
{
	partial class ViewTransactions
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
            this.grdTransactions = new DevExpress.XtraGrid.GridControl();
            this.grvTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEmployees = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCustomers = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdTransactionLines = new DevExpress.XtraGrid.GridControl();
            this.grvTransactionLines = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransaction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItems = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItems = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCreateTransaction = new System.Windows.Forms.Button();
            this.btnUpdateTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTransactions
            // 
            this.grdTransactions.Location = new System.Drawing.Point(12, 42);
            this.grdTransactions.MainView = this.grvTransactions;
            this.grdTransactions.Name = "grdTransactions";
            this.grdTransactions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCustomers,
            this.repEmployees});
            this.grdTransactions.Size = new System.Drawing.Size(927, 192);
            this.grdTransactions.TabIndex = 0;
            this.grdTransactions.UseEmbeddedNavigator = true;
            this.grdTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactions});
            // 
            // grvTransactions
            // 
            this.grvTransactions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colEmployee,
            this.colCustomer,
            this.colPaymentMethod,
            this.colTotalValue});
            this.grvTransactions.GridControl = this.grdTransactions;
            this.grvTransactions.Name = "grvTransactions";
            this.grvTransactions.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grvTransactions_RowClick);
            this.grvTransactions.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.grvTransactions_RowDeleting);
            this.grvTransactions.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvTransactions_ValidateRow);
            // 
            // colDate
            // 
            this.colDate.Caption = "Date";
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 30;
            this.colDate.Name = "colDate";
            this.colDate.OptionsColumn.ReadOnly = true;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            this.colDate.Width = 112;
            // 
            // colEmployee
            // 
            this.colEmployee.Caption = "Employee";
            this.colEmployee.ColumnEdit = this.repEmployees;
            this.colEmployee.FieldName = "EmployeeId";
            this.colEmployee.MinWidth = 30;
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.Visible = true;
            this.colEmployee.VisibleIndex = 1;
            this.colEmployee.Width = 112;
            // 
            // repEmployees
            // 
            this.repEmployees.AutoHeight = false;
            this.repEmployees.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repEmployees.Name = "repEmployees";
            this.repEmployees.PopupView = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCustomer
            // 
            this.colCustomer.Caption = "Customer";
            this.colCustomer.ColumnEdit = this.repCustomers;
            this.colCustomer.FieldName = "CustomerId";
            this.colCustomer.MinWidth = 30;
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.OptionsColumn.ReadOnly = true;
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 2;
            this.colCustomer.Width = 112;
            // 
            // repCustomers
            // 
            this.repCustomers.AutoHeight = false;
            this.repCustomers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCustomers.Name = "repCustomers";
            this.repCustomers.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colPaymentMethod
            // 
            this.colPaymentMethod.Caption = "Payment Method";
            this.colPaymentMethod.FieldName = "PaymentMethod";
            this.colPaymentMethod.MinWidth = 30;
            this.colPaymentMethod.Name = "colPaymentMethod";
            this.colPaymentMethod.Visible = true;
            this.colPaymentMethod.VisibleIndex = 3;
            this.colPaymentMethod.Width = 112;
            // 
            // colTotalValue
            // 
            this.colTotalValue.Caption = "Total Value";
            this.colTotalValue.FieldName = "TotalValue";
            this.colTotalValue.MinWidth = 30;
            this.colTotalValue.Name = "colTotalValue";
            this.colTotalValue.OptionsColumn.ReadOnly = true;
            this.colTotalValue.Visible = true;
            this.colTotalValue.VisibleIndex = 4;
            this.colTotalValue.Width = 112;
            // 
            // grdTransactionLines
            // 
            this.grdTransactionLines.Location = new System.Drawing.Point(12, 285);
            this.grdTransactionLines.MainView = this.grvTransactionLines;
            this.grdTransactionLines.Name = "grdTransactionLines";
            this.grdTransactionLines.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItems});
            this.grdTransactionLines.Size = new System.Drawing.Size(927, 194);
            this.grdTransactionLines.TabIndex = 1;
            this.grdTransactionLines.UseEmbeddedNavigator = true;
            this.grdTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactionLines});
            // 
            // grvTransactionLines
            // 
            this.grvTransactionLines.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransaction,
            this.colId,
            this.colItems,
            this.colQuantity,
            this.gridItemPrice,
            this.colNetValue,
            this.colDiscountPercent,
            this.colDiscountValue,
            this.colTotal});
            this.grvTransactionLines.GridControl = this.grdTransactionLines;
            this.grvTransactionLines.Name = "grvTransactionLines";
            this.grvTransactionLines.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvTransactionLines_CellValueChanging);
            this.grvTransactionLines.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.grvTransactionLines_RowDeleting);
            this.grvTransactionLines.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvTransactionLines_ValidateRow);
            // 
            // colTransaction
            // 
            this.colTransaction.Caption = "Transaction";
            this.colTransaction.FieldName = "TransactionId";
            this.colTransaction.MinWidth = 30;
            this.colTransaction.Name = "colTransaction";
            this.colTransaction.OptionsColumn.ReadOnly = true;
            this.colTransaction.Width = 112;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 30;
            this.colId.Name = "colId";
            this.colId.Width = 112;
            // 
            // colItems
            // 
            this.colItems.Caption = "Item";
            this.colItems.ColumnEdit = this.repItems;
            this.colItems.FieldName = "ItemId";
            this.colItems.MinWidth = 30;
            this.colItems.Name = "colItems";
            this.colItems.Visible = true;
            this.colItems.VisibleIndex = 0;
            this.colItems.Width = 112;
            // 
            // repItems
            // 
            this.repItems.AutoHeight = false;
            this.repItems.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItems.Name = "repItems";
            this.repItems.PopupView = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 30;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            this.colQuantity.Width = 112;
            // 
            // gridItemPrice
            // 
            this.gridItemPrice.Caption = "Item Price";
            this.gridItemPrice.FieldName = "ItemPrice";
            this.gridItemPrice.MinWidth = 30;
            this.gridItemPrice.Name = "gridItemPrice";
            this.gridItemPrice.OptionsColumn.ReadOnly = true;
            this.gridItemPrice.Visible = true;
            this.gridItemPrice.VisibleIndex = 2;
            this.gridItemPrice.Width = 112;
            // 
            // colNetValue
            // 
            this.colNetValue.Caption = "Net Value";
            this.colNetValue.FieldName = "NetValue";
            this.colNetValue.MinWidth = 30;
            this.colNetValue.Name = "colNetValue";
            this.colNetValue.OptionsColumn.ReadOnly = true;
            this.colNetValue.Visible = true;
            this.colNetValue.VisibleIndex = 3;
            this.colNetValue.Width = 112;
            // 
            // colDiscountPercent
            // 
            this.colDiscountPercent.Caption = "Discount %";
            this.colDiscountPercent.FieldName = "DiscountPercent";
            this.colDiscountPercent.MinWidth = 30;
            this.colDiscountPercent.Name = "colDiscountPercent";
            this.colDiscountPercent.OptionsColumn.ReadOnly = true;
            this.colDiscountPercent.Visible = true;
            this.colDiscountPercent.VisibleIndex = 4;
            this.colDiscountPercent.Width = 112;
            // 
            // colDiscountValue
            // 
            this.colDiscountValue.Caption = "Dicount Value";
            this.colDiscountValue.FieldName = "DiscountValue";
            this.colDiscountValue.MinWidth = 30;
            this.colDiscountValue.Name = "colDiscountValue";
            this.colDiscountValue.OptionsColumn.ReadOnly = true;
            this.colDiscountValue.Visible = true;
            this.colDiscountValue.VisibleIndex = 5;
            this.colDiscountValue.Width = 112;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.FieldName = "TotalValue";
            this.colTotal.MinWidth = 30;
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.ReadOnly = true;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 6;
            this.colTotal.Width = 112;
            // 
            // btnCreateTransaction
            // 
            this.btnCreateTransaction.Location = new System.Drawing.Point(748, 2);
            this.btnCreateTransaction.Name = "btnCreateTransaction";
            this.btnCreateTransaction.Size = new System.Drawing.Size(191, 34);
            this.btnCreateTransaction.TabIndex = 2;
            this.btnCreateTransaction.Text = "Create Transaction";
            this.btnCreateTransaction.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTotal
            // 
            this.btnUpdateTotal.Location = new System.Drawing.Point(708, 245);
            this.btnUpdateTotal.Name = "btnUpdateTotal";
            this.btnUpdateTotal.Size = new System.Drawing.Size(184, 34);
            this.btnUpdateTotal.TabIndex = 3;
            this.btnUpdateTotal.Text = "Update Transaction";
            this.btnUpdateTotal.UseVisualStyleBackColor = true;
            this.btnUpdateTotal.Click += new System.EventHandler(this.btnUpdateTotal_Click);
            // 
            // ViewTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 491);
            this.Controls.Add(this.btnUpdateTotal);
            this.Controls.Add(this.btnCreateTransaction);
            this.Controls.Add(this.grdTransactionLines);
            this.Controls.Add(this.grdTransactions);
            this.Name = "ViewTransactions";
            this.Text = "ViewTransactions";
            this.Load += new System.EventHandler(this.ViewTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl grdTransactions;
		private DevExpress.XtraGrid.Views.Grid.GridView grvTransactions;
		private DevExpress.XtraGrid.Columns.GridColumn colDate;
		private DevExpress.XtraGrid.Columns.GridColumn colEmployee;
		private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
		private DevExpress.XtraGrid.Columns.GridColumn colPaymentMethod;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalValue;
		private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repCustomers;
		private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
		private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repEmployees;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.GridControl grdTransactionLines;
		private DevExpress.XtraGrid.Views.Grid.GridView grvTransactionLines;
		private Button btnCreateTransaction;
		private DevExpress.XtraGrid.Columns.GridColumn colTransaction;
		private DevExpress.XtraGrid.Columns.GridColumn colItems;
		private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repItems;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
		private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
		private DevExpress.XtraGrid.Columns.GridColumn gridItemPrice;
		private DevExpress.XtraGrid.Columns.GridColumn colNetValue;
		private DevExpress.XtraGrid.Columns.GridColumn colDiscountPercent;
		private DevExpress.XtraGrid.Columns.GridColumn colDiscountValue;
		private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private Button btnUpdateTotal;
    }
}