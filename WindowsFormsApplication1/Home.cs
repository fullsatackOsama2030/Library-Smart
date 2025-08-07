using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Home : Form
    {
        conect_lo conserver = new conect_lo();

        AddBookNew adb = new AddBookNew();
        ViewAllBook Vb = new ViewAllBook();
        AddNewStudent St = new AddNewStudent();
        ViewStudents vs = new ViewStudents();

        ReturnBooks RB = new ReturnBooks();

        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices clist = new Choices();

        Graphics graphics;
        Bitmap bitmap;
        Point O_P;
        Point CLK_P;
        int CLK_Radius;
        bool SHOW_HIDE_F = false;
        public Home()
        {
            InitializeComponent();
            CLK_Radius = 200;
            O_P = new Point(70, 100);
            CLK_P = new Point(O_P.X + CLK_Radius, O_P.Y + CLK_Radius);

            bitmap = new Bitmap(800, 550);
            graphics = Graphics.FromImage(bitmap);
        }

   
        //Exit        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // this.Icon = new Icon(@"C:\Users\hp\Desktop\Liberay Management System\Icon\7.ico");

         /*   if (MessageBox.Show("Are You Sure You Want To Exit ?", "Confire", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();

            }
            else
            {

                //   this.Icon = new Icon(@"C:\Users\hp\Desktop\Liberay Management System\Icon\2.ico");
            }
          */ 
        }

        private void addNewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {


          
        }


        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {


           
        }



        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {


         
        }



        private void issuToolStripMenuItem_Click(object sender, EventArgs e)
        {


            IssueBooks IBoo = new IssueBooks();

            IBoo.ShowDialog();

        }
        SpeechRecognitionEngine receng = new SpeechRecognitionEngine();



      
        private string pc()
        {

            string info1 = Environment.MachineName;
            string pc = info1;
            return pc;
        }

private Color frontcolor(){
    string Front="";

    SqlConnection con = new SqlConnection();
    con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True "; 
    SqlCommand cmd = new SqlCommand();
    cmd.Connection = con;

    con.Open();

    cmd.CommandText = "select * from settings";
     SqlDataReader reader = cmd.ExecuteReader();
     if (reader.Read())
     {
         Front = reader["colorfront"].ToString();
         string[] Ch = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
         for (int i = 0; i < Ch.Length; i++)
         {
             if (Front == Ch[i])
             {

                 return Color.Black;
             }
         }
         con.Close();
         Color fro = Color.FromName(Front);
         return fro;

     }
     else
     {
         return Color.Black;

     }
}
private Color backcolor()
{
    string back = "";

    SqlConnection con = new SqlConnection();
    con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
    SqlCommand cmd = new SqlCommand();
    cmd.Connection = con;

    con.Open();

    cmd.CommandText = "select * from settings";
    SqlDataReader reader = cmd.ExecuteReader();
    if (reader.Read())
    {

        back = reader["colorback"].ToString();
         string[] Ch = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
         for (int i = 0; i < Ch.Length; i++)
         {
             if(back==Ch[i]){

                 return Color.White;
             }
         }
        con.Close();
        Color bac = Color.FromName(back);
        return bac;

    }
    else
    {
        return Color.White;

    }
}

private Font font()
{
    string fonts = "";
    string size = "";
    SqlConnection con = new SqlConnection();
    con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
    SqlCommand cmd = new SqlCommand();
    cmd.Connection = con;

    con.Open();

    cmd.CommandText = "select * from settings";
    SqlDataReader reader = cmd.ExecuteReader();
    if (reader.Read())
    {
        fonts = reader["font"].ToString();
        size = reader["size"].ToString();
        con.Close();
        Font fon =new Font(fonts,Convert.ToInt32(size),FontStyle.Bold);
        return fon;

    }
    else
    {
        return Font;

    }
}

private String day()
{
    string days = "4";
   
    SqlConnection con = new SqlConnection();
    con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
    SqlCommand cmd = new SqlCommand();
    cmd.Connection = con;

    con.Open();

    cmd.CommandText = "select * from settings";
    SqlDataReader reader = cmd.ExecuteReader();
    if (reader.Read())
    {
        days = reader["day"].ToString();
        con.Close();
        return days;

    }
    else
    {
        return days;

    }
}
        private void Home_Load(object sender, EventArgs e)
        {
            DeskTopes DeskTop = new DeskTopes();
            DeskTop.Dock = DockStyle.Fill;
            DeskTop.TopLevel = false;
            DeskTop.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Clear();
            panel2.Controls.Add(DeskTop);
            DeskTop.Show();
            label4.Text = "";
            label5.Text = "";
            label1.ForeColor = Color.Red;
            /*
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True "; 

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();


                cmd.CommandText = "select id 'رقم', std_name as 'اسم الطالب',book_name 'اسم الكتاب',book_issue_date 'تاريخ اخذ الكتاب' ,('" + dateTimePicker1.Value.Day + "'-day) 'عدد الايام' from IRBook where '" + dateTimePicker1.Value.Day + "'-day<='" + Convert.ToInt32(day()) + "' and book_return_date is NULL";
                SqlDataAdapter da11 = new SqlDataAdapter(cmd);
                DataSet ds11 = new DataSet();
                da11.Fill(ds11);
                dataGridView1.DataSource = ds11.Tables[0];
                con.Close();
            
               


                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select * from NewBook";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                label3.Text = da.Fill(ds).ToString();
                con.Close();

                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select * from AddStudent";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                label5.Text = da.Fill(ds1).ToString();
                con.Close();

                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select *from IRBook where book_return_date is null ";
                SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                label7.Text = da2.Fill(ds2).ToString();

                con.Close();

                string lef_top = "";


                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "select * from settings";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    lef_top = reader["leftortop"].ToString();


                }


                booksToolStripMenuItem.ForeColor = frontcolor();
                studentToolStripMenuItem.ForeColor = frontcolor();
                issuToolStripMenuItem.ForeColor = frontcolor();
                completeBookDiToolStripMenuItem.ForeColor = frontcolor();
                returnBooksToolStripMenuItem.ForeColor = frontcolor();
                exitToolStripMenuItem.ForeColor = frontcolor();
                settingsToolStripMenuItem.ForeColor = frontcolor();
                عرضتقريرالكتبToolStripMenuItem.ForeColor = frontcolor();
                عرضتقريرالطلابToolStripMenuItem.ForeColor = frontcolor();
                تقاريرنهائيةToolStripMenuItem.ForeColor = frontcolor();
                اعداداتالنظامToolStripMenuItem.ForeColor = frontcolor();
                تقريرالكتبالمردودةToolStripMenuItem.ForeColor = frontcolor();
                label1.ForeColor = frontcolor();
                label3.ForeColor = frontcolor();
                label5.ForeColor = frontcolor();
                label7.ForeColor = frontcolor();



                BackColor = backcolor();
                booksToolStripMenuItem.BackColor = backcolor();
                studentToolStripMenuItem.BackColor = backcolor();
                issuToolStripMenuItem.BackColor = backcolor();
                completeBookDiToolStripMenuItem.BackColor = backcolor();
                returnBooksToolStripMenuItem.BackColor = backcolor();
                exitToolStripMenuItem.BackColor = backcolor();
                settingsToolStripMenuItem.BackColor = backcolor();
                عرضتقريرالكتبToolStripMenuItem.BackColor = backcolor();
                عرضتقريرالطلابToolStripMenuItem.BackColor = backcolor();
                تقاريرنهائيةToolStripMenuItem.BackColor = backcolor();
                تقاريرنهائيةToolStripMenuItem.BackColor = backcolor();
                تقريرالكتبالمردودةToolStripMenuItem.BackColor = backcolor();
                label3.BackColor = backcolor();
                label5.BackColor = backcolor();
                label7.BackColor = backcolor();
                panel1.BackColor = backcolor();


                booksToolStripMenuItem.Font = font();
                studentToolStripMenuItem.Font = font();
                issuToolStripMenuItem.Font = font();
                completeBookDiToolStripMenuItem.Font = font();
                returnBooksToolStripMenuItem.Font = font();
                exitToolStripMenuItem.Font = font();
                settingsToolStripMenuItem.Font = font();
                عرضتقريرالكتبToolStripMenuItem.Font = font();
                عرضتقريرالطلابToolStripMenuItem.Font = font();
                تقاريرنهائيةToolStripMenuItem.Font = font();
                تقاريرنهائيةToolStripMenuItem.Font = font();
                تقريرالكتبالمردودةToolStripMenuItem.Font = font();
                label1.Font = font();
                label3.Font = font();
                label5.Font = font();
                label7.Font = font();
                label2.Font = font();
                label4.Font = font();
                label6.Font = font();
                textBox1.Font = font();
                textBox2.Font = font();
                textBox3.Font = font();
                textBox4.Font = font();
                textBox5.Font = font();
                textBox6.Font = font();
                textBox7.Font = font();

                if (lef_top == "top")
                {

                    menuStrip1.Dock = DockStyle.Top;
                    pictureBox1.Visible = true;

                }
                else if (lef_top == "left")
                {
                    menuStrip1.Dock = DockStyle.Left;
                    pictureBox2.Visible = true;
                }


                
                clist.Add(new string[] { "Open Add Book", "Open Add Student", "View Book", "View Student", "View Issue", "View Return Book", "Exit", "black", "white" });
                Grammar gr = new Grammar(new GrammarBuilder(clist));
                try
                {
                    sre.RequestRecognizerUpdate();
                    sre.LoadGrammar(gr);
                    sre.SpeechRecognized += Sre_spee;
                    sre.SetInputToDefaultAudioDevice();

                    sre.RecognizeAsync(RecognizeMode.Single);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            } catch (SqlException ex)
            {
                this.Hide();
                MessageBox.Show("حصل خطا . تاكد من قاعدة البيانات \n" + ex.Message);
               
                conect_lo show = new conect_lo();
                show.ShowDialog();

            }
            catch (Exception er)
            {

               
                MessageBox.Show("حصل خطا . الخطاء غير منطقي \n"+er.Message);
                Settings set = new Settings();
                set.ShowDialog();

            }

           */
           
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

        private void Sre_spee(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "black":
                    // label2.ForeColor = Color.White;
                //    panel1.BackColor = Color.Black;
                  //  label1.ForeColor = Color.White;
                    this.BackColor = Color.Black;
                    //label2.BackColor = Color.White;

              //      textBox1.BackColor = Color.Black; textBox1.ForeColor = Color.White; textBox2.BackColor = Color.Black; textBox2.ForeColor = Color.White; textBox3.BackColor = Color.Black; textBox3.ForeColor = Color.White; textBox4.BackColor = Color.Black; textBox4.ForeColor = Color.White; textBox5.BackColor = Color.Black; textBox5.ForeColor = Color.White; textBox6.BackColor = Color.Black; textBox6.ForeColor = Color.White; textBox7.BackColor = Color.Black; textBox7.ForeColor = Color.White;

                    break;
                case "white":
                    //  label2.ForeColor = Color.White;
                    this.BackColor = Color.White;
                 //   panel1.BackColor = Color.White;
                   // label1.ForeColor = Color.Black;

                  //  textBox1.BackColor = Color.White; textBox1.ForeColor = Color.Black; textBox2.BackColor = Color.White; textBox2.ForeColor = Color.Black; textBox3.BackColor = Color.White; textBox3.ForeColor = Color.Black; textBox4.BackColor = Color.White; textBox4.ForeColor = Color.Black; textBox5.BackColor = Color.White; textBox5.ForeColor = Color.Black; textBox6.BackColor = Color.White; textBox6.ForeColor = Color.Black; textBox7.BackColor = Color.White; textBox7.ForeColor = Color.Black;
                    //  label2.ForeColor = Color.Black;
                    //menuStrip1.BackColor = Color.DarkSlateGray;

                    break;
                case "hello":
                    SoundPlayer spl2 = new SoundPlayer(@"C:\Users\hp\Desktop\سطح المكتب\مشروع\Liberay Management System\sound\1.wav");
spl2.Play();
                    break;
                case "Open Add Book":
                    SoundPlayer spl1 = new SoundPlayer(@"C:\Users\hp\Desktop\Liberay Management System\sound\4.wav");
                    // spl1.Play();
                    AddBookNew add = new AddBookNew();
                    add.ShowDialog();
                    break;
                case "Open Add Student":
                    SoundPlayer spl3 = new SoundPlayer(@"C:\Users\hp\Desktop\Liberay Management System\sound\5.wav");
                    // spl3.Play();
                    AddNewStudent ads = new AddNewStudent();
                    ads.ShowDialog();
                    break;
                case "View Book":
                    ViewAllBook vbo = new ViewAllBook();
                    vbo.ShowDialog();
                    break;
                case "View Student":
                    ViewStudents vst = new ViewStudents();
                    vst.ShowDialog();
                    break;
                case "View Issue":
                    IssueBooks isb = new IssueBooks();
                    isb.ShowDialog();
                    break;
                case "View Return Book":
                    ReturnBooks retb = new ReturnBooks();
                    retb.ShowDialog();
                    break;
                default:
                    MessageBox.Show("Please Enter Sound Tru!", "Sound Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;


            }
        }


        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {


            RB.ShowDialog();
        }



        private void completeBookDiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            /*
             t.Interval = 4000;
             t.Tick += new EventHandler(t_Tick);

             MessageBox.Show("جامعة الحكمة");
             t.Start();   
            */
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {


           

        }



        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            St.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        public void ovalShape1_Click(object sender, EventArgs e)
        {


            //     Settings SS = new Settings();
            // poo2();
            //  SS.ovalShape2.Visible = true;
            //   SS.ovalShape1.Visible = false;



            //            this.BackColor = Color.White;
            //     panel1.BackColor = Color.White;
            //     label1.ForeColor = Color.Black;

            //     textBox1.BackColor = Color.White; textBox1.ForeColor = Color.Black; textBox2.BackColor = Color.White; textBox2.ForeColor = Color.Black; textBox3.BackColor = Color.White; textBox3.ForeColor = Color.Black; textBox4.BackColor = Color.White; textBox4.ForeColor = Color.Black; textBox5.BackColor = Color.White; textBox5.ForeColor = Color.Black; textBox6.BackColor = Color.White; textBox6.ForeColor = Color.Black; textBox7.BackColor = Color.White; textBox7.ForeColor = Color.Black;
            //   label2.ForeColor = Color.Black;
            //    menuStrip1.BackColor = Color.DarkSlateGray;
        }

        public void ovalShape2_Click(object sender, EventArgs e)
        {
           
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

            adb.ShowDialog();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            complateBook combook = new complateBook();
            combook.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Vb.ShowDialog();
        }

       
        private void Draw_Circle(int r, Pen pen)
        {
            Rectangle rect = new Rectangle(O_P.X + CLK_Radius - r, O_P.Y + CLK_Radius - r, r * 2, r * 2);
            graphics.DrawArc(pen, rect, 0, 360);
        }


        private void Draw_Minute_Numbers(int start)
        {
            if (SHOW_HIDE_F)
            {
                Pen pen1 = new Pen(Color.Red, 1);
                Draw_Circle(start, pen1);
                Draw_Circle(start + 15, pen1);
            }


            double Angle = 270;
            for (int i = 0; i < 12; i++)
            {
                Point P_XY = GET_XY_P(Angle, start);

                switch (i * 5)
                {
                    case 0:
                        P_XY.X += 10;
                        P_XY.Y += -18;
                        break;
                    case 5:
                        P_XY.X += 15;
                        P_XY.Y += -15;
                        break;
                    case 10:
                        P_XY.X += 15;
                        P_XY.Y += -15;
                        break;
                    case 15:
                        P_XY.X += 20;
                        P_XY.Y += -10;
                        break;
                    case 20:
                        P_XY.X += 20;
                        P_XY.Y += -5;
                        break;
                    case 25:
                        P_XY.X += 20;
                        P_XY.Y += -5;
                        break;
                    case 30:
                        P_XY.X += 15;
                        P_XY.Y += -3;
                        break;
                    case 35:
                        P_XY.X += 10;
                        P_XY.Y += -5;
                        break;
                    case 40:
                        P_XY.X += 10;
                        P_XY.Y += -8;
                        break;
                    case 45:
                        P_XY.X += 10;
                        P_XY.Y += -10;
                        break;
                    case 50:
                        P_XY.X += 10;
                        P_XY.Y += -15;
                        break;
                    case 55:
                        P_XY.X += 10;
                        P_XY.Y += -15;
                        break;
                    default:
                        P_XY.X += 10;
                        P_XY.Y += -10;
                        break;
                }


                Font font = new Font("Arial", 15, FontStyle.Bold);
                SolidBrush solidbrush = new SolidBrush(Color.Black);
                StringFormat stringformat = new StringFormat(StringFormatFlags.DirectionRightToLeft);

                graphics.DrawString((i * 5).ToString(), font, solidbrush, P_XY.X, P_XY.Y, stringformat);

                Angle += 30;
            }


        }


        private void Draw_Hour_Numbers()
        {
            int R1 = 200;
            int R2 = 225;
            int R3 = 250;

            if (SHOW_HIDE_F)
            {
                Pen pen1 = new Pen(Color.Red, 1);
                Draw_Circle(R1, pen1);
                Draw_Circle(R2, pen1);
                Draw_Circle(R3, pen1);
            }

            double Angle = 270;

            for (int i = 12; i > 0; i--)
            {
                Point P_XY = GET_XY_P(Angle, R2);

                if (SHOW_HIDE_F) graphics.DrawLine(new Pen(Color.Black, 1), CLK_P, P_XY);

                Font font = new Font("Arial", 50, FontStyle.Bold);
                SolidBrush solidbrush = new SolidBrush(Color.Black);
                StringFormat stringformat = new StringFormat(StringFormatFlags.DirectionRightToLeft);

                switch (i)
                {
                    case 12:
                        P_XY.X += 50;
                        P_XY.Y += -35;
                        break;
                    case 11:
                        P_XY.X += 45;
                        P_XY.Y += -45;
                        break;
                    case 10:
                        P_XY.X += 40;
                        P_XY.Y += -45;
                        break;
                    case 9:
                        P_XY.X += 30;
                        P_XY.Y += -35;
                        break;
                    case 8:
                        P_XY.X += 30;
                        P_XY.Y += -40;
                        break;
                    case 7:
                        P_XY.X += 35;
                        P_XY.Y += -30;
                        break;


                    case 1:
                        P_XY.X += 30;
                        P_XY.Y += -35;
                        break;
                    case 2:
                        P_XY.X += 30;
                        P_XY.Y += -40;
                        break;
                    case 3:
                        P_XY.X += 30;
                        P_XY.Y += -35;
                        break;
                    case 4:
                        P_XY.X += 30;
                        P_XY.Y += -40;
                        break;
                    case 5:
                        P_XY.X += 30;
                        P_XY.Y += -35;
                        break;
                    case 6:
                        P_XY.X += 30;
                        P_XY.Y += -35;
                        break;

                }

                graphics.DrawString(i.ToString(), font, solidbrush, P_XY.X, P_XY.Y, stringformat);

                Angle -= 30;

            }
        }
        private void DRAW_M_Lines(int ST, int End)
        {
            if (SHOW_HIDE_F)
            {
                Pen p = new Pen(Color.Brown, 1);
                Draw_Circle(ST, p);
                Draw_Circle(End, p);
            }

            double Angle = 0;
            for (int i = 0; i < 60; i++)
            {
                Angle = (360 / 60) * i;
                Angle += 270;

                Point P1 = GET_XY_P(Angle, ST);
                Point P2 = GET_XY_P(Angle, End);

                Pen MyPen = new Pen(Color.Black, 1);

                if (i % 5 > 0) MyPen.Width = 1;
                else MyPen.Width = 5;

                graphics.DrawLine(MyPen, P1, P2);
            }




        }


        Point GET_XY_P(double A, int R)
        {
            Point P_XY = new Point(0, 0);

            P_XY.X = R + (int)(R * Math.Cos(Math.PI * A / 180));
            P_XY.Y = R + (int)(R * Math.Sin(Math.PI * A / 180));
            P_XY.X += CLK_P.X - R;
            P_XY.Y += CLK_P.Y - R;

            return P_XY;
        }
        public string namla;
        public string namebook;

      /*  private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                 int   bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                 

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "select *from IRBook where id='" + bid + "'";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    namla = ds.Tables[0].Rows[0][2].ToString();
                    namebook = ds.Tables[0].Rows[0][7].ToString();

                    if (MessageBox.Show("اكتب رسالة الى " + ds.Tables[0].Rows[0][2].ToString(), "ملاحظة", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                    
                        message mess = new message();
                        mess.Show();

                    }
                    else
                    {
                        MessageBox.Show("لقد تراجعة عن الطلب");

                    }

                    

                }
            }
            catch (Exception DD)
            {
                MessageBox.Show("Please Choose Correct Data", "Not Validated", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

        }
        */


        private void عرضتقريرالكتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vb.ShowDialog();
        }

        private void عرضتقريرالطلابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vs.ShowDialog();
        }

        private void تقاريرنهائيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            complateBook combook = new complateBook();
            combook.ShowDialog();
        }

        private void اعداداتاضافيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.ShowDialog();
        }

        private void اعداداتالنظامToolStripMenuItem_Click(object sender, EventArgs e)
        {


            conect_lo conn = new conect_lo();
            if (MessageBox.Show("هل انت متأكد", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                conn.Show();
            }
            else
            {
                MessageBox.Show("تم التراجع عن العملية");

            }

            
        }

        private void تقريرالكتبالمردودةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportBookReturn re = new ReportBookReturn();
            re.ShowDialog();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                Settings s = new Settings();
                s.ShowDialog();

            }
            else if (e.Control && e.KeyCode == Keys.M)
            {
                adb.ShowDialog();

            }
            else if (e.Control && e.KeyCode == Keys.A)
            {
                St.ShowDialog();

            }
            else if (e.Control && e.KeyCode == Keys.H)
            {
                IssueBooks IBoo = new IssueBooks();

                IBoo.ShowDialog();

            }
            else if (e.Control && e.KeyCode == Keys.R)
            {
                RB.ShowDialog();

            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                Vb.ShowDialog();

            }
            else if (e.Control && e.KeyCode == Keys.L)
            {
                vs.ShowDialog();

            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                complateBook combook = new complateBook();
                combook.ShowDialog();

            }
            else if (e.Control && e.KeyCode == Keys.W)
            {
                ReportBookReturn re = new ReportBookReturn();
                re.ShowDialog();

            }
            else if (e.Control && e.KeyCode == Keys.T)
            {
                Application.Exit();

            }
            

        }

        private void label5_Click(object sender, EventArgs e)
        {
            St.ShowDialog();
        }


/*
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Gray, 30);
            Pen pen2 = new Pen(Color.Blue, 30);
            Pen pen3 = new Pen(Color.Yellow, 30);
            Pen pen4 = new Pen(Color.Crimson, 30);
            Rectangle rect = new Rectangle(O_P.X, O_P.Y, CLK_Radius * 2, CLK_Radius * 2);
            graphics.DrawArc(pen, rect, 1, 50);
            graphics.DrawArc(pen2, rect, 160, 50);
            graphics.DrawArc(pen3, rect, 250, 50);
            graphics.DrawArc(pen4, rect, 80, 50);
            Pen pen1 = new Pen(Color.Red, 1);
            int r = 5;
            Draw_Circle(r, pen1);

            Draw_Hour_Numbers();

            int M_ST = 175;
            int M_END = 150;

            DRAW_M_Lines(M_ST, M_END);

            Draw_Minute_Numbers(M_END - 25);

            int SEC_R = 200;
            Pen SEC_P = new Pen(Color.Red, 2);
            double SEC_Value = DateTime.Now.Second;
            double SEC_ANGLE = SEC_Value * (360 / 60);
            SEC_ANGLE += 270;

            Point SEC_XY_P = GET_XY_P(SEC_ANGLE, SEC_R);
            graphics.DrawLine(SEC_P, CLK_P, SEC_XY_P);

            ///

            int MIN_R = 175;
            Pen MIN_P = new Pen(Color.Black, 5);
            double MIN_Value = DateTime.Now.Minute;
            double MIN_ANGLE = MIN_Value * (360 / 60);
            MIN_ANGLE += 270;

            Point MIN_XY_P = GET_XY_P(MIN_ANGLE, MIN_R);
            graphics.DrawLine(MIN_P, CLK_P, MIN_XY_P);

            ///


            int H_R = 175;
            Pen H_P = new Pen(Color.Black, 6);
            double H_Value = DateTime.Now.Hour;
            H_Value += MIN_Value / 60;
            double H_ANGLE = H_Value * (360 / 12);
            H_ANGLE += 270;

            Point H_XY_P = GET_XY_P(H_ANGLE, H_R);
            graphics.DrawLine(H_P, CLK_P, H_XY_P);





            pictureBox3.Image = bitmap;
        }
        */


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void انشاءحسابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Siginl Sing = new Siginl();
            Sing.ShowDialog();
        }

        private void label2_Click_2(object sender, EventArgs e)
        {
            AddBookNew Bookes = new AddBookNew();
            Bookes.Dock = DockStyle.Fill;
            Bookes.TopLevel = false;
            Bookes.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Clear();
            panel2.Controls.Add(Bookes);
            Bookes.Show();
            label4.Text = "الانتقال الى تقرير الكتب";
            label5.Text = "<";
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Red;
            label3.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
            label11.ForeColor = Color.Black;
            label12.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            AddNewStudent Students = new AddNewStudent();
            Students.Dock = DockStyle.Fill;
            Students.TopLevel = false;
            Students.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Clear();
            panel2.Controls.Add(Students);
            Students.Show();
            label4.Text = "الانتقال الى تقرير الطلبة";
            label5.Text = "<";

            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
            label11.ForeColor = Color.Black;
            label12.ForeColor = Color.Black;
            label9.ForeColor = Color.Red;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            if (label4.Text== "الانتقال الى تقرير الطلبة")
            {
                ViewStudents Students = new ViewStudents();
                Students.Dock = DockStyle.Fill;
                Students.TopLevel = false;
                Students.FormBorderStyle = FormBorderStyle.None;
                panel2.Controls.Clear();
                panel2.Controls.Add(Students);
                Students.Show();
                label4.Text = "";
                label5.Text = "";
            }
            if (label4.Text == "الانتقال الى تقرير الكتب")
            {
                ViewAllBook Books = new ViewAllBook();
                Books.Dock = DockStyle.Fill;
                Books.TopLevel = false;
                Books.FormBorderStyle = FormBorderStyle.None;
                panel2.Controls.Clear();
                panel2.Controls.Add(Books);
                Books.Show();
                label4.Text = "";
                label5.Text = "";
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            DeskTopes DeskTop = new DeskTopes();
            DeskTop.Dock = DockStyle.Fill;
            DeskTop.TopLevel = false;
            DeskTop.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Clear();
            panel2.Controls.Add(DeskTop);
            DeskTop.Show();
            label4.Text = "";
            label5.Text = "";

            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
            label11.ForeColor = Color.Black;
            label12.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;

        
        }

        private void label10_Click(object sender, EventArgs e)
        {
           



            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label10.ForeColor = Color.Red;
            label11.ForeColor = Color.Black;
            label12.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;
        }

        private void label11_Click(object sender, EventArgs e)
        {

            ReturnBooks ReturnBook = new ReturnBooks();
            ReturnBook.Dock = DockStyle.Fill;
            ReturnBook.TopLevel = false;
            ReturnBook.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Clear();
            panel2.Controls.Add(ReturnBook);
            ReturnBook.Show();
            label4.Text = "";
            label5.Text = "";
            
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
            label11.ForeColor = Color.Red;
            label12.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
            label11.ForeColor = Color.Black;
            label12.ForeColor = Color.Red;
            label9.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Red;
            label10.ForeColor = Color.Black;
            label11.ForeColor = Color.Black;
            label12.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clist.Add(new string[] { "hello", "Open Add Student", "View Book", "View Student", "View Issue", "View Return Book", "Exit", "black", "white" });
                Grammar gr = new Grammar(new GrammarBuilder(clist));
                try
                {
                    sre.RequestRecognizerUpdate();
                    sre.LoadGrammar(gr);
                    sre.SpeechRecognized += Sre_spee;
                    sre.SetInputToDefaultAudioDevice();

                    sre.RecognizeAsync(RecognizeMode.Single);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }

        private void label8_Click_1(object sender, EventArgs e)
        {
             DataStudenetStatic datastudenetStatic = new DataStudenetStatic();
             datastudenetStatic.Dock = DockStyle.Fill;
             datastudenetStatic.TopLevel = false;
             datastudenetStatic.FormBorderStyle = FormBorderStyle.None;
             panel2.Controls.Clear();
             panel2.Controls.Add(datastudenetStatic);
             datastudenetStatic.Show();
             label4.Text = "";
             label5.Text = "";
             label1.ForeColor = Color.Black;
             label2.ForeColor = Color.Black;
             label3.ForeColor = Color.Black;
             label10.ForeColor = Color.Black;
             label11.ForeColor = Color.Black;
             label12.ForeColor = Color.Black;
             label9.ForeColor = Color.Black;
             label7.ForeColor = Color.Black;
             label8.ForeColor = Color.Red;
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
             databookStatic databookStatic = new databookStatic();
             databookStatic.Dock = DockStyle.Fill;
             databookStatic.TopLevel = false;
             databookStatic.FormBorderStyle = FormBorderStyle.None;
             panel2.Controls.Clear();
             panel2.Controls.Add(databookStatic);
             databookStatic.Show();
             label4.Text = "";
             label5.Text = "";
             label1.ForeColor = Color.Black;
             label2.ForeColor = Color.Black;
             label3.ForeColor = Color.Black;
             label10.ForeColor = Color.Black;
             label11.ForeColor = Color.Black;
             label12.ForeColor = Color.Black;
             label9.ForeColor = Color.Black;
             label7.ForeColor = Color.Red;
             label8.ForeColor = Color.Black;
        } 


        

  
    }
}
