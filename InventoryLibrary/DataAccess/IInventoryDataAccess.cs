using StockInventoryServer.Models;
using System.Collections.Generic;

namespace InventoryLibrary
{
    public interface IInventoryDataAccess
    {
        Product AddStock(Product product);
        List<Product> GetStock();
        Product GetStock(int id);
        Product UpdateStock(Product product);
        Product DeleteStock(int id);
    }
}