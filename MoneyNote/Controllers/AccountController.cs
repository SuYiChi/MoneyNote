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
        // GET: 回傳帳簿資料
        public ActionResult Index()
        {
           
            return View();
        }
        [ChildActionOnly]
        public ActionResult AccountItems()
        {
            FakeAccountData accountBooks = new FakeAccountData();

            return View(accountBooks.GetFakeAccountData());
        }
    }
}