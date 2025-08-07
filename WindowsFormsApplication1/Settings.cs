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
    public partial class Settings : Form
    {
        conect_lo conserver = new conect_lo();

        public Settings()
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

      

    

        private string pc()
        {

            string info1 = Environment.MachineName;
            string pc = info1;
            return pc;
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            /*
            button1.BackColor = Color.AliceBlue;
            button2.BackColor = Color.Red;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "update settings set leftortop='left' where leftortop='top'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("خطأ في صيغة امر قواعد البيانات \n" + ex.Message);

            }
            catch (Exception ex)
            {

                MessageBox.Show("خطا في السيرفر \n " + ex.Message);
            }
            */
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            /*
            button1.BackColor = Color.Red;
            button2.BackColor = Color.AliceBlue;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();

                cmd.CommandText = "update settings set leftortop='top' where leftortop='left'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("خطأ في صيغة امر قواعد البيانات \n" + ex.Message);

            }
            catch (Exception ex)
            {

                MessageBox.Show("خطا في السيرفر \n " + ex.Message);
            }
             */
        }

      
        private void button15_Click(object sender, EventArgs e)
        { 
     colorDialog1.ShowDialog();
     label14.Text = colorDialog1.Color.Name;
     try
     {
         SqlConnection con = new SqlConnection();
         con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
         SqlCommand cmd = new SqlCommand();
         cmd.Connection = con;
         con.Open();

         cmd.CommandText = "update settings set colorfront='" + colorDialog1.Color.Name.ToString() + "'";
         cmd.ExecuteNonQuery();

         con.Close();
     }
     catch (SqlException ex)
     {
         MessageBox.Show("خطأ في صيغة امر قواعد البيانات \n" + ex.Message);

     }
     catch (Exception ex)
     {

         MessageBox.Show("خطا في السيرفر \n " + ex.Message);
     }
     MessageBox.Show("تم تغيير الون الامامي بنجاح");

        }

 





        private void button6_Click_1(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();

            string font = fontDialog1.Font.Name;
            Int32 size =(Int32)fontDialog1.Font.Size;
           
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "update settings set font='" + font + "',size='" + size.ToString() + "'";
                cmd.ExecuteNonQuery();

               // MessageBox.Show("تم تغيير الخط");
                con.Close();


            }
                   catch (SqlException ex)
            {
                MessageBox.Show("خطأ في صيغة امر قواعد البيانات \n" + ex.Message);

            }
            catch (Exception ex)
            {
               
                MessageBox.Show("خطا في السيرفر \n " + ex.Message);
            }
            MessageBox.Show("تم تغيير تنسيق الخط بنجاح بنجاح");
         
        }

   

        private void button11_Click(object sender, EventArgs e)
        {
        colorDialog1.ShowDialog();
        label14.Text = colorDialog1.Color.Name;


        try
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "update settings set colorback='" + colorDialog1.Color.Name + "'";
            cmd.ExecuteNonQuery();

            //  MessageBox.Show("تم اضافة الون الخلفي");
            con.Close();

        }
        catch (SqlException ex)
        {
            MessageBox.Show("خطأ في صيغة امر قواعد البيانات \n" + ex.Message);

        }
        catch (Exception ex)
        {

            MessageBox.Show("خطا في السيرفر \n " + ex.Message);
        }
        MessageBox.Show("تم تغيير الون الخلفي بنجاح");
          
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "update settings set day='" + numericUpDown1.Value + "'";
                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (SqlException ex)
            {
                MessageBox.Show("خطأ في صيغة امر قواعد البيانات \n" + ex.Message);

            }
            catch (Exception ex)
            {

                MessageBox.Show("خطا في السيرفر \n " + ex.Message);
            }
     
      
        }

  
        private void label1_Click_2(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void toolStripContainer1_ContentPanel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button4_Click_3(object sender, EventArgs e)
        {
            MessageBox.Show("تم حفط الاعدادت بنجاح");
            this.Close();
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            if (MessageBox.Show("لن يتم حفظ الاعدادات يلزم الضغط على زر تغيير الاعدادات", "!هل انت متاكد من الخروج", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

  


    }
}
