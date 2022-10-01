using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Tests
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
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Croissants";
      Order newOrder = new Order(description);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Croissants";
      Order newOrder = new Order(description);
      string updatedDescription = "Muffins";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedDescription, result);
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
        string description01 = "Croissants";
        string description02 = "Muffins";
        Order newOrder1 = new Order(description01);
        Order newOrder2 = new Order(description02);
        List<Order> newList = new List<Order> { newOrder1, newOrder2 };
        List<Order> result = Order.GetAll();
        CollectionAssert.AreEqual(newList, result);
      }

      [TestMethod]
      public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
      {
        string description = "Croissants";
        Order newOrder = new Order(description);
        int result = newOrder.Id;
        Assert.AreEqual(1, result);
      }
  }
}
