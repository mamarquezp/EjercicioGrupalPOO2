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
        public string TituloDelEvento { get; set; }
        public DateTime FechaDelEvento { get; set; }//para fecha
        public TimeSpan DuracionDelEvento { get; set; }//para duración de evento

        public Evento(string titulo, DateTime fecha, TimeSpan duracion)
        {
            TituloDelEvento = titulo;
            FechaDelEvento = fecha;
            DuracionDelEvento = duracion;
        }
    }
    public class Clase : Evento
    {
        public Clase(string titulo, DateTime fecha, TimeSpan duracion) : base(titulo, fecha, duracion) { }
    }

    public class Conferencia : Evento
    {
        public Conferencia(string titulo, DateTime fecha, TimeSpan duracion) : base(titulo, fecha, duracion) { }
    }

    public class Practica : Evento
    {
        public Practica(string titulo, DateTime fecha, TimeSpan duracion) : base(titulo, fecha, duracion) { }
    }
}