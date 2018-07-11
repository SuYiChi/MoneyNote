using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoneyNote.Models.ViewModels
{
    public class AccountViewModel
    {
        /// <summary>
        /// 流水號
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 類別
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// 新增紀錄的日期
        /// </summary>
        public DateTime UpdateDate { get; set; }
        /// <summary>
        /// 金額
        /// </summary>
        public int Amoount { get; set; }
        /// <summary>
        /// 備註
        /// </summary>
        public string Remarks { get; set; }



    }
}