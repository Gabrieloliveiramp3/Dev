using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento_de_Funcionários
{
    public class Funcionario
    {
        public Funcionario(string nome, string cargo, decimal salario)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        public string Nome { get; }
        public string Cargo { get; }
        public decimal Salario { get; }
    }
}
