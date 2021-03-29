using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car BMW7 = new Car("BMW 7 сериии", 270, 0.8, 2200, 420, 9.2, 70, 4,6630000);
            Random rand = new Random();
            int distance = rand.Next(10, 15);
            int MaxSpeedonDistance = 2100 / rand.Next(15, 20);
            double time = distance / BMW7.MediumSpeed();
            time = Math.Round(time, 2);
            int avaria = rand.Next(1, 20);
            if (avaria == 2)
            {
                MessageBox.Show("ВЫ ПОПАЛИ В АВАРИЮ");

            }

            else
            {
                MessageBox.Show("Вы проехали дистанцию: " + Convert.ToString(distance) + " км" + "\n" + "Максимальная развитая скорость: " + Convert.ToString(MaxSpeedonDistance) + "\n" + "Средняя скорость: " + Convert.ToString(BMW7.MediumSpeed()) + "\n" + "Время в пути: " + Convert.ToString(time) + "\n" + "Уровень комфорта: " + Convert.ToString(BMW7.Pleasure()));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car BMW7 = new Car("BMW 7 сериии", 270, 0.8, 2200, 420, 9.2, 70, 4,6630000);
            Random rand = new Random();
            int distance = rand.Next(10, 15);
            int MaxSpeedonDistance = 2100 / rand.Next(18, 30);
            double time = distance / BMW7.MediumSpeed();
            time = Math.Round(time, 2);
            int avaria = rand.Next(1, 10);
            if (avaria == 2)
            {
                MessageBox.Show("ВЫ ПОПАЛИ В АВАРИЮ");

            }

            else
            {
                MessageBox.Show("Вы проехали дистанцию: " + Convert.ToString(distance) + " км" + "\n" + "Максимальная развитая скорость: " + Convert.ToString(MaxSpeedonDistance) + "\n" + "Средняя скорость: " + Convert.ToString(0.7 * BMW7.MediumSpeed()) + "\n" + "Время в пути: " + Convert.ToString(time) + "\n" + "Уровень комфорта: " + Convert.ToString(0.9 * BMW7.Pleasure()));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Car BMW7 = new Car("BMW 7 сериии", 270, 0.8, 2200, 420, 9.2, 70, 4,6630000);
            Random rand = new Random();
            int distance = rand.Next(10, 15);
            int MaxSpeedonDistance = 2100 / rand.Next(18, 30);
            double time = distance / BMW7.MediumSpeed();
            time = Math.Round(time, 2);
            int avaria = rand.Next(1, 10);
            if (avaria == 2)
            {
                MessageBox.Show("ВЫ ПОПАЛИ В АВАРИЮ");

            }

            else
            {
                MessageBox.Show("Вы проехали дистанцию: " + Convert.ToString(distance) + " км" + "\n" + "Максимальная развитая скорость: " + Convert.ToString(MaxSpeedonDistance) + "\n" + "Средняя скорость: " + Convert.ToString(0.7 * BMW7.MediumSpeed()) + "\n" + "Время в пути: " + Convert.ToString(time) + "\n" + "Уровень комфорта: " + Convert.ToString(0.9 * BMW7.Pleasure()));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Car BMW7 = new Car("BMW 7 сериии", 270, 0.8, 2200, 420, 9.2, 70, 4,6630000);
            Random rand = new Random();
            int distance = rand.Next(10, 15);
            int MaxSpeedonDistance = 2100 / rand.Next(20, 25);
            double time = distance / BMW7.MediumSpeed();
            time = Math.Round(time, 2);
            int avaria = rand.Next(1, 10);
            if (avaria == 2)
            {
                MessageBox.Show("ВЫ ПОПАЛИ В АВАРИЮ");

            }

            else
            {
                MessageBox.Show("Вы проехали дистанцию: " + Convert.ToString(distance) + " км" + "\n" + "Максимальная развитая скорость: " + Convert.ToString(MaxSpeedonDistance) + "\n" + "Средняя скорость: " + Convert.ToString(0.6 * BMW7.MediumSpeed()) + "\n" + "Время в пути: " + Convert.ToString(time) + "\n" + "Уровень комфорта: " + Convert.ToString(0.65 * BMW7.Pleasure()));
            }
        }
    }
}
