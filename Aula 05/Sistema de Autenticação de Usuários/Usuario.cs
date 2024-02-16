using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

    public class Usuario
    {
        
        private List<Usuario> usuario = new List<Usuario>();
        public int Senha { get; set; }
        public string Nome { get; set; }       

        public Usuario(string nome, int senha)
        {
            Nome = nome;
            Senha = senha;
        }

        public void SalvarUsuario(Usuario user)
        {
            usuario.Add(user);
            Console.WriteLine($"Usuário(a) {user.Nome} salvo no banco de dados.");
        }

        public void ObterTodosUsuarios()
        {
            Console.WriteLine($"\nLista de usuários :");
             foreach (user in usuario)
            {
               Console.WriteLine($"Usuário : {user.Nome}");
            }
        }
    }

