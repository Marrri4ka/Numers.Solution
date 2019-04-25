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
      string result;
      char[] myWord = _userNumber.ToString().ToCharArray();

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
      string res2 = dict[myWord[1]];


      Dictionary<int, string> dict1 = new Dictionary<int, string>();
      dict.Add(20,"twenty");
      dict.Add(30,"thirty");
      dict.Add(40,"fourty");
      dict.Add(50,"fifty");
      dict.Add(60,"sixty");
      string res1 = dict[myWord[0]];
      result = res1 + res2;

 return result;

    }
  }
}
