using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Bucles.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz
    /// 25102023 -> irm
    /// </summary>
    internal class CalculaNumImplementacion : CalculaNumInterfaz
    {
        public void calculaNum()
        {
            double numBase = pedirDouble();
            int numExpo = pedirInt();
            double aux=numBase;
            for (int i = 1; i < numExpo; i++)
            {
                aux = aux * numBase;
                
            }
            Console.WriteLine("El resultado es:" + aux);
        }

        /// <summary>
        /// Metodo que pide al usuario el numero base que se va a utilizar
        /// 25102023 -> irm
        /// </summary>
        /// <returns></returns>
        private double pedirDouble() 
        {
            double num;
            Console.WriteLine("Introduzca la base:");
            num = Convert.ToDouble(Console.ReadLine());
            return num;
        }

        /// <summary>
        /// Metodo que pide al usuario el exponente de la base
        /// 25102023 -> irm
        /// </summary>
        /// <returns></returns>
        private int pedirInt() 
        {
            int num;
            Console.WriteLine("Introduzca el exponente del numero:");
            num=Convert.ToInt32(Console.ReadLine());
            return num;
        }

    }
}
