using System;
using System.Collections.Generic;

class TriangleTracker
{
  public static void Main()
  {
     Console.WriteLine("Welcome to the Triangle Tracker 2000.");   
     Console.WriteLine("Enter 3 side lengths seperated by spaces.");
     Console.Write("Lengths: ");
     string input = Console.ReadLine();  

     String[] results = input.Split(" ");
     List<int> intResults = new List<int>();

     if(results.Length > 3)
     {
        Console.WriteLine("You have entered too many numbers.");
        Console.WriteLine("Try again.");
        Console.Write("Lengths: ");
        input = Console.ReadLine();  
     } 
     else if (results.Length < 3) 
     {
       Console.WriteLine("You did not enter 3 sides.");
        Console.WriteLine("Try again.");
        Console.Write("Lengths: ");
        input = Console.ReadLine();  
     }

     foreach (string value in results)
     {
       int number;
       bool success = int.TryParse(value, out number);
       if(success)
       {
         intResults.Add(number);
       }
       else 
       {
         Console.WriteLine("Please only enter numbers");
       }
     }


     Console.WriteLine();
     Console.WriteLine(Tracker(intResults[0], intResults[1], intResults[2]));
     Console.WriteLine();

  }

  public static string Tracker(int side1, int side2, int side3)
  {
    if ( (side1 + side2) <= side3 || (side1 + side3) <= side2 || (side2 + side3) <= side1)
    {
      return "This is not a Triangle";
    } 
    else if (side1 == side2 && side2 == side3)
    {
      return "Equilateral Triangle";
    }
    else if (side1 == side2 || side1 == side3 || side2 == side3 )
    {
      return "Isosceles";
    }
    else 
    {
      return "Scalene";
    }
  }
}