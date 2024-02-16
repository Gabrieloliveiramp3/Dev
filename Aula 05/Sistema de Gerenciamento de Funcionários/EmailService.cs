using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento_de_Funcionários
{
    public class EmailService
    {
        public void EnviarEmailAumentoSalario(Funcionario funcionario, decimal novoSalario)
        {
            Console.WriteLine($"E-mail enviado para {funcionario.Nome}: Seu novo salário é {novoSalario:C}");
        }
    }
}
