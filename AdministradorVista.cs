using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univercidad
{
    class AdministradorVista
    {
        Univercidad univercidad = new Univercidad("Sansimon");
        public void administradorVista() 
        {         
            int opcion = 0;
            do
            {
                Console.WriteLine("1.Crear Carrera");
                Console.WriteLine("2.Crear Materias");
                Console.WriteLine("3.Crear Docente");
                Console.WriteLine("4.Crear Alumno");

                opcion = Int32.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Crea Carrera");
                        Carrera carrera = new Carrera(Console.ReadLine());
                        univercidad.ingreseCarrera(carrera);
                        univercidad.imprimirCarreras();
                        break;
                    case 2:
                        Console.WriteLine("Crea Materias");
                        Materia materia = new Materia(Console.ReadLine());
                        univercidad.ingresarMateria(materia);
                        univercidad.imprimiMateria();
                        break;
                    case 3:
                        Console.WriteLine("Crea Docente");
                        Docente docente = new Docente(Console.ReadLine());
                        univercidad.ingreseDocente(docente);
                        univercidad.imprimeDocente();
                        break;
                    case 4:
                        Console.WriteLine("Crea Alumno");
                        Alumno alumno = new Alumno(Console.ReadLine());
                        univercidad.ingreseAlumnos(alumno);
                        univercidad.imprimirAlumnos();


                        break;

                    default:
                        Console.WriteLine("Esta obcion no existe");
                        break;
                }
            }
            while (opcion >= 4);
        }      
    }
}
