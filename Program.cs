using System;

class Program
{
    const string USERNAME = "rya"; 
    const string PASSWORD = "123"; 
    static int generatedOTP;

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Aon's first class Task...!");

        string username = PromptForUsername();
        string password = PromptForPassword();

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            Console.WriteLine("Username or password cannot be empty.");
            return;
        }

        if (username != USERNAME || password != PASSWORD)
        {
            Console.WriteLine("Invalid username or password. Access denied.");
            return;
        }

        generatedOTP = GenerateOTP();
        Console.WriteLine($"Your OTP is: {generatedOTP}");

        if (ValidateOTP())
        {
            Console.WriteLine("Success! You are logged in.");
        }
        else
        {
            Console.WriteLine("Invalid OTP. Access denied.");
        }
    }

    static string PromptForUsername()
    {
        Console.Write("Enter your username: ");
        return Console.ReadLine();
    }

    static string PromptForPassword()
    {
        Console.Write("Enter your password: ");
        return Console.ReadLine();
    }

    static int GenerateOTP()
    {
        Random random = new Random();
        return random.Next(10, 90); 
    }

    static bool ValidateOTP()
    {
        Console.Write("Enter the OTP: ");
        string inputOTP = Console.ReadLine();

        return inputOTP == generatedOTP.ToString();
    }
}
