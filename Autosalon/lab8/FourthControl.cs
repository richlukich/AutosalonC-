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
    public partial class FourthControl : UserControl
    {
        public FourthControl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car BMW3 = new Car("BMW 3 серии", 210, 0.7, 1800, 250, 6.4, 65, 4, 2850000);
            if (checkBox1.CheckState == CheckState.Checked)
            {
                BMW3.price = BMW3.price + 157500;
            }
            if (checkBox2.CheckState == CheckState.Checked)
            {
                BMW3.price = BMW3.price + 88500;
            }
            if (checkBox3.CheckState == CheckState.Checked)
            {
                BMW3.price = BMW3.price + 102200;
            }
            if (checkBox4.CheckState == CheckState.Checked)
            {
                BMW3.price = BMW3.price + 88500;
            }
            if (checkBox5.CheckState == CheckState.Checked)
            {
                BMW3.price = BMW3.price + 97800;
            }
                textBox1.Text = Convert.ToString(BMW3.price);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Jeep BMWX7 = new Jeep("BMW X7", 227, 0.8, 2445, 249, 7.6, 80, 4, 0, 7020000,42);
            if (checkBox6.CheckState == CheckState.Checked)
            {
                BMWX7.price = BMWX7.price + 221400;
            }
            if (checkBox7.CheckState == CheckState.Checked)
            {
                BMWX7.price = BMWX7.price + 382800;
            }
            if (checkBox8.CheckState == CheckState.Checked)
            {
                BMWX7.price = BMWX7.price + 425600;
            }
            if (checkBox9.CheckState == CheckState.Checked)
            {
                BMWX7.price = BMWX7.price + 68100;
            }
            if (checkBox10.CheckState == CheckState.Checked)
            {
                BMWX7.price = BMWX7.price + 58700;
            }
            textBox2.Text = Convert.ToString(BMWX7.price);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SportCar BMWM8 = new SportCar("BMW M8 Coupe", 305, 0.75, 1960, 600, 14.6, 68, 4, 11800000, 0.128, 3.3);
            if (checkBox11.CheckState == CheckState.Checked)
            {
                BMWM8.price = BMWM8.price + 173800;
            }
            if (checkBox12.CheckState == CheckState.Checked)
            {
                BMWM8.price = BMWM8.price + 112700;
            }
            if (checkBox13.CheckState == CheckState.Checked)
            {
                BMWM8.price = BMWM8.price + 826600;
            }
            if (checkBox14.CheckState == CheckState.Checked)
            {
                BMWM8.price = BMWM8.price + 418800;
            }
            if (checkBox15.CheckState == CheckState.Checked)
            {
                BMWM8.price = BMWM8.price + 122100;
            }
            textBox3.Text = Convert.ToString(BMWM8.price);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
