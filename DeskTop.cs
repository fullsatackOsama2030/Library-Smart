using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_Br_Hub
{
    public partial class DeskTop : Form
    {
        public DeskTop()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Exit ?", "Confire",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void addNewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            AddBooks adb = new AddBooks();
            adb.Show();
        }

       
    }
}
