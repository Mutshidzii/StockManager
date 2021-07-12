using MediatR;
using StockInventoryServer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryLibrary.Queries
{
    public class GetStockByIdQuery : IRequest<Product>
    {
        public int Id { get; set; }
        public GetStockByIdQuery(int id)
        {
            Id = id;
        }
    }
}
