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
    public partial class FiveControl : UserControl
    {
        public FiveControl()
        {
            InitializeComponent();
        }

        private void FiveControl_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Motorcycle HP4RACE = new Motorcycle("HP4 RACE",280,0.8,500,100,3.2,20,2,5492000,0.9);
            MessageBox.Show(HP4RACE.Print());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int Probka = rand.Next(1, 10);
            Motorcycle HP4RACE = new Motorcycle("HP4 RACE", 280, 0.8, 500, 216, 3.2, 20, 2, 5492000, 0.9);
            double mediumspeed = HP4RACE.MediumSpeed() / (Probka);
            mediumspeed = Math.Round(mediumspeed);
            MessageBox.Show("На дороге пробки "+Convert.ToString(Probka)+" "+"баллов"+"\n"+"Уровень проходимости пробки составило:"+Convert.ToString(HP4RACE.CrossProbka(Probka))+"\n"+"Уровень удовольствия"+" "+Convert.ToString(HP4RACE.Pleasure()+"\n"+"Средняя скорость"+" "+Convert.ToString(mediumspeed)));

        }
    }
}
