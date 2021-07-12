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
    public class DeleteStockHandler : IRequestHandler<DeleteStockCommand, Product>
    {
        private readonly IInventoryDataAccess dataAccess;

        public DeleteStockHandler(IInventoryDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }
        public Task<Product> Handle(DeleteStockCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(dataAccess.DeleteStock(request.Id));
        }
    }
}
