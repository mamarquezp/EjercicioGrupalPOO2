using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGrupalPOO2.Clases
{
    public abstract class Sala
    {
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public string Ubicacion { get; set; }
        public Sala(string nombre, int capacidad, string ubicacion)
        {
            Nombre = nombre;
            Capacidad = capacidad;
            Ubicacion = ubicacion;
        }
        public abstract void Reservar();
    }
}
