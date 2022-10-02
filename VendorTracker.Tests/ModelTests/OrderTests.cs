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
      Order newOrder = new Order("test", "test details", 20, 10-01-22);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Croissants";
      string details = "The Flaky Ones";
      int price = 20;
      int date = 10-01-22;
      Order newOrder = new Order(description, details, price, date);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetDetails_ReturnsDetails_String()
    {
      string description = "Croissants";
      string details = "The Flaky Ones";
      int price = 20;
      int date = 10-01-22;
      Order newOrder = new Order(description, details, price, date);
      string result = newOrder.Details;
      Assert.AreEqual(details, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      string description = "Croissants";
      string details = "The Flaky Ones";
      int price = 20;
      int date = 10-01-22;
      Order newOrder = new Order(description, details, price, date);
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_Int()
    {
      string description = "Croissants";
      string details = "The Flaky Ones";
      int price = 20;
      int date = 10-01-22;
      Order newOrder = new Order(description, details, price, date);
      int result = newOrder.Date;
      Assert.AreEqual(date, result);
    }


    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Croissants";
      string details = "The Flaky Ones";
      int price = 20;
      int date = 10-01-22;
      Order newOrder = new Order(description, details, price, date);
      string updatedDescription = "Big Croissants";
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
        string details01 = "The Flaky Ones";
        int price01 = 20;
        int date01 = 10-01-22;
        string description02 = "Muffins";
        string details02 = "Blueberry";
        int price02 = 30;
        int date02 = 10-31-22;
        Order newOrder1 = new Order(description01, details01, price01, date01);
        Order newOrder2 = new Order(description02, details02, price02, date02);
        List<Order> newList = new List<Order> { newOrder1, newOrder2 };
        List<Order> result = Order.GetAll();
        CollectionAssert.AreEqual(newList, result);
      }

      [TestMethod]
      public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
      {
        string description = "Croissants";
        string details = "The Flaky Ones";
        int price = 20;
        int date = 10-01-22;
        Order newOrder = new Order(description, details, price, date);
        int result = newOrder.Id;
        Assert.AreEqual(1, result);
      }

      [TestMethod]
      public void Find_ReturnsCorrectOrder_Order()
      {
        string description01 = "Croissants";
        string details01 = "The Flaky Ones";
        int price01 = 20;
        int date01 = 10-01-22;
        string description02 = "Muffins";
        string details02 = "Blueberry";
        int price02 = 30;
        int date02 = 10-31-22;
        Order newOrder1 = new Order(description01, details01, price01, date01);
        Order newOrder2 = new Order(description02, details02, price02, date02);
        Order result = Order.Find(2);
        Assert.AreEqual(newOrder2, result);
      }
  }
}
