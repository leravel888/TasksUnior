using System;

namespace ConsoleApp1
{
    class Task4v2
    {

        static void Main(string[] args)
        {
            string name;
            string zodiacSign;
            string age;
            string favoriteMovie;

            Console.Write("Как вас зовут - ");
            name = Console.ReadLine();

            Console.Write("Какой ваш знак зодиака - ");
            zodiacSign = Console.ReadLine();

            Console.Write("Сколько вам лет - ");
            age = Console.ReadLine();

            Console.Write("Какой ваш любимый фильм - ");
            favoriteMovie = Console.ReadLine();

            Console.WriteLine("Вас зовут {0}, по знаку зодиака вы {1}, вам {2}, ваш любимый фильм \"{3}\".",
            name, zodiacSign, age, favoriteMovie);


            Console.ReadKey();

        }




    }
}
