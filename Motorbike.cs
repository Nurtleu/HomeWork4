using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeWork4
{
    public partial class Motorbike
    {
        //скорость
        private double Speed;
        //Цвет
        public Color color;
        //Год выпуска
        private int yearOfIssue;
        //Мощность двигателя(л.с) 
        private int EnginePower;
        //Модель
        public string Model;
        public static string Name;

        public Motorbike()
        {
            Model = " ";
            Speed = 0;
            color = Color.BlackMetallic;
            EnginePower = 0;
            yearOfIssue = 0;
        }

        public Motorbike(double Speed, Color color, int yearOfIssue, int MileAge, int EnginePower)
        {
            this.Speed = Speed;
            this.yearOfIssue = yearOfIssue;
            this.color = color;
            this.EnginePower = EnginePower;
        }

        public void SetName(string anotherName)
        {
            Name = anotherName;
        }

        public static string GetName()
        {
            return Name;
        }

        public void SetModel(string anotherModel)
        {
            Model = anotherModel;
        }

        public string GetModel()
        {
            return Model;
        }

        public void SetSpeed(double anotherSpeed)
        {
            Speed = anotherSpeed;
        }

        public double GetSpeed()
        {
            return Speed;
        }

        public void SetyearOfIssue(int year)
        {
            yearOfIssue = year;
        }

        public int GetyearOfIssue()
        {
            return yearOfIssue;
        }

        public void SetEnginePower(int EngineP)
        {
            EnginePower = EngineP;
        }

        public int GetEnginePower()
        {
            return EnginePower;
        }
    }
}
