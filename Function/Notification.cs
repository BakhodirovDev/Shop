using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Function
{
    public class Notification
    {

        public void Note(string message)
        {
            string eni = new string(' ', (62 - message.Length) / 2);
            Console.WriteLine("       +" + new string('-', 62) + "+");
            Console.WriteLine("       |" + new string(' ', 62) + "|");
            Console.WriteLine($"       |{eni}{message}{eni}|");
            Console.WriteLine("       |" + new string(' ', 62) + "|");
            Console.WriteLine("       +" + new string('-', 62) + "+");
            Console.ResetColor();
        }
        public void Success(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string eni = new string(' ', (62 - message.Length) / 2);
            Console.WriteLine("       +" + new string('-', 62) + "+");
            Console.WriteLine("       |" + new string(' ',62) + "|");
            Console.WriteLine($"       |{eni}{message}{eni}|");
            Console.WriteLine("       |" + new string(' ', 62) + "|");
            Console.WriteLine("       +" + new string('-', 62) + "+");
            Console.ResetColor();
        }

        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string eni = new string(' ', (62 - message.Length) / 2);
            Console.WriteLine("       +" + new string('-', 62) + "+");
            Console.WriteLine("       |" + new string(' ', 62) + "|");
            Console.WriteLine($"       |{eni}{message}{eni}|");
            Console.WriteLine("       |" + new string(' ', 62) + "|");
            Console.WriteLine("       +" + new string('-', 62) + "+");
            Console.ResetColor();
        }

        public void Warning(string message)
        {   
            Console.ForegroundColor = ConsoleColor.Yellow;
            string eni = new string(' ', (62 - message.Length) / 2);
            Console.WriteLine("       +" + new string('-', 62) + "+");
            Console.WriteLine("       |" + new string(' ', 62) + "|");
            Console.WriteLine($"       |{eni}{message}{eni}|");
            Console.WriteLine("       |" + new string(' ', 62) + "|");
            Console.WriteLine("       +" + new string('-', 62) + "+");
            Console.ResetColor();
        }
    }
}
