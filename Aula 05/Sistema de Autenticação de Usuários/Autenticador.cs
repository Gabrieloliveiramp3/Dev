using System.Reflection.Metadata;

namespace Sistema_de_Autenticação_de_Usuários
{
    public class Autenticador
    {
        Usuario usuario = new Usuario();
        public void Validar()
        {
            Console.Write("\nDigite o nome do Usuário: ");
            string nomeDoUsuario = Console.ReadLine()!;
            if (nomeDoUsuario.Contains(usuario))
            {
                Console.WriteLine($"\nO Usuario {nomeDoUsuario}  foi encontrado!");
            }
            else
            {
                Console.Write("Usuário não encontrado!");
            }
        }
    }
}