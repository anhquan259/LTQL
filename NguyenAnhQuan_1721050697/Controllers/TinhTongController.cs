using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenAnhQuan_1721050697.Controllers
{
    public class TinhTongController : Controller
    {
        // GET: TinhTong
        public ActionResult Sum(string hsn)
        {
            double s = 0;
            int n, i;
            string Tong = "";
            n = Convert.ToInt32(hsn);
            for (i = 1; i < n; i++)
            {
                s += 1 / (double)i;
            }
            ViewBag.tinhtong = "Tổng = " + s;
            return View();
        }
    }
}