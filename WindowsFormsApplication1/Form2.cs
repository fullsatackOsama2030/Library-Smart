using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
using AForge.Video.DirectShow;
using ZXing;
 */
namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        /*
        FilterInfoCollection filterinfcoll;
        VideoCaptureDevice videocapture;
         */
        private void Form2_Load(object sender, EventArgs e)
        {
            /*
            filterinfcoll = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterinfcoll)
                comboBox1.Items.Add(device.Name);
            comboBox1.SelectedIndex = 0;
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
