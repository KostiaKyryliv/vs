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
            else if (choose == 4)
            {
                int size = 5;

                for (int h = 0; h < size; h++)
                {
                    for (int u = 0; u <= h; u++)
                    {
                        Console.Write(" ");
                    }
                    for (int y = 0; y < size-h; y++)
                    {
                        Console.Write("*");
                        
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Lets repit functions, choose 1, 2, 3 or 4");
                int choose = int.Parse(Console.ReadLine());
                message(choose);
                Console.WriteLine("Trypull");
            }
        }
    }
}