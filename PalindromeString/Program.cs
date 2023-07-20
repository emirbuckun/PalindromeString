using System.Text;

namespace PalindromeString
{
  internal class Program
  {
    private static void Main()
    {
      Console.Write("Enter an input: ");
      string? input = Console.ReadLine();

      if (input != null)
      {
        bool result = IsPalindrome(input);

        // Print Result
        if (result) Console.WriteLine("String is Palindrome");
        else Console.WriteLine("String is not Palindrome");
      }
      else Console.WriteLine("Wrong input!");
    }

    private static bool IsPalindrome(string input)
    {
      StringBuilder stringBuilder = new();
      int inputLength = input.Length;

      for (int i = inputLength - 1; i >= 0; i--)
        stringBuilder.Append(input[i]);

      return input.Equals(stringBuilder.ToString());
    }
  }
}