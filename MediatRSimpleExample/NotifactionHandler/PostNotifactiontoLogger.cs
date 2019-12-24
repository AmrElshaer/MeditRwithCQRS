using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatRSimpleExample.Notifaction;
using Microsoft.Extensions.Logging;

namespace MediatRSimpleExample.NotifactionHandler
{
    public class PostNotifactiontoLogger : INotificationHandler<PostNotifaction>
    {
      
        public async Task Handle(PostNotifaction notification, CancellationToken cancellationToken)
        {
            //You Can Add code To Send Post Cross Email
            Console.WriteLine($"Post Create {notification._post.Content}");
        }
    }
}
