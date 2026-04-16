using System;
public class CricketTeam
{
    public (int count, double average, int sum) Pointscalculation(int no_of_matches)
    {
        int sum = 0;
        for (int i = 0; i < no_of_matches; i++)
        {
            Console.Write($"Enter score for match {i + 1}: ");
            sum += Convert.ToInt32(Console.ReadLine());
        }
        double avg = (double)sum / no_of_matches;
        return (no_of_matches, avg, sum);
    }
}