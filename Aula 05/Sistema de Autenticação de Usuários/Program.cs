//Exercício 2: Sistema de Autenticação de Usuários
//Desenvolva um sistema de autenticação de usuários com as seguintes classes:
//Usuario: Responsável por armazenar os dados de um usuário, como nome de usuário e senha.
//Autenticador: Responsável por autenticar um usuário com base no nome de usuário e senha fornecidos.
//RegistroDeLog: Responsável por registrar tentativas de login bem-sucedidas e mal-sucedidas em um arquivo de log.

using Sistema_de_Autenticação_de_Usuários;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite seu usuario para cadastrar :");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite sua senha :");
        int senha = int.Parse(Console.ReadLine());
        Usuario user = new Usuario(nome, senha);
       

        user.SalvarUsuario(user);

        user.ObterTodosUsuarios();

        Autenticador autenticador = new Autenticador();
        autenticador.Validar(user);
    }
}