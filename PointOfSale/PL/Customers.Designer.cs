namespace PointOfSale.PL
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Text_Search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bEdit = new System.Windows.Forms.Button();
            this.But_Save = new System.Windows.Forms.Button();
            this.BNew = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.Text_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pCAT = new System.Windows.Forms.Label();
            this.BtnPrevi = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.BtnFirst = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text_Name = new System.Windows.Forms.TextBox();
            this.Text_Phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Text_LName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(540, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 563);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Text_Search);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(3, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 535);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لائحة الموظفين";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(37, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 25);
            this.button1.TabIndex = 43;
            this.button1.Text = "موافق";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Text_Search
            // 
            this.Text_Search.Font = new System.Drawing.Font("Simplified Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Search.Location = new System.Drawing.Point(127, 37);
            this.Text_Search.Multiline = true;
            this.Text_Search.Name = "Text_Search";
            this.Text_Search.Size = new System.Drawing.Size(311, 25);
            this.Text_Search.TabIndex = 0;
            this.Text_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_Search_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(444, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "إبحث هنا";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(-1, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 547);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bEdit);
            this.groupBox1.Controls.Add(this.But_Save);
            this.groupBox1.Controls.Add(this.BNew);
            this.groupBox1.Controls.Add(this.BDelete);
            this.groupBox1.Controls.Add(this.Text_Email);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pCAT);
            this.groupBox1.Controls.Add(this.BtnPrevi);
            this.groupBox1.Controls.Add(this.BtnNext);
            this.groupBox1.Controls.Add(this.BtnLast);
            this.groupBox1.Controls.Add(this.BtnFirst);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Text_Name);
            this.groupBox1.Controls.Add(this.Text_Phone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Text_LName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 541);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات العميل";
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(165, 407);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(91, 36);
            this.bEdit.TabIndex = 44;
            this.bEdit.Text = "تعديل";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.button3_Click);
            // 
            // But_Save
            // 
            this.But_Save.Enabled = false;
            this.But_Save.Location = new System.Drawing.Point(287, 407);
            this.But_Save.Name = "But_Save";
            this.But_Save.Size = new System.Drawing.Size(91, 36);
            this.But_Save.TabIndex = 5;
            this.But_Save.Text = "حفظ";
            this.But_Save.UseVisualStyleBackColor = true;
            this.But_Save.Click += new System.EventHandler(this.button2_Click);
            // 
            // BNew
            // 
            this.BNew.Location = new System.Drawing.Point(409, 407);
            this.BNew.Name = "BNew";
            this.BNew.Size = new System.Drawing.Size(109, 36);
            this.BNew.TabIndex = 4;
            this.BNew.Text = "جديد";
            this.BNew.UseVisualStyleBackColor = true;
            this.BNew.Click += new System.EventHandler(this.BNew_Click);
            // 
            // BDelete
            // 
            this.BDelete.Location = new System.Drawing.Point(24, 407);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(117, 36);
            this.BDelete.TabIndex = 41;
            this.BDelete.Text = "حذف";
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // Text_Email
            // 
            this.Text_Email.Font = new System.Drawing.Font("Simplified Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Email.Location = new System.Drawing.Point(275, 211);
            this.Text_Email.Multiline = true;
            this.Text_Email.Name = "Text_Email";
            this.Text_Email.Size = new System.Drawing.Size(170, 25);
            this.Text_Email.TabIndex = 3;
            this.Text_Email.Click += new System.EventHandler(this.Text_Email_Click);
            this.Text_Email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_Email_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "البريد الإلكتروني";
            // 
            // pCAT
            // 
            this.pCAT.AutoSize = true;
            this.pCAT.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCAT.Location = new System.Drawing.Point(372, 273);
            this.pCAT.Name = "pCAT";
            this.pCAT.Size = new System.Drawing.Size(53, 14);
            this.pCAT.TabIndex = 37;
            this.pCAT.Text = "وصف المنتج";
            // 
            // BtnPrevi
            // 
            this.BtnPrevi.Location = new System.Drawing.Point(431, 270);
            this.BtnPrevi.Name = "BtnPrevi";
            this.BtnPrevi.Size = new System.Drawing.Size(38, 21);
            this.BtnPrevi.TabIndex = 36;
            this.BtnPrevi.Text = "<<";
            this.BtnPrevi.UseVisualStyleBackColor = true;
            this.BtnPrevi.Click += new System.EventHandler(this.BtnPrevi_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(331, 270);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(35, 21);
            this.BtnNext.TabIndex = 35;
            this.BtnNext.Text = ">>";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Location = new System.Drawing.Point(275, 270);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(50, 21);
            this.BtnLast.TabIndex = 34;
            this.BtnLast.Text = "||>>";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // BtnFirst
            // 
            this.BtnFirst.Location = new System.Drawing.Point(475, 270);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(48, 21);
            this.BtnFirst.TabIndex = 33;
            this.BtnFirst.Text = "<<||";
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::PointOfSale.Properties.Resources.STM_1000LID;
            this.pictureBox1.Location = new System.Drawing.Point(13, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Text_Name
            // 
            this.Text_Name.Font = new System.Drawing.Font("Simplified Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Name.Location = new System.Drawing.Point(275, 98);
            this.Text_Name.Multiline = true;
            this.Text_Name.Name = "Text_Name";
            this.Text_Name.Size = new System.Drawing.Size(170, 25);
            this.Text_Name.TabIndex = 0;
            this.Text_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_Name_KeyDown);
            // 
            // Text_Phone
            // 
            this.Text_Phone.Font = new System.Drawing.Font("Simplified Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Phone.Location = new System.Drawing.Point(275, 173);
            this.Text_Phone.Multiline = true;
            this.Text_Phone.Name = "Text_Phone";
            this.Text_Phone.Size = new System.Drawing.Size(170, 25);
            this.Text_Phone.TabIndex = 2;
            this.Text_Phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_Phone_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(466, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "رقم الهاتف";
            // 
            // Text_LName
            // 
            this.Text_LName.Font = new System.Drawing.Font("Simplified Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_LName.Location = new System.Drawing.Point(275, 132);
            this.Text_LName.Multiline = true;
            this.Text_LName.Name = "Text_LName";
            this.Text_LName.Size = new System.Drawing.Size(170, 25);
            this.Text_LName.TabIndex = 1;
            this.Text_LName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_LName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "الإسم الأخير";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "الإسم الأول";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(193, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "صفحة العملاء";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(546, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(544, 452);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PointOfSale.Properties.Resources.R__15_;
            this.pictureBox3.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1100, 608);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label pCAT;
        private System.Windows.Forms.Button BtnPrevi;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Button BtnFirst;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox Text_Name;
        public System.Windows.Forms.TextBox Text_Phone;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox Text_LName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox Text_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BNew;
        private System.Windows.Forms.Button BDelete;
        public System.Windows.Forms.TextBox Text_Search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button But_Save;
        private System.Windows.Forms.Button bEdit;
    }
}