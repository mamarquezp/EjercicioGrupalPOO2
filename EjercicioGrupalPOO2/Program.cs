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
