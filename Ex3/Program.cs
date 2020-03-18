using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите кол-во часов отработали: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Accauntant a = new Accauntant();

            if (a.AskForBonus(Post.Manager, hours)) { Console.WriteLine("Вам дают премию"); }
            else { Console.WriteLine("Вам дают по башке"); }
        }
    }
    enum Post
    {
        Manager = 100,
        Developer = 87,
        Sccountant = 67,
        Cleaner = 32
    }

    class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker < hours) { return true; }
            else { return false; }
        }
    }
}
