using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class ThirdControl : UserControl
    {
        public ThirdControl()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Jeep BMWX5 = new Jeep("BMW X5", 222, 0.7, 2075, 231, 6.9, 80, 4, 0,5400000,34);
            MessageBox.Show(BMWX5.Print());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Jeep BMWX7 = new Jeep("BMW X7", 227, 0.8, 2445, 249, 7.6, 80, 4, 1, 7020000, 42);
            MessageBox.Show(BMWX7.Print());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Jeep BMWX5 = new Jeep("BMW X5", 222, 0.7, 2075, 231, 6.9, 80, 4, 0, 5400000, 34);
            BMWX5.Prohodimost();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Jeep BMWX7 = new Jeep("BMW X7", 227, 0.8, 2445, 249, 7.6, 80, 4, 1, 7020000, 42);
            BMWX7.Prohodimost();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Jeep BMWX6 = new Jeep("BMW X6", 230, 0.8, 2185, 249, 7.4, 83, 4, 1, 6350000, 38);
            MessageBox.Show(BMWX6.Print());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jeep BMWX6 = new Jeep("BMW X6", 230, 0.8, 2185, 249, 7.4, 83, 4, 1, 6350000, 38);
            BMWX6.Prohodimost();
        }
    }
}
