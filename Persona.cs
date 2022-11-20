using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_que_gestione_informacion
{
     class Persona
    {
         public String nombres;
         public String apellidos;
         public String estado_civil;
         public int Identificacion;
        
        public Persona(String nombres, String apellidos, String estado_civil, int Identificacion)
        {
        this.nombres = nombres;
        this.apellidos = apellidos;
        this.estado_civil = estado_civil;
        this.Identificacion = Identificacion;
        }
        public void imprimir_datos_de_persona()
        {
            Console.WriteLine("nombres" + nombres);
            Console.WriteLine("Apellidos" + apellidos);
            Console.WriteLine("estado_civil" + estado_civil);
            Console.WriteLine("Identificacion" + Identificacion);
        }
        
    }
}
