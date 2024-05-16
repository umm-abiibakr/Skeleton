using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrdersCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //test to see that it exisits
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrdersListOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrders> TestList = new List<clsOrders>();
            //add an item to the list
            //create the item of the test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.Complete = true;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.TotalAmount = 1.00m;
            TestItem.Status = "Processing";
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrdersList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            clsOrders TestOrders = new clsOrders();
            //set the properties of the test object
            TestOrders.Complete = true;
            TestOrders.OrderId = 1;
            TestOrders.CustomerId = 1;
            TestOrders.OrderDate = DateTime.Now;
            TestOrders.TotalAmount = 1.00m;
            TestOrders.Status = "Processing";
            //assign the data to the property
            AllOrders.ThisOrder = TestOrders;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.ThisOrder, TestOrders);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsOrders> TestList = new List<clsOrders>();
            //add an item to the list
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //set the properties of the test object
            TestItem.Complete = true;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.TotalAmount = 1.00m;
            TestItem.Status = "Processing";
            //add the item to the property
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
    }
}
