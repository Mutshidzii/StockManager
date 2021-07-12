using InventoryLibrary.Queries;
using MediatR;
using StockInventoryServer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryLibrary.Handlers
{
    public class GetStockByIdHandler : IRequestHandler<GetStockByIdQuery, Product>
    {
        private readonly IInventoryDataAccess dataAccess;

        public GetStockByIdHandler(IInventoryDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public Task<Product> Handle(GetStockByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(dataAccess.GetStock(request.Id));
        }
    }
}
