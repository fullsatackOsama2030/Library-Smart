namespace WindowsFormsApplication1
{
    partial class AddNewStudent
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewStudent));
               this.label1 = new System.Windows.Forms.Label();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.namest = new System.Windows.Forms.TextBox();
               this.en = new System.Windows.Forms.TextBox();
               this.Sc = new System.Windows.Forms.TextBox();
               this.SEm = new System.Windows.Forms.TextBox();
               this.button2 = new System.Windows.Forms.Button();
               this.label7 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
               this.Dep = new System.Windows.Forms.ComboBox();
               this.checkBox1 = new System.Windows.Forms.CheckBox();
               this.SS = new System.Windows.Forms.ComboBox();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.label8 = new System.Windows.Forms.Label();
               this.label9 = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.Black;
               this.label1.Location = new System.Drawing.Point(1232, 8);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(201, 29);
               this.label1.TabIndex = 1;
               this.label1.Text = "اضــــافـــة طـــــالــب";
               // 
               // pictureBox1
               // 
               this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
               this.pictureBox1.Location = new System.Drawing.Point(7, 8);
               this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(171, 133);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox1.TabIndex = 0;
               this.pictureBox1.TabStop = false;
               // 
               // namest
               // 
               this.namest.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.namest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.namest.Location = new System.Drawing.Point(971, 195);
               this.namest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.namest.Multiline = true;
               this.namest.Name = "namest";
               this.namest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
               this.namest.Size = new System.Drawing.Size(290, 40);
               this.namest.TabIndex = 0;
               this.namest.TextChanged += new System.EventHandler(this.namest_TextChanged);
               // 
               // en
               // 
               this.en.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.en.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.en.Location = new System.Drawing.Point(971, 326);
               this.en.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.en.Multiline = true;
               this.en.Name = "en";
               this.en.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
               this.en.Size = new System.Drawing.Size(290, 38);
               this.en.TabIndex = 1;
               // 
               // Sc
               // 
               this.Sc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Sc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.Sc.Location = new System.Drawing.Point(346, 189);
               this.Sc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.Sc.Multiline = true;
               this.Sc.Name = "Sc";
               this.Sc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
               this.Sc.Size = new System.Drawing.Size(292, 38);
               this.Sc.TabIndex = 4;
               this.Sc.TextChanged += new System.EventHandler(this.Sc_TextChanged);
               // 
               // SEm
               // 
               this.SEm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.SEm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.SEm.Location = new System.Drawing.Point(347, 325);
               this.SEm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.SEm.Multiline = true;
               this.SEm.Name = "SEm";
               this.SEm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
               this.SEm.Size = new System.Drawing.Size(291, 36);
               this.SEm.TabIndex = 5;
               this.SEm.TextChanged += new System.EventHandler(this.SEm_TextChanged);
               // 
               // button2
               // 
               this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.button2.BackColor = System.Drawing.Color.Red;
               this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
               this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button2.ForeColor = System.Drawing.Color.White;
               this.button2.Location = new System.Drawing.Point(1260, 760);
               this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(194, 51);
               this.button2.TabIndex = 9;
               this.button2.Text = "حفظ ";
               this.button2.UseVisualStyleBackColor = false;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.label7.Location = new System.Drawing.Point(670, 333);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(124, 24);
               this.label7.TabIndex = 6;
               this.label7.Text = "البريد اللاكتروني";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.label6.Location = new System.Drawing.Point(683, 198);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(84, 24);
               this.label6.TabIndex = 7;
               this.label6.Text = "رقم الهاتف";
               this.label6.Click += new System.EventHandler(this.label6_Click);
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.label5.Location = new System.Drawing.Point(665, 467);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(113, 24);
               this.label5.TabIndex = 8;
               this.label5.Text = "الفصل الدراسي";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.label4.Location = new System.Drawing.Point(1307, 473);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(75, 24);
               this.label4.TabIndex = 9;
               this.label4.Text = "التخصص";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.label3.Location = new System.Drawing.Point(1300, 331);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(93, 24);
               this.label3.TabIndex = 10;
               this.label3.Text = "رقم التسجيل";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.label2.Location = new System.Drawing.Point(1305, 206);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(86, 24);
               this.label2.TabIndex = 11;
               this.label2.Text = "اسم الطالب";
               // 
               // errorProvider1
               // 
               this.errorProvider1.ContainerControl = this;
               // 
               // Dep
               // 
               this.Dep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
               this.Dep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
               this.Dep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.Dep.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Dep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.Dep.FormattingEnabled = true;
               this.Dep.Location = new System.Drawing.Point(971, 467);
               this.Dep.Name = "Dep";
               this.Dep.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
               this.Dep.Size = new System.Drawing.Size(290, 30);
               this.Dep.TabIndex = 2;
               // 
               // checkBox1
               // 
               this.checkBox1.AutoSize = true;
               this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
               this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
               this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.checkBox1.ForeColor = System.Drawing.Color.Black;
               this.checkBox1.Location = new System.Drawing.Point(164, 623);
               this.checkBox1.Name = "checkBox1";
               this.checkBox1.Size = new System.Drawing.Size(122, 40);
               this.checkBox1.TabIndex = 6;
               this.checkBox1.Text = "هل الطالب متخرج";
               this.checkBox1.UseVisualStyleBackColor = true;
               this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
               // 
               // SS
               // 
               this.SS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
               this.SS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
               this.SS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.SS.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.SS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.SS.FormattingEnabled = true;
               this.SS.Location = new System.Drawing.Point(347, 461);
               this.SS.Name = "SS";
               this.SS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
               this.SS.Size = new System.Drawing.Size(299, 30);
               this.SS.TabIndex = 3;
               // 
               // textBox1
               // 
               this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBox1.ForeColor = System.Drawing.Color.Black;
               this.textBox1.Location = new System.Drawing.Point(55, 623);
               this.textBox1.Multiline = true;
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(253, 40);
               this.textBox1.TabIndex = 7;
               this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               this.textBox1.Visible = false;
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label8.ForeColor = System.Drawing.Color.Black;
               this.label8.Location = new System.Drawing.Point(320, 634);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(77, 22);
               this.label8.TabIndex = 16;
               this.label8.Text = "رقم البطاقة";
               this.label8.Visible = false;
               // 
               // label9
               // 
               this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.label9.AutoSize = true;
               this.label9.BackColor = System.Drawing.Color.Red;
               this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label9.ForeColor = System.Drawing.Color.White;
               this.label9.Location = new System.Drawing.Point(1431, 7);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(29, 31);
               this.label9.TabIndex = 37;
               this.label9.Text = "+";
               this.label9.Click += new System.EventHandler(this.label9_Click);
               // 
               // AddNewStudent
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.RosyBrown;
               this.ClientSize = new System.Drawing.Size(1465, 820);
               this.Controls.Add(this.label9);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.pictureBox1);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.SS);
               this.Controls.Add(this.checkBox1);
               this.Controls.Add(this.Dep);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.SEm);
               this.Controls.Add(this.Sc);
               this.Controls.Add(this.en);
               this.Controls.Add(this.namest);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.Name = "AddNewStudent";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "شاشة اضافة طالب";
               this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddNewStudent_FormClosed);
               this.Load += new System.EventHandler(this.AddNewStudent_Load);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox namest;
        private System.Windows.Forms.TextBox en;
        private System.Windows.Forms.TextBox Sc;
        private System.Windows.Forms.TextBox SEm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox Dep;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox SS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
    }
}