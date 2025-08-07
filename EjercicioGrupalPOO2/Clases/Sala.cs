using EjercicioGrupalPOO2.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EjercicioGrupalPOO2.Clases.Reserva;

namespace EjercicioGrupalPOO2.Clases
{
    public abstract class Sala
    {
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public string Ubicacion { get; set; }
        public List<Reserva> Reservas { get; private set; }

        public Sala(string nombre, int capacidad, string ubicacion)
        {
            Nombre = nombre;
            Capacidad = capacidad;
            Ubicacion = ubicacion;
            Reservas = new List<Reserva>();
        }

        public abstract bool Reservar(Evento evento);
    }

    public class SalaComun : Sala
    {
        public bool TieneProyector { get; set; }

        public SalaComun(string nombre, int capacidad, string ubicacion, bool tieneProyector)
            : base(nombre, capacidad, ubicacion)
        {
            TieneProyector = tieneProyector;
        }

        public override bool Reservar(Evento evento)
        {
            Console.WriteLine($"Intentando reservar la SalaComun {Nombre} para el evento: {evento.TituloDelEvento}");

            if (evento is Conferencia)
            {
                Console.WriteLine("Esta sala no es ideal para conferencias grandes");
            }
            Reservas.Add(new Reserva(this, evento));
            Console.WriteLine("Reserva confirmada");
            return true;
        }
    }

    public class Auditorio : Sala
    {
        public bool TieneEquipoDeSonido { get; set; }

        public Auditorio(string nombre, int capacidad, string ubicacion, bool tieneEquipoDeSonido)
            : base(nombre, capacidad, ubicacion)
        {
            TieneEquipoDeSonido = tieneEquipoDeSonido;
        }

        public override bool Reservar(Evento evento)
        {
            Console.WriteLine($"Intentando reservar el Auditorio {Nombre} para el evento: {evento.TituloDelEvento}");

            if (evento is Conferencia)
            {
                Reservas.Add(new Reserva(this, evento));
                Console.WriteLine("Reserva confirmada");
                return true;
            }
            else
            {
                Console.WriteLine($"Reserva rechazada. El Auditorio {Nombre} solo se puede reservar para conferencias");
                return false;
            }
        }
    }

    public class Laboratorio : Sala
    {
        public int CantidadDeComputadoras { get; set; }

        public Laboratorio(string nombre, int capacidad, string ubicacion, int cantidadDeComputadoras)
            : base(nombre, capacidad, ubicacion)
        {
            CantidadDeComputadoras = cantidadDeComputadoras;
        }

        public override bool Reservar(Evento evento)
        {
            Console.WriteLine($"Intentando reservar el Laboratorio {Nombre} para el evento: {evento.TituloDelEvento}");

            if (evento is Practica)
            {
                Reservas.Add(new Reserva(this, evento));
                Console.WriteLine("Reserva confirmada");
                return true;
            }
            else
            {
                Console.WriteLine($"Reserva rechazada. El Laboratorio {Nombre} solo se puede reservar para prácticas");
                return false;
            }
        }
    }
}