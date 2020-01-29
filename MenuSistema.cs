using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Univercidad
{
    class MenuSistema
    {
        //private Univercidad umss;
        public void menuPrincipal() 
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("          Menu de Sistemas");
                Console.WriteLine();
                Console.WriteLine("          1. Administrador");
                Console.WriteLine("          2. Docente");
                Console.WriteLine("          3. Universitario");

                opcion = Int32.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Esto es menu Administrador");
                        AdministradorVista administradorVista = new AdministradorVista();
                        administradorVista.administradorVista();


                        break;
                    case 2:
                        Console.WriteLine("Esto es menu Docente");
                        DocenteVista docenteVista = new DocenteVista();
                        docenteVista.docenteVista();

                        break;

                    case 3:
                        Console.WriteLine("Esto es menu Universitario");
                        AlumnoVista alumnoVista = new AlumnoVista();
                        alumnoVista.alumnoVista();
                        break;

                    default:
                        Console.WriteLine("Esta obcion no existe");
                        break;
                }
            } while (opcion >= 3);          
        }

        //public void AsignarMateriaAdocente()
        //{
        //    int i = 0;
        //    foreach (var docente in umss.GetDocentes())
        //    {
        //        Console.WriteLine($"{i} --Nombre={docente.Name}, ci={docente.CI}");
        //        i++;
        //    }
        //    Console.WriteLine("Selecionar Docente");
        //    int readDocenteOption = int.Parse(Console.ReadLine());
        //    Docente docenteSelecionado = umss.GetDocentes().ElementAt(readDocenteOption);

        //    int j = 0;
        //    foreach (var materia in umss.GetMaterias())
        //    {
        //        Console.WriteLine($"{i} --Nombre={materia.getNombreMateria()}");
        //        j++;
        //    }
        //    Materia materiaSeleccionada = umss.GetMaterias().ElementAt(j);

        //    materiaSeleccionada.SetDocente(docenteSelecionado);
        //}

    }
}
