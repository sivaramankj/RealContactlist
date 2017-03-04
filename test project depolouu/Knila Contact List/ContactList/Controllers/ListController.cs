using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;
namespace ContactList.Controllers
{
    [Authorize]
    public class ListController : Controller
    {
        // GET: test
        public ActionResult Index()
        {
            var c = new Data.Domain.Contact();
            return View(c);
        }
        [HttpPost]
        public ActionResult Index(Data.Domain.Contact contact)
        {
            if (ModelState.IsValid == false)
            {
                return View(contact);
            }
            return RedirectToAction("index");
        }

    }
}