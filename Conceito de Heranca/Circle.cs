using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceito_de_Heranca
{
    // Define uma classe que representa um círculo e herda de Shape
    public class Circle : Shape
    {
        // Define a propriedade que representa o raio do círculo
        public double Radius { get; set; }

        // Sobrescreve o método Area para calcular a área de um círculo
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        //// Sobrescreve o método GetType para retornar o tipo específico da forma
        //public override string GetType()
        //{
        //    return "Circle";
        //}
    }
   
}
