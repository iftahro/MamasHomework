﻿using System;
using MamaSuper.Common.Interfaces;
using MamaSuper.Common.Models;

namespace MamaSuper.Logic.Services
{
    /// <summary>
    /// <inheritdoc cref="ILineService"/>
    /// </summary>
    public class LineService : ILineService
    {
        public LineService(SupermarketLine<Customer> customersLine)
        {
            CustomersLine = customersLine;
        }

        /// <summary>
        /// <inheritdoc cref="ILineService"/>
        /// </summary>
        public event EventHandler<Customer> CustomerMovedOut;

        /// <summary>
        /// <inheritdoc cref="ILineService.CustomersLine"/>
        /// </summary>
        public SupermarketLine<Customer> CustomersLine { get; }

        /// <summary>
        /// <inheritdoc cref="ILineService.MoveOutCustomers"/>
        /// </summary>
        public void MoveOutCustomers(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Customer customer = CustomersLine.RemoveLineItem();
                CustomerMovedOut?.Invoke(this, customer);
            }
        }
    }
}