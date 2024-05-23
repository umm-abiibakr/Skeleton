using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass the method
        string Name = "John Doe";
        string Email = "johndoe@example.com";
        string Address = "123, Main Street, New York";
        string Country = "USA";
        string DateAdded = DateTime.Now.ToShortDateString();






        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }
        [TestMethod]
        public void SubscriptionOK()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.Subscription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Subscription, TestData);
        }
        [TestMethod]
        public void DateAddedOK()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DateAdded, TestData);
        }
        [TestMethod]
        public void CountryOK()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "USA";
            //assign the data to the property
            AnCustomer.Country = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Country, TestData);
        }
        [TestMethod]
        public void AddressOK()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "123, Main Street, New York";
            //assign the data to the property
            AnCustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Address, TestData);
        }
        [TestMethod]
        public void EmailOK()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "johndoe@example.com";
            //assign the data to the property
            AnCustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Email, TestData);
        }
        [TestMethod]
        public void NameOK()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "John Doe";
            //assign the data to the property
            AnCustomer.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Name, TestData);
        }
        [TestMethod]
        public void CustomerIdOK()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property

            Int32 TestData = 1;

            //assign the data to the property
            AnCustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the address id
            if (AnCustomer.CustomerId != 1)
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the dateAdded property
            if (AnCustomer.DateAdded != Convert.ToDateTime("20/05/2022"))
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the name property
            if (AnCustomer.Name != "John Doe")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the email property
            if (AnCustomer.Email != "johndoe@example.com")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the address property
            if (AnCustomer.Address != "123, Main Street, New York")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCountryFound()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the country property
            if (AnCustomer.Country != "USA")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSubscriptionFound()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the subscription property
            if (AnCustomer.Subscription != true)
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void NameMin()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "a"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aa"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should be ok
            Name = Name.PadRight(49, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void NameMax()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should be ok
            Name = Name.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void NameMid()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should be ok
            Name = Name.PadRight(25, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; 
            Name = Name.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void NameExtremeMax()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";//this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "a"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aa"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should be ok
            Email = Email.PadRight(49, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should be ok
            Email = Email.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should be ok
            Email = Email.PadRight(25, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; 
            Email = Email.PadRight(51, 'a');//this should fail
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void EmailExtreme()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "a"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "aa"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should be ok
            Address = Address.PadRight(49, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should be ok
            Address = Address.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should be ok
            Address = Address.PadRight(25, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CountryMinLessOne()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Country = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CountryMin()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Country = "a"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CountryMinPlusOne()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Country = "aa"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CountryMaxLessOne()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Country = ""; //this should be ok
            Country = Country.PadRight(49, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CountryMax()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Country = ""; //this should be ok
            Country = Country.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CountryMid()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Country = ""; //this should be ok
            Country = Country.PadRight(25, 'a');
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CountryMaxPlusOne()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Country = "";
            Country = Country.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CountryExtremeMax()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Country = "";
            Country = Country.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create A VARIABLE to  store the tsest date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the data variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create A VARIABLE to  store the tsest date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the data variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create A VARIABLE to  store the tsest date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the data variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create A VARIABLE to  store the tsest date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the data variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create A VARIABLE to  store the tsest date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the data variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
    }
}
