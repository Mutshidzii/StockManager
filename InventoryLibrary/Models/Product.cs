using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StockInventoryServer.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Email { get; set; }
        public string PartNumber { get; set; }
        public string ProductLabel { get; set; }
        public int? StartingInventory { get; set; }
        public int? InventoryRecieved { get; set; }
        public int? InventoryOnHand { get; set; }
    }
}
