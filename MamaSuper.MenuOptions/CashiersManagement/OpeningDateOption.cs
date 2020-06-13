﻿using System;
using System.Collections.Generic;
using System.Linq;
using MamaSuper.Common.Interfaces;
using MamaSuper.Common.Models;

namespace MamaSuper.MenuOptions.CashiersManagement
{
    /// <summary>
    /// Prints all the supermarket cashiers opening dates
    /// </summary>
    public class OpeningDateOption : IMenuOption
    {
        private readonly ICashiersService _cashiersService;

        public OpeningDateOption(ICashiersService cashiersService)
        {
            _cashiersService = cashiersService;
        }

        public string Description { get; } = "Get cashiers opening dates";

        public void Action()
        {
            List<Cashier> cashiers = _cashiersService.GetAllCashiers().ToList();
            for (int i = 0; i < cashiers.Count; i++)
            {
                Cashier cashier = cashiers[i];
                if (cashier.DateOpened == default)
                {
                    Console.WriteLine($"No.{i + 1}: has not yet opened\n");
                    continue;
                }

                Console.WriteLine($"No.{i + 1}: {cashier.DateOpened}\n");
            }
        }
    }
}