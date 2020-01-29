using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univercidad
{
    class Materia
    {
        private static int codigo = 0;
        private string nombre;
        private int notas;
        private string temario;
        private string horario;

        public Materia(string nombre) 
        {
            this.nombre = nombre;          
        }
        public  void ingreseHorario(string horario) 
        {
            this.horario = horario;
        
        }

        public void ingreseMateria(string materia) 
        {
            this.nombre = materia;
            codigo++;
        }

        public void ingreseNotas(int notas) 
        {
            this.notas = notas;
        }    

        public void ingresetemario(string temario) 
        {
            this.temario = temario;
        }

        public string getNombre() 
        {
            return nombre;
        }

        public int getCodigo()
        {
            return codigo;
        }

        public string getHorario()
        {
            return horario;
        }

    }
}
