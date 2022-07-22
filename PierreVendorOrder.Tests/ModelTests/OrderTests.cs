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
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    
  }
}