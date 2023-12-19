using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section3._6
{
    internal class Program
    {
        public static void ForLoop()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"For Loop increment  {i}");
            }
            Console.WriteLine();
        }

        public static void WhileLoop()
        {
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine($"While loop {i}");
                i++;
            }
            Console.WriteLine();
        }

        public static void DowhileLoop()
        {
            int i = 1;
            do
            {
                Console.WriteLine($"doWhile loop {i}");
                i++;
            }
            while (i <= 10);
            Console.WriteLine();
        }

        public static void ForeachLoop()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            foreach (int i in arr)
            {
                Console.WriteLine($"Foreach loop {i}");
            }
            Console.WriteLine();
        }

        public static void SelectMenu()
        {
            Console.WriteLine("Choose loop execution: \n1 - ForLoop\n2 - While\n3 - dowhile\n4 - foreach\n5 - exit");
        }

        public static int GetChoi()
        {
            Console.WriteLine("Enter choice");
            int choi = Convert.ToInt32(Console.ReadLine());
            return choi;
        }
        public static void SwitchLoop()
        {
            while (true)
            {
                SelectMenu();
                Console.WriteLine();
                int val = GetChoi();
                Console.WriteLine();
                switch (val)
                {
                    case 1:
                        {
                            ForLoop();
                            break;
                        }
                    case 2:
                        {
                            WhileLoop();
                            break;
                        }
                    case 3:
                        {
                            DowhileLoop();
                            break;
                        }
                    case 4:
                        {
                            ForeachLoop();
                            break;
                        }
                    case 5:
                        {
                            System.Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Choice. pls select correct one");
                            break;
                        }
                }
            }
        }

        static void Main(string[] args)
        {
            SwitchLoop();
            Console.ReadLine();
        }
    }
}
