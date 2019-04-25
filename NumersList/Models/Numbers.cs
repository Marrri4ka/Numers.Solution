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
      string res="";
      if(_userNumber == 3)
      {
        res="three";
      }
      return res;
    }
  }
}
