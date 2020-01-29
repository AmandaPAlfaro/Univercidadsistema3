using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univercidad
{
    class Univercidad
    {

        string nombreunivercidad;
        private string nombre;
        List<AdministradorVista> administradorVistas = new List<AdministradorVista>();
        List<Materia> materia = new List<Materia>();
        List<Docente> docentes = new List<Docente>();
        List<Alumno> alumnos = new List<Alumno>();
        List<Carrera> carreras = new List<Carrera>();     
        Dictionary<string, string> alumnosRegistrados = new Dictionary<string, string>();

       

        public Univercidad(string nombre)
        {
            this.nombreunivercidad = nombre;
        }

        public void ingresarMateria(Materia materia) 
        {
            this.materia.Add(materia);
        }

        public void ingreseDocente(Docente docentes)
        {
            this.docentes.Add(docentes);
        }

        public void ingreseAlumnos(Alumno alumno)
        {
            this.alumnos.Add(alumno);
        }

        public void ingreseCarrera(Carrera carreras)
        {
            this.carreras.Add(carreras);
        }
        //IMPRIMIR
        public void imprimiMateria()
        {
            foreach (Materia materia in materia)
            {
                Console.WriteLine(materia.getNombre());
            }
        }
        public void imprimirAlumnos() 
        {
            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(alumno.getNombre());
            }
        }

        public void imprimeDocente()
        {
            foreach (Docente docente in docentes)
            {
                Console.WriteLine(docente.getNombre());
            }
        }     
      
        public void imprimirUniversitarios()
        {
            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(alumno.getNombre());
            }
        }
        public void imprimirCarreras()
        {
            foreach (Carrera carrera in carreras)
            {
                Console.WriteLine(carrera.getNombre());
            }
        }

        //ELIMINA 

        public void eliminarUniversitario(string nombreUniversitario)
        {
            List<Alumno> alumnosAUX = new List<Alumno>();
            foreach (Alumno universitario in alumnos)
            {
                alumnosAUX.Add(universitario);
            }

            foreach (Alumno alunos in alumnosAUX)
            {
                if (alunos.getNombre() == nombreUniversitario)
                {
                    alumnos.Remove(alunos);
                }
            }
        }

        public void eliminarCarrera(string nombreCarrera) 
        {
            List<Carrera> carrerasAux = new List<Carrera>();
            foreach (Carrera carrera in carreras)
            {
                carrerasAux.Add(carrera);
            }
            foreach (Carrera univercidad in carrerasAux)
            {
                if (univercidad.getNombre() == nombreCarrera)
                {
                    carreras.Remove(univercidad);
                }
            }
            
        }
        
        public void eliminarDocente(string nombreDocente) 
        {
            List<Docente>docenteAux = new List<Docente>();
            foreach (Docente docente1 in docentes )
            {
                docenteAux.Add(docente1);
            }
            foreach (Docente univercidad in docenteAux)
            {
                if (univercidad.getNombre() == nombreDocente)
                {
                    docentes.Remove(univercidad);
                }
            }
        }

        public void registrarEnCarrera(string nombreCarrera, string nombreAlumno) 
        {
       
            alumnosRegistrados.Add(nombreCarrera, nombreAlumno);
        }

        public Carrera getCarrera(string nombreCarrera)
        {
            foreach (var item in this.carreras)
            {
                if (item.getNombre() == nombreCarrera)
                {
                    return item;
                }
            }
            return null;
        }
        public void eliminarMateria(string nombreMateria)
        {
            List<Materia> materiaAux = new List<Materia>();
            foreach (Materia materia in materia)
            {
                materiaAux.Add(materia);
            }
            foreach (Materia univercidad in materiaAux)
            {
                if (univercidad.getNombre() == nombreMateria)
                {
                    materia.Remove(univercidad);
                }
            }

        }
    }
}
