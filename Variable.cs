using System;

namespace Variables
{
  public class Variable
  {
    public static void Other(string[] args)
    {
     var numbersOfCupsOfCoffee = 4;
     var fullName = "Daniel Dean Demerin";
     DateTime date1 = DateTime.Now;
     var today = date1;
     Console.WriteLine(fullName
         + " has had "
         + numbersOfCupsOfCoffee
         + " cups of coffee on "
         + today + ".");
     //Welcome user
     Console.WriteLine("Hey there, new user!");
     //Ask user their name
     Console.WriteLine("What's your name?");
     var user = Console.ReadLine();
     //Print out greeting with user's name
     if (user == "Alice") {
       Console.WriteLine("Welcome to Wonderland, Alice!");
     }
     Console.WriteLine("Nice to meet you " + user + "!");
     //Ask user to input two numbers
     Console.WriteLine("Pick a number between 1 and 50.");
     var firstNumber = Console.ReadLine();
     Console.WriteLine("Pick another number between 51 and 100.");
     var secondNumber = Console.ReadLine();
     //Convert a String into a double
     var operand1 = double.Parse(firstNumber);
     var operand2 = double.Parse(secondNumber);
     var sum = operand1 + operand2;
     var difference = operand2 - operand1;
     var quotient = operand2 / operand1;
     var product = operand1 * operand2;
     var remainder = operand1 % operand2;
     //Print all results in a meaningful way.
     Console.WriteLine("Why did I ask for these random numbers you ask? To make use of the double.Parse method, my dear friend!");
     Console.WriteLine("Lets see how double.Parse works!");
     Console.WriteLine("Your sum is " + sum + ".");
     Console.WriteLine("Your difference is " + difference + ".");
     Console.WriteLine("Your quotient is " + quotient + ".");
     Console.WriteLine("Your product is " + product + ".");
     Console.WriteLine("And the remainder is " + remainder + ".");
     Console.WriteLine("See! Now, wasn't that fun?! ");
    }
  }
}
