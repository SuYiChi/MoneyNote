using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoneyNote.Models;

namespace MoneyNote.Controllers
{
    public class AccountController : Controller
    {
        // GET: money
        public ActionResult Index()
        {
            FakeAccountData AccountBooks = new FakeAccountData();

            return View(AccountBooks.GetFakeAccountData());
        }
    }
}