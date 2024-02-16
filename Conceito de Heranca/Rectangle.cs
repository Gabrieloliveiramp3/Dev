using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceito_de_Heranca
{
    // Define uma classe que representa um retângulo e herda de Shape
    public class Rectangle : Shape
    {
        // Define as propriedades que representam a largura e a altura do retângulo
        public double Width { get; set; }
        public double Height { get; set; }

        // Sobrescreve o método Area para calcular a área de um retângulo
        public override double Area()
        {
            return Width * Height;
        }

        //// Sobrescreve o método GetType para retornar o tipo específico da forma
        //public override string GetType()
        //{
        //    return "Rectangle";
        //}
    }
}
