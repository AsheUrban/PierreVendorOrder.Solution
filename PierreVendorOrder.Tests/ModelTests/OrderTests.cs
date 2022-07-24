using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreVendorOrder.Models;

namespace PierreVendorOrder.Tests
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
      Order newOrder = new Order("test", "test", "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "4 bags of flour.";
      string price = "test";
      string date = "test";
      Order newOrder = new Order(description, price, date);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "4 bags of flour.";
      string price = "test";
      string date = "test";
      Order newOrder = new Order(description, price, date);
      string updatedDescription = "6 bags of flour & 2 loaves of bread.";

      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void SetPrice_SetPrice_String()
    {
      string description = "4 bags of flour.";
      string price = "test";
      string date = "test";
      Order newOrder = new Order(description, price, date);
      string updatedPrice = "test2";
      newOrder.Price = updatedPrice;
      string result = newOrder.Price;
      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void SetDate_SetDate_String()
    {
      string description = "4 bags of flour.";
      string price = "test";
      string date = "test";
      Order newOrder = new Order(description, price, date);
      string updatedDate = "test2";
      newOrder.Date = updatedDate;
      string result = newOrder.Date;
      Assert.AreEqual(updatedDate, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string description01 = "4 loaves of bread.";
      string price01 = "test01";
      string date01 = "test01";
      string description02 = "2 loaves of bread.";
      string price02 = "test02";
      string date02 = "test02";
      Order newOrder1 = new Order(description01, price01, date01);
      Order newOrder2 = new Order(description02, price02, date02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string description = "4 loaves of bread.";
      string price = "test";
      string date = "test";
      Order newOrder = new Order(description, price, date);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrders_Order()
    {
      string description01 = "4 loaves of bread.";
      string price01 = "test01";
      string date01 = "test01";
      string description02 = "2 loaves of bread.";
      string price02 = "test02";
      string date02 = "test02";
      Order newOrder1 = new Order(description01, price01, date01);
      Order newOrder2 = new Order(description02, price02, date02);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}