using MediatR;
using StockInventoryServer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryLibrary.Commands
{
    public class DeleteStockCommand : IRequest<Product>
    {
        public int Id { get; set; }

        public DeleteStockCommand(int id)
        {
            this.Id = id;
        }
    }
}
