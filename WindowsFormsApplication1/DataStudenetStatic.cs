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
     public partial class DataStudenetStatic : Form
     {
          conect_lo conserver = new conect_lo();

          public DataStudenetStatic()
          {
               InitializeComponent();
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
          private void button2_Click(object sender, EventArgs e)
          {

               if (semes.Text != "" && spectio.Text != "")
               {     
                 string Dept = semes.Text;
                    string SSt = spectio.Text;
         


                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "insert into dataStudent (spectializations,semesters) values ('" + Dept + "','" + SSt + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    if (MessageBox.Show("تم اضافة البيانات بنجاح...لاضافة بيانات اخر اضغط موافق ", "Asterisk", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {

                         semes.Text = "";
                         spectio.Text = "";
                   
                    }
                    else
                    {
                         this.Close();
                    }

               }
               else
               {
                    MessageBox.Show("المعذرة هناك بيانات غير موجودة!!!", "خطأ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

               }


          }

          private void label1_Click(object sender, EventArgs e)
          {

          }
     }
}
