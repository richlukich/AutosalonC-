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
    public partial class SecondControl : UserControl
    {
        public SecondControl()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Car BMW3 = new Car("BMW 3 серии", 223, 0.7, 1535, 156, 6.3, 59, 4,2850000);
           MessageBox.Show(BMW3.Print());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Car BMW5 = new Car("BMW 5 серии", 235, 0.75, 1615, 184, 6.5, 65, 4,3820000);
            MessageBox.Show(BMW5.Print());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Car BMW7 = new Car("BMW 7 сериии", 250, 0.8, 1750, 249, 7.2, 78, 4,6630000);
            MessageBox.Show(BMW7.Print());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
      
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
