using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);
            conect_lo co = new conect_lo();
            string nameserver =co.comboBox.Text;
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =" + Environment.MachineName + "\\" + nameserver + ";database='"+co.textBox1.Text+"';integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                Application.Run(new Home());
                con.Close();
                con.Open();
                


            }
            catch (SqlException ex)
            {
                MessageBox.Show("لم يتم التعرف على السيرفر قم بتعيين السيرفر من جديد \n" + ex.Message);

                Application.Run(new conect_lo());
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث الخطأ في قاعدة البيانات \n" + ex.Message);
             
            }
               
          
      
      
        



        }
      
    }
     
}
