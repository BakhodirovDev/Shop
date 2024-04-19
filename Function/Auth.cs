using Shop.Interface;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Function
{
    public class Auth : IAuth
    {
        List<Users> userList=new List<Users>()
        {
            new Users()
            {
                Id= 777,
                FullName = "SystemAdmin",
                userName = "sysadmin",
                Password = "12345",
                PhoneNumber = "999090909",
                Email = "admin@gmail.com",
                Role=Role.SuperAdmin
            }
        };
        public bool Login(string username, string password)
        {
            Users? resultUser=userList.FirstOrDefault(m => m.userName == username && m.Password == password);
            if (resultUser?.Role==Role.SuperAdmin)
            {
                ChangeRole(UserShowLists(), RoleShow());
            }
            return false;
        }
        public void Register()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("        FullNameni kiriting: ");
            string FullName = Console.ReadLine();
            Console.Write("        UserName kiriting: ");
            string userName = Console.ReadLine();
            Console.Write("        Password kiriting: ");
            string Password = Console.ReadLine();
            Console.Write("        PhoneNumber kiriting: +998");
            string PhoneNumber = Console.ReadLine();
            Console.Write("        Email kiriting: ");
            string? Email = Console.ReadLine();

            Users users = new Users()
            {
                Id= int.Parse(PhoneNumber),
                FullName = FullName,
                userName = userName,
                Password = Password,
                PhoneNumber = PhoneNumber,
                Email = Email,
                Role=Role.Client
            };
            userList.Add(users);

        }
        public int ChangeRole(Users users,int role)
        {
            //Change roleni bajarib kelish
            return 0;
        }
        public Users UserShowLists()
        {
            foreach (Users user in userList) 
            {
                if (user.Role!=Role.SuperAdmin)
                {
                    Console.WriteLine($@"{user.Id}|{user.FullName}|{user.userName}|{user.Password}|{user.PhoneNumber}|{user.Email}|{user.Role}");
                }
            }
            Console.WriteLine();
            Console.Write("Id ni kiriting: ");
            int SelectedId=int.Parse(Console.ReadLine());
            //id ni tekshirish Exception bilan 
            Users resultUser = userList.FirstOrDefault(m => m.Id==SelectedId);

            return resultUser;

        }

        public int RoleShow()
        {
            int choose=2;
            Console.WriteLine("1=" + Role.Admin);
            Console.WriteLine("2=" + Role.Client);
            Console.Write("Rolni tanlang: ");
            try
            {
                choose = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("");
            }
            return choose;
        }

        internal void RegisterPage()
        {
            Notification notification = new Notification();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n");
            notification.Note("Ro'yxatdan o'tish sahifasiga xush kelibsiz.");
            Console.WriteLine("\n\n\n");
            Register();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n");
            notification.Success("Muvaffaqiyatli ro'yxatdan o'tdingiz.");
            Thread.Sleep(3000);
            Main_Shop.main();
        }

        internal void LoginPage()
        {
            Notification notification = new Notification();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n");
            notification.Note("Tizimga kirish sahifasiga xush kelibsiz.");
            Console.WriteLine("\n\n\n");
            Console.Write("        UserName kiriting: ");
            string username = Console.ReadLine();
            Console.Write("        Password kiriting: ");
            string password = Console.ReadLine();
            Login(username, password);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n");
            notification.Success("Muvaffaqiyatli tizimga kirdingiz.");
            Thread.Sleep(3000);
            Main_Shop.main();
        }
    }
}
