using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_que_gestione_informacion
{
 class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Josthin", "Avila","Soltero", 1316282449);
            persona.imprimir_datos_de_persona();
            Empleados empleados = new Empleados("2016", "23", "Xavier", "Pachay", "Soltero", 1316282449);
            empleados.imprimir_datos_de_empleado();
            Estudiante estudiantes1 = new Estudiante("SextoNivel", "Tonny","Bailon","Soltero", 1317943756);
            estudiantes1.imprimir_Curso_que_esta_Matriculado();
            Profesores profesores = new Profesores("Matematicas", "Lenguaje", "arquitectura", "Anthony", "Santana", "Soltero", 1317562865);
            profesores.departamento_al_que_pertenece();
            PersonalServicio personalServicio = new PersonalServicio("biblioteca", "Decanato", "Secretaria", "veronica", "Quijije", "Sotera", 1316930512);
            personalServicio.seccion_en_que_estan_asignados();


            
            Console.WriteLine(persona.ToString());
             Console.WriteLine(empleados.ToString());
                Console.WriteLine(estudiantes1.ToString());
                Console.WriteLine(profesores.ToString());
                Console.WriteLine(personalServicio.ToString());

        }
        
    }
     
}