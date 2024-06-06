using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstAircrafts
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create 
            clsAircrafts AnAircraft = new clsAircrafts();
            //test to see that it exists
            Assert.IsNotNull(AnAircraft);
        }

        [TestMethod]

        public void AircraftIdOk()
        {
            //create an instance of the class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AnAircraft.AircraftId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAircraft.AircraftId, TestData);

        }

        [TestMethod]
        public void PriceOK()
        {
            // Create an instance of the class we want to test
            clsAircrafts AnAircraft = new clsAircrafts();

            // Create some test data to assign to the property
            decimal TestData = 100.50m;

            // Assign the data to the property
            AnAircraft.Price = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(AnAircraft.Price, TestData);
        }


        [TestMethod]
        public void DescriptionOK()
        {
            // Create an instance of the class we want to test
            clsAircrafts AnAircraft = new clsAircrafts();

            // Create some test data to assign to the property
            string TestData = "This is a test description.";

            // Assign the data to the property
            AnAircraft.Description = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(AnAircraft.Description, TestData);
        }


        [TestMethod]
        public void ImageUrlOK()
        {
            // Create an instance of the class we want to test
            clsAircrafts AnAircraft = new clsAircrafts();

            // Create some test data to assign to the property
            string TestData = "https://example.com/image.jpg";
            //Assign the data to the property
            AnAircraft.ImageUrl = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnAircraft.ImageUrl, TestData);
        }

        [TestMethod]
        public void QuantityOK()
        {

            // Create an instance of the class we want to test
            clsAircrafts AnAircraft = new clsAircrafts();
            // Create some test data to assign to the property
            // Assign the data to the property
            AnAircraft.Quantity = (int)10;
            // Test to see that the two values are the same
            Assert.AreEqual(AnAircraft.Quantity, 10);
        }


        [TestMethod]
        public void AvailabilityOK()
        {

            // Create an instance of the class we want to test
            clsAircrafts AnAircraft = new clsAircrafts();
            // Create some test data to assign to the property
            Boolean TestData = true;
            // Assign the data to the property
            AnAircraft.Availability = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnAircraft.Availability, TestData);
        }


        [TestMethod]
        public void ManufacturedDateOK()
        {

            // Create an instance of the class we want to test
            clsAircrafts AnAircraft = new clsAircrafts();
            // Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // Assign the data to the property
            AnAircraft.ManufacturedDated = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnAircraft.ManufacturedDated, TestData);
        }


        [TestMethod]
        public void AircraftNameOK()
        {

            // Create an instance of the class we want to test
            clsAircrafts AnAircraft = new clsAircrafts();

            // Create some test data to assign to the property
            string TestData = "Coolest Aircraft";

            // Assign the data to the property
            AnAircraft.AircraftName = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(AnAircraft.AircraftName, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //create new Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 AircraftId = 14;
            //invoke the method 
            Found = AnAircraft.Find(AircraftId);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestAircraftIdFound()
        {
            //create an instance of the class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //create new Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is lol)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AircraftId = 16;
            //invoke the method 
            Found = AnAircraft.Find(AircraftId);
            //check the aircraft id
            if (AnAircraft.AircraftId != 16)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestAircraftNameFound()
        {
            // Create an instance of the class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            // Create new Boolean variable to store the results of the search
            Boolean Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is lol)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 AircraftId = 16;
            // Invoke the method 
            Found = AnAircraft.Find(AircraftId);
            // Check the aircraft name
            if (AnAircraft.AircraftName != "Test Boeing 123")
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestManufacturedDatedFound()
        {
            // Create an instance of the class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            // Create new Boolean variable to store the results of the search
            Boolean Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is lol)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 AircraftId = 16;
            // Invoke the method 
            Found = AnAircraft.Find(AircraftId);
            // Check the manufactured date
            if (AnAircraft.ManufacturedDated != new DateTime(2003, 02, 06))
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            // Create an instance of the class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            // Create new Boolean variable to store the results of the search
            Boolean Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is lol)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 AircraftId = 16;
            // Invoke the method 
            Found = AnAircraft.Find(AircraftId);
            // Check the price
            if (AnAircraft.Price != 12345678.00m)
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailabilityFound()
        {
            // Create an instance of the class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            // Create new Boolean variable to store the results of the search
            Boolean Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is lol)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 AircraftId = 16;
            // Invoke the method 
            Found = AnAircraft.Find(AircraftId);
            // Check the availability
            if (AnAircraft.Availability != true)
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            // Create an instance of the class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            // Create new Boolean variable to store the results of the search
            Boolean Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is lol)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 AircraftId = 16;
            // Invoke the method 
            Found = AnAircraft.Find(AircraftId);
            // Check the quantity
            if (AnAircraft.Quantity != 6)
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            // Create an instance of the class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            // Create new Boolean variable to store the results of the search
            Boolean Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is lol)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 AircraftId = 16;
            // Invoke the method 
            Found = AnAircraft.Find(AircraftId);
            // Check the description
            if (AnAircraft.Description != "This is a test")
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestImageUrlFound()
        {
            // Create an instance of the class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            // Create new Boolean variable to store the results of the search
            Boolean Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is lol)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 AircraftId = 16;
            // Invoke the method 
            Found = AnAircraft.Find(AircraftId);
            // Check the image URL
            if (AnAircraft.ImageUrl != "null")
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }
    }
}
