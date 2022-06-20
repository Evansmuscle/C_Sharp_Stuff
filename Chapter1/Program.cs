using System;

namespace Chapter1
{
    class Program
    {
        void Types()
        {
            int x;
            x = 10;

            int y = 20;
            int z = x + y;

            double height = 300.5;
            bool working = true;
            char symbol = '@';
            string name = "Khan";

            const double PI = 3.14159;

            // Type casting
            double a = 3.501;
            Int16 b = Convert.ToInt16(a);

            Console.WriteLine(b);
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string? name = Console.ReadLine();

            if (name != null)
            {
                Console.WriteLine("Your name is: " + name);
            }
        }
    }
}
