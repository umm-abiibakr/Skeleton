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
            string TestData = "Pending";
            //assign the data to the property 
            AnOrder.Status = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Status, TestData);
        }
    }
}
