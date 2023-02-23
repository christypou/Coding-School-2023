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
			((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repEmployees)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).BeginInit();
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
			this.colTotalValue.Visible = true;
			this.colTotalValue.VisibleIndex = 3;
			this.colTotalValue.Width = 112;
			// 
			// grdTransactionLines
			// 
			this.grdTransactionLines.Location = new System.Drawing.Point(12, 224);
			this.grdTransactionLines.MainView = this.grvTransactionLines;
			this.grdTransactionLines.Name = "grdTransactionLines";
			this.grdTransactionLines.Size = new System.Drawing.Size(776, 223);
			this.grdTransactionLines.TabIndex = 1;
			this.grdTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactionLines});
			// 
			// grvTransactionLines
			// 
			this.grvTransactionLines.GridControl = this.grdTransactionLines;
			this.grvTransactionLines.Name = "grvTransactionLines";
			// 
			// CreateTransactionForCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
	}
}