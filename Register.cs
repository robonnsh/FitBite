using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FitBite
{
    internal class Register
    {

        public List<User> RegisteredUser { get; set; } = new List<User>();

        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $@"\registered users.xml";
        XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
        FileStream stream = null;

        UserInfo info = new UserInfo();

        public void RegisterUser(User user)
        {

            if (File.Exists(path))
            {
                stream = File.OpenRead(path);
                RegisteredUser = (List<User>)serializer.Deserialize(stream);
                stream.Dispose();
                if (RegisteredUser.Any(u => u.Name == user.Name || u.Email == user.Email))
                {
                    Console.WriteLine("User with this name or email is already registered. ");
                    return;
                }
            }
            if (RegisteredUser.Find(i => i.ToString() == user.ToString()) == null)
            {
                RegisteredUser.Add(user);
                stream = File.Create(path);
                serializer.Serialize(stream, RegisteredUser);
                stream.Dispose();
                Console.WriteLine("Registration completed successfully");

            }
        }

        public void UserLogin(string email, string password)
        {

            stream = File.OpenRead(path);
            RegisteredUser = (List<User>)serializer.Deserialize(stream);
            stream.Dispose();
            var user = RegisteredUser.FirstOrDefault(u => u.Email == email &&
            u.Password == password);

            if (user != null)
            {
                Console.Clear();
                Console.WriteLine($"Welcome {user.Name}");
                Console.WriteLine();
                Console.WriteLine("In order to use --FitBite-- please fill out following information");
                info.AdditionalInfo();
                info.ProcessOptions();
            }
            else
            {
                Console.WriteLine("User not found");
                return;
            }
        }

    }

}


