using System;
 
namespace ConsoleApp1
{
    class Task4
    {       
        public string name;
        string zodiacSign;
        int age;
        string favoriteMovie;

        static void Main(string[] args)
        {
            Task4 user = new Task4() ;
            
            Console.Write("Как вас зовут - ");
            user.name = Console.ReadLine();

            Console.Write("Какой ваш знак зодиака - ");
            user.zodiacSign = Console.ReadLine();

            Console.Write("Сколько вам лет - ");
            user.age = user.ChekEnterAge(Console.ReadLine());

            Console.Write("Какой ваш любимый фильм - ");
            user.favoriteMovie = Console.ReadLine();
            
            Console.WriteLine("Вас зовут {0}, по знаку зодиака вы {1}, вам {2} {3}, ваш любимый фильм \"{4}\".", 
            user.name, user.zodiacSign, user.age, user.CheckDeclinationAge(user.age), user.favoriteMovie);
        

            Console.ReadKey();

        }

        public int ChekEnterAge(string ageString)
        {
            int ageInt = 0; 
            while (!int.TryParse(ageString, out ageInt) || !(ageInt > 3 && ageInt < 100))
            {
                Console.Write("Введите корректный возраст - ");
                ageString = Console.ReadLine();
            }
            return ageInt;
        }

        public string CheckDeclinationAge(int ageInt)
        {
            string declinationAge = "";

            if (ageInt % 10 == 1 && (ageInt % 100)/10 != 1)
            {
                declinationAge = "год";
            }
            else if ((ageInt % 10 >= 2 && ageInt % 10 <= 4) && (ageInt % 100) / 10 != 1)
            {
                declinationAge = "года";
            }
            else 
            {
                declinationAge = "лет";
            }

            return declinationAge;
        }

    }
}
