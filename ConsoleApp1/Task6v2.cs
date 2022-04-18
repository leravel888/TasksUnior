using System;

namespace ConsoleApp1
{
    class Task6v2
    {
        static void Main()
        {
            int countOfImages = 52;
            int countOfImagesInRow = 3;

            int filledRows = countOfImages / countOfImagesInRow;
            int excessImages = countOfImages - (filledRows * countOfImagesInRow);

            Console.WriteLine("Кол-во заполненных рядов - " + filledRows);
            Console.WriteLine("Кол-во лишних картинок - " + excessImages);

            Console.ReadLine();
        }
    }
}
