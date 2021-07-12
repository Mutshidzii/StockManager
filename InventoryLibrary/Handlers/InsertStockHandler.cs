using InventoryLibrary.Commands;
using MediatR;
using StockInventoryServer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryLibrary.Handlers
{
    public class InsertStockHandler : IRequestHandler<InsertStockCommand, Product>
    {
        private readonly IInventoryDataAccess dataAccess;

        public InsertStockHandler(IInventoryDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }
        public Task<Product> Handle(InsertStockCommand request, CancellationToken cancellationToken)
        {
            Product product = new Product
            {
                ProductName = request.ProductName,
                PartNumber = request.PartNumber,
                ProductLabel = request.ProductLabel,
                StartingInventory = request.StartingInventory,
                InventoryRecieved = request.InventoryRecieved,
                InventoryOnHand = request.InventoryOnHand
            };

            return Task.FromResult(dataAccess.AddStock(product));
        }
    }
}
