using System;
using System.Collections.Generic;
namespace CoreEscuela.Entidades
{
    public class Cursos
    {   
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }

        public List<Alumnos> Alumnos {get; set;}

        public List<Asignatura> Asignatura { get; set; }

        public Cursos()
        {
            //Este constructor únicamente se encarga de generar el ID, cuya modificación está restringida
            UniqueId = Guid.NewGuid().ToString();
        }

    }
}