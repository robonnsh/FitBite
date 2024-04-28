using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBite
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        //private bool IsValidEmail(string email)
        //{
        //    string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
        //    return Regex.IsMatch(email, emailPattern);
        //}
        public void UserCredentials()
        {
            Console.WriteLine("Enter your name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your email: ");
            Email = Console.ReadLine();
            //while (!IsValidEmail(email))
            //    //{
            //    //    Console.WriteLine("Please enter a valid email");
            //    //    email = Console.ReadLine();
            //    //}
            Console.WriteLine("Enter your password: ");
            Password = Console.ReadLine();
        }
        
        public void LoginCredentials()
        {
            Console.WriteLine("Enter your email: ");
            Email = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            Password = Console.ReadLine();
        }
        
    }
}
