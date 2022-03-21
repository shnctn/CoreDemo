using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DaraAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        private WriterManager wm = new WriterManager(new EfWriterRepository());

        /// <summary>
        /// ekleme işlemi yapılırken get ve post methodların isimleri aynı olmak zorundadır.
        /// httpget yüklenirkeb
        /// httppost button tetiklendiginde
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer w)
        {
            WriterValidator wv = new WriterValidator();
            ValidationResult result = wv.Validate(w);
            if (result.IsValid)
            {

                w.WriterStatus = true;
                w.WriterAbout = "Yazar ilk kaydını yaptı.";
                wm.AddWriter(w);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }

            return View();
        }
    }
}
