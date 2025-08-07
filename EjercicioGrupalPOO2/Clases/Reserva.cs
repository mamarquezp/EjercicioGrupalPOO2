using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGrupalPOO2.Clases
{
    public enum EstadoReserva { Pendiente, Confirmada, Rechazada } 

    public class Reserva
    {
        public Sala Sala { get; private set; }
        public Evento Evento { get; private set; }
        public EstadoReserva Estado { get; set; }
        public Organizador Organizador { get; private set; }

        public Reserva(Sala sala, Evento evento, Organizador organizador)
        {
            Sala = sala;
            Evento = evento;
            Estado = EstadoReserva.Pendiente;
            Organizador = organizador;
        }

        public void Mostrar()
        {
            Console.WriteLine("--- Reserva ---");
            Console.WriteLine($"Evento: {Evento.TituloDelEvento}");
            Console.WriteLine($"Sala: {Sala.Nombre}");
            Console.WriteLine($"Organizador: {Organizador.Nombre}");
            Console.WriteLine($"Horario: {Evento.FechaDelEvento:dd/MM/yyyy HH:mm} | Duración: {Evento.DuracionDelEvento}");
            Console.WriteLine($"Estado: {Estado}");
            Console.WriteLine("---------------");
        }
    }
}