using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstManufacturers
    {
        public int ManufacturersId { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsManufacturers AManufacturer = new clsManufacturers();
            //test to see that it exists
            Assert.IsNotNull(AManufacturer);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of class we want to create
            clsManufacturers AManufacturer = new clsManufacturers();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AManufacturer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AManufacturer.IsActive, TestData);
        }


        [TestMethod]
        public void ManufacturerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsManufacturers AManufacturer = new clsManufacturers();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AManufacturer.ManufacturerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AManufacturer.ManufacturerId, TestData);
        }

        [TestMethod]
        public void NamePropertyOK(string testData)
        {
            //create an instance of class we want to create
            clsManufacturers AManufacturer = new clsManufacturers();
            //create some test data to assign to the property
            Int32 TestData = 123;
            //assign the data to the property
            AManufacturer.Name = testData;
            //test to see that the two values are the same
            Assert.AreEqual(AManufacturer.Name, TestData);
        }

        [TestMethod]
        public void CountryPropertyOK()
        {
            //create an instance of the class we want to create
            clsManufacturers AManufacturer = new clsManufacturers();
            //create some test data to assign to the property
            string TestData = "USA";
            //assign the data to the property
            AManufacturer.Country = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AManufacturer.Country, TestData);
        }

        [TestMethod]
        public void CreatedAtPropertyOK()
        {
            //create an instance of the class we want to create
            clsManufacturers AManufacturer = new clsManufacturers();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AManufacturer.CreatedAt = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AManufacturer.CreatedAt, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        { //create an instance of the class we want to create
            clsManufacturers AManufacturer = new clsManufacturers();
            //create new Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ManufacturersId = 7;
            //invoke the method 
            Found = AManufacturer.Find(ManufacturersId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestManufacturerIdFound()
        {
            //create an instance of the class we want to create
            clsManufacturers AManufacturer = new clsManufacturers();
            //create new Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is lol)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ManufacturerId = 7;
            //invoke the method 
            Found = AManufacturer.Find(ManufacturersId);
            //check the manufacturer id
            if (AManufacturer.ManufacturerId != 7)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

    }

}



