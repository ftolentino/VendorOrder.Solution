using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresVendors.Models;
using System;

namespace PierresVendors.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      DateTime date = new DateTime(2022, 07, 24);
      Order newOrder = new Order("Chocoalte", 4, "Donut Order", date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string title = "Donut Order";
      string description = "Donut";
      double price = 4;
      DateTime date = new DateTime(2022, 07, 24);

      //Act
      Order newOrder = new Order(description, price, title, date);
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Donut";
      double price = 4;
      string title = "Donut Order";
      DateTime date = new DateTime(2022, 07, 24);
      Order newOrder = new Order(description, price, title, date);

      //Act
      string updatedDescription = "Do the dishes";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string description01 = "Donut1";
      double price01 = 4;
      string title01 = "Donut Order1";
      DateTime date01 = new DateTime(2022, 07, 24);

      string description02 = "Donut2";
      string title02 = "Donut Order2";
      DateTime date02 = new DateTime(2022, 07, 24);
      double price02 = 4;
      Order newOrder1 = new Order(description01, price01, title01, date01);
      Order newOrder2 = new Order(description02, price02, title02, date02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturn_Int()
    {
      string description = "Donut";
      double price = 4;
      string title = "Donut Order";
      DateTime date = new DateTime(2022, 07, 24);
      Order newOrder = new Order(description, price, title, date);
      int result = newOrder.Id;
      Assert.AreEqual(1,result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectItem_Order()
    {
      //Arrange
      string description01 = "Donut1";
      double price01 = 4;
      string title01 = "Donut Order1";
      DateTime date01 = new DateTime(2022, 07, 24);
      string description02 = "Donut2";
      string title02 = "Donut Order2";
      DateTime date02 = new DateTime(2022, 07, 24);
      double price02 = 4;
      Order newOrder1 = new Order(description01, price01, title01, date01);
      Order newOrder2 = new Order(description02, price02, title02, date02);

      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }

    // [TestMethod]
    // public void GetPrice_OrderReturnPrice_Double()
    // {
    //   double price = 4.75;
    //   Order newOrder = new Order(price);
    //   double result = newOrder.Price;
    //   Assert.AreEqual(newOrder, result);
    // }
  }
}