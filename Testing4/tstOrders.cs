using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void InstanceOk()
          
        { //create an instance of the class we want to 
            clsOrders AnOrder = new clsOrders();
         //test to see that it exists
         Assert.IsNotNull(AnOrder); 
        }

        [TestMethod]
        public void CompletePropertyOK()

        { //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property 
            AnOrder.Complete = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Complete, TestData);
        }


        [TestMethod]
        public void OrderDatePropertyOk()

        { //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void OrderIdPropertyOk()

        { //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property 
            AnOrder.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOk()

        { //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property 
            AnOrder.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }


        [TestMethod]
        public void TotalAmountPropertyOk()

        { //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Decimal TestData = 11.80m;
            //assign the data to the property 
            AnOrder.TotalAmount = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.TotalAmount, TestData);
        }

        [TestMethod]
        public void StatusPropertyOk()

        { //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            string TestData = "Processing";
            //assign the data to the property 
            AnOrder.Status = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Status, TestData);
        }


        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create new Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 14;
            //invoke the method 
            Found = AnOrder.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create new Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is lol)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 14;
            //invoke the method 
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.OrderId != 14)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create new Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is lol)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 14;
            //invoke the method 
            Found = AnOrder.Find(OrderId);
            //check the customer id
            if (AnOrder.CustomerId != 12345)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestTotalAmountFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create new Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is lol)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 14;
            //invoke the method 
            Found = AnOrder.Find(OrderId);
            //check the customer id
            if (AnOrder.TotalAmount != 12000000m)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create new Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is lol)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 14;
            //invoke the method 
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.OrderDate != Convert.ToDateTime("12/05/2024"))
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCompleteFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create new Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is lol)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 14;
            //invoke the method 
            Found = AnOrder.Find(OrderId);
            //check the customer id
            if (AnOrder.Complete != false)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestStatusFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create new Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is lol)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 14;
            //invoke the method 
            Found = AnOrder.Find(OrderId);
            //check the customer id
            if (AnOrder.Status != "Processing")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);

        }
    }
}
