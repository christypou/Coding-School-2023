namespace FuelStation.DevEx
{
	partial class CreateTransactionForCustomer
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
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdTransactionLines = new DevExpress.XtraGrid.GridControl();
            this.grvTransactionLines = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItems = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUpdateTotal = new System.Windows.Forms.Button();
            this.btnToIndex = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTransactions
            // 
            this.grdTransactions.Location = new System.Drawing.Point(12, 12);
            this.grdTransactions.MainView = this.grvTransactions;
            this.grdTransactions.Name = "grdTransactions";
            this.grdTransactions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEmployees});
            this.grdTransactions.Size = new System.Drawing.Size(776, 206);
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
            this.repEmployees.PopupView = this.repositoryItemGridLookUpEdit1View;
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
            this.colPaymentMethod.Caption = "Payment Type";
            this.colPaymentMethod.FieldName = "PaymentMethod";
            this.colPaymentMethod.MinWidth = 30;
            this.colPaymentMethod.Name = "colPaymentMethod";
            this.colPaymentMethod.Visible = true;
            this.colPaymentMethod.VisibleIndex = 2;
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
            this.colTotalValue.VisibleIndex = 3;
            this.colTotalValue.Width = 112;
            // 
            // grdTransactionLines
            // 
            this.grdTransactionLines.Location = new System.Drawing.Point(12, 261);
            this.grdTransactionLines.MainView = this.grvTransactionLines;
            this.grdTransactionLines.Name = "grdTransactionLines";
            this.grdTransactionLines.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItems,
            this.repositoryItemSpinEdit1});
            this.grdTransactionLines.Size = new System.Drawing.Size(776, 186);
            this.grdTransactionLines.TabIndex = 1;
            this.grdTransactionLines.UseEmbeddedNavigator = true;
            this.grdTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactionLines});
            // 
            // grvTransactionLines
            // 
            this.grvTransactionLines.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTransactionId,
            this.colItem,
            this.colQuantity,
            this.colItemPrice,
            this.colNetValue,
            this.colDiscountPercent,
            this.colDiscountValue,
            this.colTotal});
            this.grvTransactionLines.GridControl = this.grdTransactionLines;
            this.grvTransactionLines.Name = "grvTransactionLines";
            this.grvTransactionLines.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvTransactionLines_CellValueChanged);
            this.grvTransactionLines.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvTransactionLines_CellValueChanging);
            this.grvTransactionLines.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.grvTransactionLines_RowDeleting_1);
            this.grvTransactionLines.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvTransactionLines_ValidateRow);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 30;
            this.colId.Name = "colId";
            this.colId.Width = 112;
            // 
            // colTransactionId
            // 
            this.colTransactionId.Caption = "Transaction Id";
            this.colTransactionId.FieldName = "TransactionId";
            this.colTransactionId.MinWidth = 30;
            this.colTransactionId.Name = "colTransactionId";
            this.colTransactionId.Width = 112;
            // 
            // colItem
            // 
            this.colItem.Caption = "Item";
            this.colItem.ColumnEdit = this.repItems;
            this.colItem.FieldName = "ItemId";
            this.colItem.MinWidth = 30;
            this.colItem.Name = "colItem";
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 0;
            this.colItem.Width = 112;
            // 
            // repItems
            // 
            this.repItems.AutoHeight = false;
            this.repItems.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItems.Name = "repItems";
            this.repItems.PopupView = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 30;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            this.colQuantity.Width = 112;
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
            // colItemPrice
            // 
            this.colItemPrice.Caption = "Item Price";
            this.colItemPrice.FieldName = "ItemPrice";
            this.colItemPrice.MinWidth = 30;
            this.colItemPrice.Name = "colItemPrice";
            this.colItemPrice.OptionsColumn.ReadOnly = true;
            this.colItemPrice.Visible = true;
            this.colItemPrice.VisibleIndex = 2;
            this.colItemPrice.Width = 112;
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
            this.colDiscountValue.Caption = "Discount Value";
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
            // btnUpdateTotal
            // 
            this.btnUpdateTotal.Location = new System.Drawing.Point(579, 224);
            this.btnUpdateTotal.Name = "btnUpdateTotal";
            this.btnUpdateTotal.Size = new System.Drawing.Size(176, 34);
            this.btnUpdateTotal.TabIndex = 2;
            this.btnUpdateTotal.Text = "Update Transaction";
            this.btnUpdateTotal.UseVisualStyleBackColor = true;
            this.btnUpdateTotal.Click += new System.EventHandler(this.btnUpdateTotal_Click);
            // 
            // btnToIndex
            // 
            this.btnToIndex.Location = new System.Drawing.Point(12, 466);
            this.btnToIndex.Name = "btnToIndex";
            this.btnToIndex.Size = new System.Drawing.Size(143, 34);
            this.btnToIndex.TabIndex = 3;
            this.btnToIndex.Text = "Back To Home";
            this.btnToIndex.UseVisualStyleBackColor = true;
            this.btnToIndex.Click += new System.EventHandler(this.btnToIndex_Click);
            // 
            // CreateTransactionForCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 512);
            this.Controls.Add(this.btnToIndex);
            this.Controls.Add(this.btnUpdateTotal);
            this.Controls.Add(this.grdTransactionLines);
            this.Controls.Add(this.grdTransactions);
            this.Name = "CreateTransactionForCustomer";
            this.Text = "CreateTransactionForCustomer";
            this.Load += new System.EventHandler(this.CreateTransactionForCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl grdTransactions;
		private DevExpress.XtraGrid.Views.Grid.GridView grvTransactions;
		private DevExpress.XtraGrid.Columns.GridColumn colDate;
		private DevExpress.XtraGrid.Columns.GridColumn colEmployee;
		private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repEmployees;
		private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
		private DevExpress.XtraGrid.Columns.GridColumn colPaymentMethod;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalValue;
		private DevExpress.XtraGrid.GridControl grdTransactionLines;
		private DevExpress.XtraGrid.Views.Grid.GridView grvTransactionLines;
		private DevExpress.XtraGrid.Columns.GridColumn colItem;
		private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repItems;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
		private DevExpress.XtraGrid.Columns.GridColumn colItemPrice;
		private DevExpress.XtraGrid.Columns.GridColumn colNetValue;
		private DevExpress.XtraGrid.Columns.GridColumn colDiscountPercent;
		private DevExpress.XtraGrid.Columns.GridColumn colDiscountValue;
		private DevExpress.XtraGrid.Columns.GridColumn colTotal;
		private DevExpress.XtraGrid.Columns.GridColumn colTransactionId;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
        private Button btnUpdateTotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private Button btnToIndex;
    }
}