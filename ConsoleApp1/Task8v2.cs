using System;

namespace ConsoleApp1
{
    class Task8v2
    {
        static void Main()
        {
            int countPeople;
            int minutesInHour = 60;
            int timeOfReception = 10;
            int waitHours; 
            int waitMinutes; 

            Console.Write("Кол-во людей в очереди - ");
            countPeople =Int32.Parse(Console.ReadLine());

            waitHours = (countPeople * timeOfReception) / minutesInHour;
            waitMinutes = (countPeople * timeOfReception) % minutesInHour;

            Console.WriteLine("Осталось ждать {0} час(а) {1} минут.", waitHours, waitMinutes);

            Console.ReadLine();
        }
    }
}
