using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System.Collections.Generic;
using System;

namespace PierresVendors.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }
    
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Suzie", "Suzie's Donuts");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Suzie";
      string details = "Suzie's Donuts";
      Vendor newVendor = new Vendor(name, details);

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Suzy";
      string details= "Suzy's Donuts";
      Vendor newVendor = new Vendor(name, details);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name01 = "Suzy";
      string details01 = "Suzy's Donuts";
      string name02 = "John";
      string details02 = "John's Donuts";
      Vendor newVendor1 = new Vendor(name01, details01);
      Vendor newVendor2 = new Vendor(name02, details02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name01 = "Suzy";
      string details01 = "Suzy's Donuts";
      string name02 = "John";
      string details02 = "John's Donuts";
      Vendor newVendor1 = new Vendor(name01, details01);
      Vendor newVendor2 = new Vendor(name02, details02);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddItem_AssociatesItemWithCategory_ItemList()
    {
      //Arrange
      string description = "Donut.";
      double price = 4;
      string title = "Suzie's Donut";
      DateTime date = new DateTime(2022,07,24);
      Order newOrder = new Order(description, price, title, date);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Suzy";
      string details = "Suzy's Donuts";
      Vendor newVendor = new Vendor(name, details);
      newVendor.AddOrder(newOrder);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
