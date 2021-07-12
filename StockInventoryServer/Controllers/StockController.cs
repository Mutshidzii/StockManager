using EmailService;
using InventoryLibrary.Commands;
using InventoryLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using StockInventoryServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockInventoryApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class StockController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IEmailSender _emailSender;
        public StockController(IMediator mediator,IEmailSender emailSender)
        {
            this.mediator = mediator;
            _emailSender = emailSender;
        }

        [HttpGet("stocks")]
        public Task<List<Product>> GetStocks()
        {
            return mediator.Send(new GetStockListQuery());
        }

        [HttpGet("stock/{id}")]
        public Task<Product> GetStock(int id)
        {
            return mediator.Send(new GetStockByIdQuery(id));
        }

        [HttpPost("insertStock")]
        public async Task<Product> InsertStock([FromBody] Product newproduct) 
        {
            var message = new Message(new string[] { newproduct.Email }, "Report Email", "This content is from our email");
            await _emailSender.SendEmailAsync(message);
            return await mediator.Send(new InsertStockCommand(newproduct));
        }

        [HttpPut("updateStock")]
        public async Task<Product> UpdateStock([FromBody] Product product)
        {
            return await mediator.Send(new UpdateStockCommand(product));
        }

        [HttpDelete("deleteStock/{id}")]
        public async Task<Product> DeleteStock(int id)
        {
            return await mediator.Send(new DeleteStockCommand(id));
        }
    }
}
