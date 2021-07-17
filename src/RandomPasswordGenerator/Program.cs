using System;
using SilentDevNull.Utilities.Security;

namespace RandomPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Random Length");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword()}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Password Length 10");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(10)}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(10)}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(10)}");
            Console.WriteLine();
            Console.WriteLine("Password length 15");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(15)}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(15)}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(15)}");
            Console.WriteLine();
            Console.WriteLine("Password length 20");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(20)}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(20)}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(20)}");
            Console.WriteLine();
            Console.WriteLine("Password length 25");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(25)}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(25)}");
            Console.WriteLine($"{RandomPassword.CreateRandomPassword(25)}");
            Console.WriteLine();
        }
    }
}
