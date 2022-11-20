using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_que_gestione_informacion
{
 class PersonalServicio:Persona
 {

 public String biblioteca;
 public String decanato;
 public String secretaria;

 public PersonalServicio(String biblioteca, String decanato, String secretaria, string nombres, string apellidos, string estado_civil, int Identificacion): base(biblioteca, decanato, secretaria, Identificacion)
 {
    this.biblioteca = biblioteca;
    this.decanato = decanato;
    this.secretaria = secretaria;

 }
    public void seccion_en_que_estan_asignados(){
    Console.WriteLine("biblioteca" + biblioteca);
    Console.WriteLine("decanato"+ decanato);
    Console.WriteLine("secretaria" + secretaria);
    }
}
}