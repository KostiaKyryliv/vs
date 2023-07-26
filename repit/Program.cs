using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add1
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
                    for(int j = 0; j <=i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Lets repit functions, choose 1 or 2");
                int choose = int.Parse(Console.ReadLine());
                message(choose);
            }
        }
    }
}