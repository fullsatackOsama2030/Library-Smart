using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class AddBookNew : Form
    {
       public int day;
       conect_lo conserver = new conect_lo();
        public AddBookNew()
        {
            InitializeComponent();
        }


        /// <summary>
        /// //////////
        /// </summary>
        /// <returns></returns>
        /// 


        

        private string pc()
        {

           string info1 = Environment.MachineName;
            string pc = info1;
            return pc;
        }




        /// <summary>
        /// /////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (NameBook.Text != "" && NameAuthor.Text != "" && BookPub.Text != "" && comboBox2.Text != "" && QBook.Text != "" && comboBox1.Text != "" && comboBox5.Text != "" && comboBox4.Text != "" && comboBox3.Text!="")
            {
                string bname = NameBook.Text.ToUpper();
                string bauthor = NameAuthor.Text.ToUpper();
                string publication = BookPub.Text;
                string pdate = dateTimePicker1.Text;
                string tas = comboBox2.Text;
                string depar = comboBox1.Text;
                Int64 qusity = Int64.Parse(QBook.Text);
                int shelf = (int)numericUpDown1.Value;

                string name_go = comboBox5.Text;
                string print = comboBox4.Text;
                string lang = comboBox3.Text;
                string notice = textBox2.Text;
                Int64 numid = Int64.Parse(nuid.Text);


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";   
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewBook (اسم_الكتاب,مؤلف_الكتاب,التخصص,تاريخ_الاصدار,التصنيف,كمية_الكتاب,رقم_الرف,القسم,اسم_الناشر,الطبعة,لغة_الكتاب,ملاحظات,الرقم_الخاص) values ('" + bname + "','" + bauthor + "','" + publication + "','" + pdate + "','" + tas + "','" + qusity + "','" + shelf + "','" + depar + "','" + name_go + "','" + print + "','" + lang + "','" + notice + "','" + numid + "')";
                cmd.ExecuteNonQuery();

                if (MessageBox.Show("تم اضافة الكتاب بنجاح...لاضافة كتاب اخر اضغط موافق ", "Asterisk", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    NameBook.Text = "";
                    NameAuthor.Text = "";
                    BookPub.Text = "";
                    comboBox2.Text = "";
                    comboBox1.Text = "";
                    QBook.Text = "";
                    comboBox5.Text = "";
                    comboBox4.Text = "";
                    comboBox3.Text = "";
                    textBox2.Text = "";
                    dateTimePicker1.Text.Clone();
                    numericUpDown1.ResetText();
                }
                else
                {

                }

            }
            else
            {
                MessageBox.Show("Sory Not Found Data!!! ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            }

        private void button1_Click(object sender, EventArgs e)
        {

            NameBook.Text = "";
            NameAuthor.Text = "";
            BookPub.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
            QBook.Text = "";
            comboBox5.Text = "";
            comboBox4.Text = "";
            comboBox3.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text.Clone();
            numericUpDown1.ResetText();

            if (NameBook.Text == "" && NameAuthor.Text == "" && BookPub.Text == "" && comboBox2.Text == "" && QBook.Text == "" && comboBox1.Text == "")
            {

                this.Close();
             
            }
            else
            {

                if (MessageBox.Show("Oh Sorry Found Data In Here ,Do You Delete And Exit  ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();

                }
               


            }
        }
        public string namedata()
        {
            string namedate;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =" + Environment.MachineName + "\\" +conserver.server() + ";database=" + conserver.textBox1.Text + ";integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "select * from settings";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                namedate = reader["namedata"].ToString();

                return namedate;
            }
            return null;

        }
        private void AddBookNew_Load(object sender, EventArgs e)
        {
        
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";   
            SqlCommand cmd = new SqlCommand();           
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select DISTINCT التخصص from NewBook";
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {

                    BookPub.Items.Add(sdr.GetString(i));
                    BookPub.AutoCompleteCustomSource.Add(sdr.GetString(i));
                }

            }
            con.Close();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select DISTINCT اسم_الكتاب from NewBook";
            SqlDataReader sdr1 = cmd.ExecuteReader();
            while (sdr1.Read())
            {
                for (int i = 0; i < sdr1.FieldCount; i++)
                {

                    NameBook.Items.Add(sdr1.GetString(i));
                    NameBook.AutoCompleteCustomSource.Add(sdr1.GetString(i));
                }

            }
            con.Close();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select DISTINCT اسم_الناشر from NewBook";
            SqlDataReader sdr2 = cmd.ExecuteReader();
            while (sdr2.Read())
            {
                for (int i = 0; i < sdr2.FieldCount; i++)
                {

                    comboBox5.Items.Add(sdr2.GetString(i));
                    comboBox5.AutoCompleteCustomSource.Add(sdr2.GetString(i));
                }

            }
            con.Close();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select DISTINCT التصنيف from NewBook";
            SqlDataReader sdr3 = cmd.ExecuteReader();
            while (sdr3.Read())
            {
                for (int i = 0; i < sdr3.FieldCount; i++)
                {

                    comboBox2.Items.Add(sdr3.GetString(i));
                    comboBox2.AutoCompleteCustomSource.Add(sdr3.GetString(i));
                }

            }
            con.Close();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select DISTINCT الطبعة from NewBook";
            SqlDataReader sdr4 = cmd.ExecuteReader();
            while (sdr4.Read())
            {
                for (int i = 0; i < sdr4.FieldCount; i++)
                {

                    comboBox4.Items.Add(sdr4.GetString(i));
                    comboBox4.AutoCompleteCustomSource.Add(sdr4.GetString(i));
                }

            }

            
            // SoundPlayer spl2 = new SoundPlayer(@"C:\Users\hp\Desktop\Liberay Management System\sound\sound2\1.wav");   spl2.Play();
         
        }

        private void NameBook_TextChanged(object sender, EventArgs e)
        {
            string[] Ch = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            for (int i = 0; i < Ch.Length; i++)
            {
                if (NameBook.Text == Ch[i])
                {
                    errorProvider1.SetError(NameBook, "لا تدخل رقم");
                   if( MessageBox.Show(errorProvider1.GetError(NameBook), "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)== DialogResult.OK){
                       NameBook.Text = "";
                       errorProvider1.Clear();
                   }
                   
                }
             
           
            }
        }

        private void NameAuthor_TextChanged(object sender, EventArgs e)
        {
              string[] Ch = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
              for (int i = 0; i < Ch.Length; i++)
              {
                  if (NameAuthor.Text == Ch[i])
                  {
                      errorProvider1.SetError(NameAuthor, "لا تدخل رقم");
                      if (MessageBox.Show(errorProvider1.GetError(NameAuthor), "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                      {

                          NameAuthor.Text = "";
                          errorProvider1.Clear();
                      }

                  }
               
              }
        }

        private void AddBookNew_FormClosed(object sender, FormClosedEventArgs e)
        {
       //     Application.Restart();
      
            //  SoundPlayer spl2 = new SoundPlayer(@"C:\Users\hp\Desktop\Liberay Management System\sound\6.wav"); spl2.Play();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BookPub_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Prices_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void QBook_TextChanged(object sender, EventArgs e)
        {
              


     
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NameAuthor_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void BookPub_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] Ch = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            for (int i = 0; i < Ch.Length; i++)
            {
                if (BookPub.Text == Ch[i])
                {
                    errorProvider1.SetError(BookPub, "لا تدخل رقم");
                    if (MessageBox.Show(errorProvider1.GetError(BookPub), "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        BookPub.Text = "";
                        errorProvider1.Clear();
                    }

                }


            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            NameBook.Text = "";
            NameAuthor.Text = "";
            BookPub.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
            QBook.Text = "";
            comboBox5.Text = "";
            comboBox4.Text = "";
            comboBox3.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text.Clone();
            numericUpDown1.ResetText();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

   

      

     
    }
}
