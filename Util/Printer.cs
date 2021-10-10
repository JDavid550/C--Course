using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(string titulo){
            var linea = "".PadLeft(titulo.Length, '=');
            WriteLine(linea);
            WriteLine(titulo);
            WriteLine(linea);
        }
    }
}