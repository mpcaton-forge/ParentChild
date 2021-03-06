﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ParentChild.Model;

namespace ParentChild.WebUI.ViewModels
{
    public class SalesOrderItemViewModel : IObjectWithState
    {
        public int SalesOrderItemId { get; set; }
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public int SalesOrderId { get; set; }

        public ObjectState ObjectState { get; set; }
    }
}