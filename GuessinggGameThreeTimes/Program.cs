using System;

namespace GuessinggGameThreeTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja pole suutnud kolme katsega nr ära arvata, siis mängu võidab arvuti;
            //*programm genereerib juhuslikku numbrit vaid üks kord.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta number, mis sa arvad, et arvuti pakub:");
                int guessedNumber = Convert.ToInt32(Console.ReadLine());

                if (cpuNumber == guessedNumber)
                {
                    Console.WriteLine("Palju õnne, oled mängu võitnud!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale number. {3 - i} katset on jäänud.");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
