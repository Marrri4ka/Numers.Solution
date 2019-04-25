using System;
using System.Collections.Generic;

namespace NumbersList.Models
{
  public class List // class
  {
    private int _userNumber; // property

    public List ( int userNumber) // constructor
    {
      _userNumber = int.Parse(userNumber);
    }


    public string GetValue()
    {
      string result="";

      if(_userNumber == 3)
      {
      result = "three";
      }
      return result;
    }
  }
}
