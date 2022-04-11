using maithithuy_GK.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace maithithuy_GK.Controllers
{
    public class ShopController : Controller
    {

        // GET: Shop
        public ActionResult Index()
        {
            DatabaseContext db = new DatabaseContext();
            return View(db.Products.ToList());
        }
    }
}