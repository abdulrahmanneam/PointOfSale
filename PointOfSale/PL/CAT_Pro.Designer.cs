namespace PointOfSale.PL
{
    partial class CAT_PRO
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Text_ID = new System.Windows.Forms.TextBox();
            this.pCAT = new System.Windows.Forms.Label();
            this.BtnPrevi = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.BtnFirst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Text_Des = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Text_Search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BNew = new System.Windows.Forms.Button();
            this.BPDF = new System.Windows.Forms.Button();
            this.BWord = new System.Windows.Forms.Button();
            this.BExcel = new System.Windows.Forms.Button();
            this.BPrintAll = new System.Windows.Forms.Button();
            this.BPrintItem = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.BSave = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.pic_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1529, 709);
            this.panel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Text_ID);
            this.groupBox1.Controls.Add(this.pCAT);
            this.groupBox1.Controls.Add(this.BtnPrevi);
            this.groupBox1.Controls.Add(this.BtnNext);
            this.groupBox1.Controls.Add(this.BtnLast);
            this.groupBox1.Controls.Add(this.BtnFirst);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Text_Des);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Text_Search);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(11, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1506, 502);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الأصناف";
            // 
            // Text_ID
            // 
            this.Text_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_ID.Location = new System.Drawing.Point(1247, 54);
            this.Text_ID.Multiline = true;
            this.Text_ID.Name = "Text_ID";
            this.Text_ID.ReadOnly = true;
            this.Text_ID.Size = new System.Drawing.Size(93, 25);
            this.Text_ID.TabIndex = 15;
            // 
            // pCAT
            // 
            this.pCAT.AutoSize = true;
            this.pCAT.Location = new System.Drawing.Point(1099, 250);
            this.pCAT.Name = "pCAT";
            this.pCAT.Size = new System.Drawing.Size(61, 13);
            this.pCAT.TabIndex = 14;
            this.pCAT.Text = "وصف المنتج";
            // 
            // BtnPrevi
            // 
            this.BtnPrevi.Location = new System.Drawing.Point(1222, 246);
            this.BtnPrevi.Name = "BtnPrevi";
            this.BtnPrevi.Size = new System.Drawing.Size(48, 21);
            this.BtnPrevi.TabIndex = 13;
            this.BtnPrevi.Text = "<<";
            this.BtnPrevi.UseVisualStyleBackColor = true;
            this.BtnPrevi.Click += new System.EventHandler(this.BtnPrevi_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(985, 246);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(48, 21);
            this.BtnNext.TabIndex = 12;
            this.BtnNext.Text = ">>";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Location = new System.Drawing.Point(916, 246);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(48, 21);
            this.BtnLast.TabIndex = 11;
            this.BtnLast.Text = "||>>";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // BtnFirst
            // 
            this.BtnFirst.Location = new System.Drawing.Point(1293, 246);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(48, 21);
            this.BtnFirst.TabIndex = 10;
            this.BtnFirst.Text = "<<||";
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1293, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "بحث عن المنتج";
            // 
            // Text_Des
            // 
            this.Text_Des.Location = new System.Drawing.Point(916, 100);
            this.Text_Des.Multiline = true;
            this.Text_Des.Name = "Text_Des";
            this.Text_Des.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Text_Des.Size = new System.Drawing.Size(425, 131);
            this.Text_Des.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1366, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "وصف المنتج";
            // 
            // Text_Search
            // 
            this.Text_Search.Location = new System.Drawing.Point(918, 346);
            this.Text_Search.Multiline = true;
            this.Text_Search.Name = "Text_Search";
            this.Text_Search.Size = new System.Drawing.Size(352, 33);
            this.Text_Search.TabIndex = 1;
            this.Text_Search.TextChanged += new System.EventHandler(this.Text_Search_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1366, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "رقم المنتج";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(768, 493);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BNew);
            this.groupBox2.Controls.Add(this.BPDF);
            this.groupBox2.Controls.Add(this.BWord);
            this.groupBox2.Controls.Add(this.BExcel);
            this.groupBox2.Controls.Add(this.BPrintAll);
            this.groupBox2.Controls.Add(this.BPrintItem);
            this.groupBox2.Controls.Add(this.BDelete);
            this.groupBox2.Controls.Add(this.BSave);
            this.groupBox2.Location = new System.Drawing.Point(11, 594);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1515, 112);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة";
            // 
            // BNew
            // 
            this.BNew.Location = new System.Drawing.Point(1349, 29);
            this.BNew.Name = "BNew";
            this.BNew.Size = new System.Drawing.Size(109, 36);
            this.BNew.TabIndex = 11;
            this.BNew.Text = "جديد";
            this.BNew.UseVisualStyleBackColor = true;
            this.BNew.Click += new System.EventHandler(this.BNew_Click);
            // 
            // BPDF
            // 
            this.BPDF.Location = new System.Drawing.Point(24, 29);
            this.BPDF.Name = "BPDF";
            this.BPDF.Size = new System.Drawing.Size(74, 36);
            this.BPDF.TabIndex = 10;
            this.BPDF.Text = "PDF";
            this.BPDF.UseVisualStyleBackColor = true;
            this.BPDF.Click += new System.EventHandler(this.BPDF_Click);
            // 
            // BWord
            // 
            this.BWord.Location = new System.Drawing.Point(114, 29);
            this.BWord.Name = "BWord";
            this.BWord.Size = new System.Drawing.Size(75, 36);
            this.BWord.TabIndex = 8;
            this.BWord.Text = "Word";
            this.BWord.UseVisualStyleBackColor = true;
            this.BWord.Click += new System.EventHandler(this.BWord_Click);
            // 
            // BExcel
            // 
            this.BExcel.Location = new System.Drawing.Point(210, 29);
            this.BExcel.Name = "BExcel";
            this.BExcel.Size = new System.Drawing.Size(78, 36);
            this.BExcel.TabIndex = 7;
            this.BExcel.Text = "Excel";
            this.BExcel.UseVisualStyleBackColor = true;
            this.BExcel.Click += new System.EventHandler(this.BExcel_Click);
            // 
            // BPrintAll
            // 
            this.BPrintAll.Location = new System.Drawing.Point(328, 29);
            this.BPrintAll.Name = "BPrintAll";
            this.BPrintAll.Size = new System.Drawing.Size(144, 36);
            this.BPrintAll.TabIndex = 5;
            this.BPrintAll.Text = "طباعة الكل";
            this.BPrintAll.UseVisualStyleBackColor = true;
            this.BPrintAll.Click += new System.EventHandler(this.BPrintAll_Click);
            // 
            // BPrintItem
            // 
            this.BPrintItem.Location = new System.Drawing.Point(511, 29);
            this.BPrintItem.Name = "BPrintItem";
            this.BPrintItem.Size = new System.Drawing.Size(155, 36);
            this.BPrintItem.TabIndex = 4;
            this.BPrintItem.Text = "طباعة الصنف";
            this.BPrintItem.UseVisualStyleBackColor = true;
            this.BPrintItem.Click += new System.EventHandler(this.BPrintItem_Click);
            // 
            // BDelete
            // 
            this.BDelete.Location = new System.Drawing.Point(810, 29);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(117, 36);
            this.BDelete.TabIndex = 2;
            this.BDelete.Text = "حذف";
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // BSave
            // 
            this.BSave.Enabled = false;
            this.BSave.Location = new System.Drawing.Point(1028, 19);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(207, 36);
            this.BSave.TabIndex = 0;
            this.BSave.Text = "حفظ";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PointOfSale.Properties.Resources.R__15_;
            this.pictureBox3.Location = new System.Drawing.Point(1478, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pic_Logo
            // 
            this.pic_Logo.Image = global::PointOfSale.Properties.Resources.STM_1000LID;
            this.pic_Logo.Location = new System.Drawing.Point(21, 20);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(100, 56);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Logo.TabIndex = 4;
            this.pic_Logo.TabStop = false;
            // 
            // CAT_PRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 709);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CAT_PRO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAT_Pro";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BPDF;
        private System.Windows.Forms.Button BWord;
        private System.Windows.Forms.Button BExcel;
        private System.Windows.Forms.Button BPrintAll;
        private System.Windows.Forms.Button BPrintItem;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.Button BSave;
        public System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_Search;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Text_Des;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label pCAT;
        private System.Windows.Forms.Button BtnPrevi;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.Button BNew;
        private System.Windows.Forms.TextBox Text_ID;
    }
}