using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class CalculosDeArea
    {
        /// <summary>
        /// Calcula a área do quadrado baseado no valor de um dos lados
        /// </summary>
        /// <param name="ladoQuadrado">Recebe o valor de um lado do quadrado com a precisão inteira </param>
        /// <returns>Retorna a área total do quadrado</returns>
        public double CalculaAreaQuadrado(double ladoQuadrado)
        {
            return ladoQuadrado * ladoQuadrado;
        }

        public static void CalculaArea()
        {
            Console.WriteLine("Informa o lado do quadrado : ");
            var ladoQuadrado = int.Parse(Console.ReadLine());

            var bibliotecaCalculos = new CalculosDeArea();
            Console.WriteLine($"Minha área é : {bibliotecaCalculos.CalculaAreaQuadrado(ladoQuadrado)}");

        }
    }
}
