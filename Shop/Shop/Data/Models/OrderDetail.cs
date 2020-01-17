﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int LightID { get; set; }

        public ushort price { get; set; }

        public virtual Light light { get; set; }
        public virtual Order order { get; set; }
    }
}
