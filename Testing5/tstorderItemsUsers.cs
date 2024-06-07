using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing5
{
    [TestMethod]
    public void InstanceOk()
    {
        //create an instance of the class we want to create
        clsorderItemsCollection AOrderItemsCollection = new clsorderItemsCollection();
        //test to see that it exists
        Assert.IsNotNull(AOrderItemsCollection);
    }

    [TestMethod]
    public void OrderItemsIDPropertyOK()
    {
        //create an instance of the class we want to create
        clsorderItemsCollection AOrderItemsCollection = new clsorderItemsCollection();
        //create some test data to assign to the property
        Int32 TestData = 1;
        //assign the data to the property
        AOrderItemsCollection.orderItems_ID = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AOrderItemsCollection.orderItems_ID, TestData);
    }

    [TestMethod]
    public void QuantityPropertyOK()
    {
        //create an instance of the class we want to create
        clsOrderItemsCollection AOrderItemsCollection = new clsOrderItemsCollection();
        //create some test data to assign to the property
        string TestData = "10";
        //assign the data to the property
        AOrderItemsCollection.Quantity = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AOrderItemsCollection.Quantity, TestData);
    }

    [TestMethod]
    public void PricePropertyOK()
    {
        //create an instance of the class we want to create
        clsorderItemsCollection AOrderItemsCollection = new clsorderItemsCollection();
        //create some test data to assign to the property
        string TestData = "100.00";
        //assign the data to the property
        AOrderItemsCollection.price = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AOrderItemsCollection.price, TestData);
    }

    [TestMethod]
    public void DispatchDatePropertyOK()
    {
        //create an instance of the class we want to create
        clsOrderItemsCollection AOrderItemsCollection = new clsOrderItemsCollection();
        //create some test data to assign to the property
        DateTime TestData = DateTime.Now;
        //assign the data to the property
        AOrderItemsCollection.DispatchDate = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AOrderItemsCollection.DispatchDate, TestData);
    }

    [TestMethod]
    public void OrderReceivedPropertyOK()
    {
        //create an instance of the class we want to create
        clsorderItemsCollection AOrderItemsCollection = new clsorderItemsCollection();
        //create some test data to assign to the property
        Boolean TestData = true;
        //assign the data to the property
        AOrderItemsCollection.orderReceived = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AOrderItemsCollection.orderReceived, TestData);
    }
}
