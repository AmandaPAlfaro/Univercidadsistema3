using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univercidad
{
    class HorarioVista 
    {
       
        public void mostrarHorario(string horario) 
        {
            Console.WriteLine("Elige tu horario: ");
            Materia materia = new Materia(horario);
            string horarioIngresado = Console.ReadLine();

        }

    }
}
