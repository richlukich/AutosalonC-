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
    public partial class SixControl : UserControl
    {
        public SixControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SportCar BMWM8 = new SportCar("BMW M8 Coupe", 305, 0.75, 1960, 600, 14.6, 68,4, 11800000, 0.128,3.3);
            BMWM8.Gonka();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            SportCar BMWM8 = new SportCar("BMW M8 Coupe", 305, 0.75, 1960, 600, 14.6, 68, 4, 11800000, 0.128, 3.3);
            MessageBox.Show(BMWM8.Print());
        }
    }
}
