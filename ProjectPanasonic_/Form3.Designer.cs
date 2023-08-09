namespace ProjectPanasonic_
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tblUserinfoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.projectPanasonicDataSet = new ProjectPanasonic_.ProjectPanasonicDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserPswrd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.search = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tblUserinfoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserinfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblJobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserinfoTableAdapter = new ProjectPanasonic_.ProjectPanasonicDataSetTableAdapters.TblUserinfoTableAdapter();
            this.tblJobTableAdapter = new ProjectPanasonic_.ProjectPanasonicDataSetTableAdapters.TblJobTableAdapter();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.tblUserinfoBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserinfoBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserinfoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPanasonicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserinfoBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserinfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserinfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserinfoBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserinfoBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tblUserinfoBindingSource6;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1924, 1055);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // tblUserinfoBindingSource3
            // 
            this.tblUserinfoBindingSource3.DataMember = "TblUserinfo";
            this.tblUserinfoBindingSource3.DataSource = this.projectPanasonicDataSet;
            // 
            // projectPanasonicDataSet
            // 
            this.projectPanasonicDataSet.DataSetName = "ProjectPanasonicDataSet";
            this.projectPanasonicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colUserName,
            this.colUserPswrd,
            this.colUserEmail,
            this.colDepartment,
            this.colJob,
            this.search});
            this.gridView1.DetailHeight = 682;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1562;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 49;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 182;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.MinWidth = 49;
            this.colUserName.Name = "colUserName";
            this.colUserName.OptionsColumn.AllowEdit = false;
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 1;
            this.colUserName.Width = 182;
            // 
            // colUserPswrd
            // 
            this.colUserPswrd.FieldName = "UserPswrd";
            this.colUserPswrd.MinWidth = 49;
            this.colUserPswrd.Name = "colUserPswrd";
            this.colUserPswrd.OptionsColumn.AllowEdit = false;
            this.colUserPswrd.Visible = true;
            this.colUserPswrd.VisibleIndex = 2;
            this.colUserPswrd.Width = 182;
            // 
            // colUserEmail
            // 
            this.colUserEmail.FieldName = "UserEmail";
            this.colUserEmail.MinWidth = 49;
            this.colUserEmail.Name = "colUserEmail";
            this.colUserEmail.OptionsColumn.AllowEdit = false;
            this.colUserEmail.Visible = true;
            this.colUserEmail.VisibleIndex = 3;
            this.colUserEmail.Width = 182;
            // 
            // colDepartment
            // 
            this.colDepartment.FieldName = "Department";
            this.colDepartment.MinWidth = 49;
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.OptionsColumn.AllowEdit = false;
            this.colDepartment.Visible = true;
            this.colDepartment.VisibleIndex = 4;
            this.colDepartment.Width = 182;
            // 
            // colJob
            // 
            this.colJob.FieldName = "Job";
            this.colJob.MinWidth = 49;
            this.colJob.Name = "colJob";
            this.colJob.OptionsColumn.AllowEdit = false;
            this.colJob.Visible = true;
            this.colJob.VisibleIndex = 5;
            this.colJob.Width = 182;
            // 
            // search
            // 
            this.search.Caption = "Edit";
            this.search.ColumnEdit = this.repositoryItemButtonEdit1;
            this.search.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.search.MinWidth = 25;
            this.search.Name = "search";
            this.search.Visible = true;
            this.search.VisibleIndex = 6;
            this.search.Width = 94;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.tblUserinfoBindingSource3;
            this.repositoryItemLookUpEdit1.DisplayMember = "Job";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // tblUserinfoBindingSource4
            // 
            this.tblUserinfoBindingSource4.DataMember = "TblUserinfo";
            this.tblUserinfoBindingSource4.DataSource = this.projectPanasonicDataSet;
            // 
            // tblUserinfoBindingSource2
            // 
            this.tblUserinfoBindingSource2.DataMember = "TblUserinfo";
            this.tblUserinfoBindingSource2.DataSource = this.projectPanasonicDataSet;
            // 
            // tblUserinfoBindingSource1
            // 
            this.tblUserinfoBindingSource1.DataMember = "TblUserinfo";
            this.tblUserinfoBindingSource1.DataSource = this.projectPanasonicDataSet;
            this.tblUserinfoBindingSource1.CurrentChanged += new System.EventHandler(this.tblUserinfoBindingSource1_CurrentChanged);
            // 
            // tblJobBindingSource
            // 
            this.tblJobBindingSource.DataMember = "TblJob";
            this.tblJobBindingSource.DataSource = this.projectPanasonicDataSet;
            this.tblJobBindingSource.CurrentChanged += new System.EventHandler(this.tblJobBindingSource_CurrentChanged);
            // 
            // tblUserinfoBindingSource
            // 
            this.tblUserinfoBindingSource.DataMember = "TblUserinfo";
            this.tblUserinfoBindingSource.DataSource = this.projectPanasonicDataSet;
            this.tblUserinfoBindingSource.CurrentChanged += new System.EventHandler(this.tblUserinfoBindingSource_CurrentChanged);
            // 
            // tblUserinfoTableAdapter
            // 
            this.tblUserinfoTableAdapter.ClearBeforeFill = true;
            // 
            // tblJobTableAdapter
            // 
            this.tblJobTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(1472, 5);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(90, 33);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Kullanıcı Ekle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(1574, 5);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(6);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(90, 32);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Geri";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1672, 42);
            this.panelControl1.TabIndex = 3;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(1371, 5);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(90, 33);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Güncelle ";
            this.simpleButton3.Visible = false;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // tblUserinfoBindingSource5
            // 
            this.tblUserinfoBindingSource5.DataMember = "TblUserinfo";
            this.tblUserinfoBindingSource5.DataSource = this.projectPanasonicDataSet;
            // 
            // tblUserinfoBindingSource6
            // 
            this.tblUserinfoBindingSource6.DataMember = "TblUserinfo";
            this.tblUserinfoBindingSource6.DataSource = this.projectPanasonicDataSet;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Bilgileri";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserinfoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPanasonicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserinfoBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserinfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserinfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserinfoBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserinfoBindingSource6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private ProjectPanasonicDataSet projectPanasonicDataSet;
        private System.Windows.Forms.BindingSource tblUserinfoBindingSource;
        private ProjectPanasonicDataSetTableAdapters.TblUserinfoTableAdapter tblUserinfoTableAdapter;
        private System.Windows.Forms.BindingSource tblJobBindingSource;
        private ProjectPanasonicDataSetTableAdapters.TblJobTableAdapter tblJobTableAdapter;
        private System.Windows.Forms.BindingSource tblUserinfoBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserPswrd;
        private DevExpress.XtraGrid.Columns.GridColumn colUserEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colJob;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource tblUserinfoBindingSource2;
        private System.Windows.Forms.BindingSource tblUserinfoBindingSource3;
        private System.Windows.Forms.BindingSource tblUserinfoBindingSource4;
        private DevExpress.XtraGrid.Columns.GridColumn search;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private System.Windows.Forms.BindingSource tblUserinfoBindingSource5;
        private System.Windows.Forms.BindingSource tblUserinfoBindingSource6;
    }
}