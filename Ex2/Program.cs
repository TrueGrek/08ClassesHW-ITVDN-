using System;
using System.Threading;
namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку и цвет через запятую: ");
            Random rand = new Random();
            while (true)
            {
                MyClass.Print("Дядя Пул", rand.Next(0, 3));
                Thread.Sleep(1);
            }
        }
    }

    enum EnumType
    {
        Green,
        Blue,
        Red
    }

    static class MyClass
    {
        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case (0):
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case (1):
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case (2):
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default: Console.WriteLine("Разбойник, ты выходишь за массив!");
                    break;
            }
            for (int i = 0; i < 20; i++)
            {
                Console.Write(stroka);
            }
        }
     }
}
