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
    public partial class ReportBookReturn : Form
    {
        conect_lo conserver = new conect_lo();

        public ReportBookReturn()
        {
            InitializeComponent();
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
     
        private void ReportBookReturn_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =" + Environment.MachineName + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "select std_enroll 'الرقم المميز', std_name 'اسم الطالب',book_name 'اسم الكتاب',book_issue_date 'تاريخ اخذ الكتاب',std_dept 'القسم',std_sem 'المستوى', std_contact 'رقم التواصل',std_email 'البريد الالكتروني' from IRBook where book_return_date is not null ";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            con.Close();
            dataGridView1.DataSource = ds1.Tables[0];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width,1000);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0,this.dataGridView1.Width,this.dataGridView1.Height));
            e.Graphics.DrawImage(bm,0,50);

        }
    }
}
