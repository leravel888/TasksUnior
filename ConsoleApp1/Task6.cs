using System;

namespace ConsoleApp1
{
    class Task6
    {
        static void Main()
        {
            int countOfImages = 52;
            int countOfImagesInRow = 3;
            int heightImage = 10;
            int heightWindow = Console.WindowHeight;

            int filledRows = heightWindow / heightImage;
            int outputImages = filledRows * countOfImagesInRow;

            int excessImages = countOfImages - outputImages;

            Console.WriteLine("Кол-во заполненных рядов - " + filledRows);
            Console.WriteLine("Кол-во лишних картинок - " + excessImages);

            Console.ReadLine();

        }
    }
}
