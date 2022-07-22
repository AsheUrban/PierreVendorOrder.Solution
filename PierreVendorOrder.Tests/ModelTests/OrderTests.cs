using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreVendorOrder.Models;

namespace PierreVendorOrder.Tests
{
  [TestClass]
  public class OrderTests
  {

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "4 bags of flour.";
      Order newOrder = new Order(description);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    

  }
}