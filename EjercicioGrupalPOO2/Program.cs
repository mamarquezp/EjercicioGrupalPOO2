/*
 Ejercicio 1

Una universidad desea automatizar el proceso de reservas de salas para eventos académicos y
extracurriculares. Debes diseñar un sistema que permita registrar diferentes tipos de salas, gestionar sus
reservas, validar la disponibilidad, y aplicar reglas especiales según el tipo de sala o evento.

Requisitos:
Existen diferentes tipos de salas: SalaComun, Auditorio, Laboratorio.
Cada sala tiene propiedades comunes (nombre, capacidad, ubicación), pero también atributos únicos
(por ejemplo, equipo de sonido, computadoras, proyector).
Debe haber una clase abstracta o interfaz que obligue a implementar un método Reservar() con reglas
distintas por tipo de sala.
Las reservas deben validarse según el tipo de evento (clase, conferencia, práctica) y horarios disponibles.
El sistema debe permitir listar todas las reservas realizadas y su estado (confirmada, rechazada,
pendiente).
Aplicar encapsulamiento para proteger datos sensibles como contacto del organizador, notas privadas,
etc.
Debe usarse una colección polimórfica para manejar y ejecutar las reservas.

Sugerencia: Podrían agregar una clase Evento con subclases o polimorfismo para definir distintos
comportamientos según el tipo de evento.
*/
using EjercicioGrupalPOO2.Clases;

namespace EjercicioGrupalPOO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sala> salas = new List<Sala>();
            salas.Add(new SalaComun("Aula 101", 30, "Edificio A", true));
            salas.Add(new Auditorio("Auditorio Central", 200, "Edificio de Conferencia", true));
            salas.Add(new Laboratorio("Lab de Computación", 25, "Edificio de Ingeniería", 25));

            Organizador organizador1 = new Organizador("Diego Gómez", "diego.gomez@email.com", "Notas privadas de evento");
            Organizador organizador2 = new Organizador("Mike Márquez", "mike.marquez@email.com", "Notas privadas de Mike");

            List<Reserva> todasLasReservas = new List<Reserva>(); //para guardar todas las reservas

            Evento claseMatematicas = new Clase("Clase de Matemáticas", new DateTime(2025, 8, 10, 9, 0, 0), TimeSpan.FromHours(2));//fecha en AAAA,MM,DD,HH,MM,SS (formato de 24hrs) duración en h
            Evento congresoIA = new Conferencia("Congreso de Inteligencia Artificial", new DateTime(2025, 8, 15, 10, 0, 0), TimeSpan.FromHours(4));
            Evento practicaRedes = new Practica("Práctica de Redes", new DateTime(2025, 8, 12, 14, 0, 0), TimeSpan.FromHours(3));
            Evento practicaProgramacion = new Practica("Práctica de Programación", new DateTime(2025, 8, 12, 14, 0, 0), TimeSpan.FromHours(2));

            Console.WriteLine("--- Realizando reservas ---");

            var reserva1 = new Reserva(salas[1], congresoIA, organizador1);
            if (salas[1].Reservar(congresoIA, organizador1))
            {
                reserva1.Estado = EstadoReserva.Confirmada;
                todasLasReservas.Add(reserva1);
            }
            else
            {
                reserva1.Estado = EstadoReserva.Rechazada;
                todasLasReservas.Add(reserva1);
            }
            
            Console.WriteLine();

            var reserva2 = new Reserva(salas[1], claseMatematicas, organizador1);
            if (salas[1].Reservar(claseMatematicas, organizador1))
            {
                reserva2.Estado = EstadoReserva.Confirmada;
                todasLasReservas.Add(reserva2);
            }
            else
            {
                reserva2.Estado = EstadoReserva.Rechazada;
                todasLasReservas.Add(reserva2);
            }

            Console.WriteLine();

            var reserva3 = new Reserva(salas[2], practicaRedes, organizador2);
            if (salas[2].Reservar(practicaRedes, organizador2))
            {
                reserva3.Estado = EstadoReserva.Confirmada;
                todasLasReservas.Add(reserva3);
            }
            else
            {
                reserva3.Estado = EstadoReserva.Rechazada;
                todasLasReservas.Add(reserva3);
            }
            
            Console.WriteLine();

            var reserva4 = new Reserva(salas[2], practicaProgramacion, organizador2);
            if (salas[2].Reservar(practicaRedes, organizador2))
            {
                reserva4.Estado = EstadoReserva.Confirmada;
                todasLasReservas.Add(reserva4);
            }
            else
            {
                reserva4.Estado = EstadoReserva.Rechazada;
                todasLasReservas.Add(reserva4);
            }

            Console.WriteLine();

            var reserva5 = new Reserva(salas[0], claseMatematicas, organizador1);
            if (salas[0].Reservar(practicaRedes, organizador1))
            {
                reserva5.Estado = EstadoReserva.Confirmada;
                todasLasReservas.Add(reserva5);
            }
            else
            {
                reserva5.Estado = EstadoReserva.Rechazada;
                todasLasReservas.Add(reserva5);
            }

            Console.WriteLine();

            Console.WriteLine("--- Listado de Reservas ---");
            foreach (var reserva in todasLasReservas)
            {
                reserva.Mostrar();
            }
        }
    }
}