using Ejercicio2Bucles.Servicios;

namespace Ejercicio2Bucles 
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// 25102023 -> irm
    /// </summary>
    class Program 
    {
        /// <summary>
        /// Metodo principal de la aplicacion
        /// 25102023 -> irm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) 
        {
            //Creamos los objetos
            CalculaNumInterfaz cNI = new CalculaNumImplementacion();
            //Llamamos al metodo a traves del objeto
            cNI.calculaNum();
        
        }
    }
}