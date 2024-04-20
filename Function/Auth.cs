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
            Console.Write("Ism Familiyani kiriting : ");
            string FullName =Console.ReadLine();
            Console.Write("Usernameni kiriting : ");
            string userName =Console.ReadLine();
            Console.Write("Parolni kiriting : ");
            string Password =Console.ReadLine();
            Console.Write("Telefon nomerni kiriting : +998");
            string PhoneNumber =Console.ReadLine();
            Console.Write("Emailni kiriting : ");
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
    }
}
