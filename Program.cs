using System;

namespace Calculator1
{
    class Math
    {
        public double Add(double x,double y)
        {
            return x + y;
        }
        public double Substract(double x,double y)
        {
            return x - y;
        }
        public double Multiply(double x,double y)
        {
            return x * y;
        }
        public double Division(double x,double y)
        {
            return x / y;
        }
        public double Modulus(double x,double y)
        {
            return x % y;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Hallo Sir...");
            Console.WriteLine("Please Enter your first number: ");
            double.TryParse(Console.ReadLine(), out double num1);
            Console.WriteLine("Enter your second number: ");
            double.TryParse(Console.ReadLine(), out double num2);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Now, please Sir choose your desired mathematical operator:");
            Console.WriteLine("1.Add\n2.Substract\n3.Multiply\n4.Divison\n5.Modulus");
            string chooseOperator = Console.ReadLine();
            switch(chooseOperator)
            {
                case "1":
                    Console.WriteLine(math.Add(num1, num2));
                    break;
                case "2":
                   Console.WriteLine(math.Substract(num1, num2));
                    break;
                case "3":
                   Console.WriteLine(math.Multiply(num1, num2));
                    break;
                case "4":
                   Console.WriteLine(math.Division(num1, num2));
                    break;
                case "5":
                    Console.WriteLine(math.Modulus(num1, num2));
                    break;

            }
        }
    }
}
