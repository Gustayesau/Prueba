using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
   
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            //Estudiante c = new Estudiante();           
            Estudiante c = new Estudiante();
            //    List<string> materias = new List<string>()
            //    {
            //        "matematica","algoritmia","mvc basico",
            //        "historia del internet","use tools","linq"
            //};
            //    var query = from n in materias
            //                where n.StartsWith("m")
            //                select n;
            if (Request.HttpMethod == "POST")
            {
                string elejir = Request["g"];
                if (elejir == "N")
                {
                string buscar = Request["nom"];
                var query = from a in c.Lista() where a.Nombre.Contains(buscar) select a;
                return View(query.ToList());
                }else if (elejir=="M")
                {
                    string buscar = Request["nom"];
                    var query = from a in c.Lista() where a.Materia.Contains(buscar) select a;
                    return View(query.ToList());
                }
                else if (elejir == "P")
                {
                    string buscar = Request["nom"];
                    int bus =Convert.ToInt32(buscar);
                    
                    var query = (from a in c.Lista() where a.Promedio==bus select a);
                    return View(query.ToList());
                }

            }
           
            return View(c.Lista().ToList());
        }
        

    }
}