using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGrupalPOO2.Clases
{
    public class Evento
    {
        // Propiedades del evento
        public string TituloDelEvento { set; get; }

        public DateTime fechaDelEvento { set; get; }

        public TimeSpan duracionDelEvento { set; get; }
        public Evento (string tituloDelEvento, DateTime fecha, TimeSpan duracion)
        {
            TituloDelEvento = tituloDelEvento;
            fechaDelEvento = fecha;
            duracionDelEvento = duracion;
        }
    }
    public class Clase : Evento
    {
        // Subclase para clase académica
        public Clase(string tituloDelEvento, DateTime fecha, TimeSpan duracion)
            : base(tituloDelEvento, fecha, duracion) { }
    }

    public class Conferencia : Evento
    {
        // Subclase para clase comferencia
        public Conferencia(string tituloDelEvento, DateTime fecha, TimeSpan duracion)
            : base(tituloDelEvento, fecha, duracion) { }
    }

    public class Practica : Evento
    {
        // Subclase para clase practica
        public Practica(string tituloDelEvento, DateTime fecha, TimeSpan duracion)
            : base(tituloDelEvento, fecha, duracion) { }
    }

}
