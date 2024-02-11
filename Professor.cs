using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarto_Projeto
{
    public class Professor : Pessoa
    {
        public string cadeira;
        protected float salario;
        

        public Professor(string nome, int idade, string cpf, string cadeira, float salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
            this.cadeira = cadeira;
            this.salario = salario;

            mensagemPessoa();
            mensagemProfessor();

            
        }

        protected void mensagemProfessor()
        {
            Console.WriteLine("Salário: "+salario);
        }

        
    }
}
