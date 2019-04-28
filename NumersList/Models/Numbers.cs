using System;
using System.Collections.Generic;

namespace NumbersList.Models
{
  public class List // class
  {
    private int _userNumber; // property

    public List ( int userNumber) // constructor
    {
      _userNumber = userNumber;
    }


    public string GetValue()
    {

      char[] newChar = _userNumber.ToString().ToCharArray();


      Dictionary<int, string> dict = new Dictionary<int, string>();
      dict.Add(1,"one");
      dict.Add(2,"two");
      dict.Add(3,"three");
      dict.Add(4,"four");
      dict.Add(5,"five");
      dict.Add(6,"six");
      dict.Add(7,"seven");
      dict.Add(8,"eight");
      dict.Add(9,"nine");
      dict.Add(10,"ten");
      dict.Add(11,"eleven");
      dict.Add(12,"twelve");
      dict.Add(13,"thirteen");
      dict.Add(14,"fourteen");
      dict.Add(15,"fifteen");



      Dictionary<int, string> dict1 = new Dictionary<int, string>();
      dict1.Add(2,"twenty");
      dict1.Add(3,"thirty");
      dict1.Add(4,"fourty");
      dict1.Add(5,"fifty");
      dict1.Add(6,"sixty");
// 56
          int numOne = int.Parse(newChar[0].ToString()); //5
          int numTwo = int.Parse(newChar[1].ToString()); //6


          return  dict1[numOne] + dict[numTwo];

    }

  }
}
