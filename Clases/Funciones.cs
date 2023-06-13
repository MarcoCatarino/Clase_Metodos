using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Metodos.Clases
{
    public class Funciones
    // La clase es una planttilla que permite crear  Metododos y Objetos
    {

        #region CODIGO DEL METODO  SUMA
        // Se utiliza para INDICAR desde donde se INICIA a OCULTAR una parte del codigo (#REGION)
        public int Suma(int num1, int num2, int num3, int num4)
        {
            int resultado = num1 + num2 + num3 + num4;

            // En caso de usar un metodo se debe termiar con un RETURN para que funcione
            // En este caso el metodo es de tipo INT, por lo que se regresara (RETURN) un numero del mismo tipo
            return resultado;
        }
        // Se utiliza para INDICAR desde donde se FINALIZA el OCULTAR una parte del codigo (#ENDREGION)
        #endregion


        #region CODIGO DEL METODO  RESTA
        // Se utiliza para INDICAR desde donde se INICIA a OCULTAR una parte del codigo (#REGION)
        public void Resta()
        {
            int num01 = 15;
            int num02 = 5;

            int resultado = num01 - num02;
            
            Console.WriteLine("Tu 1er numero es = " + num01 + "\n");
            Console.WriteLine("Tu 2ndo numero es = " + num02 + "\n");
            Console.WriteLine("Turesultado es = " + resultado);
        }
        // Se utiliza para INDICAR desde donde se FINALIZA el OCULTAR una parte del codigo (#ENDREGION)
        #endregion

    }
}