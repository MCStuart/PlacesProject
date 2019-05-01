using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Places.Controllers;
using Places.Models;

namespace Places.Tests
{
    [TestClass]
    public class CitiesControllerTest
    {

      [TestMethod]
      public void Create_ReturnsCorrectActionType_RedirectToActionResult()
      {
          //Arrange
          CitiesController controller = new CitiesController();

          //Act
          IActionResult view = controller.Create("Walk the dog");

          //Assert
          Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
      }

      [TestMethod]
      public void Create_RedirectsToCorrectAction_Index()
      {
          //Arrange
          CitiesController controller = new CitiesController();
          RedirectToActionResult actionResult = controller.Create("Walk the dog") as RedirectToActionResult;

          //Act
          string result = actionResult.ActionName;

          //Assert
          Assert.AreEqual(result, "Index");
      }

    }
}
