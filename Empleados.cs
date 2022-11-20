using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_que_gestione_informacion
{
 class Empleados:Persona
    {
        public String año_de_incorporacion;
        public string numero_de_despacho;
        public Empleados(string año_de_incorporacion, string numero_de_despacho, String nombres, String apellidos, String estado_civil, int Identificacion): base(año_de_incorporacion, numero_de_despacho, nombres, Identificacion)
    {
     
     this.año_de_incorporacion = año_de_incorporacion;
     this.numero_de_despacho = numero_de_despacho;
     
    }
  public void imprimir_datos_de_empleado(){
     Console.WriteLine("año_de_incorporacion" + año_de_incorporacion);
     Console.WriteLine("Numero_de_despacho" + numero_de_despacho);
    
     
    }
}
}