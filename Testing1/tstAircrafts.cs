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
    }
}
