using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceito_de_Heranca
{
    // Define uma classe que representa um quadrado e herda de Shape
    public class Square : Shape
    {
        // Define a propriedade que representa o lado do quadrado
        public double SideLength { get; set; }

        // Sobrescreve o método Area para calcular a área de um quadrado
        public override double Area()
        {
            return SideLength * SideLength;
        }

        //// Sobrescreve o método GetType para retornar o tipo específico da forma
        //public override string GetType()
        //{
        //    return "Square";
        //}
    }
}
