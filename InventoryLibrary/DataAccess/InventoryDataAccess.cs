using StockInventoryServer.Models;
using System.Collections.Generic;
using System.Linq;

namespace InventoryLibrary
{
    //This class is responsible for database communication, all the CRUD Methods are done here.
    public class InventoryDataAccess : IInventoryDataAccess
    {
        private readonly StocksDBContext context;

        public InventoryDataAccess(StocksDBContext context)
        {
            this.context = context;
        }

        public Product AddStock(Product product)
        {

            var newProduct = new Product
            {
                ProductName = product.ProductName,
                PartNumber = product.PartNumber,
                ProductLabel = product.ProductLabel,
                StartingInventory = product.StartingInventory,
                InventoryRecieved = product.InventoryRecieved,
                InventoryOnHand = product.InventoryOnHand
            };

            //add and save the product to the database
            context.Product.Add(newProduct);
            context.SaveChanges();

            return newProduct;
        }

        //Returns a single product
        public Product GetStock(int id)
        {
            var product = context.Product.Find(id);
            return product;
        }

        //returns a list of stock items
        public List<Product> GetStock()
        {
            return context.Product.ToList();
        }

        //Update stock
        public Product UpdateStock(Product product)
        {
            Product productUpdate = context.Product.Find(product.Id);

            productUpdate.ProductName = product.ProductName;
            productUpdate.ProductLabel = product.ProductLabel;
            productUpdate.PartNumber = product.PartNumber;
            productUpdate.InventoryRecieved = product.InventoryRecieved;
            productUpdate.InventoryOnHand = productUpdate.InventoryOnHand;
            productUpdate.StartingInventory = productUpdate.StartingInventory;

            context.SaveChanges();

            return productUpdate;
        }

        //delete stock
        public Product DeleteStock(int id)
        {
            Product product = context.Product.Find(id);
            context.Product.Remove(product);
            context.SaveChanges();
            
            return product;
        }
    }
}
