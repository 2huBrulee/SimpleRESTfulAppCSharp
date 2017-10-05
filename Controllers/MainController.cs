using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SimpleRESTfulApp.Controllers
{
    [Route("/")]
    public class MainController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "lds", "fake" };
        }
    }
}