using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary.clsorderitems;

namespace Testing5
{
    internal class tstorderItemsCollection
    {
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsorderItemsCollection Allorderitems = new clsorderItemsCollection();
            //test to see that it exisits
            Assert.IsNotNull(Allorderitems);
        }

        [TestMethod]

        public void OrderItemsListOK()

        {

            //create an instance of the class we want to create

            clsorderItemsCollection AllOrderItems = new clsorderItemsCollection();

            //create some test data to assign to the property

            //in this case the data needs to be a list of objects

            List<clsOrderItems> TestList = new List<clsOrderItems>();

            //add an item to the list

            //create the item of the test data

            clsOrderItems TestItem = new clsOrderItems();

            //set its properties

            TestItem.orderItems_id = 1;

            TestItem.Quantity = "1";

            TestItem.Price = "1.00";

            TestItem.DispatchDate = DateTime.Now;

            TestItem.OrderReceived = true;

            //add the item to the property

            TestList.Add(TestItem);

            //assign the data to the property

            AllOrderItems.orderItems_List = TestList;

            //test to see that the two values are the same

            Assert.AreEqual(AllOrderItems.orderItems_List, TestList);

        }


        [TestMethod]

        public void ThisOrderItemPropertyOK()

        {

            //create an instance of the class we want to create

            clsorderItemsCollection AllOrderItems = new clsorderItemsCollection();

            //create some test data to assign to the property

            clsOrderItems TestOrderItems = new clsOrderItems();

            //set the properties of the test object

            TestOrderItems.orderItems_id = 1;

            TestOrderItems.Quantity = "1";

            TestOrderItems.Price = "1.00";

            TestOrderItems.DispatchDate = DateTime.Now;

            TestOrderItems.OrderReceived = true;

            //assign the data to the property

            AllOrderItems.ThisOrderItem = TestOrderItems;

            //test to see that the two values are the same 

            Assert.AreEqual(AllOrderItems.ThisOrderItem, TestOrderItems);

        }


       


        [TestMethod]


        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsorderItemsCollection AllOrderItems = new clsorderItemsCollection();
            //create the item of test data 
            clsOrderItems TestItem = new clsOrderItems();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.orderItems_id = 1;
            TestItem.Quantity = "1";
            TestItem.Price = "1.00";
            TestItem.DispatchDate = DateTime.Now;
            TestItem.OrderReceived = true;
            //set ThisOrder to the test data
            AllOrderItems.ThisOrderItem = TestItem;
            //add the record
            PrimaryKey = AllOrderItems.Add();
            //set the primary key of the test data
            TestItem.orderItems_id = PrimaryKey;
            //find the record
            AllOrderItems.ThisOrderItem.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderItems.ThisOrderItem, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsorderItemsCollection AllOrderItems = new clsorderItemsCollection();
            //create the item of test data 
            clsOrderItems TestItem = new clsOrderItems();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.orderItems_id = 1;
            TestItem.Quantity = "1";
            TestItem.Price = "1.00";
            TestItem.DispatchDate = DateTime.Now;
            TestItem.OrderReceived = true;
            //set ThisOrder to the test data
            AllOrderItems.ThisOrderItem = TestItem;
            //add the record
            PrimaryKey = AllOrderItems.Add();
            //set the primary key of the test data
            TestItem.orderItems_id = PrimaryKey;
            //modify the test record
            TestItem.Quantity = "2";
            TestItem.Price = "2.00";
            TestItem.DispatchDate = DateTime.Now;
            TestItem.OrderReceived = false;
            //update the record
            AllOrderItems.Update();
            //find the record
            AllOrderItems.ThisOrderItem.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderItems.ThisOrderItem, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsorderItemsCollection AllOrderItems = new clsorderItemsCollection();
            //create the item of test data 
            clsOrderItems TestItem = new clsOrderItems();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.orderItems_id = 1;
            TestItem.Quantity = "1";
            TestItem.Price = "1.00";
            TestItem.DispatchDate = DateTime.Now;
            TestItem.OrderReceived = true;
            //set ThisOrder to the test data
            AllOrderItems.ThisOrderItem = TestItem;
            //add the record
            PrimaryKey = AllOrderItems.Add();
            //set the primary key of the test data
            TestItem.orderItems_id = PrimaryKey;
            //find the record
            AllOrderItems.ThisOrderItem.Find(PrimaryKey);
            //delete the record
            AllOrderItems.Delete();
            //now find the record
            Boolean Found = AllOrderItems.ThisOrderItem.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]

        
    }
}
