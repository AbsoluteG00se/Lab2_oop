using System;

namespace Laba_2
{
    abstract class Currency
    {
        public int value;
        public string type;
        public int conversionRate; 

        public abstract double convertToRubles();
        public abstract void display();

        virtual display()
        {

        }
    }

    class Dollar : Currency
    {
        public override double convertToRubles()
        {
            return value * conversionRate;
        }

        public override void display(
            
            )
        {
            Console.WriteLine($"Type of currency: {type}");
            Console.WriteLine($"Amount of money: {value}");
            Console.WriteLine($"Value in rubles after conversion: {this.convertToRubles()}");
        }
    }

    class Euro : Currency
    {
        public override double convertToRubles()
        {
            return value * (conversionRate / 0.85);
        }

        public override void display()
        {
            Console.WriteLine($"Type of currency: {type}");
            Console.WriteLine($"Amount of money: {value}");
            Console.WriteLine($"Value in rubles after conversion: {this.convertToRubles()}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Currency myDollar = new Dollar { value = 100, type = "Dollar", conversionRate = 75 };
            Console.WriteLine("Object of Dollar:");
            myDollar.display();

            Currency myEuro = new Euro { value = 50, type = "Euro", conversionRate = 85 };
            Console.WriteLine("Object of Euro:");
            myEuro.display();
        }
    }
}
