﻿namespace Sistema_de_Gerenciamento_de_Funcionários
{
    public class CalculadoraSalario
    {
        public void CalcularSalario(decimal horasTrabalhadas, decimal valorHora)
        {
            Console.WriteLine($"O valor do Salario do Funcionario  é {horasTrabalhadas * valorHora}");
        }
    }

    //public void CalcularSalario
    //{
    //    get
    //    {
    //        void CalcularSalario()
    //        {
    //            Console.Clear();
    //            menu.ExibirTituloDaOpcao("Calculadora de Salario");
    //            Console.Write("Digite o nome do funcionario: ");
    //            string nomeDoFuncionario = Console.ReadLine()!;
    //            if (nomeDoFuncionario.Contains())
    //            {
    //                Console.WriteLine($"\nO Funcionario {nomeDoFuncionario} não foi encontrado!");
    //                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    //                Console.ReadKey();
    //                Console.Clear();
    //                menu.ExibirMenu();
    //            }
    //            else
    //            {
    //                Console.Write("Digite  quantas horas o Funcionario trabalhou: ");
    //                double horasTrabalhadas = double.Parse(Console.ReadLine()!);
    //                Console.WriteLine("Digite o valor da hora trabalhada :");
    //                int valorDaHora = int.Parse(Console.ReadLine());
    //                Console.WriteLine($"O valor do Salario do Funcionario {nomeDoFuncionario} e {horasTrabalhadas*valorDaHora}");
    //            }
    //        }
    //    }

    //    set
    //    { }
    //}
}