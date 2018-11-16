using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(Realtime_SignalR.Models.StartUp))]
namespace Realtime_SignalR.Models
{
    public class StartUp
    {

        public void Configuration(IAppBuilder app)
        {

            app.MapSignalR();

        }
    }
}