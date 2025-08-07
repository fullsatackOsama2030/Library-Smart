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
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        conect_lo conserver = new conect_lo();
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Username_MouseClick(object sender, MouseEventArgs e)
        {
            if (Username.Text == "Username")
            {

                Username.Clear();
            }
        }

        private void Pass_MouseClick(object sender, MouseEventArgs e)
        {
            if (Pass.Text == "Passowrd")
            {

                Pass.Clear();
                Pass.PasswordChar = '*';
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

          //  myCell my = new myCell();
            //my.web11();
            //my.Show();

            System.Diagnostics.Process.Start(@"https://www.instagram.com/osama.sadk.54?igsh=ODA1NTc5OTg5Nw==");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //myCell my = new myCell();
            //my.web22();
           // my.Show();
            System.Diagnostics.Process.Start(@"file:/C:/Users/hp/Desktop/Web.html");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //myCell my = new myCell();
            //my.web33();
            //my.Show();
            System.Diagnostics.Process.Start(@"https://www.youtube.com/@OsamaSadk-vt6ys");
        }
  

        private string pc()
        {

            string info1 = Environment.MachineName;
            string pc = info1;
            return pc;
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
         
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select *from Login where username='" + Username.Text.ToUpper() + "'and pass='" + Pass.Text.ToUpper() + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    this.Hide();
                  // MessageBox.Show("Hello " + Username.Text, "Succesfully", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    Home des = new Home();
                    des.Show();
                }
                else
                {

                    MessageBox.Show("الاسم او كلمة المرور غير موجودة", "تنوية", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
         
           
        }
        SpeechRecognitionEngine receng = new SpeechRecognitionEngine();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            try{
            SpeechSynthesizer ss = new SpeechSynthesizer();
            PromptBuilder pb = new PromptBuilder();
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
            Choices clist = new Choices();

            clist.Add(new string[] { "yellow", "open my name is Ali", "open my name is Hamdi" });
            Grammar gr = new Grammar(new GrammarBuilder(clist));
          
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += Sre_spee11;
                sre.SetInputToDefaultAudioDevice();

                sre.RecognizeAsync(RecognizeMode.Single);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
       
     
        private void Sre_spee11(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {

                case "yellow":
                 //   SoundPlayer spl1 = new SoundPlayer(@"C:\Users\hp\Desktop\Liberay Management System\sound\1.wav");Username.Text = "Admin";Pass.Text = "adminosama";
                    Home h =new Home();
                    h.ShowDialog();

                    //button1.PerformClick();
                 //   spl1.Play();
                    break;
                case "open my name is Ali":
                  //  SoundPlayer spl2 = new SoundPlayer(@"C:\Users\hp\Desktop\Liberay Management System\sound\2.wav");  Username.Text = "Admin";Pass.Text = "adminosama";
                    button1.PerformClick();
                   // spl2.Play();
                    break;
                case "open my name is Hamdi":
                  //  SoundPlayer spl3 = new SoundPlayer(@"C:\Users\hp\Desktop\Liberay Management System\sound\3.wav"); Username.Text = "Admin"; Pass.Text = "adminosama";
                    button1.PerformClick();
                    //spl3.Play();
                    break;

                default:

                    MessageBox.Show("no");
                    break;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Siginl si = new Siginl();
            si.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt)
            {
                this.Hide();
                Home s = new Home();
                s.ShowDialog();

            }
        }
    }
}
