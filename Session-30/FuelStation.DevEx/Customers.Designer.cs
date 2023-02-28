namespace FuelStation.DevEx
{
	partial class Customers
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
			this.grdCustomers = new DevExpress.XtraGrid.GridControl();
			this.grvCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnToIndex = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).BeginInit();
			this.SuspendLayout();
			// 
			// grdCustomers
			// 
			this.grdCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdCustomers.Location = new System.Drawing.Point(35, 31);
			this.grdCustomers.MainView = this.grvCustomers;
			this.grdCustomers.Name = "grdCustomers";
			this.grdCustomers.Size = new System.Drawing.Size(711, 361);
			this.grdCustomers.TabIndex = 0;
			this.grdCustomers.UseEmbeddedNavigator = true;
			this.grdCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCustomers});
			// 
			// grvCustomers
			// 
			this.grvCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colSurname,
            this.colCardNumber});
			this.grvCustomers.GridControl = this.grdCustomers;
			this.grvCustomers.Name = "grvCustomers";
			this.grvCustomers.OptionsView.ShowGroupPanel = false;
			this.grvCustomers.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvCustomers_CellValueChanging);
			this.grvCustomers.BeforeLeaveRow += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler(this.grvCustomers_BeforeLeaveRow);
			this.grvCustomers.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.grvCustomers_RowDeleting);
			this.grvCustomers.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvCustomers_ValidateRow);
			// 
			// colName
			// 
			this.colName.Caption = "Name";
			this.colName.FieldName = "Name";
			this.colName.MinWidth = 30;
			this.colName.Name = "colName";
			this.colName.Visible = true;
			this.colName.VisibleIndex = 0;
			this.colName.Width = 112;
			// 
			// colSurname
			// 
			this.colSurname.Caption = "Surname";
			this.colSurname.FieldName = "Surname";
			this.colSurname.MinWidth = 30;
			this.colSurname.Name = "colSurname";
			this.colSurname.Visible = true;
			this.colSurname.VisibleIndex = 1;
			this.colSurname.Width = 112;
			// 
			// colCardNumber
			// 
			this.colCardNumber.Caption = "Card Number";
			this.colCardNumber.FieldName = "CardNumber";
			this.colCardNumber.MinWidth = 30;
			this.colCardNumber.Name = "colCardNumber";
			this.colCardNumber.Visible = true;
			this.colCardNumber.VisibleIndex = 2;
			this.colCardNumber.Width = 112;
			// 
			// btnToIndex
			// 
			this.btnToIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnToIndex.Location = new System.Drawing.Point(35, 404);
			this.btnToIndex.Name = "btnToIndex";
			this.btnToIndex.Size = new System.Drawing.Size(139, 34);
			this.btnToIndex.TabIndex = 1;
			this.btnToIndex.Text = "Back To Home";
			this.btnToIndex.UseVisualStyleBackColor = true;
			this.btnToIndex.Click += new System.EventHandler(this.btnToIndex_Click);
			// 
			// Customers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnToIndex);
			this.Controls.Add(this.grdCustomers);
			this.Name = "Customers";
			this.Text = "Customers";
			this.Load += new System.EventHandler(this.Customers_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl grdCustomers;
		private DevExpress.XtraGrid.Views.Grid.GridView grvCustomers;
		private DevExpress.XtraGrid.Columns.GridColumn colName;
		private DevExpress.XtraGrid.Columns.GridColumn colSurname;
		private DevExpress.XtraGrid.Columns.GridColumn colCardNumber;
        private Button btnToIndex;
    }
}