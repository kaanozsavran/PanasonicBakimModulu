namespace ProjectPanasonic_
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.tblUserinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectPanasonicDataSet = new ProjectPanasonic_.ProjectPanasonicDataSet();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.tblUserTableAdapter = new ProjectPanasonic_.ProjectPanasonicDataSetTableAdapters.TblUserTableAdapter();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.projectPanasonicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserinfoTableAdapter = new ProjectPanasonic_.ProjectPanasonicDataSetTableAdapters.TblUserinfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPanasonicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPanasonicDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(152, 133);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DataSource = this.tblUserinfoBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "UserName";
            this.lookUpEdit1.Properties.NullText = "SEÇİM YAPINIZ";
            this.lookUpEdit1.Properties.PopupFormMinSize = new System.Drawing.Size(750, 300);
            this.lookUpEdit1.Size = new System.Drawing.Size(155, 22);
            this.lookUpEdit1.TabIndex = 0;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
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
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(45, 132);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(101, 21);
            this.labelControl9.TabIndex = 1;
            this.labelControl9.Text = "Kullanıcılar:";
            this.labelControl9.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // tblUserTableAdapter
            // 
            this.tblUserTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(59, 170);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(87, 21);
            this.labelControl10.TabIndex = 2;
            this.labelControl10.Text = "Ad Soyad:";
            this.labelControl10.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(34, 208);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(112, 21);
            this.labelControl11.TabIndex = 3;
            this.labelControl11.Text = "Kullanıcı Adı:";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(100, 246);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(46, 21);
            this.labelControl12.TabIndex = 4;
            this.labelControl12.Text = "Şifre:";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(94, 282);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(52, 21);
            this.labelControl13.TabIndex = 5;
            this.labelControl13.Text = "Email:";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(12, 319);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(134, 21);
            this.labelControl14.TabIndex = 6;
            this.labelControl14.Text = "Department ID:";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(152, 171);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(155, 22);
            this.textEdit1.TabIndex = 7;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(152, 207);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(155, 22);
            this.textEdit2.TabIndex = 8;
            this.textEdit2.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(152, 247);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(155, 22);
            this.textEdit3.TabIndex = 9;
            this.textEdit3.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(152, 283);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(155, 22);
            this.textEdit4.TabIndex = 10;
            this.textEdit4.EditValueChanged += new System.EventHandler(this.textEdit4_EditValueChanged);
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(152, 320);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Intern",
            "Software Engineer",
            "Computer Engineer",
            "Software Developer",
            "Data Analyst",
            "IT Manager"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(155, 22);
            this.comboBoxEdit1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // simpleButton8
            // 
            this.simpleButton8.Location = new System.Drawing.Point(152, 362);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(74, 32);
            this.simpleButton8.TabIndex = 13;
            this.simpleButton8.Text = "Güncelle";
            this.simpleButton8.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // simpleButton9
            // 
            this.simpleButton9.Location = new System.Drawing.Point(233, 362);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(74, 32);
            this.simpleButton9.TabIndex = 14;
            this.simpleButton9.Text = "Geri";
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // projectPanasonicDataSetBindingSource
            // 
            this.projectPanasonicDataSetBindingSource.DataSource = this.projectPanasonicDataSet;
            this.projectPanasonicDataSetBindingSource.Position = 0;
            // 
            // tblUserinfoTableAdapter
            // 
            this.tblUserinfoTableAdapter.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 415);
            this.Controls.Add(this.simpleButton9);
            this.Controls.Add(this.simpleButton8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.textEdit4);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.lookUpEdit1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güncelleme";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPanasonicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPanasonicDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private ProjectPanasonicDataSet projectPanasonicDataSet;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private ProjectPanasonicDataSetTableAdapters.TblUserTableAdapter tblUserTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private System.Windows.Forms.BindingSource projectPanasonicDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblUserinfoBindingSource;
        private ProjectPanasonicDataSetTableAdapters.TblUserinfoTableAdapter tblUserinfoTableAdapter;
    }
}