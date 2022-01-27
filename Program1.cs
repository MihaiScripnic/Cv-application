using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string action;

                try
                {
                    Console.WriteLine("give the firstValue ");
                    firstValue = double.Parse(Console.ReadLine());
                    Console.WriteLine("give the secondValue");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("error!the program cant conveer string to number !");
                    Console.ReadLine();
                    continue;

                }


                Console.WriteLine("choose the operation  : '+' '-' '*' '/' ");

                action = Console.ReadLine();




                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);

                        break;
                    case "-":

                        Console.WriteLine(firstValue - secondValue);
                        break;
                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;
                    case "/":
                        if (secondValue == 0)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            Console.WriteLine(firstValue / secondValue);
                        }

                        break;
                    default:

                        Console.WriteLine("error! unknown operation");
                        break;
                }
                Console.ReadLine();

            }








        }
    }
}
    

