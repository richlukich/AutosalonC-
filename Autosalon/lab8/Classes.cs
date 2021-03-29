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
    interface Itransport
    {
        double Pleasure(); //уровень удовольствия
       
        double MediumSpeed(); //средняя скорость
    }

    interface Iprint
    {
        string Print(); //данные об автомобиле
    }
    abstract class Transpot : Iprint, Itransport
    {
        public string TypeOfTransport { get; protected set; } //название машины
        public int MaxSpeed { get; protected set; } //макс. скорость
        public double Upravlyamost { get; protected set; } //управляемость летом
        public int weight { get; protected set; } //вес
        public int Power { get; protected set; } //мощность
        public double Rashod100 { get; protected set; } //расход на 100км
        public int fuel { get; protected set; } //объем бака
        public int price { get; set; } //цена
        public virtual string Print()
        {
            string name = "Модель машины: " + TypeOfTransport + "\n" + "Максимальная скорость: " + Convert.ToString(MaxSpeed) + "\n" + "Управляемость летом: " + Convert.ToString(Upravlyamost) + "\n" + "Масса: " + Convert.ToString(weight) + "\n" + "Расход на 100км: " + Convert.ToString(Rashod100) + "\n" + "Объем бака: " + Convert.ToString(fuel);
            return name;
        }
        
        public abstract double Pleasure();
        public abstract double MediumSpeed();



    }

    class Car : Transpot, Iprint, Itransport
    {
        public Car(string TypeOfTransport, int MaxSpeed, double Upravlyamost, int weight, int Power, double Rashod100, int fuel, int wheels, int price)
        {
            this.TypeOfTransport = TypeOfTransport;
            this.MaxSpeed = MaxSpeed;
            this.Upravlyamost = Upravlyamost;
            this.weight = weight;
            this.Power = Power;
            this.Rashod100 = Rashod100;
            this.fuel = fuel;
            this.wheels = wheels;
            this.price = price;


        }
        public int wheels { get; set; } //кол-во колес
        public override double Pleasure()
        {
            double Comfort = (MediumSpeed() * weight * Power * wheels) / (200000000);
            if (Comfort > 1){
                Comfort = 0.95;
            }
            return Comfort;
        }
        public override double MediumSpeed()
        {
            Random rand = new Random();
            double speed = rand.Next(MaxSpeed / 4, MaxSpeed / 3);
            return speed;
        }



    }

    class Jeep : Car, Iprint, Itransport {
        public Jeep(string TypeOfTransport, int MaxSpeed, double Upravlyamost, int weight, int Power, double Rashod100, int fuel, int wheels,int BlockDif, int price,int wheelsDiam) : base(TypeOfTransport, MaxSpeed, Upravlyamost, weight, Power, Rashod100, fuel, wheels, price)
        {
            this.BlockDif = BlockDif; 
            this.wheelsDiam = wheelsDiam; 
        }


        public int BlockDif { get; set; }//блокировка дифференциала
        public int wheelsDiam { get; set; }//диаметр колес

        public override double Pleasure()
        {
            double Comfort = (MediumSpeed() * weight * Power * wheels) / (200000000);
            if (Comfort > 1)
            {
                Comfort = 0.97;
            }
            return Comfort;
        }

        public override double MediumSpeed()
        {
            Random rand = new Random();

            double speed = rand.Next(2 * this.MaxSpeed / 7, this.MaxSpeed / 3);
            return speed;
        }
        public override string Print()
        {
            string name;
            if (BlockDif == 1)
            {
                name = "Модель машины: " + TypeOfTransport + "\n" + "Максимальная скорость: " + Convert.ToString(MaxSpeed) + "\n" + "Управляемость летом: " + Convert.ToString(Upravlyamost) + "\n" + "Масса: " + Convert.ToString(weight) + "\n" + "Расход на 100км: " + Convert.ToString(Rashod100) + "\n" + "Объем бака: " + Convert.ToString(fuel) + "\n" + "Блокировка дифференциала: есть";

            }
            else
            {

                name = "Модель машины: " + TypeOfTransport + "\n" + "Максимальная скорость: " + Convert.ToString(MaxSpeed) + "\n" + "Управляемость летом: " + Convert.ToString(Upravlyamost) + "\n" + "Масса: " + Convert.ToString(weight) + "\n" + "Расход на 100км: " + Convert.ToString(Rashod100) + "\n" + "Объем бака: " + Convert.ToString(fuel) + "\n" + "Блокировка дифференциала: нет";



            }
            return name;
        }
        public void Prohodimost() //уровень проходимости
        {
            Random rand = new Random();
            
           
                double gryaz = rand.Next(1, 10);
                double prohodimost = (Power * wheelsDiam+1000*BlockDif) / weight;
                prohodimost = Math.Exp(-(gryaz-1)/prohodimost);
                prohodimost = Math.Round(prohodimost, 2);
                double speed = this.MediumSpeed() / (gryaz * gryaz);
                speed = Math.Round(speed, 2);
            if (prohodimost < 0.18)
            {
                MessageBox.Show("Условия-грязь" + "\n" + "Уровень грязи=" + Convert.ToString(gryaz) + "\n" + "Вы застряли");
            }
            else
            {
                MessageBox.Show("Условия-грязь" + "\n" + "Уровень грязи=" + Convert.ToString(gryaz) + "\n" + "Уровень проходимости" + " " + Convert.ToString(prohodimost)+"\n"+"Уровень удовольствия"+"  "+ this.Pleasure()+"\n"+"Средняя скорость:"+" "+Convert.ToString(speed));
            }
            

        }
    }

    class Motorcycle : Transpot, Itransport, Iprint
    {
        public Motorcycle(string TypeOfTransport, int MaxSpeed, double Upravlyamost, int weight, int Power, double Rashod100, int fuel, int wheels, int price, double Manevrenost)
        {
            this.TypeOfTransport = TypeOfTransport;
            this.MaxSpeed = MaxSpeed;
            this.Upravlyamost = Upravlyamost;
            this.weight = weight;
            this.Power = Power;
            this.Rashod100 = Rashod100;
            this.fuel = fuel;
            this.wheels = wheels;
            this.price = price;
            this.Manevrenost = Manevrenost;


        }
        public int wheels { get; set; }
        public double Manevrenost { get; set; } //уровень маневренности
        public override double MediumSpeed()
        {
            Random rand = new Random();

            double speed = rand.Next(2 * MaxSpeed / 7, MaxSpeed / 3);
            return speed;
        }
        public override string Print()
        {
            string name;
            name = "Модель мотоцикла: " + TypeOfTransport + "\n" + "Максимальная скорость: " + Convert.ToString(MaxSpeed) + "\n" + "Управляемость летом: " + Convert.ToString(Upravlyamost) + "\n" + "Масса: " + Convert.ToString(weight) + "\n" + "Расход на 100км: " + Convert.ToString(Rashod100) + "\n" + "Объем бака: " + Convert.ToString(fuel);
            return name;
        }
        public override double Pleasure()
        {
            double Pleasure =2* Power * Upravlyamost * Manevrenost / weight;
            return Pleasure;
        }
        public double CrossProbka(int Probka) //уровень проходимости пробки
        {

            double CrossProbka = Power * Manevrenost * Power / (1000 * Probka * Probka * Probka);
            if (CrossProbka > 1)
            {
                CrossProbka = (1 - 0.1 * Probka);
            }
            CrossProbka = Math.Round(CrossProbka, 2);
            return CrossProbka;
        }
    }
    class SportCar : Car, Iprint, Itransport
    {
        public SportCar(string TypeOfTransport, int MaxSpeed, double Upravlyamost, int weight, int Power, double Rashod100, int fuel, int wheels, int price, double Clirens, double Razgon100) : base(TypeOfTransport, MaxSpeed, Upravlyamost, weight, Power, Rashod100, fuel, wheels, price)
        {
            this.Clirens = Clirens;
            this.Razgon100 = Razgon100;
        }
        public double Clirens { get; protected set; } //клиренс
        public double Razgon100 {get; protected set;} //разгон до 100


        public override string Print()
        {
            string name;
            name = "Модель машины: " + TypeOfTransport + "\n" + "Максимальная скорость: " + Convert.ToString(MaxSpeed) + "\n" + "Управляемость летом: " + Convert.ToString(Upravlyamost) + "\n" + "Масса: " + Convert.ToString(weight) + "\n" + "Расход на 100км: " + Convert.ToString(Rashod100) + "\n" + "Объем бака: " + Convert.ToString(fuel) + "\n" + "Разгон до 100 км/ч:" +" "+ Convert.ToString(Razgon100)+"сек" + "\n" + "Клиренс: " + Convert.ToString(Clirens)+" " +"м";
            return name;
        }
        public void Gonka() // как гоночный автомобиль ведет себя в гонке
        {
            Random rand = new Random();
            double Uscorenie = 100 / (this.Razgon100);
            double time100 = Math.Sqrt(200 / Uscorenie);
            time100 = Math.Round(time100, 2);
            double maxspeed100 = time100 * Uscorenie;
            maxspeed100 = Math.Round(maxspeed100, 2);
            double speed = (Power * MaxSpeed * Upravlyamost) / (Clirens * weight * 5);
            double time400 =time100+ 400 / (speed);
            time400 = Math.Round(time400, 2);
            double maxspeed400 = speed + 3*rand.Next(5,10);
            maxspeed400 = Math.Round(maxspeed400, 2);
            speed = (Power * MaxSpeed * Upravlyamost) / (Clirens * weight * 3);
            double time1000 = time100 + time400 + 600 / speed;
            time1000 = Math.Round(time1000, 2);
            double maxspeed1000 = speed + 3 * rand.Next(5, 10);
            maxspeed1000 = Math.Round(maxspeed1000, 2);
            MessageBox.Show("100 метров: " + "\n" + "Время: " + Convert.ToString(time100) + " " + "секунд" + "\n"+"Максимальная скорость"+" "+Convert.ToString(maxspeed100)+" "+"км/ч"+"\n" + "500 метров" + "\n" + "Время: " + Convert.ToString(time400) + " " + "секунд"+"\n" + "Максимальная скорость"+ " " + Convert.ToString(maxspeed400)+" "+"км/ч" +"\n" + "1000 метров: " + "\n" + "Время: " + Convert.ToString(time1000) + " " + "секунд" + "\n" + "Максимальная скорость" + " " + Convert.ToString(maxspeed1000)+" "+"км/ч");

        }
      


    }
   

  
} 

    

    


