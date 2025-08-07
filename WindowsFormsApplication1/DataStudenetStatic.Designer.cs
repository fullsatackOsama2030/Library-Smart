namespace WindowsFormsApplication1
{
     partial class DataStudenetStatic
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataStudenetStatic));
               this.label5 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label9 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.spectio = new System.Windows.Forms.TextBox();
               this.semes = new System.Windows.Forms.TextBox();
               this.button1 = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // label5
               // 
               this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.label5.Location = new System.Drawing.Point(458, 328);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(113, 24);
               this.label5.TabIndex = 12;
               this.label5.Text = "الفصل الدراسي";
               // 
               // label4
               // 
               this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.label4.Location = new System.Drawing.Point(1066, 330);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(75, 24);
               this.label4.TabIndex = 13;
               this.label4.Text = "التخصص";
               // 
               // label9
               // 
               this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.label9.AutoSize = true;
               this.label9.BackColor = System.Drawing.Color.Red;
               this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label9.ForeColor = System.Drawing.Color.White;
               this.label9.Location = new System.Drawing.Point(1177, 14);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(29, 31);
               this.label9.TabIndex = 39;
               this.label9.Text = "+";
               // 
               // label1
               // 
               this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.Black;
               this.label1.Location = new System.Drawing.Point(838, 14);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(346, 37);
               this.label1.TabIndex = 38;
               this.label1.Text = "اضــــافـــة بيانات طالب ثابتة";
               this.label1.Click += new System.EventHandler(this.label1_Click);
               // 
               // pictureBox1
               // 
               this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
               this.pictureBox1.Location = new System.Drawing.Point(3, 3);
               this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(171, 133);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox1.TabIndex = 40;
               this.pictureBox1.TabStop = false;
               // 
               // spectio
               // 
               this.spectio.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.spectio.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.spectio.Location = new System.Drawing.Point(743, 322);
               this.spectio.Multiline = true;
               this.spectio.Name = "spectio";
               this.spectio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
               this.spectio.Size = new System.Drawing.Size(290, 44);
               this.spectio.TabIndex = 0;
               // 
               // semes
               // 
               this.semes.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.semes.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.semes.Location = new System.Drawing.Point(137, 321);
               this.semes.Multiline = true;
               this.semes.Name = "semes";
               this.semes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
               this.semes.Size = new System.Drawing.Size(299, 44);
               this.semes.TabIndex = 1;
               // 
               // button1
               // 
               this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.button1.AutoSize = true;
               this.button1.BackColor = System.Drawing.Color.Red;
               this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
               this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.ForeColor = System.Drawing.Color.White;
               this.button1.Location = new System.Drawing.Point(8, 708);
               this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(235, 79);
               this.button1.TabIndex = 56;
               this.button1.Text = "حفظ ";
               this.button1.UseVisualStyleBackColor = false;
               // 
               // DataStudenetStatic
               // 
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
               this.BackColor = System.Drawing.Color.RosyBrown;
               this.ClientSize = new System.Drawing.Size(1215, 795);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.semes);
               this.Controls.Add(this.spectio);
               this.Controls.Add(this.pictureBox1);
               this.Controls.Add(this.label9);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label4);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "DataStudenetStatic";
               this.ShowInTaskbar = false;
               this.Text = "DataStudenetStatic";
               this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.Label label9;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.PictureBox pictureBox1;
          private System.Windows.Forms.TextBox spectio;
          private System.Windows.Forms.TextBox semes;
          private System.Windows.Forms.Button button1;
     }
}