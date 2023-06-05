using AppQuarta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppQuarta.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult InsertPessoa()
        {  
            return View();
        }

        [HttpPost]
        public ActionResult InsertPessoa(Pessoa objPessoa)
        {   
            if(ModelState.IsValid)
            {
                return View("Resultado", objPessoa);
            }

            //if(string.IsNullOrEmpty(objPessoa.Obs))
            //{
            //    ModelState.AddModelError("Obs", "O campo observação é obrigatório")
            //}
            return View();
        }

        public ActionResult Resultado(Pessoa objPessoa) { return View(objPessoa); }
    }
}