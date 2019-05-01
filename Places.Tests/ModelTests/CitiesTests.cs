using Microsoft.VisualStudio.TestTools.UnitTesting;
using Places.Models;
using System.Collections.Generic;
using System;

namespace Places.Tests
{
  [TestClass]
  public class CityTest : IDisposable
  {

    public void Dispose()
    {
      City.ClearAll();
    }

    [TestMethod]
    public void CityConstructor_CreatesInstanceOfCity_City()
    {
      City newCity = new City("test");
      Assert.AreEqual(typeof(City), newCity.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      City newCity = new City(description);

      //Act
      string result = newCity.GetDescription();

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      City newCity = new City(description);

      //Act
      string updatedDescription = "Do the dishes";
      newCity.SetDescription(updatedDescription);
      string result = newCity.GetDescription();

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_CityList()
    {
      //Arrange
      List<City> newList = new List<City> { };

      //Act
      List<City> result = City.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsCities_CityList()
    {
      //Arrange
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      City newCity1 = new City(description01);
      City newCity2 = new City(description02);
      List<City> newList = new List<City> { newCity1, newCity2 };

      //Act
      List<City> result = City.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_CitiesInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string description = "Walk the dog.";
      City newCity = new City(description);

      //Act
      int result = newCity.GetId();

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectCity_City()
    {
      //Arrange
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      City newCity1 = new City(description01);
      City newCity2 = new City(description02);

      //Act
      City result = City.Find(2);

      //Assert
      Assert.AreEqual(newCity2, result);
    }

  }
}
