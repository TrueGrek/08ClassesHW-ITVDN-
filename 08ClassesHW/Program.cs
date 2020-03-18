using System;

namespace _08ClassesHW
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday;
            DateTime now = DateTime.Now;
            TimeSpan wait;
            Console.WriteLine("Введите свою дату рождения в формате гггг, мм, дд : ");
            birthday = Convert.ToDateTime(Console.ReadLine());
            DateTime thisyear = new DateTime(now.Year, birthday.Month, birthday.Day);
            if (thisyear< now)
            {
                DateTime Plusthisyear = new DateTime(now.Year + 1, birthday.Month, birthday.Day);
                wait = Plusthisyear - now;
            }
            else wait = thisyear - now;
            Console.WriteLine("До вашего рождения осталось: {0} дня", wait.Days);



        }
    }
}
