using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreVendorOrder.Models;
using System.Collections.Generic;
using System;

namespace PierreVendorOrder.Tests
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
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "New Seasons";
      string name02 = "Extracto";
      Vendor newVendor1 = new Vendor(name01);
      Vendor newVendor2 = new Vendor(name02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {

      string name01 = "New Seasons";
      string name02 = "Extracto";
      Vendor newVendor1 = new Vendor(name01);
      Vendor newVendor2 = new Vendor(name02);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string description = "4 loaves of bread.";
      string price = "test";
      string date = "test";
      Order newOrder = new Order(description, price, date);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Extracto";
      Vendor newVendor = new Vendor(name);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}