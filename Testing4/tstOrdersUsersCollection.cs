using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrdersUsersCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrdersUsersCollection AllUsers = new clsOrdersUsersCollection();
            //test to see that it exisits
            Assert.IsNotNull(AllUsers);
        }

        [TestMethod]
        public void UsersListOK()
        {
            //create an instance of the class we want to create
            clsOrdersUsersCollection AllUsers = new clsOrdersUsersCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of users
            List<clsOrdersUser> TestList = new List<clsOrdersUser>();
            //add an item to the list
            //create the item of the test data
            clsOrdersUser TestItem = new clsOrdersUser();
            //set its properties
            TestItem.UserID = 1;
            TestItem.UserName = "Zainab";
            TestItem.Password = "ZainabSPassword";
            TestItem.Department = "Orders";
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property
            AllUsers.UsersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.UsersList, TestList);
        }

        [TestMethod]
        public void ThisUserPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdersUsersCollection AllUsers = new clsOrdersUsersCollection();
            //create some test data to assign to the property
            clsOrdersUser TestUser = new clsOrdersUser();
            //set the properties of the test object
            TestUser.UserID = 1;
            TestUser.UserName = "Zainab";
            TestUser.Password = "ZainabSPassword";
            TestUser.Department = "Orders";
            //assign the data to the property
            AllUsers.ThisUser = TestUser;
            //test to see that the two values are the same 
            Assert.AreEqual(AllUsers.ThisUser, TestUser);
        }

        [TestMethod]
        public void ChangePWMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersUsersCollection AllUsers = new clsOrdersUsersCollection();
            //create the item of test data 
            clsOrdersUser TestItem = new clsOrdersUser();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.UserName = "Zainab";
            TestItem.Password = "ZainabSPassword";
            TestItem.Department = "Orders";
            //set ThisOrder to the test data
            AllUsers.ThisUser = TestItem;
            //set the primary key of the test data
            TestItem.UserID = PrimaryKey;
            //modify the test record
            TestItem.UserName = "Zainabu";
            TestItem.Password = "ZainabSPW";
            TestItem.Department = "Order";
            //set the record based on the new data 
            AllUsers.ThisUser = TestItem;
            //update the record
            AllUsers.ChangePW();
            //find the record
            AllUsers.ThisUser.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.ThisUser, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersUsersCollection AllUsers = new clsOrdersUsersCollection();
            //create the item of test data 
            clsOrdersUser TestItem = new clsOrdersUser();
            //variable to store the primary key
            Int32 PrimaryKey =0;
            //set its properties 
            TestItem.UserID = 1;
            TestItem.UserName = "Zainab";
            TestItem.Password = "ZainabSPassword";
            TestItem.Department = "Orders";
            //set ThisOrder to the test data
            AllUsers.ThisUser = TestItem;
            //set the primary key of the test data
            TestItem.UserID = PrimaryKey;
            //find the record
            AllUsers.ThisUser.Find(PrimaryKey);
            //delete the record
            AllUsers.Delete();
            //now find the record
            Boolean Found = AllUsers.ThisUser.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
    }
}
