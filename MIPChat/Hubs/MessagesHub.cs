﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace MIPChat.Hubs
{
    public class MessagesHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}