using Shop;
using Shop.Function;

public class Program
{
    public static void Main()
    {
        try
        {
            // Nazirov Elmurod
            // Nazirov Elmurod 2
            // Sulaymanov Islom
            // Abdullayev Hayotjon

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