using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu;
            //*programm genereerib juhuslikku numbrit vaid üks kord.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            bool loopActive = true;
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Sisesta number, mis sa arvad, et arvuti pakub:");
                int guessedNumber = Convert.ToInt32(Console.ReadLine());

                if (cpuNumber == guessedNumber)
                {
                    Console.WriteLine("Palju õnne, õige number!");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale number, proovi uuesti.");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
