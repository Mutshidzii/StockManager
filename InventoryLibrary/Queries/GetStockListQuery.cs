using MediatR;
using StockInventoryServer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryLibrary.Queries
{
    public class GetStockListQuery : IRequest<List<Product>>
    {
    }
}
