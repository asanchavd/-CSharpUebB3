namespace PProgUebB3;

public class Ueb1
{
    public static void LeapYear()
    {
        Console.Write("Geben Sie ein Jahr ein: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        {
            Console.WriteLine($"Das Jahr {year} ist Schaltjahr");
        }
        else
        {
            Console.WriteLine($"Das Jahr: {year} ist KEIN Schaltjahr");
        }
    }
}