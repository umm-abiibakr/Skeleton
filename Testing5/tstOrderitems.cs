using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static ClassLibrary.clsorderitems;


namespace Testing5
{
    [TestClass]
    public class tstOrderItems
    {
        private bool dispatchDate;
        private bool price;

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsorderitems AnOrderItem = new clsorderitems();
            //test to see that it exists
            Assert.IsNotNull(AnOrderItem);
        }

        [TestMethod]
        public void OrderItems_idPropertyOK()
        {
            //create an instance of the class we want to create
            clsorderitems AnOrderItem = new clsorderitems();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderItem.orderItems_id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderItem.orderItems_id, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsorderitems AnOrderItem = new clsorderitems();
            //create some test data to assign to the property
            string TestData = "10";
            //assign the data to the property
            AnOrderItem.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderItem.Quantity, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsorderitems AnOrderItem = new clsorderitems();
            //create some test data to assign to the property
            string TestData = "10.99";
            //assign the data to the property
            AnOrderItem.price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderItem.price, TestData);
        }

        [TestMethod]
        public void DispatchDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsorderitems AnOrderItem = new clsorderitems();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrderItem.dispatchDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderItem.dispatchDate, TestData);
        }

        [TestMethod]
        public void OrderReceivedPropertyOK()
        {
            //create an instance of the class we want to create
            clsorderitems AnOrderItem = new clsorderitems();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrderItem.orderReceived = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderItem.orderReceived, TestData);
        }
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsorderitems AnOrderItems = new clsorderitems();

            //create some test data to use with the method
            int quantity = 2;
            string price = "100.00";
            DateTime dispatchDate = DateTime.Now;
            bool orderReceived = false;

            //invoke the method
            AnOrderItems.Find(quantity, price, dispatchDate, orderReceived);

            //test to see if the result is true
            Assert.IsTrue(AnOrderItems.Found);
        }
        [TestMethod]
        public void TestOrderItemsIdFound()
        {
            //create an instance of the class we want to create
            clsorderitems AnOrderItem = new clsorderitems();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderItemsId = 21;
            //invoke the method
            Found = AnOrderItem.Find(OrderItemsId);
            //check the order items id property
            if (AnOrderItem.orderItems_id != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsorderitems AnOrderItem = new clsorderitems();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string Quantity = "10";
            //invoke the method
            Found = AnOrderItem.Find(Quantity);
            //check the quantity property
            if (AnOrderItem.Quantity != "10")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsorderitems AnOrderItem = new clsorderitems();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string Price = "100.00";
            //invoke the method
            Found = AnOrderItem.Find(price);
            //check the price property
            if (AnOrderItem.Price != "100.00")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDispatchDateFound()
        {
            //create an instance of the class we want to create
            clsorderitems AnOrderItem = new clsorderitems();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            DateTime DispatchDate = DateTime.Now;
            //invoke the method
            Found = AnOrderItem.Find(dispatchDate);
            //check the dispatch date property
            if (AnOrderItem.dispatchDate != DateTime.Now)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderReceivedFound()
        {
            //create an instance of the class we want to create
            clsorderitems AnOrderItem = new clsorderitems();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Boolean OrderReceived = false;
            //invoke the method
            Found = AnOrderItem.Find(OrderReceived);
            //check the order received property
            if (AnOrderItem.orderReceived != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }

    [TestMethod]
    public void ValidMethodOK()
    {
        //create an instance of the class we want to create
        clsOrderItems AnOrder = new clsOrderItems();
        //String variable to store any error message
        String Error = "";
        //create some test data to pass the method
        int OrderItems_id = 1;
        string Quantity = "10";
        string Price = "10.99";
        DateTime DispatchDate = DateTime.Now;
        bool OrderReceived = true;
        //invoke the method
        Error = AnOrder.Valid(OrderItems_id, Quantity, Price, DispatchDate, OrderReceived);
        //test to see if the result is correct
        Assert.AreEqual(Error, "");
    }

    [TestMethod]
    public void OrderItems_idMinLessOne()
    {
        //create an instance of the class we want to create
        clsOrderItems AnOrder = new clsOrderItems();
        //String variable to store any error message
        String Error = "";
        //create some test data to pass the method
        int OrderItems_id = 0;
        string Quantity = "10";
        string Price = "10.99";
        DateTime DispatchDate = DateTime.Now;
        bool OrderReceived = true;
        //invoke the method
        Error = AnOrder.Valid(OrderItems_id, Quantity, Price, DispatchDate, OrderReceived);
        //test to see if the result is correct
        Assert.AreNotEqual(Error, "");
    }

    [TestMethod]
    public void OrderItems_idMin()
    {
        //create an instance of the class we want to create
        clsOrderItems AnOrder = new clsOrderItems();
        //String variable to store any error message
        String Error = "";
        //create some test data to pass the method
        int OrderItems_id = 1;
        string Quantity = "10";
        string Price = "10.99";
        DateTime DispatchDate = DateTime.Now;
        bool OrderReceived = true;
        //invoke the method
        Error = AnOrder.Valid(OrderItems_id, Quantity, Price, DispatchDate, OrderReceived);
        //test to see if the result is correct
        Assert.AreEqual(Error, "");
    }

    [TestMethod]
    public void OrderItems_idMinPlusOne()
    {
        //create an instance of the class we want to create
        clsOrderItems AnOrder = new clsOrderItems();
        //String variable to store any error message
        String Error = "";
        //create some test data to pass the method
        int OrderItems_id = 2;
        string Quantity = "10";
        string Price = "10.99";
        DateTime DispatchDate = DateTime.Now;
        bool OrderReceived = true;
        //invoke the method
        Error = AnOrder.Valid(OrderItems_id, Quantity, Price, DispatchDate, OrderReceived);
        //test to see if the result is correct
        Assert.AreEqual(Error, "");
    }

    [TestMethod]
    public void QuantityMinLessOne()
    {
        //create an instance of the class we want to create
        clsOrderItems AnOrder = new clsOrderItems();
        //String variable to store any error message
        String Error = "";
        //create some test data to pass the method
        int OrderItems_id = 1;
        string Quantity = "";
        string Price = "10.99";
        DateTime DispatchDate = DateTime.Now;
        bool OrderReceived = true;
        //invoke the method
        Error = AnOrder.Valid(OrderItems_id, Quantity, Price, DispatchDate, OrderReceived);
        //test to see if the result is correct
        Assert.AreNotEqual(Error, "");
    }

    [TestMethod]
    public void QuantityMin()
    {
        //create an instance of the class we want to create
        clsOrderItems AnOrder = new clsOrderItems();
        //String variable to store any error message
        String Error = "";
        //create some test data to pass the method
        int OrderItems_id = 1;
        string Quantity = "1";
        string Price = "10.99";
        DateTime DispatchDate = DateTime.Now;
        bool OrderReceived = true;
        //invoke the method
        Error = AnOrder.Valid(OrderItems_id, Quantity, Price, DispatchDate, OrderReceived);
        //test to see if the result is correct
        Assert.AreEqual(Error, "");
    }

    [TestMethod]
    public void QuantityMinPlusOne()
    {
        //create an instance of the class we want to create
        clsOrderItems AnOrder = new clsOrderItems();
        //String variable to store any error message
        String Error = "";
        //create some test data to pass the method
        int OrderItems_id = 1;
        string Quantity = "2";
        string Price = "10.99";
        DateTime DispatchDate = DateTime.Now;
        bool OrderReceived = true;
        //invoke the method
        Error = AnOrder.Valid(OrderItems_id, Quantity, Price, DispatchDate, OrderReceived);


    }
}