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
    public class GetStockListHandler : IRequestHandler<GetStockListQuery, List<Product>>
    {
        private readonly IInventoryDataAccess dataAccess;

        public GetStockListHandler(IInventoryDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }
        public Task<List<Product>> Handle(GetStockListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(dataAccess.GetStock());
        }
    }
}
