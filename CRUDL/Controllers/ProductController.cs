using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUDL.Models;
using System.Web.Mvc;
namespace CRUDL.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product6
        static IList<ProductDetails> products = new List<ProductDetails>
        {
            new ProductDetails(){ProId=01,ProName="Apple",Price=100,DeptName=dept.fruits}
        };
        public ActionResult DisplayTable()
        {
            return View(products);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProId,ProName,Price,DeptName")] ProductDetails pro)
        {
            if (ModelState.IsValid)
            {
                products.Add(pro);
                return RedirectToAction("DisplayTable");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var edit=products.Where(s=>s.ProId == Id).FirstOrDefault();
            return View(edit);
        }
        [HttpPost]
        public  ActionResult Edit(ProductDetails pro)
        {
            var edits = products.Where(s => s.ProId == pro.ProId).FirstOrDefault();
            products.Remove(edits);
            products.Add(pro);
            return RedirectToAction("DisplayTable");
        }
        [HttpGet]
        public ActionResult Details(int Id) {
            var edit = products.Where(s => s.ProId == Id).FirstOrDefault();
            return View(edit);
        }
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var delete = products.Where(s => s.ProId == Id).FirstOrDefault();
            products.Remove(delete);
            return RedirectToAction("DisplayTable");

        }
    }
}