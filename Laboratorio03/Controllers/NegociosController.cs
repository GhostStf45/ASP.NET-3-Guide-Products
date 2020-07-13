using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio03.Models;

namespace Laboratorio03.Controllers
{
    public class NegociosController : Controller
    {

            public Negocios2017Entities2 bd = new Negocios2017Entities2();

            public ActionResult Clientes()
            {
                
                return View(bd.tb_clientes.ToList());
            }
            public ActionResult PaginacionClientes(int ? pag)
            {
                int c = bd.tb_clientes.Count();
                ViewBag.numreg = c % 10 != 0 ? c / 10 + 1 : c / 10;
                int pageact = pag == null ? 0: (int)pag;
                int reginicio = pageact * 10;
                int regfin = reginicio + 10;
                List<tb_clientes> lista = new List<tb_clientes>();
                for (int i = reginicio; i < regfin; i++)
                {
                    if (i == c) break;
                    lista.Add(bd.tb_clientes.ToList()[i]);
                }
                return View(lista);
            }
            //GET : Negocios
            public ActionResult Index()
            {
                return View();
            }
        
    }
}