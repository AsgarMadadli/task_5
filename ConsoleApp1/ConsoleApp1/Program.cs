using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Tarih girin (dd _ MM _ yyyy):");
        string userInput = Console.ReadLine();

        try
        {
            DateTime date = DateTime.ParseExact(userInput, "dd _ MM _ yyyy", null);
            Console.WriteLine("Tarih: " + date.ToString());
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Beklenmeyen bir hata oluştu: " + ex.Message);
        }
    }
}