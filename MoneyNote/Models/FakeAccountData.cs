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
        /// 記憶體暫存記帳本
        /// </summary>
        private static List<AccountViewModel> MyAccountBooks;

        public List<AccountViewModel> GetFakeAccountData()
        {
            MyAccountBooks = new List<AccountViewModel>();

            //收入的sample資料
            for (int i = 1; i < 51; i++)
            {
                if (i <= 25)

                    MyAccountBooks.Add(new AccountViewModel { Id = i, Category = "收入", Amoount = i * 1000, UpdateDate = DateTime.Now.AddDays(i), Remarks = "收入" + i });
                else
                    MyAccountBooks.Add(new AccountViewModel { Id = i, Category = "支出", Amoount = i * 500, UpdateDate = DateTime.Now.AddDays(i), Remarks = "支出" + i });

            }


            return MyAccountBooks;

        }

    }
}