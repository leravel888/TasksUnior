using System;

namespace ConsoleApp1
{
    class Task7
    {
        static void Main()
        {
            int countCoin;
            int countCrystal = 0;
            int priceCrystal = 13;
            int countCrystalsToBuy;

            Console.Write("Введите кол-во золота - ");
            countCoin =Int32.Parse(Console.ReadLine());

            Console.WriteLine("Цена одного кристалла - " + priceCrystal);
            Console.Write("Сколько кристаллов вы хотите купить - ");

            countCrystalsToBuy = Int32.Parse(Console.ReadLine());

            countCrystal += countCrystalsToBuy;
            countCoin -= countCrystalsToBuy * priceCrystal;

            Console.WriteLine("Осталось золота - {0}, кристаллов - {1} ",countCoin, countCrystal);

            Console.ReadLine();

        }
    }
}
