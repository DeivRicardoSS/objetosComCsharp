using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quarto_Projeto;

namespace Quarto_Projeto
{
    public class Aluno : Pessoa
    {
        public string materia;
        public float teste;
        public float prova;
        public float media;
        public float recuperacao;

        


        public Aluno(string nome,string cpf, int idade, string materia, float teste, float prova, float media, float recuperacao)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
            this.materia = materia;
            this.teste = teste;
            this.prova = prova;
            this.media = media;
            this.recuperacao = recuperacao;
            mensagemAluno();
        }

        protected void mensagemAluno()
        {
            Console.WriteLine("O aluno " + nome + " foi cadastrado na matéria de "+ materia);
        }

    }
}
