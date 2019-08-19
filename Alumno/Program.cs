using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno
{
    class Program
    {
        static void Main(string[] args)
        {

            Alumno alumno = new Alumno();

            Console.WriteLine("Matrícula:       " + alumno.Matricula);
            Console.WriteLine("Nombre:          " + alumno.Nombre);

            

            Console.WriteLine("\n\nAlumno 2");

            Alumno alumno1 = new Alumno("Pedro", "189299");

            Console.WriteLine("Matrícula:       " + alumno1.Matricula);

            Console.WriteLine("Nombre:          " + alumno1.Nombre);

            Console.ReadLine();



        }
    }
}
