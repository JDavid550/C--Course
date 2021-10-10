using System;

namespace CoreEscuela.Entidades{
    public class Evaluacion
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public Asignatura Asignatura { get; set; }
        public float Nota { get; set; }

        public Evaluacion()
        {
            //Este constructor únicamente se encarga de generar el ID, cuya modificación está restringida
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}