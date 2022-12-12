using System;

namespace Seminar7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter nums");
            string? str = Console.ReadLine();
            int num = Convert.ToInt32(str);
            System.Console.WriteLine(num);
            if (TryParse(str, out num))
            {
                System.Console.WriteLine(num);
            }
            var tmp = new int[10,10];
    
        }

        static bool TryParse(string str, out int num)
        {
            try
            {
                num = int.Parse(str);
                return true;
            }
            catch
            {
                num = 0;
                return false;

            }

        }
    }
}
