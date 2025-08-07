using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Siginl : Form
    {
        conect_lo conserver = new conect_lo();
        public Siginl()
        {
            InitializeComponent();
        }
        public string namedata()
        {
            try
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
            }
            catch (SqlException ex)
            {
                this.Hide();
                MessageBox.Show("حصل خطا . تاكد من قاعدة البيانات \n" + ex.Message);

                conect_lo show = new conect_lo();
                show.ShowDialog();

            }
            catch (Exception er)
            {


                MessageBox.Show("حصل خطا . في السيرفر خطأ \n" + er.Message);


            }
            return null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    string name = textBox1.Text.ToUpper();
                    string passw = textBox2.Text.ToUpper();
                    SqlConnection con = new SqlConnection();
                   
                    con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "insert into Login(username,pass) values('" + name + "','" + passw + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تم? تم اضافة الحساب...", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("حصل خطاء ..يلزم املاء البيانات كاملة");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Invalid  Found Data No Currect!\n"+Ex.Message,"Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);

            }
        }

        private void Ret_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            
        }
       
        private string pc()
        {

            string info1 = Environment.MachineName;
            string pc = info1;
            return pc;
        }

        private void Siginl_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
      
        }
    }
}
