using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number to add?");
             int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Number to add to the first one?");
            int y = int.Parse(Console.ReadLine());

            int sum = Add(x, y);

            Console.WriteLine($"The sum of your numbers is {sum}."); 

            Console.WriteLine("Number to subtract?");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number to subtract from the first one?");
            int y1 = int.Parse(Console.ReadLine());

            int sub = Subtract(x1, y1);

            Console.WriteLine($"The difference of your numbers is {sub}.");

            Console.WriteLine("Number to multiply?");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number to multiply with the first one?");
            int y2 = int.Parse(Console.ReadLine());

            int mul = Multiply(x2, y2);

            Console.WriteLine($"The product of your numbers is {mul}.");


            Console.WriteLine("Number to divide?");
            int x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number to divide with the first one?");
            int y3 = int.Parse(Console.ReadLine());

            int div = Divide(x3, y3);

            Console.WriteLine($"The dividend is {div}.");

            Console.WriteLine("Number to do whatever modulous does?");
            int x4 = int.Parse(Console.ReadLine());
            Console.WriteLine("What's another number you'd like to include in the equation?");
            int y4 = int.Parse(Console.ReadLine());

            int modu = Mod(x4, y4);

            Console.WriteLine($"The modulus? of your numbers is {modu}.");

            Console.WriteLine("Number for a bonus problem?");
            int x5 = int.Parse(Console.ReadLine());
            Console.WriteLine("What's another number you'd like to include?");
            int y5 = int.Parse(Console.ReadLine());

            Console.WriteLine("How about another one?");
            int y6 = int.Parse(Console.ReadLine());

            Console.WriteLine("And another one?");
            int y7 = int.Parse(Console.ReadLine());

            int done = bonus(x5, y5, y6, y7);

            Console.WriteLine($"The bonus number is {done}.");

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine($"Hi! My name is {name}! I'm a human who lives on planet earth. Even though you didn't ask, I'm about to share a bunch of useless facts about me!");
            Console.WriteLine($"First of all, my favorite color is {color}.");
            Console.WriteLine($"My favorite animal is {animal} and my favorite band is {band}.");
        }

        public static int Add(int x, int y)
        {
            int add = x + y;
            return add;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;

        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }
       public static int Divide(int x, int y)
        {
            return x / y;

        }

        public static int Mod(int x, int y)
        {
            return x % y;

        }

        public static int bonus(params int[] list)
        {
            int bonus = 0; 
            for (int i = 0; i < list.Length; i++)
            {
                bonus = bonus + list[i];
            }
            return bonus;
        }

    }
}
