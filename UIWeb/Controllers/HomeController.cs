using Business.Abstract;
using Entities.DtoConcrete.DtoOrders;
using Microsoft.AspNetCore.Mvc;
using System;

namespace UIWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrdersManager manager;


        public HomeController(IOrdersManager _manager)
        {
            manager = _manager;
        }

        

        public IActionResult Index()
        {

            

            return Json("");
        }
    }
}
