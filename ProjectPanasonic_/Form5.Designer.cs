namespace ProjectPanasonic_
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.tblUserinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectPanasonicDataSet = new ProjectPanasonic_.ProjectPanasonicDataSet();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserTableAdapter = new ProjectPanasonic_.ProjectPanasonicDataSetTableAdapters.TblUserTableAdapter();
            this.tblUserBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.tblUserinfoTableAdapter = new ProjectPanasonic_.ProjectPanasonicDataSetTableAdapters.TblUserinfoTableAdapter();
            this.tblUserinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPanasonicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserinfoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(12, 134);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(112, 21);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Kullanıcı Adı:";
            this.labelControl7.Click += new System.EventHandler(this.labelControl7_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(75, 179);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(49, 21);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Yetki:";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(130, 135);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DataSource = this.tblUserinfoBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "UserName";
            this.lookUpEdit1.Properties.NullText = "SEÇİM YAPINIZ";
            this.lookUpEdit1.Properties.PopupFormMinSize = new System.Drawing.Size(750, 300);
            this.lookUpEdit1.Size = new System.Drawing.Size(185, 22);
            this.lookUpEdit1.TabIndex = 2;
            // 
            // tblUserinfoBindingSource
            // 
            this.tblUserinfoBindingSource.DataMember = "TblUserinfo";
            this.tblUserinfoBindingSource.DataSource = this.projectPanasonicDataSet;
            // 
            // projectPanasonicDataSet
            // 
            this.projectPanasonicDataSet.DataSetName = "ProjectPanasonicDataSet";
            this.projectPanasonicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataMember = "TblUser";
            this.tblUserBindingSource.DataSource = this.projectPanasonicDataSet;
            // 
            // tblUserBindingSource1
            // 
            this.tblUserBindingSource1.DataMember = "TblUser";
            this.tblUserBindingSource1.DataSource = this.projectPanasonicDataSet;
            // 
            // tblUserTableAdapter
            // 
            this.tblUserTableAdapter.ClearBeforeFill = true;
            // 
            // tblUserBindingSource2
            // 
            this.tblUserBindingSource2.DataMember = "TblUser";
            this.tblUserBindingSource2.DataSource = this.projectPanasonicDataSet;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "SEÇİM YAPINIZ";
            this.comboBoxEdit1.Location = new System.Drawing.Point(130, 180);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(185, 22);
            this.comboBoxEdit1.TabIndex = 4;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(130, 221);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(85, 27);
            this.simpleButton6.TabIndex = 5;
            this.simpleButton6.Text = "Güncelle";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // simpleButton7
            // 
            this.simpleButton7.Location = new System.Drawing.Point(230, 221);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(85, 27);
            this.simpleButton7.TabIndex = 7;
            this.simpleButton7.Text = "Geri";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // tblUserinfoTableAdapter
            // 
            this.tblUserinfoTableAdapter.ClearBeforeFill = true;
            // 
            // tblUserinfoBindingSource1
            // 
            this.tblUserinfoBindingSource1.DataMember = "TblUserinfo";
            this.tblUserinfoBindingSource1.DataSource = this.projectPanasonicDataSet;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 276);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetki Güncelleme";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPanasonicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserinfoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private ProjectPanasonicDataSet projectPanasonicDataSet;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private ProjectPanasonicDataSetTableAdapters.TblUserTableAdapter tblUserTableAdapter;
        private System.Windows.Forms.BindingSource tblUserBindingSource1;
        private System.Windows.Forms.BindingSource tblUserBindingSource2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private System.Windows.Forms.BindingSource tblUserinfoBindingSource;
        private ProjectPanasonicDataSetTableAdapters.TblUserinfoTableAdapter tblUserinfoTableAdapter;
        private System.Windows.Forms.BindingSource tblUserinfoBindingSource1;
    }
}