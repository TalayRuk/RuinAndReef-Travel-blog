using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RuinAndReef.Controller
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}

//HomeController inherits from the Controller class which has public methods, called "actions".
//This action return an instance of IActionResult (this can be many forms, but in this case we choose View
//View method is called w/no parameters = it'll look for the view w/the same name as the action (in this case Index() method will return the **Index view)*
