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
    public class UpdateStockHandler : IRequestHandler<UpdateStockCommand, Product>
    {
        private readonly IInventoryDataAccess dataAccess;

        public UpdateStockHandler(IInventoryDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }
        public Task<Product> Handle(UpdateStockCommand request, CancellationToken cancellationToken)
        {
            Product product = new Product
            {
                Id = request.Id,
                ProductName = request.ProductName,
                PartNumber = request.PartNumber,
                ProductLabel = request.ProductLabel,
                StartingInventory = request.StartingInventory,
                InventoryRecieved = request.InventoryRecieved,
                InventoryOnHand = request.InventoryOnHand
            };

            return Task.FromResult(dataAccess.UpdateStock(product));
        }
    }
}
