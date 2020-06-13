﻿using System;
using System.Collections.Generic;

namespace MamaSuper.Common.Models
{
    /// <summary>
    /// Represents a cashier's in the MamaSuper
    /// </summary>
    public class Cashier
    {
        /// <summary>
        /// Customers who passed in the cashier
        /// </summary>
        public List<Customer> PassedCustomers { get; set; }

        /// <summary>
        /// The date on which the cashier opened
        /// </summary>
        public DateTime DateOpened { get; set; }
    }
}