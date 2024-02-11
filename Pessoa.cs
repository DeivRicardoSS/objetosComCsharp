using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Quarto_Projeto
{
    public class Pessoa
    {
        public string nome;
        protected int idade;
        protected string cpf;

        protected void mensagemPessoa()
        {
            Console.WriteLine("Nome: " + nome + "\nIdade: " + idade + "\nCpf: " + cpf);
            
        }

        

        
    }
}
