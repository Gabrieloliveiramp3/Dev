using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define a classe abstrata que representa uma forma

namespace Conceito_de_Heranca
{
    public abstract class Shape
    {
        // Define um método virtual que calcula a área da forma
        public virtual double Area()
        {
            return 0;
        }

        //// Define um método virtual que retorna o tipo da forma
        //public virtual string GetType()
        //{
        //    return "Shape";
        //}

    }
}