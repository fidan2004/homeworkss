using System;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

           //task 1
            DateTime dt = new DateTime(2004, 05, 29);
            Console.WriteLine(dt.ToString("dddd"));
           
         
            //task 2
            DateTime dt2 = DateTime.Now;
            DateTime dt3 = new DateTime(2004, 05, 29);
            var result = DateTime.Now - dt3;
            Console.WriteLine(result);
            
            //task 7
            int sum = 0;
            Console.WriteLine(myfunct(sum));
        }

        static int myfunct(int num)
        {
            int reminder;
            Console.Write("Enter the Number : ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (number > 0)
            {
                reminder = number % 10;
                sum = sum + reminder;
                number = number / 10;
            }
            return sum;

        }
    }
}
