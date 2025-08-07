namespace WindowsFormsApplication1
{
    partial class ReturnBooks
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBooks));
               this.comboBox1 = new System.Windows.Forms.ComboBox();
               this.button2 = new System.Windows.Forms.Button();
               this.button1 = new System.Windows.Forms.Button();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.panel2 = new System.Windows.Forms.Panel();
               this.label5 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.pictureBox2 = new System.Windows.Forms.PictureBox();
               this.label1 = new System.Windows.Forms.Label();
               this.textBox2 = new System.Windows.Forms.TextBox();
               this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
               this.button5 = new System.Windows.Forms.Button();
               this.button4 = new System.Windows.Forms.Button();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.Bnames = new System.Windows.Forms.TextBox();
               this.BiD = new System.Windows.Forms.TextBox();
               this.label4 = new System.Windows.Forms.Label();
               this.label16 = new System.Windows.Forms.Label();
               this.label17 = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               this.panel2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
               this.SuspendLayout();
               // 
               // comboBox1
               // 
               this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
               this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
               this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.comboBox1.FormattingEnabled = true;
               this.comboBox1.Location = new System.Drawing.Point(518, 21);
               this.comboBox1.Name = "comboBox1";
               this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
               this.comboBox1.Size = new System.Drawing.Size(320, 34);
               this.comboBox1.TabIndex = 0;
               this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
               // 
               // button2
               // 
               this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.button2.BackColor = System.Drawing.Color.Red;
               this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
               this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button2.ForeColor = System.Drawing.Color.Cornsilk;
               this.button2.Location = new System.Drawing.Point(839, 21);
               this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(103, 32);
               this.button2.TabIndex = 4;
               this.button2.Text = "تحديث";
               this.button2.UseVisualStyleBackColor = false;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // button1
               // 
               this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.button1.BackColor = System.Drawing.Color.Red;
               this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
               this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.ForeColor = System.Drawing.Color.White;
               this.button1.Location = new System.Drawing.Point(647, 62);
               this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(159, 47);
               this.button1.TabIndex = 3;
               this.button1.Text = "البحث عن طالب";
               this.button1.UseVisualStyleBackColor = false;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // textBox1
               // 
               this.textBox1.Enabled = false;
               this.textBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBox1.Location = new System.Drawing.Point(3, 77);
               this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.textBox1.Multiline = true;
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(116, 49);
               this.textBox1.TabIndex = 2;
               this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
               // 
               // pictureBox1
               // 
               this.pictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
               this.pictureBox1.Location = new System.Drawing.Point(5, 4);
               this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(112, 85);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox1.TabIndex = 0;
               this.pictureBox1.TabStop = false;
               // 
               // dataGridView1
               // 
               this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Location = new System.Drawing.Point(2, 129);
               this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
               this.dataGridView1.RowTemplate.Height = 26;
               this.dataGridView1.Size = new System.Drawing.Size(1428, 592);
               this.dataGridView1.TabIndex = 1;
               this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
               // 
               // panel2
               // 
               this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.panel2.BackColor = System.Drawing.Color.RosyBrown;
               this.panel2.Controls.Add(this.label5);
               this.panel2.Controls.Add(this.label6);
               this.panel2.Controls.Add(this.pictureBox2);
               this.panel2.Controls.Add(this.label1);
               this.panel2.Controls.Add(this.textBox2);
               this.panel2.Controls.Add(this.dateTimePicker1);
               this.panel2.Controls.Add(this.button5);
               this.panel2.Controls.Add(this.button4);
               this.panel2.Controls.Add(this.label2);
               this.panel2.Controls.Add(this.label3);
               this.panel2.Controls.Add(this.Bnames);
               this.panel2.Controls.Add(this.BiD);
               this.panel2.Controls.Add(this.label4);
               this.panel2.Location = new System.Drawing.Point(3, 3);
               this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(1427, 718);
               this.panel2.TabIndex = 2;
               this.panel2.Visible = false;
               // 
               // label5
               // 
               this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.label5.AutoSize = true;
               this.label5.BackColor = System.Drawing.Color.Red;
               this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.ForeColor = System.Drawing.Color.White;
               this.label5.Location = new System.Drawing.Point(1394, 5);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(29, 31);
               this.label5.TabIndex = 43;
               this.label5.Text = "+";
               // 
               // label6
               // 
               this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.ForeColor = System.Drawing.Color.Black;
               this.label6.Location = new System.Drawing.Point(1135, 5);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(255, 31);
               this.label6.TabIndex = 42;
               this.label6.Text = "أســــتــعــــادة كـــــتـــــــــــاب";
               // 
               // pictureBox2
               // 
               this.pictureBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
               this.pictureBox2.Location = new System.Drawing.Point(3, 2);
               this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.pictureBox2.Name = "pictureBox2";
               this.pictureBox2.Size = new System.Drawing.Size(112, 85);
               this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox2.TabIndex = 6;
               this.pictureBox2.TabStop = false;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(144, 368);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(143, 24);
               this.label1.TabIndex = 5;
               this.label1.Text = "ملاحضات الاسترداد";
               // 
               // textBox2
               // 
               this.textBox2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBox2.ForeColor = System.Drawing.Color.Red;
               this.textBox2.Location = new System.Drawing.Point(33, 395);
               this.textBox2.Multiline = true;
               this.textBox2.Name = "textBox2";
               this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
               this.textBox2.Size = new System.Drawing.Size(391, 207);
               this.textBox2.TabIndex = 4;
               this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
               // 
               // dateTimePicker1
               // 
               this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
               this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.dateTimePicker1.Location = new System.Drawing.Point(314, 275);
               this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.dateTimePicker1.Name = "dateTimePicker1";
               this.dateTimePicker1.Size = new System.Drawing.Size(266, 26);
               this.dateTimePicker1.TabIndex = 3;
               // 
               // button5
               // 
               this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.button5.BackColor = System.Drawing.Color.Red;
               this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
               this.button5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button5.ForeColor = System.Drawing.Color.White;
               this.button5.Location = new System.Drawing.Point(1118, 665);
               this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.button5.Name = "button5";
               this.button5.Size = new System.Drawing.Size(127, 43);
               this.button5.TabIndex = 2;
               this.button5.Text = "الغاء";
               this.button5.UseVisualStyleBackColor = false;
               this.button5.Click += new System.EventHandler(this.button5_Click);
               // 
               // button4
               // 
               this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.button4.BackColor = System.Drawing.Color.Red;
               this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
               this.button4.Font = new System.Drawing.Font("Traditional Arabic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button4.ForeColor = System.Drawing.Color.White;
               this.button4.Location = new System.Drawing.Point(1263, 661);
               this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.button4.Name = "button4";
               this.button4.Size = new System.Drawing.Size(156, 50);
               this.button4.TabIndex = 2;
               this.button4.Text = "استعادة الكتاب";
               this.button4.UseVisualStyleBackColor = false;
               this.button4.Click += new System.EventHandler(this.button4_Click);
               // 
               // label2
               // 
               this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(888, 142);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(108, 26);
               this.label2.TabIndex = 0;
               this.label2.Text = "الاسم الكتاب";
               // 
               // label3
               // 
               this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(1160, 272);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(89, 22);
               this.label3.TabIndex = 0;
               this.label3.Text = "تاريخ التسليم";
               // 
               // Bnames
               // 
               this.Bnames.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.Bnames.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Bnames.Location = new System.Drawing.Point(565, 133);
               this.Bnames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.Bnames.Multiline = true;
               this.Bnames.Name = "Bnames";
               this.Bnames.Size = new System.Drawing.Size(309, 46);
               this.Bnames.TabIndex = 1;
               this.Bnames.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
               // 
               // BiD
               // 
               this.BiD.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.BiD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.BiD.Location = new System.Drawing.Point(871, 268);
               this.BiD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.BiD.Name = "BiD";
               this.BiD.Size = new System.Drawing.Size(266, 29);
               this.BiD.TabIndex = 1;
               this.BiD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
               // 
               // label4
               // 
               this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.Location = new System.Drawing.Point(606, 275);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(93, 22);
               this.label4.TabIndex = 0;
               this.label4.Text = "تاريخ الارجاع";
               // 
               // label16
               // 
               this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.label16.AutoSize = true;
               this.label16.BackColor = System.Drawing.Color.Red;
               this.label16.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label16.ForeColor = System.Drawing.Color.White;
               this.label16.Location = new System.Drawing.Point(1395, 5);
               this.label16.Name = "label16";
               this.label16.Size = new System.Drawing.Size(29, 31);
               this.label16.TabIndex = 41;
               this.label16.Text = "+";
               // 
               // label17
               // 
               this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.label17.AutoSize = true;
               this.label17.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label17.ForeColor = System.Drawing.Color.Black;
               this.label17.Location = new System.Drawing.Point(1136, 5);
               this.label17.Name = "label17";
               this.label17.Size = new System.Drawing.Size(255, 31);
               this.label17.TabIndex = 40;
               this.label17.Text = "أســــتــعــــادة كـــــتـــــــــــاب";
               // 
               // ReturnBooks
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoScroll = true;
               this.BackColor = System.Drawing.Color.RosyBrown;
               this.ClientSize = new System.Drawing.Size(1431, 722);
               this.Controls.Add(this.panel2);
               this.Controls.Add(this.label16);
               this.Controls.Add(this.label17);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.comboBox1);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.pictureBox1);
               this.Controls.Add(this.dataGridView1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.MaximizeBox = false;
               this.Name = "ReturnBooks";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "ReturnBooks";
               this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReturnBooks_FormClosed);
               this.Load += new System.EventHandler(this.ReturnBooks_Load);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               this.panel2.ResumeLayout(false);
               this.panel2.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox BiD;
        private System.Windows.Forms.TextBox Bnames;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}