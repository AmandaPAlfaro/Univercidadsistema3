using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univercidad
{
    class DocenteVista
    {
        Univercidad universidad = new Univercidad("Sansimon");
        public void docenteVista()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1.Seleccionar MAteria");
                Console.WriteLine("2.Retirar Materia");
                Console.WriteLine("3.Seleccionar Horario");

                opcion = Int32.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese la carrera");
                        string nombreCarrera = Console.ReadLine();
                        Carrera carrera = universidad.getCarrera(nombreCarrera);
                        Console.WriteLine("Ingrese nombre del Docente");
                        Docente docente = new Docente(Console.ReadLine());
                        docente.mostrarDocente();
                        universidad.imprimeDocente();
                        Console.WriteLine("Tome Materias");
                        Materia materia = new Materia(Console.ReadLine());
                        docente.ingreseMateria(materia);
                        break;

                    case 2:
                        Console.WriteLine("Retirar Materia");
                        string eliminarmateria = Console.ReadLine();
                        universidad.eliminarMateria(eliminarmateria);
                        Console.WriteLine();                       
                        break;

                    case 3:
                        Console.WriteLine("Seleccionar Horario");



                        break;

                    default:
                        Console.WriteLine("Esta obcion no existe");
                        break;
                }
            } while (true);
        }
    }
}
