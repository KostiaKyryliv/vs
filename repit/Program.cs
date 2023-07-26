using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repit
{

    internal class Program
    {
        static void message(int choose)
        {
            if (choose == 1)
            {
                Console.WriteLine("You like banana");
            }
            else if (choose == 2) 
            {
                int size = 5;
                
                for (int i = 0; i < size; i++) 
                { 
                    for(int j = 0; j <size-i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else if (choose == 3)
            {
                int size = 5;

                for (int g = 0; g < size; g++)
                {
                    for (int f = 0; f <= g; f++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Lets repit functions, choose 1, 2 or 3");
                int choose = int.Parse(Console.ReadLine());
                message(choose);
            }
        }
    }
}