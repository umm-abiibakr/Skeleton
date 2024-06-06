using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
                AnAircraft.ManufacturedDate = TestData;
                // Test to see that the two values are the same
                Assert.AreEqual(AnAircraft.ManufacturedDate, TestData);
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
                }

            }
      

