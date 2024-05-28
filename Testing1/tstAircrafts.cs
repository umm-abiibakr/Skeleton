using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Testing1
{
    internal class tstAircrafts
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsAircrafts AnAircraft = new clsAircrafts();
            //test to see that it exists
            Assert.IsNotNull(AnAircraft);
        }

        [TestMethod]
        public void AircraftIDOK()
        {
            // Create an instance of the class we want to test
            clsAircrafts AnAircraft = new clsAircrafts();
            // Create some test data to assign to the property
            int TestData = 1;
            // Assign the data 
            AnAircraft.AircraftID = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnAircraft.AircraftID, TestData);





            [TestMethod]
            public void DescriptionOk()

            //create an instance of the class we want to test 
            clsAircrafts AnAircraft = new clsAircrafts();
            string TestData = "Hello Aircraft";
            //assign the data to the property
            AnAircraft.Description = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnAircraft.Description, TestData);




            [TestMethod]
            public void PriceOK()

            { //create an instance of the class we want to create
                clsOrders AnAircraft = new clsAircrafts();
                //create some test data to assign to the property
                Decimal TestData = 11.80m;
                //assign the data to the property 
                AnAircraft.Price = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnAircraft.Price, TestData);
            }


            [TestMethod]
                public void ImageUrlOK()
                {

                    // Create an instance of the class we want to test
                    clsAircrafts AnAircraft = new clsAircrafts();
                    // Create some test data to assign to the property
                    string TestData = "https://example.com/image.jpg";
                    // Assign the data to the property
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
                    bool TestData = true;
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
    }
}
