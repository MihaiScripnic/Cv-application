using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            string action;

            Console.WriteLine("give the firstValue ");
            firstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("give the secondValue");
            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("choose the operation  : '+' '-' '*' '/' ");

            action = Console.ReadLine();

            if (action =="+")
            {
                Console.WriteLine(firstValue +  secondValue);
            }
            else if (action =="-")  
            {
                Console.WriteLine(firstValue - secondValue);
            }else if (action =="*")
            {
                Console.WriteLine(firstValue * secondValue);

            }else if (action =="/")

            {
                if (secondValue == 0)
                    Console.WriteLine(0);
                else
                    Console.WriteLine(firstValue / secondValue);
                } 
                else 
                {
                    Console.WriteLine("error!unknown operation");
                }

                Console.ReadLine();
            }

        }
    }

    