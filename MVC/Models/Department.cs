﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public void AddSeller(Seller sl)
        {
            Sellers.Add(sl);
        }

        public double TotalSales(DateTime Inicial,DateTime Final)
        {
            return Sellers.Sum(seller => seller.TotalSales(Inicial, Final));
        }

    }
}
