using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing1
{
    [TestClass]
    public class tstAircraftsCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsAircraftsCollection AllAircrafts = new clsAircraftsCollection();
            //test to see that it exisits
            Assert.IsNotNull(AllAircrafts);
        }

        [TestMethod]
        public void AircraftsListOK()
        {
            //create an instance of the class we want to create
            clsAircraftsCollection AllAircrafts = new clsAircraftsCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsAircrafts> TestList = new List<clsAircrafts>();
            //add an item to the list
            //create the item of the test data
            clsAircrafts TestItem = new clsAircrafts();
            //set its properties
            TestItem.Availability = true;
            TestItem.AircraftId = 1;
            TestItem.AircraftName = "Aiircraft";
            TestItem.ManufacturedDated = DateTime.Now;
            TestItem.Price = 1.00m;
            TestItem.Description = "description";
            TestItem.Quantity = 1;
            TestItem.ImageUrl = "imageurl";

            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property
            AllAircrafts.AircraftsList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAircrafts.AircraftsList, TestList);
        }



        [TestMethod]
        public void ThisAircraftPropertyOK()
        {
            //create an instance of the class we want to create
            clsAircraftsCollection AllAircrafts = new clsAircraftsCollection();
            //create some test data to assign to the property
            clsAircrafts TestAircraft = new clsAircrafts();
            //set the properties of the test object
            TestAircraft.Availability = true;
            TestAircraft.AircraftId = 1;
            TestAircraft.AircraftName = "Aircraft";
            TestAircraft.ManufacturedDated = DateTime.Now;
            TestAircraft.Price = 1.00m;
            TestAircraft.Description = "Description";
            TestAircraft.Quantity = 1;
            TestAircraft.ImageUrl = "imageurl";
            //assign the data to the property
            AllAircrafts.ThisAircraft = TestAircraft;
            //test to see that the two values are the same 
            Assert.AreEqual(AllAircrafts.ThisAircraft, TestAircraft);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsAircraftsCollection AllAircrafts = new clsAircraftsCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsAircrafts> TestList = new List<clsAircrafts>();
            //add an item to the list
            //create the item of test data
            clsAircrafts TestItem = new clsAircrafts();
            //set the properties of the test object
            TestItem.Availability = true;
            TestItem.AircraftId = 1;
            TestItem.AircraftName = "Aircraft";
            TestItem.ManufacturedDated = DateTime.Now;
            TestItem.Price = 1.00m;
            TestItem.Description = "Description";
            TestItem.Quantity = 1;
            TestItem.ImageUrl = "imageurl";
            //add the item to the property
            TestList.Add(TestItem);
            //assign the data to the property
            AllAircrafts.AircraftsList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllAircrafts.AircraftsList.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsAircraftsCollection AllAircrafts = new clsAircraftsCollection();
            //create the item of test data 
            clsAircrafts TestItem = new clsAircrafts();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Availability = true;
            TestItem.AircraftId = 1;
            TestItem.AircraftName = "Boeing 747";
            TestItem.ManufacturedDated = DateTime.Now;
            TestItem.Price = 100000000.00m;
            TestItem.Description = "Large passenger aircraft";
            TestItem.Quantity = 10;
            TestItem.ImageUrl = "http://example.com/boeing747.jpg";
            //set ThisAircraft to the test data
            AllAircrafts.ThisAircraft = TestItem;
            //add the record
            PrimaryKey = AllAircrafts.Add();
            //set the primary key of the test data
            TestItem.AircraftId = PrimaryKey;
            //find the record
            AllAircrafts.ThisAircraft.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllAircrafts.ThisAircraft, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // Create an instance of the class we want to create
            clsAircraftsCollection AllAircrafts = new clsAircraftsCollection();
            // Create the item of test data
            clsAircrafts TestItem = new clsAircrafts();
            // Variable to store the primary key
            Int32 PrimaryKey = 0;
            // Set its properties
            TestItem.Availability = true;
            TestItem.AircraftName = "Boeing 747";
            TestItem.ManufacturedDated = DateTime.Now;
            TestItem.Price = 100000000.00m;
            TestItem.Description = "Large passenger aircraft";
            TestItem.Quantity = 10;
            TestItem.ImageUrl = "http://example.com/boeing747.jpg";
            // Set ThisAircraft to the test data
            AllAircrafts.ThisAircraft = TestItem;
            // Add the record
            PrimaryKey = AllAircrafts.Add();
            // Set the primary key of the test data
            TestItem.AircraftId = PrimaryKey;
            // Modify the test record
            TestItem.Availability = false;
            TestItem.AircraftName = "Airbus A380";
            TestItem.ManufacturedDated = DateTime.Now;
            TestItem.Price = 120000000.00m;
            TestItem.Description = "Double-deck, wide-body, four-engine jet airliner";
            TestItem.Quantity = 8;
            TestItem.ImageUrl = "http://example.com/airbusa380.jpg";
            // Update the record
            AllAircrafts.Update();
            // Find the record
            AllAircrafts.ThisAircraft.Find(PrimaryKey);
            // Test to see that the two values are the same
            Assert.AreEqual(AllAircrafts.ThisAircraft, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create an instance of the class we want to create
            clsAircraftsCollection AllAircrafts = new clsAircraftsCollection();
            // Create the item of test data
            clsAircrafts TestItem = new clsAircrafts();
            // Variable to store the primary key
            Int32 PrimaryKey = 0;
            // Set its properties
            TestItem.Availability = true;
            TestItem.AircraftName = "Boeing 747";
            TestItem.ManufacturedDated = DateTime.Now;
            TestItem.Price = 100000000.00m;
            TestItem.Description = "Large passenger aircraft";
            TestItem.Quantity = 10;
            TestItem.ImageUrl = "http://example.com/boeing747.jpg";
            // Set ThisAircraft to the test data
            AllAircrafts.ThisAircraft = TestItem;
            // Add the record
            PrimaryKey = AllAircrafts.Add();
            // Set the primary key of the test data
            TestItem.AircraftId = PrimaryKey;
            // Find the record
            AllAircrafts.ThisAircraft.Find(PrimaryKey);
            // Delete the record
            AllAircrafts.Delete();
            // Now find the record
            Boolean Found = AllAircrafts.ThisAircraft.Find(PrimaryKey);
            // Test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByAircraftNameMethodOK()
        {
            //create an instance of the class we want to create
            clsAircraftsCollection AllAircrafts = new clsAircraftsCollection();
            //create an instance of the filtered data 
            clsAircraftsCollection FilteredAircrafts = new clsAircraftsCollection();
            //apply a blank string (should return all records)
            FilteredAircrafts.ReportByAircraftName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllAircrafts.Count, FilteredAircrafts.Count);
        }

        [TestMethod]
        public void ReportByAircraftNameTestDataFound()
        {
            //create an instance of the filtered data
            clsAircraftsCollection FilteredAircrafts = new clsAircraftsCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a name taht doesnt exist
            FilteredAircrafts.ReportByAircraftName("Some One");
            //check that the correct number of records are found
            if (FilteredAircrafts.Count == 2)
            {
                if (FilteredAircrafts.AircraftsList[0].AircraftId != 63)
                {
                    OK = false;
                }
                if (FilteredAircrafts.AircraftsList[1].AircraftId != 53)
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
