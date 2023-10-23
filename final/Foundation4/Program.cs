using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Activity> list = new List<Activity>();
        
        Running run = new Running(3, 2023, 11, 15, 15);
        Cycling cyc = new Cycling(27, 2023, 12, 1, 30);
        Swimming swim = new Swimming(19, 2023, 10, 27, 45);

        list.Add(run);
        list.Add(cyc);
        list.Add(swim);

        foreach (Activity activity in list)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}