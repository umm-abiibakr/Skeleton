using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {
        //create some test data to pass the method
        string Status = "processing";
        string OrderDate = DateTime.Now.ToShortDateString();
        
   
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
            string TestData = "processing";
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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //String variable to store any error message
            String Error = "";
            //invoke the method 
            Error = AnOrder.Valid(Status, OrderDate);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StatusMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Status = ""; //this triggers an error
            //invoke the method 
            Error = AnOrder.Valid(Status, OrderDate) ;
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StatusMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Status = "p"; 
            //invoke the method 
            Error = AnOrder.Valid(Status, OrderDate);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StatusMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Status = "pr";
            //invoke the method 
            Error = AnOrder.Valid(Status, OrderDate);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void StatusMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Status = "processin";
            //invoke the method 
            Error = AnOrder.Valid(Status, OrderDate);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void StatusMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Status = "processing";
            //invoke the method 
            Error = AnOrder.Valid(Status, OrderDate);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StatusMid()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Status = "proce";
            //invoke the method 
            Error = AnOrder.Valid(Status, OrderDate);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StatusMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Status = "processingg";
            //invoke the method 
            Error = AnOrder.Valid(Status, OrderDate);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StatusExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Status = "";
            Status = Status.PadRight(500, 'p'); //this should fail
            //invoke the method 
            Error = AnOrder.Valid(Status, OrderDate);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method 
            Error = AnOrder.Valid(Status, OrderDate);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method 
            Error = AnOrder.Valid(Status, OrderDate);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method 
            Error = AnOrder.Valid(Status, OrderDate);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method 
            Error = AnOrder.Valid(Status, OrderDate);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method 
            Error = AnOrder.Valid(Status, OrderDate);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //String variable to store any error message
            String Error = "";
            //set the OrderDate to a non date value
            string OrderDate = "This is not a date!";
            //invoke the method 
            Error = AnOrder.Valid(Status, OrderDate);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
