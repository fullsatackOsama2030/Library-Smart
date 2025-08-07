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
    public partial class conect_lo : Form
    {
        public conect_lo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
  

        public string server()
        {
            return comboBox.Text;
        }
     

       
        private void button1_Click(object sender, EventArgs e)
        {
         

            string nameserver = comboBox.Text;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =" + Environment.MachineName + "\\" + nameserver + ";database='" + textBox1.Text + "';integrated security=True ";

                 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                MessageBox.Show("تم الاتصال بالسيرفر بنجاح");

                con.Close();
                Home des = new Home();
                des.ShowDialog();

               
            }
            catch (SqlException ex)
            {
                MessageBox.Show("قد يكون هذا السيرفر غير موجود ..اعد صياغة السيرفر من جديد  \n\n" + ex.Message);
                comboBox.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show("حدث خطأ \n\n" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            String sql = textBox1.Text;
          
             string nameserver =comboBox.Text;

             try
             {
                 SqlConnection con = new SqlConnection();
                 con.ConnectionString = "data source =" + Environment.MachineName + "\\" + nameserver + ";database='"+sql+"';integrated security=True ";
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = con;
                 con.Open();

       /*       
           cmd.CommandText = "create table AddStudent(sid int identity(1,1) primary key not null,اسم_الطالب varchar(255) not null,رقم_البطاقة varchar(255) not null,القسم varchar(255) not null,المستوى_الدراسي varchar(255) not null,رقم_الهاتف bigint not null,البريد_الالكتروني_1 varchar(255) not null,رقم_البطاقة_الشخصية varchar(255) null)";
           cmd.ExecuteNonQuery();
        
           cmd.CommandText = "create table IRBook(id int identity(1,1) primary key,std_enroll varchar(255) not null,std_name varchar(255) not null,std_dept varchar(255) not null,std_sem varchar(255) not null,std_contact bigint not null,std_email varchar(255) not null,book_name varchar(255) null,book_issue_date varchar(255) null,book_return_date varchar(255) null,day bigint null)";
           cmd.ExecuteNonQuery();
        */ 
           //cmd.CommandText = "create table Login(id int identity(1,1) primary key ,username varchar(255) not null,pass varchar(255) not null)";
           //cmd.ExecuteNonQuery();
           //cmd.CommandText = "create table NewBook(bid int identity(1,1) primary key not null,اسم_الكتاب varchar(255) not null,مؤلف_الكتاب varchar(255) not null,التخصص varchar(255) not null,تاريخ_الاصدار varchar(255) not null,كمية_الكتاب bigint not null,رقم_الرف bigint null,التصنيف varchar(255) null,القسم varchar(255)  null,اسم_الناشر varchar(255) null,الطبعة varchar(255) null,لغة_الكتاب varchar(2) null,ملاحظات varchar(255) null,الرقم_الخاص bigint null)";
          // cmd.ExecuteNonQuery();
           cmd.CommandText = "create table settings(leftortop varchar(255) null,colorfront varchar(255) null,colorback varchar(255)  null,namedata varchar(255) null,font varchar(255) null,day varchar(255) null,size varchar(20) null,dec varchar(255) null)";
           cmd.ExecuteNonQuery();
           cmd.CommandText = "insert into settings(namedata,colorfront,colorback,font,day,leftortop,size,dec) values('" + sql + "','" + "Black  " + "','" + "Fuchsia" + "','" + "Times New Roman" + "','" + "4" + "','" + "top" + "','" + "17" + "','" + "لايوجد" + "')";
           cmd.ExecuteNonQuery();
       
                con.Close();
           
         
                 MessageBox.Show("تمت عملية اضافة الجداول بنجاح");
                               


             }
             catch (Exception ex)
             {

                 MessageBox.Show(". قد تكون قاعدة البيانات هذا موجودة مسبقاً ..قم باعادة المحاولة مرة اخرى \n او قد يكون السيرفر غير صحيح \n يلزمك اولاً اضافة اسم قاعدة البيانات الى السيرفر"+ex.Message);

             }

     
              



        }
       

        private void conect_lo_Load(object sender, EventArgs e)
        {
           
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("هذا ليس من صلاحياتك...");
            MessageBox.Show("في حال تريد تغيير السيرفر قم بالتواصل مع المطور \n على الرقم :715206725\n او على الرقم:734169472", "تنوية", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);

        }

        private void comboBox1_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("هذا ليس من صلاحياتك...");
            if (MessageBox.Show("في حال تريد تغيير السيرفر قم بالتواصل مع المطور \n على الرقم :715206725\n او على الرقم:734169472", "تنوية", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {


            }
            else
            {

                this.Close();
            }

        }
    }
}
