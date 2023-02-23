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
			this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCustomers = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
			this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.repEmployees = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridControl2 = new DevExpress.XtraGrid.GridControl();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.btnCreateTransaction = new System.Windows.Forms.Button();
			this.btnDeleteTransaction = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repEmployees)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
			this.grdTransactions.Size = new System.Drawing.Size(776, 195);
			this.grdTransactions.TabIndex = 0;
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
			this.grvTransactions.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvTransactions_ValidateRow);
			// 
			// colDate
			// 
			this.colDate.Caption = "Date";
			this.colDate.FieldName = "Date";
			this.colDate.MinWidth = 30;
			this.colDate.Name = "colDate";
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
			// colCustomer
			// 
			this.colCustomer.Caption = "Customer";
			this.colCustomer.ColumnEdit = this.repCustomers;
			this.colCustomer.FieldName = "CustomerId";
			this.colCustomer.MinWidth = 30;
			this.colCustomer.Name = "colCustomer";
			this.colCustomer.Visible = true;
			this.colCustomer.VisibleIndex = 2;
			this.colCustomer.Width = 112;
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
			this.colTotalValue.Visible = true;
			this.colTotalValue.VisibleIndex = 4;
			this.colTotalValue.Width = 112;
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
			// gridControl2
			// 
			this.gridControl2.Location = new System.Drawing.Point(12, 284);
			this.gridControl2.MainView = this.gridView2;
			this.gridControl2.Name = "gridControl2";
			this.gridControl2.Size = new System.Drawing.Size(776, 154);
			this.gridControl2.TabIndex = 1;
			this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
			// 
			// gridView2
			// 
			this.gridView2.GridControl = this.gridControl2;
			this.gridView2.Name = "gridView2";
			// 
			// btnCreateTransaction
			// 
			this.btnCreateTransaction.Location = new System.Drawing.Point(597, 2);
			this.btnCreateTransaction.Name = "btnCreateTransaction";
			this.btnCreateTransaction.Size = new System.Drawing.Size(191, 34);
			this.btnCreateTransaction.TabIndex = 2;
			this.btnCreateTransaction.Text = "Create Transaction";
			this.btnCreateTransaction.UseVisualStyleBackColor = true;
			// 
			// btnDeleteTransaction
			// 
			this.btnDeleteTransaction.Location = new System.Drawing.Point(12, 2);
			this.btnDeleteTransaction.Name = "btnDeleteTransaction";
			this.btnDeleteTransaction.Size = new System.Drawing.Size(191, 34);
			this.btnDeleteTransaction.TabIndex = 3;
			this.btnDeleteTransaction.Text = "Delete Transaction";
			this.btnDeleteTransaction.UseVisualStyleBackColor = true;
			this.btnDeleteTransaction.Click += new System.EventHandler(this.btnDeleteTransaction_Click);
			// 
			// ViewTransactions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDeleteTransaction);
			this.Controls.Add(this.btnCreateTransaction);
			this.Controls.Add(this.gridControl2);
			this.Controls.Add(this.grdTransactions);
			this.Name = "ViewTransactions";
			this.Text = "ViewTransactions";
			this.Load += new System.EventHandler(this.ViewTransactions_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repEmployees)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
		private DevExpress.XtraGrid.GridControl gridControl2;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private Button btnCreateTransaction;
		private Button btnDeleteTransaction;
	}
}