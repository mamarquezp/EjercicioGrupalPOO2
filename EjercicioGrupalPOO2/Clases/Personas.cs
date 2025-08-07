using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EjercicioGrupalPOO2.Clases.Personas;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjercicioGrupalPOO2.Clases
{
    internal class Personas
    {
        public class Organizador
        {
            public string Nombre { get; set; }
            private string Contacto { get; set; }
            private string NotasPrivadas { get; set; }

            public Organizador(string nombre, string contacto, string notas)
            {
                Nombre = nombre;
                Contacto = contacto;
                NotasPrivadas = notas;
            }
        }

        public class Reserva
        {
            public Evento Evento { get; private set; }
            public Sala Sala { get; private set; }

            public Reserva(Sala sala, Evento evento)
            {
                Sala = sala;
                Evento = evento;
                
            }

            public void Mostrar()
            {
                Console.WriteLine($"Evento: {Evento.TituloDelEvento} | Sala: {Sala.Nombre} | duracion: {Evento.duracionDelEvento}");
            }
        }
    }
    }