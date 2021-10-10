using System;
using CoreEscuela.Entidades;
using static System.Console; //Permite solos escribir WriteLine
using System.Collections.Generic;
using System.Linq;

namespace CoreEscuela.EscuelaEngine
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        /**Añadí estos dos métodos al momento de factorizar el código con el fin de hacerlos accesibles desde el Program.cs**/
        public List<Cursos> Lista_cursos { get; set; }
        public List<Cursos> Otra_lista_cursos { get; set; }
        public List <Alumnos> Lista_alumnos{ get; set; }
        public List <Asignatura> Lista_asignaturas { get; set; }


        public void Inicializar(){
            CargarCursos();
            //CargarAsignaturas();
        }

        private float GenerarNotas(){
                Random cantRandom = new Random();
                float nota = cantRandom.Next(0,5);
                return nota;
        }
        private void CargarEvaluaciones()
        {   
            CargarAsignaturas();
            foreach (var al in Lista_alumnos)
            {   
                al.Evaluacion = new List<Evaluacion>();
                for (int i = 0; i < Lista_asignaturas.ToArray().Length ; i++)
                {  
                    al.Evaluacion.Add(
                        new Evaluacion{
                            Asignatura = Lista_asignaturas[i], 
                            Nota=GenerarNotas()
                            }
                    );

                }
                 
                
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Lista_cursos)
            {
                Lista_asignaturas = new List<Asignatura>(){
                    new Asignatura{Nombre="Matemática"},
                    new Asignatura{Nombre="Pensamiento algoritmico"},
                    new Asignatura{Nombre="Escritura técnica"}
                };
                curso.Asignatura = Lista_asignaturas;
                
            }
        }

        private List<Alumnos> CargarAlumnos(int cantidad)
        {
            string[] primer_nombre = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] segundo_nombre = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var lis= from n1 in primer_nombre
                                from n2 in segundo_nombre
                                from a in apellido
                                select new Alumnos{Nombre= $"{n1} {n2} {a}"};
            
            

            Lista_alumnos = lis.OrderBy((al)=>al.UniqueId).Take(cantidad).ToList();
            CargarEvaluaciones();
            return Lista_alumnos;

        }



        /*Para borrar algo se le pasa un delegado que se usa como 'selector' de lo que se va a borrar*/
        private static bool Predicado(Cursos curso){
                return curso.Nombre == "Marketing";
        }

        private void CargarCursos(){
                        Console.WriteLine("Mi escuela");
            Escuela = new Escuela("Platzi","Av. 72",2013, pais:"Colombia");
            Escuela.tipoEscuela = TiposEscuela.Primaria;
            Console.WriteLine(Escuela);
            Console.WriteLine(Escuela.Pais);

             /**Acá lo estoy haciendo con Listas, que es una forma de colección**/

            Lista_cursos = new List<Cursos>(){
                new Cursos(){
                Nombre = "Desarrollo Web",
                Jornada = TiposJornada.Tarde,
                },
                new Cursos(){
                Nombre = "Desarrollo Web",
                Jornada = TiposJornada.Tarde,
                }
            };

            Lista_cursos.Add(
                new Cursos(){
                    Nombre = "Marketing",
                    Jornada = TiposJornada.Mañana,
                }
            );

            Otra_lista_cursos = new List <Cursos>(){
                new Cursos(){
                    Nombre = "Startups",
                    Jornada = TiposJornada.Noche,
                },
                new Cursos(){
                    Nombre = "Inglés",
                    Jornada = TiposJornada.Noche,
                },
            };

            Lista_cursos.AddRange(Otra_lista_cursos);


            /**Eliminación de elementos de la lista por medio de un predicado
            Un predicado es lo que se afirma o niega de una proposición que retorna 
            un valor booleano en una función que puede ser ingresada como parametro**/
            //A partir de C# 3.5 no es necesario asignarle el predicate ya que se implementó inferencia de tipos

            Predicate <Cursos> miAlgoritmo = Predicado;
            Lista_cursos.RemoveAll(miAlgoritmo);

            //**También se puede hace así por medio del delegate**//

            Lista_cursos.RemoveAll(delegate (Cursos curso){
                return curso.Nombre == "Startups";
            });

             //** Y si la instrucción de borrado es aún más corta, se puede hacer con una función lambda**//

            Lista_cursos.RemoveAll((Cursos curso)=>{return curso.Nombre == "Inglés";});

            //Carga de alumnos dentro del curso

            foreach (var curso in Lista_cursos)
            {
                curso.Alumnos = CargarAlumnos(10);
            }


        }
    }
}