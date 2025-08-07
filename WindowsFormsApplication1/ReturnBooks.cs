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
    public partial class ReturnBooks : Form
    {
        conect_lo conserver = new conect_lo();
        public ReturnBooks()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Soure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from IRBook where std_enroll='" + textBox1.Text + "' and book_return_date is NULL";
            SqlDataAdapter Da1 = new SqlDataAdapter(cmd);
            DataSet Ds1 = new DataSet();
            Da1.Fill(Ds1);
            if (Ds1.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = Ds1.Tables[0];

            }
            else
            {

                MessageBox.Show("Invalid ID Or Book Issue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }
        string bname;
        string bdate;
        Int64 rowid;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    panel2.Visible = true;
                }
            }
            catch (Exception DD)
            {
                MessageBox.Show("Please Choose Correct Data", "Not Validated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel2.Visible = false;

            }


            Bnames.Text=bname;
            BiD.Text=bdate;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("سيتم اعادة الكتاب هل نكمل العملية ؟", "سؤال", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)==DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from IRBook where std_enroll='" + textBox1.Text + "' and book_return_date is NULL";
                SqlDataAdapter Da1 = new SqlDataAdapter(cmd);
                DataSet Ds1 = new DataSet();
                Da1.Fill(Ds1);

                //-------------------------------------
                con.Open();

                cmd.CommandText = "insert into settings(dec) values('" + textBox2.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                con.Open();
                cmd.CommandText = "update IRBook set book_return_date='" + dateTimePicker1.Text + "' where std_enroll='" + textBox1.Text + "' and id='" + rowid + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("نجحة عملية استعادة الكتاب", "تم بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                panel2.Visible = false;
                textBox1.Clear();
            }
            else
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void ReturnBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            //  SoundPlayer spl2 = new SoundPlayer(@"C:\Users\hp\Desktop\Liberay Management System\sound\6.wav"); spl2.Play();
        }
      

        private string pc()
        {

            string info1 = Environment.MachineName;
            string pc = info1;
            return pc;
        }
        public string namedata()
        {
            string namedate;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =" + Environment.MachineName + "\\" + conserver.server() + ";database=" + conserver.textBox1.Text + ";integrated security=True ";
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
        private void ReturnBooks_Load(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "select DISTINCT std_name from IRBook where book_return_date is null ";
           
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    comboBox1.Items.Add(sdr.GetString(i));
                    comboBox1.AutoCompleteCustomSource.Add(sdr.GetString(i));

                }

            }

            
            // SoundPlayer spl2 = new SoundPlayer(@"C:\Users\hp\Desktop\Liberay Management System\sound\sound2\6.wav"); spl2.Play();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select * from AddStudent  where اسم_الطالب='" + comboBox1.Text + "'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox1.Text = reader["رقم_البطاقة"].ToString();
                }

            }

        }

      
    }
}
