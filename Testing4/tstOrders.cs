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
    }
}
