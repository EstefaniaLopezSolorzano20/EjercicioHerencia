using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_que_gestione_informacion
{
 class Profesores:Persona
 {

 public String matematicas;
 public String lenguaje;
 public String arquitectura;

 public Profesores(String matematicas, String lenguaje, String arquitectura, string nombres, string apellidos, string estado_civil, int Identificacion): base(matematicas, lenguaje, arquitectura, Identificacion)
 {
    this.matematicas = matematicas;
    this.lenguaje= lenguaje;
    this.arquitectura = arquitectura;

 }
    public void departamento_al_que_pertenece(){
    Console.WriteLine("matematicas" + matematicas);
    Console.WriteLine("lenguaje"+ lenguaje);
    Console.WriteLine("arquitectura" + arquitectura);
    }
}
}