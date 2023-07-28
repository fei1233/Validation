using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;

namespace ASS2._5final.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Manage
        [Authorize(Roles = "Admin")]
        public ActionResult Manage()
        {
            // Implement your logic here, e.g., retrieve data from the database or perform actions related to managing data.
            // You can also pass data to the view if needed.

            return View();
        }
    }
}
