using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace ApiFramwork.Controllers
{
    [Route("api/{service}/{method}")]
    // [Route("api")]
    public class RootController : Controller
    {
        public RootController()
        {

        }

        public string Get()
        { 
            var s = this.RouteData.Values;
            string service = this.RouteData.Values["service"].ToString();
            string method = this.RouteData.Values["method"].ToString();
            return $"{service}-{method}";
        }
    }
}