using System;

namespace ConsoleApp1
{
    class Task8
    {
        static void Main()
        {
            int countPeople;
            int minutesInHour = 60;
            int timeOfReception = 10;
            string waitTime;

            Console.Write("Кол-во людей в очереди - ");
            countPeople =Int32.Parse(Console.ReadLine());

            waitTime = "Осталось ждать "+(countPeople * timeOfReception) / minutesInHour + " час(а) " 
            + (countPeople * timeOfReception) % minutesInHour + " минут.";
            Console.WriteLine(waitTime);

            Console.ReadLine();
        }
    }
}
