using System;

namespace l_2_t_1
{
    class Program
    {
        static void Main()
        {
            bool t = true;

            while (t)
            {

                Console.WriteLine("введите:\n1 - проверить двузначное число\nлюбое другое число - выход");

                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("введите двузначное число: ");
                        int a = Convert.ToInt32(Console.ReadLine());

                        if (a / 100 == 0 && a > 9 || a / 100 == 0 && a < -9)
                        {
                            int c = Class1.doSum(a);

                            if (c % 2 == 0)
                                Console.WriteLine($"сумма цифр числа {a} четная");
                            else
                                Console.WriteLine($"сумма цифр числа {a} нечетная");
                        }
                        else
                            Console.WriteLine("вы ввели не двузначное число!");

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














































