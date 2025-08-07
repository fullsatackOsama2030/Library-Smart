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
    
    public partial class AddNewStudent : Form
    {

        conect_lo conserver = new conect_lo();
        public AddNewStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string num_card = "";
            if (checkBox1.Checked == true)
            {
                if (textBox1.Text != "")
                {
                      num_card = textBox1.Text;
                }
            }
                    if (namest.Text != "" && en.Text != "" && Dep.Text != "" && SS.Text != "" && Sc.Text != "" && SEm.Text != "")
                    {
                        string bname = namest.Text.ToUpper();
                        string enc = en.Text.ToUpper();
                        string Dept = Dep.Text;
                        string SSt = SS.Text;
                        Int64 Sct = Int64.Parse(Sc.Text);
                        string em = SEm.Text+"@gmail.com";
                       

                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True "; 
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;

                        con.Open();
                        cmd.CommandText = "insert into AddStudent (اسم_الطالب,رقم_البطاقة,القسم,المستوى_الدراسي,رقم_الهاتف,البريد_الالكتروني_1,رقم_البطاقة_الشخصية) values ('" + bname + "','" + enc + "','" + Dept + "','" + SSt + "','" + Sct + "','" + em + "','" + num_card + "')";
                        cmd.ExecuteNonQuery();
                        con.Close();

                        if (MessageBox.Show("تم اضافة الطالب بنجاح...لاضافة طالب اخر اضغط موافق ", "Asterisk", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                        {

                            namest.Text = "";
                            en.Text = "";
                            Dep.Text = "";
                            SS.Text = "";
                            Sc.Text = "";
                            SEm.Text = "";
                            textBox1.Text = "";
                            textBox1.Visible = false;
                            label8.Visible = false;
                        }
                        else
                        {
                   

                        }

                    }
                    else
                    {
                        MessageBox.Show("المعذرة هناك بيانات غير موجودة!!! ", "خطأ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    }
    
          

           
}

      

        private string pc()
        {

            string info1 = Environment.MachineName;
            string pc = info1;
            return pc;
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void AddNewStudent_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Restart();
      
           
            //  SoundPlayer spl2 = new SoundPlayer(@"C:\Users\hp\Desktop\Liberay Management System\sound\6.wav");spl2.Play();
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

        private void AddNewStudent_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True "; 
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select DISTINCT semesters from dataStudent";
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {

                    Dep.Items.Add(sdr.GetString(i));
                    Dep.AutoCompleteCustomSource.Add(sdr.GetString(i));
                }

            }
            con.Close();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select DISTINCT spectializations from dataStudent";
            SqlDataReader sdr1 = cmd.ExecuteReader();
            while (sdr1.Read())
            {
                for (int i = 0; i < sdr1.FieldCount; i++)
                {
                    SS.Items.Add(sdr1.GetString(i));
                    SS.AutoCompleteCustomSource.Add(sdr1.GetString(i));
                }

            }
            con.Close();
            //  SoundPlayer spl2 = new SoundPlayer(@"C:\Users\hp\Desktop\Liberay Management System\sound\sound2\2.wav"); spl2.Play();
        }

        private void namest_TextChanged(object sender, EventArgs e)
        {
            string[] Ch = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            for (int i = 0; i < Ch.Length; i++)
            {
                if (namest.Text == Ch[i])
                {
                    errorProvider1.SetError(namest, "No Enter Number");
                    if (MessageBox.Show(errorProvider1.GetError(namest), "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        namest.Text = "";
                        errorProvider1.Clear();
                    }
                    else
                    {
                        namest.Text = "";
                        errorProvider1.Clear();
                    }

                }


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void SEm_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("ان الطالب متخرج .. يلزم تسجيل رقم البطاقة الشخصية", "ملاحظة", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                textBox1.Visible = true;
                label8.Visible = true;

            }
            else
            {

                MessageBox.Show("عفواً! حصل خطأ .. رقم البطاقة ضرورية اذا كان الطالب متخرج ");
            }

        }

        private void Sc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            namest.Text = "";
            en.Text = "";
            Dep.Text = "";
            SS.Text = "";
            Sc.Text = "";
            SEm.Text = "";
            textBox1.Text = "";
            textBox1.Visible = false;
            label8.Visible = false;
        }

        private void label11_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
          
        }
    }
}
