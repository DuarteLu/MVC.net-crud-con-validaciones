using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ABM.Datos;

namespace ABM.Servicios
{
    public class JugadorServicio
    {
        JugadorEntities ctx = new JugadorEntities();

        public void Agregar(Jugador j)
        {
            ctx.Jugador.Add(j);
            ctx.SaveChanges();
        }

        public Jugador ObtenerPorId(int id)
        {
            return ctx.Jugador.Find(id);

        }
        public void Eliminar(int id)
        {
            var j = ObtenerPorId(id);
            ctx.Jugador.Remove(j);
            ctx.SaveChanges();
        }
        public List<Jugador> ObtenerTodos()
        {
            return ctx.Jugador.ToList();
        }

        public void Modificar(Jugador j)
        {

            Jugador JugViejo = new Jugador();
            JugViejo = ObtenerPorId(j.idJugador);
            JugViejo.Apellido = j.Apellido;
            ctx.SaveChanges();
        }
    }
}
