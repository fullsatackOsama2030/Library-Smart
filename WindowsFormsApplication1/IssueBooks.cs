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
    public partial class IssueBooks : Form
    {
        conect_lo conserver = new conect_lo();
        public IssueBooks()
        {
            InitializeComponent();
        }
        int count;

   
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
        private void IssueBooks_Load(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select DISTINCT اسم_الطالب from AddStudent";
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    comboBox1.Items.Add(sdr.GetString(i));
                  
                }

            }
            con.Close();


            // SoundPlayer spl2 = new SoundPlayer(@"C:\Users\hp\Desktop\Liberay Management System\sound\sound2\4.wav"); spl2.Play();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select DISTINCT اسم_الكتاب from NewBook", con);
            SqlDataReader sdr1 = cmd.ExecuteReader();

            while (sdr1.Read())
            {
                for (int i = 0; i < sdr1.FieldCount; i++)
                {
                    Bname.Items.Add(sdr1.GetString(i));

                }

            }
            sdr1.Close();
            con.Close();

         
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            if (textBox1.Text != "")
            {
                string eid = textBox1.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select *from AddStudent where رقم_البطاقة='" + eid + "'";
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataSet Ds = new DataSet();
                Da.Fill(Ds);

                //----------------------------------------
                cmd.CommandText = "select count(std_enroll) from IRBook where std_enroll='" + eid + "' and book_return_date is null";
                SqlDataAdapter Da1 = new SqlDataAdapter(cmd);
                DataSet Ds1 = new DataSet();
                Da1.Fill(Ds1);
                count=int.Parse(Ds1.Tables[0].Rows[0][0].ToString());

                
                if (Ds.Tables[0].Rows.Count != 0)
                {
                    SN.Text = Ds.Tables[0].Rows[0][1].ToString();
                    DEPt.Text = Ds.Tables[0].Rows[0][3].ToString();
                    Ssem.Text = Ds.Tables[0].Rows[0][4].ToString();
                    Scon.Text = Ds.Tables[0].Rows[0][5].ToString();
                    StEm.Text = Ds.Tables[0].Rows[0][6].ToString();  
                   
                }
                else
                {
                    SN.Text = "";
                    DEPt.Text = "";
                    Ssem.Text = "";
                    Scon.Text = "";
                    StEm.Text = "";
                    MessageBox.Show("Invalid Enrollement No ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
      
             
          
               
            }
        }

        private void BtIssue_Click(object sender, EventArgs e)
        {
            if (SN.Text != "")
            {
                button1_Click(sender, e);

                if (Bname.SelectedIndex != -1 && count <= 2)
                {
                    string enroll = textBox1.Text;
                    string Nam = SN.Text;
                    string Depp = DEPt.Text;
                    string ssn = Ssem.Text;
                    Int64 Stcon = Int64.Parse(Scon.Text);
                    string Emi = StEm.Text;
                    string bna = Bname.Text;
                    string booissdate = dateTimePicker1.Text;
                    int day = dateTimePicker1.Value.Day;
                    string eid = textBox1.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;


                    cmd.CommandText = "insert into IRBook(std_enroll,std_name,std_dept,std_sem,std_contact,std_email,book_name,book_issue_date,day) values('" + enroll + "','" + Nam + "','" + Depp + "','" + ssn + "','" + Stcon + "','" + Emi + "','" + bna + "','" + booissdate + "','"+day+"')";
                    SqlDataAdapter Da = new SqlDataAdapter(cmd);
                    DataSet Ds = new DataSet();
                    Da.Fill(Ds);



                    MessageBox.Show("Book Issued", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bname.Text = "";
                  
                }
                else
                {

                    MessageBox.Show("Select Book. Or Maximom Of Book Ms Been Issued", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Enter Valid Enrollement No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
          
                    
     
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
                SN.Text = "";
                DEPt.Text = "";
                Ssem.Text = "";
                Scon.Text = "";
                StEm.Text = ""; 

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Soure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {


            }
        }

        private void IssueBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            
            // SoundPlayer spl2 = new SoundPlayer(@"C:\Users\hp\Desktop\Liberay Management System\sound\6.wav"); spl2.Play();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void dep_Click(object sender, EventArgs e)
        {

        }
    }
}
