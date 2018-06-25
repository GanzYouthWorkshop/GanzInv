using GEV.Web.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzInv
{
    public class Serverside
    {
        private WebServer m_Server;

        public Serverside()
        {
            this.m_Server = new WebServer(5600, @".\wwwroot\");
            this.m_Server.Start();
            this.m_Server.CompiledRequestHandlers.Add("ajax.mws", this.AjaxHandler);
        }

        public bool AjaxHandler(RequestHandler handler)
        {


            return true;
        }
    }
}
