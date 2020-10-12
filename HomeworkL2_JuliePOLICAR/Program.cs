using System;

namespace HomeworkL2_JuliePOLICAR
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
            //Ex7();
            //Ex8();
            Ex9();
        }

        private static void Ex1()
        {
            Console.WriteLine("Hello!");
            Console.Write("My name is Julie");

            Console.ReadKey();
        }

        private static void Ex2()
        {
            Console.WriteLine("Please enter a number ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum of the numbers is " + (a + b));
            Console.ReadKey();

        }

        private static void Ex3()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + (-4) * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

            Console.ReadKey();
        }

        private static void Ex4()
        {
            Console.WriteLine("Please enter a number :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number :");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("The result of the multiplication is" + (a * b * c));

            Console.ReadKey();
        }

        private static void Ex5()
        {
            Console.WriteLine("Please enter a number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a * 1);
            Console.WriteLine(a * 2);
            Console.WriteLine(a * 3);
            Console.WriteLine(a * 4);
            Console.WriteLine(a * 5);
            Console.WriteLine(a * 6);
            Console.WriteLine(a * 7);
            Console.WriteLine(a * 8);
            Console.WriteLine(a * 9);
            Console.WriteLine(a * 10);

            Console.ReadKey();

        }

        private static void Ex6()
        {
            Console.WriteLine("Please enter a number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("The average of these number is" + (a + b + c + d) /4);
            
            Console.ReadKey();
        }

        private static bool Ex7()
        {
            Console.WriteLine("Please enter a number");
            int a = int.Parse(Console.ReadLine());

            bool z = true;
            if (100 < a && a < 200)
            {
                return z;
            }

            else
            {
                z = false;
                return z;
            }



        }

        private static void Ex8()
        {
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            Console.WriteLine(day+" "+month+" "+year);
        }

        private static void Ex9()
        {
            Console.WriteLine("How old are you ?");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("You were born in " + (DateTime.Now.Year - y));

            Console.ReadKey();
        }

        private static void Ex10()
        {
            Console.WriteLine("Please enter a number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine((x + y) * z);
            Console.WriteLine((x + y) * (y + z));

            Console.ReadKey();
        }
    }
}

