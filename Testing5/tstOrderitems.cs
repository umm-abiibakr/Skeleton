using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstOrderitems
    {
        public void InstanceOk()

        { //create an instance of the class we want to 
            clsorderitems Anorderitems = new clsorderitems();
            //test to see that it exists
            Assert.IsNotNull(Anorderitems);
        }
    }
}
