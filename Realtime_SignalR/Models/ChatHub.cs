using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Realtime_SignalR.Models
{
    [HubName("ChatHub")]

    public class ChatHub : Hub
    {

        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.push(name, message);
        }
    }
}