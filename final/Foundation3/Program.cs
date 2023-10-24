using System;

class Program
{
    static void Main(string[] args)
    {
    Console.Clear();
    Lectures lec = new Lectures("Elon Musk", 1500, "Cyber Truck", "Showing the Power of new Tech", "11/22/2023", "8:30 p.m");
    lec.SetAddress("5th Street", "Reno", "Nevada", "USA");
    Console.WriteLine($"\n{lec.GetStandardDetails()}");
    Console.WriteLine($"\n{lec.GetShortDescription()}");
    lec.GetFullInformation();

    Receptions rec = new Receptions("cdodson@byui.edu", "Inheritance", "Display the use of Inheritance", "10/24/2023", "12:00 a.m");
    rec.SetAddress("25th Street", "Ogden", "Utah", "USA");
    Console.WriteLine($"\n{rec.GetStandardDetails()}");
    Console.WriteLine($"\n{rec.GetShortDescription()}");
    rec.GetFullInformation();   

    Outdoor outdoor = new Outdoor("Cloudy with a chance of thunderstorms", "Volleyball practice", "FHE group activity", "10/24/2023", "7:00pm");
    outdoor.SetAddress("Pařížská", "Prauge", "Praha", "Cezhia");
    Console.WriteLine($"\n{outdoor.GetStandardDetails()}");
    Console.WriteLine($"\n{outdoor.GetShortDescription()}");
    outdoor.GetFullInformation(); 

    }
}