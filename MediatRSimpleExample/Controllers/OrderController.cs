using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatRSimpleExample.domainmodel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using MediatRSimpleExample.Repository;
using MediatRSimpleExample.Query;
using MediatRSimpleExample.Commands;

namespace MediatRSimpleExample.Controllers
{
   //kjjj
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        
        public readonly IMediator _mediator;
        public  OrderController(IMediator mediatR)
        {
            this._mediator = mediatR;
        }
        [HttpGet("Orders")]
        public async  Task<IActionResult> Orders()
        {
            var query = new GetAllOrders();
           var resuilt= await _mediator.Send(query);
            return Ok(resuilt);
           
        }


  




        [HttpPost("AddOrder")]
        public async Task<IActionResult> CreatOrder(Order order)
        {
            var command = new CreateOrder(order);
            var response =await _mediator.Send(command);
            if (response!=null)
            {
               return RedirectToAction(nameof(Orders));

            }
            return null;
            

        }










        [HttpGet("GetOrder/{Id}")]
        public async Task<IActionResult> GetOrderById(Guid Id)
        {
            var query = new GetorderbyIdQuery(Id);
            var response = await _mediator.Send(query);
            if (response !=null)
            {
                return Ok(response);
            }
            return null;
        }

    }
}