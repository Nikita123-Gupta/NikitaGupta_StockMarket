using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.UserAPI.Models
{
    public class IpoDetails
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public string StockExchange { get; set; }
        public double Price { get; set; }
        public int TotalShares { get; set; }
        public DateTime DateTime { get; set; }
        public string Remarks { get; set; }

    }
}
