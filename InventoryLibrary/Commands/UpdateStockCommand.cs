using MediatR;
using StockInventoryServer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryLibrary.Commands
{
    public class UpdateStockCommand : IRequest<Product>
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string PartNumber { get; set; }
        public string ProductLabel { get; set; }
        public int? StartingInventory { get; set; }
        public int? InventoryRecieved { get; set; }
        public int? InventoryOnHand { get; set; }

        public UpdateStockCommand(Product product)
        {
            this.Id = product.Id;
            this.ProductName = product.ProductName;
            this.PartNumber = product.PartNumber;
            this.ProductLabel = product.ProductLabel;
            this.StartingInventory = product.StartingInventory;
            this.InventoryRecieved = product.InventoryRecieved;
            this.InventoryOnHand = product.InventoryOnHand;
        }
    }
}
