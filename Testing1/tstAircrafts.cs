using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;

namespace Testing1
{
    [TestClass]
    public class tstAircrafts
    {
        //good test data
        //create some test data to pass the method
        string AircraftName = "Boeng 123";
        string ImageUrl = "exampleaircraft.com";
        string Description = "Test Description";
        string ManfacturedDated = DateTime.Now.ToShortDateString();

        public object ManufacturedDated { get; private set; }

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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //String variable to store any error message
            String Error = "";
            //invoke the method 
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AircraftNameMinLessOne()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AircraftName = ""; //this should trigger an error
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AircraftNameMin()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AircraftName = "s"; //this should be ok
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AircraftNameMinPlusOne()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AircraftName = "ss"; //this should be ok
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AircraftNameMaxLessOne()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AircraftName = ""; //this should be ok
            AircraftName = AircraftName.PadRight(49, 'a');
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AircraftNameMax()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AircraftName = ""; //this should be ok
            AircraftName = AircraftName.PadRight(50, 'a');
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AircraftNameMid()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AircraftName = ""; //this should be ok
            AircraftName = AircraftName.PadRight(25, 'a');
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AircraftNameMaxPlusOne()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            AircraftName = Name.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AircraftNameExtremeMax()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AircraftName = "";
            AircraftName = AircraftName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void ImageUrlMinLessOne()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ImageUrl = "";//this should trigger an error
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void ImageUrlMin()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ImageUrl = "a"; //this should be ok
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void ImageUrlMinPlusOne()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ImageUrl = "aa"; //this should be ok
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void ImageUrlMaxLessOne()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ImageUrl = ""; //this should be ok
            ImageUrl = ImageUrl.PadRight(49, 'a');
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void ImageUrlMax()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ImageUrl = ""; //this should be ok
            ImageUrl = ImageUrl.PadRight(50, 'a');
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void ImageUrlMid()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ImageUrl = ""; //this should be ok
            ImageUrl = ImageUrl.PadRight(25, 'a');
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void ImageUrlMaxPlusOne()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ImageUrl = "";
            ImageUrl = ImageUrl.PadRight(51, 'a');//this should fail
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ImageUrlExtreme()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ImageUrl = "";
            ImageUrl = ImageUrl.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Description = ""; //this triggers an error
            //invoke the method 
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DescriptionMin()
        {
            //create an instance of the class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Description = "p";
            //invoke the method 
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Description = "ss";
            //invoke the method 
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Description = "aircrafts";
            //invoke the method 
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void DescriptionMax()
        {
            //create an instance of the class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Description = "processing";
            //invoke the method 
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DescriptionMid()
        {
            //create an instance of the class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Description = "aircr";
            //invoke the method 
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Description = "processingg";
            //invoke the method 
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DescriptionExtremeMax()
        {
            //create an instance of the class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Description = "";
            Description = Description.PadRight(500, 'p'); //this should fail
            //invoke the method 
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void ManufacturedDatedExtremeMin()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to 100 years ago
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string ManufacturedDated = TestDate.ToString();
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ManufacturedDatedMinLessOne()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to one day less than today
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string ManufacturedDated = TestDate.ToString();
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ManufacturedDatedMin()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string ManufacturedDated = TestDate.ToString();
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ManufacturedDatedMinPlusOne()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to one day more than today
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string ManufacturedDated = TestDate.ToString();
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ManufacturedDatedExtremeMax()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to 100 years in the future
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string ManufacturedDated = TestDate.ToString();
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ManufacturedDatedInvalidData()
        {
            //create an instance of the new class we want to create
            clsAircrafts AnAircraft = new clsAircrafts();
            //string variable to store any error message
            String Error = "";
            //set the ManufacturedDate to a non-date value
            string ManufacturedDated = "this is not a date!";
            //invoke the method
            Error = AnAircraft.Valid(AircraftName, Description, ImageUrl, ManufacturedDated);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
