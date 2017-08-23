using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeWork4
{
    public class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Добро пожаловать!");

            WriteLine("Enter model motorBike:");
            string Model=ReadLine();
            WriteLine("Speed:");
            int Speed = Int16.Parse(ReadLine());              
            WriteLine("Year of issue:");
            int yearOfIssue=Int32.Parse(ReadLine());
            WriteLine("Engine power(л.с)");
            int EnginePower=Int32.Parse(ReadLine());
            WriteLine("Name:");
            string Name = ReadLine();
            ReadLine();

            WriteLine("Enter model motorBike:");
            WriteLine(Model);

            WriteLine("Motorcycle color:");
            WriteLine(Color.BlackMetallic);

            WriteLine("Speed:");
            WriteLine(Speed);

            WriteLine("Year of issue:");
            WriteLine(yearOfIssue);

            WriteLine("Engine power(л.с)");
            WriteLine(EnginePower);

            WriteLine("Name:");
            WriteLine(Name);
            
            ReadLine();

            
        }
    }
}
