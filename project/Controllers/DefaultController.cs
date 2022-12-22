using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bussenic_logic;
using model_layer;
namespace project.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Iproductlist prods;
        // GET: Default
        public DefaultController(Iproductlist prod)
        {
            prods = prod;
        }
       
            
        public ActionResult Index()
        {

            var prod = prods.Lict();

            return View(prod);
        }
    }
}