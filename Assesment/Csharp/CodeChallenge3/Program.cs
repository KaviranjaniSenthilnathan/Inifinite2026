using System;

namespace CodeChallenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("......IPL PROGRAM.......");

            CricketTeam team = new CricketTeam();

            Console.Write("Enter number of matches: ");
            int n = Convert.ToInt32(Console.ReadLine());

            var result = team.Pointscalculation(n);

            Console.WriteLine($"Matches: {result.count}");
            Console.WriteLine($"Total: {result.sum}");
            Console.WriteLine($"Average: {result.average}");
            Console.WriteLine("\n.....FILE APPEND PROGRAM ......");

            FileAppend file = new FileAppend();
            file.AppendTextToFile("Ranjani.txt");
            Console.WriteLine("\n......MOBILE PHONE EVENT SYSTEM......");

            MobilePhone phone = new MobilePhone();

            phone.OnRing += new RingtonePlayer().PlayRingtone;
            phone.OnRing += new ScreenDisplay().ShowDisplay;
            phone.OnRing += new VibrationMotor().Vibrate;

            phone.ReceiveCall();
        }
    }
}