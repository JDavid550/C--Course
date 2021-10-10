using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades{
    public class Alumnos
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }

        public List<Evaluacion> Evaluacion {get; set;}

        public Alumnos()
        {
            //Este constructor únicamente se encarga de generar el ID, cuya modificación está restringida
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}