using System;
using CoreEscuela.Entidades;
using static System.Console; //Permite solos escribir WriteLine
using System.Collections.Generic;
using CoreEscuela.EscuelaEngine;
using CoreEscuela.Util;



namespace C__School_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Esto se paso a EscuelaEngine para refactorizar el código
            Console.WriteLine("Mi escuela");
            var escuela = new Escuela("Platzi","Av. 72",2013, pais:"Colombia");
            escuela.tipoEscuela = TiposEscuela.Primaria;
            Console.WriteLine(escuela);
            Console.WriteLine(escuela.Pais);*/


            /* Console.WriteLine(escuela.Nombre);
            Console.WriteLine(escuela.Direccion);
            Console.WriteLine(escuela.Año_fundacion);
            
            Console.WriteLine(escuela.tipoEscuela); */
            
            /* var arregloCursos = new Cursos[2];
            arregloCursos[0] = new Cursos(){

                Nombre = "Desarrollo Web",
                Jornada = TiposJornada.Tarde,
            };

            arregloCursos[1] = new Cursos(){
                Nombre = "Data Science",
                Jornada = TiposJornada.Mañana,
            }; */
            ///El arreglo también se puede escribir así
            Cursos[] arregloCursos = {  //No la estoy usando desde de creé la lista
                new Cursos(){
                Nombre = "Desarrollo Web",
                Jornada = TiposJornada.Tarde,
                },
                new Cursos(){
                Nombre = "Desarrollo Web",
                Jornada = TiposJornada.Tarde,
                }

            };

            ///O así, si creamos la variable Cursos en el archivo de escuela: (Posible borrado)

            /* escuela.Cursos = new Cursos(){
                new Cursos(){
                Nombre = "Desarrollo Web",
                Jornada = TiposJornada.Tarde,
                },
                new Cursos(){
                Nombre = "Desarrollo Web",
                Jornada = TiposJornada.Tarde,
                }
            }; */

         /*    System.Console.WriteLine("============================================");
            System.Console.WriteLine(arregloCursos[0].Nombre + ", " + arregloCursos[0].UniqueId + ", " + arregloCursos[0].Jornada);
            System.Console.WriteLine(arregloCursos[1].Nombre + ", " + arregloCursos[1].UniqueId + "," + arregloCursos[1].Jornada);
            ImprimirCursosWhile(arregloCursos);
            ImprimirCursosDoWhile(arregloCursos);
            ImprimirCursosFor(arregloCursos); */

            var engine = new EscuelaEngine();
            engine.Inicializar();

            ImprimirCursosEscuela(engine.Lista_cursos);
        }

        ///Ciclos
        public static void ImprimirCursosWhile(Cursos[] arregloCursos){
            int counter = 0;
            while (counter < arregloCursos.Length)
            {
                Console.WriteLine(arregloCursos[counter].Nombre + ", " + arregloCursos[counter].UniqueId + ", " + arregloCursos[counter].Jornada);
                counter += 1;
            }
        }
        public static void ImprimirCursosDoWhile(Cursos[] arregloCursos){
            int counter = 0;
            do
            {
                Console.WriteLine(arregloCursos[counter].Nombre + ", " + arregloCursos[counter].UniqueId + ", " + arregloCursos[counter].Jornada);
                counter += 1;
            } while (counter < arregloCursos.Length);
            
        }
        public static void ImprimirCursosFor(Cursos[] arregloCursos){
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                Console.WriteLine(arregloCursos[i].Nombre + ", " + arregloCursos[i].UniqueId + ", " + arregloCursos[i].Jornada);
            }

            foreach (var curso in arregloCursos)
            {
                WriteLine(curso.Nombre + ", " + curso.UniqueId + ", " + curso.Jornada);
                
            } 
            
            
        }



        public static void ImprimirCursosEscuela(List<Cursos> lista_cursos){

            
            Printer.DibujarLinea("CURSOS DE LA ESCUELA");
            
            foreach (var curso in lista_cursos)
            {
                WriteLine(curso.Nombre + ", " + curso.UniqueId + ", " + curso.Jornada);
                Printer.DibujarLinea("Asignaturas");
                foreach (var asignatura in curso.Asignatura)
                {
                    WriteLine(asignatura.Nombre);
                }
                Printer.DibujarLinea("Alumnos");
                foreach (var alumno in curso.Alumnos)
                {
                    WriteLine(alumno.Nombre + "\n - Evaluación: "  );
                    for (int i = 0; i < alumno.Evaluacion.ToArray().Length ; i++)
                    {
                        WriteLine("Asignatura: " + alumno.Evaluacion[i].Asignatura.Nombre + "\n - Nota: " + alumno.Evaluacion[i].Nota);
                    }
                    
                }
                
            } 
        }
    }
}
