using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatRSimpleExample.domainmodel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using MediatRSimpleExample.Notifaction;
namespace MediatRSimpleExample.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public PostController(IMediator mediator)
        {
            this._Mediator = mediator;
        }
        [HttpPost("PublishPost")]
        public async Task PublishPost(Post post)
        {
            var PostNotifaction = new PostNotifaction { _post=post };

             await _Mediator.Publish(PostNotifaction);
        }
    }
}