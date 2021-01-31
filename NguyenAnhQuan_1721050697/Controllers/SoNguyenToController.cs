using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenAnhQuan_1721050697.Models.MyProcess;

namespace NguyenAnhQuan_1721050697.Controllers
{
    public class SoNguyenToController : Controller
    {
        // GET: SoNguyenTo
        public ActionResult SNT(string soN)
        {
            int n, tong = 0;
            n = Convert.ToInt32(soN);
            List<int> SoNguyenTo = new List<int>(); //Tạo DS SNT < n
            for(int i = 1; i < n; i++)
            {
                if (kiemTraSNT(i) == true)
                {
                    SoNguyenTo.Add(i);
                }
            }
            foreach(int a in SoNguyenTo) //Lấy SNT trong List SNT vừa thêm
            {
                int check = tong + a;
                if(check < 100)
                {
                    tong += a;
                }
            }
            bool kiemTraSNT(int number)
            {
                int dem = 0;
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            ViewBag.List = SoNguyenTo;
            ViewBag.Tong = "Tổng các số nguyên tố = " + tong;
            return View();
        }
    }
}