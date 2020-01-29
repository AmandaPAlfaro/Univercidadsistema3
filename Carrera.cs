using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univercidad
{
    class Carrera
    {
        private string nombre;
        private static int codigo = 0;
        List<Materia> lmateria = new List<Materia>();
        List<Alumno> alumnosRegistrado = new List<Alumno>();
        List<Docente> registrarDocentes = new List<Docente>();
     
        public Carrera(string nombre)
        {
            this.nombre = nombre;
        }

        public void ingreseMateria(Materia materia)
        {
            lmateria.Add(materia);
        }
        public void IngreseAlumnos(Alumno alumnos)
        {
            alumnosRegistrado.Add(alumnos);
        }
        public void IngreseDocentes(Docente docentes)
        {
            registrarDocentes.Add(docentes);
        }
      
        public string getNombre()
        {
            return nombre;
        }       

        public void mostrarMaterias() 
        {
            foreach (var item in this.lmateria)
            {
                Console.WriteLine(item.getNombre());
            }
        }

       
    }
}
