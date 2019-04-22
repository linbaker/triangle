using System;
using System.Collections.Generic;

namespace Geometry {

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter length of side one: ");
      string sideOneLength = Console.ReadLine();
      int sideOne = int.Parse(sideOneLength);

      Console.WriteLine("Enter length of side two: ");
      string sideTwoLength = Console.ReadLine();
      int sideTwo = int.Parse(sideTwoLength);

      Console.WriteLine("Enter length of side three: ");
      string sideThreeLength = Console.ReadLine();
      int sideThree = int.Parse(sideThreeLength);

      if (sideOne + sideTwo <= sideThree || sideTwo + sideThree <= sideOne || sideOne + sideThree <= sideTwo) {
     Console.WriteLine("That is not a triangle.");
   } else if (sideOne == sideTwo && sideOne == sideThree) {
      Console.WriteLine("That is an equalaterial triangle.");
    } else if (sideOne == sideTwo && sideOne > sideThree) {
      Console.WriteLine("That is an isosceles triangle.");
    } else if (sideOne == sideThree && sideOne > sideTwo) {
      Console.WriteLine("That is an isosceles triangle.");
    } else if (sideTwo == sideThree && sideTwo > sideOne) {
      Console.WriteLine("That is an isosceles triangle.");
    } else if (sideOne != sideTwo && sideTwo != sideThree && sideOne != sideThree) {
      Console.WriteLine("That is a scalene triangle.");
    } else {
      Console.WriteLine("Invalid input try again");
    }
    }
  }

}
