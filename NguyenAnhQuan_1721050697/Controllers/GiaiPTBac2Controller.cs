using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenAnhQuan_1721050697.Controllers
{
    public class GiaiPTBac2Controller : Controller
    {
        // GET: GiaiPTBac2
        public ActionResult GPT(string hsa, string hsb, string hsc)
        {
            double a, b, c, delta, x1, x2;
            string KetQua = "";
            a = Convert.ToDouble(hsa);
            b = Convert.ToDouble(hsb);
            c = Convert.ToDouble(hsc);
            delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                KetQua = "PT vô nghiệm";
            }
            else if (delta == 0)
            {
                x1 = b / (2 * a);
                KetQua = "PT có nghiệm kép = " + x1;
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                KetQua = "PT có 2 nghiệm x1 = " + x1 + " và x2 = " + x2;
            }
            ViewBag.ketqua = "Kết quả : " + KetQua;
            return View();
        }
    }
}