using System;

namespace OOP_LR_ONE
{
    class Program
    {
        static void Main(string[] args)
        {
            double z, a_5 = 345, b = 8.5, y = 4 ;

            Console.WriteLine("Лабораторная работа 1. Разработка консольного приложения");
            Console.WriteLine("Перец Роман Валерьевич");
            Console.WriteLine("ИНС-б-о-18-1(2)");
            Console.WriteLine("14.10.2000");
            Console.WriteLine("Сторожевая");
            Console.WriteLine("Информатика, Математика, Биология");
            Console.WriteLine("Photoshop, English, reading books");
            z = a_5 + b - a_5 * (b + y);
            Console.WriteLine("a_5 = " + a_5 + "   b = " + b + "   y = " + y + "   z = " + z);
            Console.ReadKey();
        }
    }
}
