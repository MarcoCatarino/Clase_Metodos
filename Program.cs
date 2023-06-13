using System;
using POO_Metodos.Clases;
namespace POO_Metodos
{
    internal class Program : Funciones
    {
        static void Main(string[] args)
        {
            Funciones funciones = new Funciones();

            Console.WriteLine("SUMA");

            /* 1er METODO PARA IMPRIMIR
                int resultado = funciones.Suma(10 , 5,  8, 3);
                Console.WriteLine("Tu resultado es = " + resultado);     
            */

            /* 2ndo METODO PARA IMPRIMIR 
                Console.WriteLine(funciones.Suma(10, 5, 8, 3));
            */

            /* 3er METODO PARA IMPRIMIR PIDIENDO LOS DATOS - SIMPLIFICADO
                Console.WriteLine("Escribe tu 1er numero= ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escribe tu 2ndo numero= ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escribe tu 3er numero= ");
                int num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escribe tu 4to numero= ");
                int num4 = int.Parse(Console.ReadLine());
            */

            // 3er METODO PARA IMPRIMIR PIDIENDO LOS DATOS - DECLARANDO ANTES
                int num1, num2, num3, num4;
                Console.WriteLine("Escribe tu 1er numero= ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escribe tu 2ndo numero= ");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escribe tu 3er numero= ");
                num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escribe tu 4to numero= ");
                num4 = int.Parse(Console.ReadLine());
            



            Console.WriteLine("Tu resultado es = " + funciones.Suma(num1, num2, num3, num4));

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("RESTA");
            funciones.Resta();
        }
    }
}
