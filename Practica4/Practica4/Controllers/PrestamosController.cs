using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica4.Models;
using System.Net;
using System.Data.Entity;

namespace Practica4.Controllers
{
    public class PrestamosController : Controller
    {
        #region Contexto
        // Atributo contexto
        private bibiotecaEntities _contexto;
        //PPropiedad contexto
        public bibiotecaEntities Contexto
        {
            set { _contexto = value; }
            get
            {
                if (_contexto == null)
                    _contexto = new bibiotecaEntities();
                return _contexto;
            }
        }
        #endregion
        // GET: Prestamos
        public ActionResult Index()
        {
            return View(Contexto.Prestamos.ToList());
        }
    }
}