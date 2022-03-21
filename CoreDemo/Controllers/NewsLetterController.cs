using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DaraAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {
        private NewsLetterManager nwm = new NewsLetterManager(new EfNewsLetterRepository());
        [HttpGet]
        public PartialViewResult SubScirebeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubScirebeMail(NewsLetter p)
        {
            p.MailStatus = true;
            nwm.AddNewsLetter(p);
            return PartialView();
        }
    }
}
