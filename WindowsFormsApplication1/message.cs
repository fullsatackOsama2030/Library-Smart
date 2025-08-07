using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace WindowsFormsApplication1
{
    public partial class message : Form
    {
        public message()
        {
            InitializeComponent();
        }

        private void message_Load(object sender, EventArgs e)
        {
            Home h=new Home();
            string name= h.namla;
            string namebook=h.namebook;
            textBox1.Text = "مرحبا نحن جامعة الحكمة .. لقد تأخرت عن تسليم الكتاب  اذا تأخرت يوم واحد عن ارجاع الكتاب بعد تلقي هذا االرسالة سيتم رفع تقرير بحقك";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string formaddress = "al.hikma.unversity@gmail.com";
            string toAddress = "osamasadk501@gmail.com";
            string subject = "مرحبا انا اسامة";
            string body = "مشس تساينتشس شتسايتنشسي";
            SmtpClient sm = new SmtpClient("smtp.gmail.com", 465)
            {
                Credentials = new NetworkCredential("al.hikma.unversity@gmail.com", "alhikmaunversity29"),
EnableSsl=true,


            };
         
            try
            {
                MailMessage mail = new MailMessage(formaddress, toAddress, subject, body);
                sm.Send(mail);
                MessageBox.Show("ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }

        }
    }
}
