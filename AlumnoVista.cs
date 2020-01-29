using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univercidad
{
    class AlumnoVista
    {

        Univercidad universidad = new Univercidad("Sansimon");
        

        public void alumnoVista() 
        {
            do
            {
                int opcion = 0;

                Console.WriteLine("1.Tomar materia");
                Console.WriteLine("2.Ver horario");
                Console.WriteLine("3.Retirar materia");

                opcion = Int32.Parse(Console.ReadLine());
                HorarioVista horarioVista = new HorarioVista();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese su carrera");
                        string nombreCarrera = Console.ReadLine();
                        Carrera carrera = universidad.getCarrera(nombreCarrera);
                        Console.WriteLine("Ingrese nombre del Alumno");
                        Alumno alumno = new Alumno(Console.ReadLine());
                        carrera.mostrarMaterias();                     
                        universidad.imprimiMateria();
                        Console.WriteLine("Tome Materias");
                        Materia materia = new Materia(Console.ReadLine());
                        alumno.ingreseMateria(materia);
                        horarioVista.mostrarHorario("");



                        break;

                    case 2:
                        Console.WriteLine("Ver horario");                       
                        
                        break;

                    case 3:                     
                        Console.WriteLine("Retirar materia");
                        string eliminarmateria = Console.ReadLine();
                        universidad.eliminarMateria(eliminarmateria);
                        Console.WriteLine();

                        break;
                 
                    default:
                        Console.WriteLine("Esta obcion no existe");
                        break;
                }

            } while (true);
        }
    }
}
