using System;
namespace MyCalculator
{
    public class Calculator
    {

        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int NumberInMemory { get; set; }

        public Calculator()
        {
            FirstNumber = 0;
            SecondNumber = 0;
            NumberInMemory = 0;
        }

        public int SumNumbers(){
            return (FirstNumber + SecondNumber);
        }
        public int MultiplyNumbers()
        {
            return (FirstNumber * SecondNumber);
        }
        public int SumInBetween()
        {
            int sum = 0;
            for (int i = FirstNumber; i <= SecondNumber; i++){
                sum += i;
            }
            return sum;
        }


        public String toString(){
            string result = "First number: " + FirstNumber + "\nSecond number: " + SecondNumber + "\nNumber in memory: " + NumberInMemory;
            return result;
        }
    }
}
