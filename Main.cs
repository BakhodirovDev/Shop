using Shop.Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Shop
{
    internal class Main_Shop
    {
        public static void main()
        {
            Auth auth = new Auth();
            Notification Notification = new Notification();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n");
            Notification.Note("Assalomu alaykum Online Shopping Systemga xush kelibsiz.");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n       +--------------------------------------------------------------+");
            Console.WriteLine("       |                                                              |");
            Console.WriteLine("       |   1.Tizimga kirish                                           |");
            Console.WriteLine("       |                                                              |");
            Console.WriteLine("       |   2.Ro'yxatdan o'tish                                        |");
            Console.WriteLine("       |                                                              |");
            Console.WriteLine("       +--------------------------------------------------------------+\n\n\n");
            Console.Write("\n        Tanlang: ");

            try
            {
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        auth.LoginPagec();
                        break;
                    case 2:
                        auth.RegisterPage();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Notification.Error("Faqat 1 va 2 raqamlaridan foydalaning.");
                        Thread.Sleep(3000);
                        main();
                        break;
                }
            }
            catch
            {
                Console.Clear();
                Notification.Error("Faqat 1 va 2 raqamlaridan foydalaning.");
                Thread.Sleep(3000);
                main();
            }

        }   
    }
}
