using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public DateTime FechadeNacimiento { get; set; }
        public string Dirección { get; set; }
        public string Telefono { get; set; }

        
        public Alumno()
        {
            Nombre = "Pendiente";
            Matricula = "Sin Asignar";
        }

        public Alumno(string nombre , string matricula)
        {
            Nombre = nombre;
            Matricula = matricula;
        }

    }
}
