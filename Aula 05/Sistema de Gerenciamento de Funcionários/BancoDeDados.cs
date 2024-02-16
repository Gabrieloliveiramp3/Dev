using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento_de_Funcionários
{
    public class BancoDeDados
    {
        private Dictionary<string, int> funcionarios = new Dictionary<string, int>();

        public void SalvarFuncionario(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
            Console.WriteLine($"Funcionário(a) {funcionario.Nome} salvo no banco de dados.");

        }
        public void SalvarSalario(Funcionario salario)
        {
            funcionarios.Add(salario)
            Console.WriteLine($"Salario {funcionario.Salario} salvo no banco de dados.");

        }

        public void ObterTodosFuncionarios()
        {
            Console.WriteLine($"\nLista de funcionarios :");
            foreach  (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine($"Funcionários : {funcionario.Nome}");
            }
        }
        

    }
}
