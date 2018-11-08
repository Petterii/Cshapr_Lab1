using System;

namespace MyCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            int mysum = 0;
            Calculator calc = new Calculator();

            bool playing = true;
            do {
                Console.WriteLine("-------------------------");
                Console.WriteLine("1.Add two numbers");
            Console.WriteLine("2.Multiply two numbers"); 
            Console.WriteLine("3.Sum the numbers between two numbers."); 
            Console.WriteLine("4.Add number to memory"); 
            Console.WriteLine("5.Clear memory"); 
            Console.WriteLine("6.Print calculator contents."); 
            Console.WriteLine("7.Quit");

            int choise = -1;
            try
            {
                choise = int.Parse(Console.ReadLine());
            }catch {
                Console.WriteLine("Bad Choice!!!!!!");
                    break;
            }
         
          
                switch (choise)
                {
                    case 1:
                        Console.WriteLine("Add two numbers.");
                        Console.Write("First Number: ");
                        calc.FirstNumber = int.Parse(Console.ReadLine());
                        Console.Write("Second Number: ");
                        calc.SecondNumber = int.Parse(Console.ReadLine());
                        mysum = calc.SumNumbers();
                        Console.WriteLine("Result: " + mysum);
                        break;
                    case 2:
                        Console.WriteLine(".Multiply two numbers.");
                        Console.Write("First Number: ");
                        calc.FirstNumber = int.Parse(Console.ReadLine());
                        Console.Write("Second Number: ");
                        calc.SecondNumber = int.Parse(Console.ReadLine());
                        mysum = calc.MultiplyNumbers();
                        Console.WriteLine("Result: " + mysum);
                        break;
                    case 3:
                        Console.WriteLine("Sum the numbers between two numbers.");
                        Console.Write("First Number: ");
                        calc.FirstNumber = int.Parse(Console.ReadLine());
                        Console.Write("Second Number: ");
                        calc.SecondNumber = int.Parse(Console.ReadLine());
                        mysum = calc.SumInBetween();
                        Console.WriteLine(calc.SumInBetween());
                        break;
                    case 4:
                        Console.Write("Add to memory");
                        Console.Write("Add Number to memory: ");
                        calc.NumberInMemory = int.Parse(Console.ReadLine());
                        Console.WriteLine("Number successfully added to memory ");
                        break;
                    case 5:
                        Console.WriteLine("Number cleared in memory");
                        calc.NumberInMemory = 0;
                        break;
                    case 6:
                        Console.WriteLine(calc.toString());
                        break;
                    case 7:
                        playing = false;
                        break;
                }
            } while (playing);
        }
    }
}
