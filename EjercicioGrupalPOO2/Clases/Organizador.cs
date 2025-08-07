using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGrupalPOO2.Clases
    {
        public class Organizador
        {
            public string Nombre { get; set; } //Pública
            private string Contacto { get; set; } // Privada
            private string NotasPrivadas { get; set; } // Privada

            public Organizador(string nombre, string contacto, string notas)
            {
                Nombre = nombre;
                Contacto = contacto;
                NotasPrivadas = notas;
            }
        }
    }
