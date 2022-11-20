using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_que_gestione_informacion
{
     class Estudiante:Persona

    {
        public string Curso;
        public Estudiante(string Curso, string nombres, string apellidos, string estado_civil, int Identificacion):base(Curso, nombres, apellidos, Identificacion)
        {
            this.Curso = Curso;
        }
       public void imprimir_Curso_que_esta_Matriculado()
        {
             Console.WriteLine("Curso" + Curso);
    }
}
}