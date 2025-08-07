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
    public partial class ViewStudents : Form
    {
        conect_lo conserver = new conect_lo();
        private SqlConnection con;
        private SqlCommand comm;
        private SqlDataAdapter sda;
       private DataSet daset;
        public ViewStudents()
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
        private void ViewStudents_Load(object sender, EventArgs e)
        {
         //   SoundPlayer spl2 = new SoundPlayer(@"C:\Users\hp\Desktop\Liberay Management System\sound\sound2\8.wav"); spl2.Play();

             con = new SqlConnection();
             con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
             comm = new SqlCommand();
             con.Open();
             comm.Connection = con;
             comm.CommandText = "select * from AddStudent";
             sda = new SqlDataAdapter(comm);
             daset = new DataSet();
             sda.Fill(daset);
             con.Close();
             dataGridView1.DataSource = daset.Tables[0];





             con.Open();
             comm.Connection = con;
             comm.CommandText = "select DISTINCT المستوى_الدراسي from AddStudent";
             SqlDataReader sdr = comm.ExecuteReader();
             while (sdr.Read())
             {
                 for (int i = 0; i < sdr.FieldCount; i++)
                 {

                     Ssr.Items.Add(sdr.GetString(i));
                     Ssr.AutoCompleteCustomSource.Add(sdr.GetString(i));
                 }

             }
             con.Close();
             con.Open();
             comm.Connection = con;
             comm.CommandText = "select DISTINCT القسم from AddStudent";
             SqlDataReader sdr4 = comm.ExecuteReader();
             while (sdr4.Read())
             {
                 for (int i = 0; i < sdr4.FieldCount; i++)
                 {

                     Depts.Items.Add(sdr4.GetString(i));
                     Depts.AutoCompleteCustomSource.Add(sdr4.GetString(i));
                 }

             }
             con.Close();
             

        }

        int Sid;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerchS.Text = "";
            panel2.Visible = false;
        }

        private void SerchS_TextChanged(object sender, EventArgs e)
        {
           
            if (SerchS.Text != "")
            {
                Image im = Image.FromFile(@"C:\Users\hp\Desktop\سطح المكتب\مشروع\Liberay Management System\search1.gif");
                pictureBox1.Image = im;
                label1.Visible = false;

                con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
                con.Open();

                comm.Connection = con;
                comm.CommandText = "select *from AddStudent where  رقم_البطاقة LIKE'" + SerchS.Text + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(comm);
                DataSet daset = new DataSet();
                sda.Fill(daset);
                con.Close();

                dataGridView1.DataSource = daset.Tables[0];
                


            }
       
            else
            {
                Image im = Image.FromFile(@"C:\Users\hp\Desktop\سطح المكتب\مشروع\Liberay Management System\search.gif");
                pictureBox1.Image = im;
                label1.Visible = true;
                con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
              con.Open();
              SqlCommand comm = new SqlCommand();
                comm.Connection = con;
                comm.CommandText = "select *from AddStudent";
                SqlDataAdapter sda = new SqlDataAdapter(comm);
                DataSet daset = new DataSet();
                sda.Fill(daset);
                con.Close();
                dataGridView1.DataSource = daset.Tables[0];

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Update. Confir?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string bnames = Nas.Text;
                string abs = Enn.Text;
                string bpu = Depts.Text;
                string dates = Ssr.Text;
                Int64 pps = Int64.Parse(Sct.Text);
                string bqs = SEmil.Text;
                string num_card = textBox1.Text;

                con = new SqlConnection();
                con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
                comm = new SqlCommand();
                comm.Connection = con;
                comm.CommandText = "update AddStudent set  اسم_الطالب='" + bnames + "', رقم_البطاقة='" + abs + "', القسم='" + bpu + "', المستوى_الدراسي='" + dates + "', رقم_الهاتف='" + pps + "', البريد_الالكتروني_1='" + bqs + "', رقم_البطاقة_الشخصية='" + num_card + "' where sid='" + rowid + "'";
                sda = new SqlDataAdapter(comm);
               daset = new DataSet();
               sda.Fill(daset);

                comm.CommandText = "select *from AddStudent";
                sda.Fill(daset);
                dataGridView1.DataSource = daset.Tables[0];
                panel2.Visible = false;
            }
            else
            {


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Delete. Confir?", "Confirestion Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string bnames = Nas.Text;
                string abs = Enn.Text;
                string bpu = Depts.Text;
                string dates = Ssr.Text;
                Int64 pps = Int64.Parse(Sct.Text);
                string bqs = SEmil.Text;
                 con = new SqlConnection();
                 con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
               comm = new SqlCommand();
                comm.Connection = con;
                comm.CommandText = "delete from AddStudent where sid='" + rowid + "'";
                sda = new SqlDataAdapter(comm);
                daset = new DataSet();
                sda.Fill(daset);
                comm.CommandText = "select *from AddStudent";
                sda.Fill(daset);
                dataGridView1.DataSource = daset.Tables[0];

                panel2.Visible = false;
            }
            else
            {


            }
        }

        private void ViewStudents_FormClosed(object sender, FormClosedEventArgs e)
        {
      
            //    SoundPlayer spl2 = new SoundPlayer(@"C:\Users\hp\Desktop\Liberay Management System\sound\6.wav");spl2.Play();
         

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد سيتم حذف جميع بيانات الطلاب", "رسالة تنبية", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
            {
                con = new SqlConnection();
                con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
                comm = new SqlCommand();
                comm.Connection = con;
                comm.CommandText = "delete from AddStudent";
                sda = new SqlDataAdapter(comm);
                daset = new DataSet();
                sda.Fill(daset);
                comm.CommandText = "select *from AddStudent";
                sda.Fill(daset);
                dataGridView1.DataSource = daset.Tables[0];
                panel2.Visible = false;

            }
            else
            {
                panel2.Visible = false;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SerchS.Visible = true;
            textBox2.Visible = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SerchS.Visible = false;
            textBox2.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                Image im = Image.FromFile(@"C:\Users\hp\Desktop\سطح المكتب\مشروع\Liberay Management System\search1.gif");
                pictureBox1.Image = im;
                label1.Visible = false;


                con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
              con.Open();
               comm.Connection = con;
               comm.CommandText = "select *from AddStudent where  اسم_الطالب LIKE'" + textBox2.Text + "%'";
                sda = new SqlDataAdapter(comm);
                daset = new DataSet();
                sda.Fill(daset);
                con.Close();
                dataGridView1.DataSource = daset.Tables[0];



            }

            else
            {
                Image im = Image.FromFile(@"C:\Users\hp\Desktop\سطح المكتب\مشروع\Liberay Management System\search.gif");
                pictureBox1.Image = im;
                label1.Visible = true;
                con.Open();
                 comm = new SqlCommand();
                comm.Connection = con;
                comm.CommandText = "select *from AddStudent";
                sda = new SqlDataAdapter(comm);
                daset = new DataSet();
                sda.Fill(daset);
                con.Close();
                dataGridView1.DataSource = daset.Tables[0];

            }
        }




        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {

                    Sid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    panel2.Visible = true;

                     con = new SqlConnection();
                     con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
                     comm = new SqlCommand();
                    comm.Connection = con;
                    comm.CommandText = "select * from AddStudent where sid='" + Sid + "'";
                    sda = new SqlDataAdapter(comm);
                    daset= new DataSet();
                    sda.Fill(daset);

                    rowid = Int64.Parse(daset.Tables[0].Rows[0][0].ToString());

                    Nas.Text = daset.Tables[0].Rows[0][1].ToString();
                    Enn.Text = daset.Tables[0].Rows[0][2].ToString();
                    Depts.Text = daset.Tables[0].Rows[0][3].ToString();
                    Ssr.Text = daset.Tables[0].Rows[0][4].ToString();
                    Sct.Text = daset.Tables[0].Rows[0][5].ToString();
                    SEmil.Text = daset.Tables[0].Rows[0][6].ToString();
                    if (daset.Tables[0].Rows[0][7].ToString() == "")
                    {
                        textBox1.Text = "لا يوجد";
                    }
                    else
                    {
                        textBox1.Text = daset.Tables[0].Rows[0][7].ToString();
                    }

                }
            }
            catch (Exception DD)
            {
                MessageBox.Show("Please Choose Correct Data", "Not Validated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel2.Visible = false;

            }
        }

        private void Ssr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
