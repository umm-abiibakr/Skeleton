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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create the item of test data 
            clsOrders TestItem = new clsOrders();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Complete = true;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.TotalAmount = 1.00m;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Status = "Processing";
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create the item of test data 
            clsOrders TestItem = new clsOrders();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Complete = true;
            TestItem.CustomerId = 1;
            TestItem.TotalAmount = 1.00m;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Status = "Processing";
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //modify the test record
            TestItem.Complete = false;
            TestItem.CustomerId = 3;
            TestItem.TotalAmount = 3.00m;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Status = "Cancelled";
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create the item of test data 
            clsOrders TestItem = new clsOrders();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Complete = true;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.TotalAmount = 1.00m;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Status = "Processing";
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod] 
        public void ReportByStatusMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create an instance of the filtered data 
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //apply a blank string (should return all records)
            FilteredOrders.ReportByStatus("");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByStatusNoneFound()
        {
            //create an instance of the class we want to create
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //apply a status that does not exist
            FilteredOrders.ReportByStatus("Abort");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByStatusTestDataFound()
        {
            //create an instance of the filtered data
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a status that does not exist
            FilteredOrders.ReportByStatus("Finished");
            //check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                //check to see that the first record is 146
                if (FilteredOrders.OrdersList[0].OrderId != 4533)
                {
                    OK = false;
                }
                //check to see that the first record is 147
                if (FilteredOrders.OrdersList[1].OrderId != 4534)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
