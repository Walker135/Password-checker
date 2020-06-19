using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "1234567890";
      string specialChars = "!£$%^&*()_-+={}[]:;@'~#<,>.?/| \\ ¬`";

      Console.WriteLine("Please enter password: ");
      string password = Console.ReadLine();

      int score = 0;
      int length = password.Length; 

      if (length >= minLength)
        score ++;
      if (Tools.Contains(password, uppercase))
        score ++;
      if (Tools.Contains(password, lowercase))
        score ++;
      if (Tools.Contains(password, digits))
        score ++;
      if (Tools.Contains(password, specialChars))
        score ++;

      if (password == "password")
        score = 0;
      if (password == "1234")
        score = 0;
      
      Console.Write("Password strength is: ");
      switch (score)
      {
        case 5:
        Console.WriteLine("Extremely Strong");
        break;
        
        case 4:
        Console.WriteLine("Extremely Strong");
        break;

        case 3:
        Console.WriteLine("Strong");
        break;

        case 2:
        Console.WriteLine("Medium");
        break;

        case 1:
        Console.WriteLine("Weak");
        break;

        default:
        Console.WriteLine("Don't meet standards");
        break;
      }        
    }
  }
}
