//Exercício 1: Sistema de Gerenciamento de Funcionários
//Crie um sistema de gerenciamento de funcionários com as seguintes classes:
//Funcionario: Responsável por armazenar os dados de um funcionário, como nome, cargo e salário.
//CalculadoraSalario: Responsável por calcular o salário de um funcionário com base nas horas trabalhadas e no valor da hora.
//EmailService: Responsável por enviar e-mails aos funcionários, por exemplo, para comunicar aumento de salário.
//BancoDeDados: Responsável por salvar os dados dos funcionários em um banco de dados.

using Sistema_de_Gerenciamento_de_Funcionários;
using System;

EmailService email = new EmailService();
Funcionario funcionario = new Funcionario("Gabriel", "Analista de TI", 15000);
Funcionario funcionario1 = new Funcionario("Nicole", "Analista de TI", 30000);


CalculadoraSalario calculadoraSalario = new CalculadoraSalario();
calculadoraSalario.CalcularSalario(30, 300);


Console.WriteLine($"\nNome: {funcionario.Nome}");
Console.WriteLine($"Cargo : {funcionario.Cargo}");
Console.WriteLine($"Salário : {funcionario.Salario}\n");

BancoDeDados bancoDeDados = new BancoDeDados();
bancoDeDados.SalvarFuncionario(funcionario);
bancoDeDados.SalvarFuncionario(funcionario1);
bancoDeDados.ObterTodosFuncionarios();

email.EnviarEmailAumentoSalario(funcionario, 30000);
email.EnviarEmailAumentoSalario(funcionario1, 40000);

