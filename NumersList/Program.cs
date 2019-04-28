
using System;
using System.Collections.Generic;
namespace NumbersList.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine ("Please enter your number");
      int UserNumber = int.Parse(Console.ReadLine());
      List newList = new List(UserNumber);
      Console.WriteLine ("Your result is" + " " + newList.GetValue());
    }
  }
}
