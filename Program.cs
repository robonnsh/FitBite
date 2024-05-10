using FitBite;
using System.Security.Cryptography.X509Certificates;

// Login or Register, save user in File - path --Desktop, xml file--

Register register = new Register();
User newUser = new User();
Console.WriteLine("\t\t---------- Welcome to FitBite ----------");
Console.WriteLine("");
Console.WriteLine("In order to use FitBite please Log in or Register");
Console.WriteLine("");
bool isValid = false;
while (!isValid)
{
    Console.WriteLine("For Log in enter 1");
    Console.WriteLine("For Register enter 2");
    int userOption = int.Parse(Console.ReadLine());
    if (userOption == 1)
    {
        Console.Clear();
        Console.WriteLine("\t------ You've been redirected to Login page ------");
        Console.WriteLine("");
        newUser.LoginCredentials();
        register.UserLogin(newUser.Email, newUser.Password);
        isValid = true;
    }
    if (userOption == 2)
    {
        Console.Clear();
        Console.WriteLine("\t------ You've been redirected to Register page ------");
        Console.WriteLine("");
        newUser.UserCredentials();
        register.RegisterUser(newUser);
        isValid = true;
    }

}




