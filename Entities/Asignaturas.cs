using System;

namespace CoreEscuela.Entidades{
    public class Asignatura
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }

        public Asignatura()
        {
            //Este constructor únicamente se encarga de generar el ID, cuya modificación está restringida
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}