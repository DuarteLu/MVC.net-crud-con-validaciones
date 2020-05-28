using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ABM.Servicios;
using ABM.Datos;
using System.ComponentModel.DataAnnotations;

namespace ABM.Controllers
{
    public class JugadoresController : Controller
    {
        JugadorServicio Jugadores = new JugadorServicio();

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult Agregar([Bind(Include = "idJugador,Apellido,Edad")] Jugador j)
        {
            if (ModelState.IsValid)
            {

                Jugadores.Agregar(j);
                return Redirect("/Jugador/Lista");
            }
            return View(j);
        }
        [HttpGet]
        public ActionResult Agregar()
        {
            return View();
        }

        public ActionResult Lista()
        {
            return View(Jugadores.ObtenerTodos());
        }
        [HttpGet]
        public ActionResult Modificar(int id)
        {
            Jugador j = Jugadores.ObtenerPorId(id);
            return View(j);
        }

        [HttpPost]
        public ActionResult Modificar(Jugador j)
        {
            Jugadores.Modificar(j);
            return Redirect("/Jugador/Lista");
        }

        public ActionResult Eliminar(int id)
        {
            Jugadores.Eliminar(id);
            return Redirect("/Jugador/Lista");
        }
    }


}
}