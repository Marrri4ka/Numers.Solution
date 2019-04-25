using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using NumbersList.Models;

namespace Items.Tests
{
  [TestClass]
  public class ListTest
  {
    [TestMethod]
    public void GetValue_Test()
    {
      //Arrange
      List newList = new List (21);
      // Act
      string result = newList.GetValue();

      // Assert
      Assert.AreEqual (result, "fifteen");
    }
  }
}
