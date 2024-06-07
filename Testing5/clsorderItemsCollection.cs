using ClassLibrary;
using System;
using System.Collections.Generic;

namespace Testing5
{
    internal class clsorderItemsCollection
    {
        internal List<clsorderitems.clsOrderItems> orderItems_List;

        public clsorderitems.clsOrderItems ThisOrderItem { get; internal set; }
        public object OrderItemsList { get; internal set; }

        internal int Add()
        {
            throw new NotImplementedException();
        }

        internal void Delete()
        {
            throw new NotImplementedException();
        }

        internal void ReportByStatus(string v)
        {
            throw new NotImplementedException();
        }

        internal void Update()
        {
            throw new NotImplementedException();
        }
    }
}