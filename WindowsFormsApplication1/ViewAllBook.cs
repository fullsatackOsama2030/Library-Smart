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
using System.Data.OleDb;




namespace WindowsFormsApplication1
{
    public partial class ViewAllBook : Form
    {
        conect_lo conserver = new conect_lo();
        public ViewAllBook()
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
        private void ViewAllBook_Load(object sender, EventArgs e)
        {
            //   SoundPlayer spl2 = new SoundPlayer(@"C:\Users\hp\Desktop\Liberay Management System\sound\sound2\7.wav"); spl2.Play();





            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select *from NewBook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();



            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select DISTINCT التخصص from NewBook";
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {

                    bp.Items.Add(sdr.GetString(i));
                    bp.AutoCompleteCustomSource.Add(sdr.GetString(i));
                }

            }
            con.Close();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select DISTINCT الطبعة from NewBook";
            SqlDataReader sdr4 = cmd.ExecuteReader();
            while (sdr4.Read())
            {
                for (int i = 0; i < sdr4.FieldCount; i++)
                {

                    comboBox4.Items.Add(sdr4.GetString(i));
                    comboBox4.AutoCompleteCustomSource.Add(sdr4.GetString(i));
                }

            }
            con.Close();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select DISTINCT التصنيف from NewBook";
            SqlDataReader sdr3 = cmd.ExecuteReader();
            while (sdr3.Read())
            {
                for (int i = 0; i < sdr3.FieldCount; i++)
                {

                    bq.Items.Add(sdr3.GetString(i));
                    bq.AutoCompleteCustomSource.Add(sdr3.GetString(i));
                }

            }
            con.Close();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select DISTINCT اسم_الناشر from NewBook";
            SqlDataReader sdr2 = cmd.ExecuteReader();
            while (sdr2.Read())
            {
                for (int i = 0; i < sdr2.FieldCount; i++)
                {

                    comboBox5.Items.Add(sdr2.GetString(i));
                    comboBox5.AutoCompleteCustomSource.Add(sdr2.GetString(i));
                }

            }



        }

        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {

                    bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    panel2.Visible = true;
                    dataGridView1.Visible = false;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "select *from NewBook where bid='" + bid + "'";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    nb.Text = ds.Tables[0].Rows[0][1].ToString();
                    ba.Text = ds.Tables[0].Rows[0][2].ToString();
                    bp.Text = ds.Tables[0].Rows[0][3].ToString();
                    datas.Text = ds.Tables[0].Rows[0][4].ToString();
                    pp.Text = ds.Tables[0].Rows[0][5].ToString();
                    numericUpDown1.Text = ds.Tables[0].Rows[0][6].ToString();
                    bq.Text = ds.Tables[0].Rows[0][7].ToString();
                    comboBox1.Text = ds.Tables[0].Rows[0][8].ToString();
                    comboBox5.Text = ds.Tables[0].Rows[0][9].ToString();
                    comboBox4.Text = ds.Tables[0].Rows[0][10].ToString();
                    comboBox3.Text = ds.Tables[0].Rows[0][11].ToString();
                    textBox2.Text = ds.Tables[0].Rows[0][12].ToString();

                }
            }
            catch (Exception DD)
            {
                MessageBox.Show("Please Choose Correct Data", "Not Validated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               

            }






        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            dataGridView1.Visible = true;
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (search.Text != "")
            {
                Image im = Image.FromFile(@"C:\Users\hp\Desktop\سطح المكتب\مشروع\Liberay Management System\search1.gif");
                pictureBox1.Image = im;
        
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select *from NewBook where  اسم_الكتاب LIKE'" + search.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
                dataGridView1.DataSource = ds.Tables[0];

            }
            else
            {
                Image im = Image.FromFile(@"C:\Users\hp\Desktop\سطح المكتب\مشروع\Liberay Management System\search.gif");
                pictureBox1.Image = im;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select *from NewBook";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
                dataGridView1.DataSource = ds.Tables[0];


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search.Text = "";
            panel2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("تم التعديل على البيانات !", "تم انجاز المهمة", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string bnames = nb.Text;
                string abs = ba.Text;
                string bpu = bp.Text;
                string dates = datas.Text;
                Int64 pps = Int64.Parse(pp.Text);
                string bqs = bq.Text;
                int shelf = (int)numericUpDown1.Value;
                string depa = comboBox1.Text;

                string name_go = comboBox5.Text;
                string print = comboBox4.Text;
                string lang = comboBox3.Text;
                string notice = textBox2.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update NewBook set  اسم_الكتاب='" + bnames + "',مؤلف_الكتاب='" + abs + "',التخصص='" + bpu + "',تاريخ_الاصدار='" + dates + "',التصنيف='" + bqs + "',كمية_الكتاب='" + pps + "',رقم_الرف='" + shelf + "',القسم='" + depa + "',اسم_الناشر='" + name_go + "',الطبعة='" + print + "',لغة_الكتاب='" + lang + "',ملاحظات='" + notice + "' where bid='" + rowid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                cmd.CommandText = "select *from NewBook";
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
               
            }
            else
            {
        /*
                nb.Text = "";
                ba.Text = "";
                bp.Text = "";
                datas.Text = "";
                pp.Text = "";
                */

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Delete. Confir?", "Confirestion Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from NewBook where bid='" + rowid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.CommandText = "select *from NewBook";
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                panel2.Visible = false;
                dataGridView1.Visible = true;
            }
            else
            {
               

            }
        }

        private void ViewAllBook_FormClosed(object sender, FormClosedEventArgs e)
        {

            //  SoundPlayer spl2 = new SoundPlayer(@"C:\Users\hp\Desktop\Liberay Management System\sound\6.wav"); spl2.Play();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد سيتم حذف جميع بيانات الكتب", "رسالة تنبية", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =" + pc() + "\\" + conserver.server() + ";database=" + namedata() + ";integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from NewBook";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.CommandText = "select *from NewBook";
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                MessageBox.Show(ds.Tables[0].ToString());
                panel2.Visible = false;

            }
            else
            {
                panel2.Visible = false;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exel_Click(object sender, EventArgs e)
        {
            // استخدام مربع حوار لحفظ الملف
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "احفظ ملف Excel";
                saveFileDialog.FileName = "data.xlsx"; // اسم افتراضي

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // إنشاء DataTable لتخزين البيانات
                    DataTable dataTable = new DataTable();

                    // إضافة الأعمدة إلى DataTable
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        dataTable.Columns.Add(column.HeaderText);
                    }

                    // إضافة الصفوف إلى DataTable
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow) // تجنب إضافة الصف الجديد
                        {
                            DataRow dataRow = dataTable.NewRow();
                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                dataRow[i] = row.Cells[i].Value;
                            }
                            dataTable.Rows.Add(dataRow);
                        }
                    }
                    // إنشاء ملف Excel باستخدام OleDb
                    string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0 Xml;HDR=YES';";
                    OleDbConnection connection = new OleDbConnection(connectionString);
                    connection.Open();

                  
                    OleDbCommand command = new OleDbCommand("CREATE TABLE [Sheet1] (" + string.Join(", ", dataTable.Columns.Cast<DataColumn>().Select(c => "[" + c.ColumnName + "] TEXT")) + ")", connection);
                    command.ExecuteNonQuery();

                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        string insertCommand = "INSERT INTO [Sheet1] VALUES (" + string.Join(", ", dataRow.ItemArray.Select(v => "'" + v + "'")) + ")";
                        OleDbCommand insertCommandObj = new OleDbCommand(insertCommand, connection);
                        insertCommandObj.ExecuteNonQuery();
                    }

                    connection.Close(); 
                    MessageBox.Show("تم تصدير البيانات إلى Excel بنجاح.");
                }
            }



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
     
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "احفظ ملف Excel";
            saveFileDialog.FileName = "data.xlsx"; // اسم افتراضي

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0 Xml;HDR=YES;'"))
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", conn);
                    DataTable tbl = new DataTable();

                    conn.Open();
                    tbl.Load(cmd.ExecuteReader());
                    conn.Close();

                  
                    if (tbl.Rows.Count > 0) 
                    {
                        DataTable filteredTable = tbl.Clone(); 
                        for (int i = 0; i < 38; i++) 
                        {
                            filteredTable.ImportRow(tbl.Rows[i]);
                        }

                        dataGridView1.DataSource= filteredTable;
                        MessageBox.Show("تم تصدير البيانات من Excel بنجاح.");
                    }
                    else
                    {
                        MessageBox.Show("لا توجد بيانات كافية في الملف.");
                    }
                }
            }




        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void datas_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
