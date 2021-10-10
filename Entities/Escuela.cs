namespace CoreEscuela.Entidades

{
    public class Escuela
    {
        string nombre;
        public string Nombre{
            get{return "Copia del nombre: " + nombre;}
            set{nombre = value.ToUpper();}
        }
        
        // Esta es la propiedad que permite el acceso a la variable sin exponer su valor publicamente (Ocultamiento del estado)
        string direccion;
        public string Direccion { 
            get {return "Copia dirección: " + direccion;} 
            set {direccion = value.ToUpper();}
        }
        
        int año_fundacion;
        public int Año_fundacion{ 
            get{return  año_fundacion;}
            set{año_fundacion = value;}
        }

        public TiposEscuela tipoEscuela;

        private string pais;
        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }
/*         private Cursos[] cursos;
        public Cursos[] Cursos
        {
            get { return cursos; }
            set { cursos = value; }
        } */
        

        //Función constructora
        public Escuela(string nombre, string direccion, int año_fundacion)
        {
        this.nombre = nombre;
        this.direccion = direccion;
        this.año_fundacion = año_fundacion;
        }

        //Otra forma de definir la función constructora
        public Escuela(string nombre,string direccion, int año_fundacion, string pais = ""){
            (Nombre,Direccion, Año_fundacion) = (nombre,direccion, año_fundacion);
            Pais = pais;

        }

        ///Acá se modifica el método ToString para que desde el archivo Program.cs se imprima toda la variable que desde aquí tendrá las reglas para su aparición en consola
        public override string ToString(){
            return $"Nombre: \"{Nombre}\" \n Direccion: {Direccion} \n Año de fundación: {Año_fundacion} \n Tipo Escuela: {tipoEscuela}";
        }
  
    }
   
}