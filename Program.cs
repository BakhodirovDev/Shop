﻿using Shop;

public class Program
{
    public static void Main()
    {
        try
        {
            // Behruz

            Console.Title = "Online Shopping System";
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Main_Shop.main();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}
