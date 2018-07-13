using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MoneyNote.Models.ViewModels;

namespace MoneyNote.Models
{
    public class FakeAccountData
    {
        /// <summary>
        /// Gets the fake account data.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AccountViewModel> GetFakeAccountData()
        {
            //收入的sample資料
            for (var i = 1; i < 51; i++)
            {
                var type = i < 25 ? "收入" : "支出";
                yield return new AccountViewModel
                {
                    Id         = i,
                    Category   = type,
                    Amoount    = i * i < 25 ? 1000 : 500,
                    UpdateDate = DateTime.Now.AddDays(i),
                    Remarks    = type + i
                };
            }
        }
    }
}