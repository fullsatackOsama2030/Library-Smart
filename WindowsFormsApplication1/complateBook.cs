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
    public partial class complateBook : Form
    {
        conect_lo conserver = new conect_lo();
        public complateBook()
        {
            InitializeComponent();
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
     

        private void complateBook_Load(object sender, EventArgs e)
        {
           // SoundPlayer spl2 = new SoundPlayer(@"C:\Users\hp\Desktop\Liberay Management System\sound\sound2\5.wav");spl2.Play();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =" + Environment.MachineName + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select std_enroll 'الرقم المميز', std_name 'اسم الطالب',book_name 'اسم الكتاب',book_issue_date 'تاريخ اخذ الكتاب',std_dept 'القسم',std_sem 'المستوى', std_contact 'رقم التواصل',std_email 'البريد الالكتروني' from IRBook where book_return_date is null ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

        }

        

       
        private void complateBook_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            //  SoundPlayer spl2 = new SoundPlayer(@"C:\Users\hp\Desktop\Liberay Management System\sound\6.wav"); spl2.Play();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
