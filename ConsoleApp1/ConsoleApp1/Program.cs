using System;

namespace l_2_t_2
{
    class Program
    {
        static void Main()
        {
            bool t = true;

            while (t)
            {

                Console.WriteLine("введите:\n1 - ввести координаты\nлюбое другое число - выход");

                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {

                    case 1:
                        Console.WriteLine("введите координату х: ");
                        double x = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("введите координату y: ");
                        double y = Convert.ToDouble(Console.ReadLine());

                        double res = Class1.check(x, y);

                        if (res == 1)
                        {
                            Console.WriteLine("да");
                        }
                        else if (res == 0)
                        {
                            Console.WriteLine("на границе");
                        }
                        else
                        {
                            Console.WriteLine("нет");
                        }

                        break;

                    default:
                        break;

                }

                Console.WriteLine("введите:\n1 - продолжить\nлюбое другое число - закончить");

                int b = Convert.ToInt32(Console.ReadLine());

                if (b == 1) t = true;
                else t = false;



            }
        }
    }
}

