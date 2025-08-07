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

            List<Reserva> todasLasReservas = new List<Reserva>(); //para guardar todas las reservas

            Evento claseMatematicas = new Clase("Clase de Matemáticas", new DateTime(2025, 8, 10, 9, 0, 0), TimeSpan.FromHours(2));//fecha en AAAA,MM,DD,HH,MM,SS (formato de 24hrs) duración en h
            Evento congresoIA = new Conferencia("Congreso de Inteligencia Artificial", new DateTime(2025, 8, 15, 10, 0, 0), TimeSpan.FromHours(4));
            Evento practicaRedes = new Practica("Práctica de Redes", new DateTime(2025, 8, 12, 14, 0, 0), TimeSpan.FromHours(3));

            Console.WriteLine("--- Realizando reservas ---");

            bool reserva1Exitosa = salas[1].Reservar(congresoIA);
            if (reserva1Exitosa)
            {
                todasLasReservas.Add(new Reserva(salas[1], congresoIA));
            }

            Console.WriteLine();

            bool reserva2Exitosa = salas[1].Reservar(claseMatematicas);
            if (reserva2Exitosa)
            {
                todasLasReservas.Add(new Reserva(salas[1], claseMatematicas));
            }

            Console.WriteLine();

            bool reserva3Exitosa = salas[2].Reservar(practicaRedes);
            if (reserva3Exitosa)
            {
                todasLasReservas.Add(new Reserva(salas[2], practicaRedes));
            }

            Console.WriteLine();

            bool reserva4Exitosa = salas[0].Reservar(claseMatematicas);
            if (reserva4Exitosa)
            {
                todasLasReservas.Add(new Reserva(salas[0], claseMatematicas));
            }

            Console.WriteLine();

            Console.WriteLine("--- Listado de Reservas Exitosas ---");
            foreach (var reserva in todasLasReservas)
            {
                reserva.Mostrar();
            }
        }
    }
}