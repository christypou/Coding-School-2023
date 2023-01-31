namespace Session_11 {
    partial class EngineerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.grdEngineers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridEngineerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridEngineerSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTasks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTasks = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridSalaryPerMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdServiceTasks = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textBoxEngineerTitle = new System.Windows.Forms.TextBox();
            this.textBoxServiceTaskTitle = new System.Windows.Forms.TextBox();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnPopulate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdEngineers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiceTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEngineers
            // 
            this.grdEngineers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grdEngineers.Location = new System.Drawing.Point(10, 46);
            this.grdEngineers.MainView = this.gridView1;
            this.grdEngineers.Margin = new System.Windows.Forms.Padding(2);
            this.grdEngineers.Name = "grdEngineers";
            this.grdEngineers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repTasks});
            this.grdEngineers.Size = new System.Drawing.Size(431, 143);
            this.grdEngineers.TabIndex = 0;
            this.grdEngineers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridEngineerName,
            this.gridEngineerSurname,
            this.gridTasks,
            this.gridSalaryPerMonth});
            this.gridView1.DetailHeight = 280;
            this.gridView1.GridControl = this.grdEngineers;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridEngineerName
            // 
            this.gridEngineerName.Caption = "Name";
            this.gridEngineerName.FieldName = "Name";
            this.gridEngineerName.MinWidth = 24;
            this.gridEngineerName.Name = "gridEngineerName";
            this.gridEngineerName.Visible = true;
            this.gridEngineerName.VisibleIndex = 0;
            this.gridEngineerName.Width = 160;
            // 
            // gridEngineerSurname
            // 
            this.gridEngineerSurname.Caption = "Surname";
            this.gridEngineerSurname.FieldName = "Surname";
            this.gridEngineerSurname.MinWidth = 24;
            this.gridEngineerSurname.Name = "gridEngineerSurname";
            this.gridEngineerSurname.Visible = true;
            this.gridEngineerSurname.VisibleIndex = 1;
            this.gridEngineerSurname.Width = 205;
            // 
            // gridTasks
            // 
            this.gridTasks.Caption = "Task";
            this.gridTasks.ColumnEdit = this.repTasks;
            this.gridTasks.FieldName = "TaskID";
            this.gridTasks.MinWidth = 24;
            this.gridTasks.Name = "gridTasks";
            this.gridTasks.Visible = true;
            this.gridTasks.VisibleIndex = 3;
            this.gridTasks.Width = 90;
            // 
            // repTasks
            // 
            this.repTasks.AutoHeight = false;
            this.repTasks.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTasks.Name = "repTasks";
            this.repTasks.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.DetailHeight = 280;
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridSalaryPerMonth
            // 
            this.gridSalaryPerMonth.Caption = "Salary";
            this.gridSalaryPerMonth.FieldName = "SalaryPerMonth";
            this.gridSalaryPerMonth.MinWidth = 24;
            this.gridSalaryPerMonth.Name = "gridSalaryPerMonth";
            this.gridSalaryPerMonth.Visible = true;
            this.gridSalaryPerMonth.VisibleIndex = 2;
            this.gridSalaryPerMonth.Width = 64;
            // 
            // grdServiceTasks
            // 
            this.grdServiceTasks.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grdServiceTasks.Location = new System.Drawing.Point(467, 46);
            this.grdServiceTasks.MainView = this.gridView2;
            this.grdServiceTasks.Margin = new System.Windows.Forms.Padding(2);
            this.grdServiceTasks.Name = "grdServiceTasks";
            this.grdServiceTasks.Size = new System.Drawing.Size(431, 143);
            this.grdServiceTasks.TabIndex = 1;
            this.grdServiceTasks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.grdServiceTasks.Click += new System.EventHandler(this.grdServiceTasks_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridCode,
            this.Description,
            this.gridHours});
            this.gridView2.DetailHeight = 280;
            this.gridView2.GridControl = this.grdServiceTasks;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridCode
            // 
            this.gridCode.Caption = "Code";
            this.gridCode.FieldName = "Code";
            this.gridCode.MinWidth = 24;
            this.gridCode.Name = "gridCode";
            this.gridCode.Visible = true;
            this.gridCode.VisibleIndex = 0;
            this.gridCode.Width = 134;
            // 
            // Description
            // 
            this.Description.Caption = "Description";
            this.Description.FieldName = "Description";
            this.Description.MinWidth = 24;
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 1;
            this.Description.Width = 134;
            // 
            // gridHours
            // 
            this.gridHours.Caption = "Hours";
            this.gridHours.FieldName = "Hours";
            this.gridHours.MinWidth = 24;
            this.gridHours.Name = "gridHours";
            this.gridHours.Visible = true;
            this.gridHours.VisibleIndex = 2;
            this.gridHours.Width = 64;
            // 
            // textBoxEngineerTitle
            // 
            this.textBoxEngineerTitle.Location = new System.Drawing.Point(152, 10);
            this.textBoxEngineerTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEngineerTitle.Name = "textBoxEngineerTitle";
            this.textBoxEngineerTitle.ReadOnly = true;
            this.textBoxEngineerTitle.Size = new System.Drawing.Size(170, 27);
            this.textBoxEngineerTitle.TabIndex = 2;
            this.textBoxEngineerTitle.Text = "Engineers";
            this.textBoxEngineerTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxServiceTaskTitle
            // 
            this.textBoxServiceTaskTitle.Location = new System.Drawing.Point(606, 10);
            this.textBoxServiceTaskTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxServiceTaskTitle.Name = "textBoxServiceTaskTitle";
            this.textBoxServiceTaskTitle.ReadOnly = true;
            this.textBoxServiceTaskTitle.Size = new System.Drawing.Size(170, 27);
            this.textBoxServiceTaskTitle.TabIndex = 3;
            this.textBoxServiceTaskTitle.Text = "Service Tasks";
            this.textBoxServiceTaskTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxServiceTaskTitle.TextChanged += new System.EventHandler(this.textBoxServiceTaskTitle_TextChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(804, 203);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 36);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(10, 203);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(118, 36);
            this.btnPopulate.TabIndex = 6;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // EngineerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 360);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.textBoxServiceTaskTitle);
            this.Controls.Add(this.textBoxEngineerTitle);
            this.Controls.Add(this.grdServiceTasks);
            this.Controls.Add(this.grdEngineers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EngineerForm";
            this.Text = "EngineerForm";
            this.Load += new System.EventHandler(this.EngineerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEngineers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiceTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdEngineers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridEngineerName;
        private DevExpress.XtraGrid.Columns.GridColumn gridEngineerSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalaryPerMonth;
        private DevExpress.XtraGrid.GridControl grdServiceTasks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridCode;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn gridHours;
        private TextBox textBoxEngineerTitle;
        private TextBox textBoxServiceTaskTitle;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.SimpleButton btnPopulate;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repTasks;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridTasks;
    }
}