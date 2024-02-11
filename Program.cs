using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Quarto_Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int controle1 = 0;
            string nome = "", cpf = "", materia = "", cadeira = "";
            int idade = 0 , contador = 0, contador2 = 0;
            float salario = 0;

            Aluno[] alunos = new Aluno[10]; // Array para armazenar alunos
            Professor[] professores = new Professor[4]; // Array para armazenar professores

            do {


                Console.Clear();
                Console.WriteLine("=====================================================");
            Console.WriteLine("Inicio do programa:");
            Console.WriteLine("=====================================================");
            Console.WriteLine("Cadastrar ou ver médias?");
            Console.WriteLine("1 = Cadastrar 2 = Ver Médias");
            Console.WriteLine("=====================================================");

            controle1 = int.Parse(Console.ReadLine());

            Console.Clear();

            if (controle1 == 1)
            {
                
                Console.WriteLine("=====================================================");
                Console.WriteLine("Cadastrar Aluno ou Professor?");
                Console.WriteLine("1 = Aluno 2 = Professor");
                Console.WriteLine("=====================================================");

                controle1 = int.Parse(Console.ReadLine());

                Console.Clear();

                if (controle1 == 1)
                {
                    Console.WriteLine("===================Cadastrar=Aluno===================");
                    Console.WriteLine("Digite o nome:");
                    nome = Console.ReadLine();
                    Console.WriteLine("=====================================================");

                    Console.WriteLine("Digite o CPF:");
                    cpf = Console.ReadLine();
                    Console.WriteLine("=====================================================");

                    Console.WriteLine("Digite a idade:");
                    idade = int.Parse(Console.ReadLine());
                    Console.WriteLine("=====================================================");

                    Console.WriteLine("Digite a Matéria do Aluno:");
                    materia = Console.ReadLine();

                    

                        if (contador < 10)
                        {
                            alunos[contador] = new Aluno(nome, cpf, idade, materia, 0, 0, 0, 0);
                            Console.WriteLine("Aluno Cadastrado");
                            contador++;
                        }
                        else if (contador > 9)
                        {
                            Console.WriteLine("Espaço Cheio");

                        }
                        Console.WriteLine(contador + "/10 Alunos Cadastrados");

                    }
                    else if(controle1 == 2)
                    {
                        Console.WriteLine("=================Cadastrar=Professores===============");
                        Console.WriteLine("Digite o nome:");
                        nome = Console.ReadLine();
                        Console.WriteLine("=====================================================");

                        Console.WriteLine("Digite o CPF:");
                        cpf = Console.ReadLine();
                        Console.WriteLine("=====================================================");

                        Console.WriteLine("Digite a idade:");
                        idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("=====================================================");

                        Console.WriteLine("Digite a Cadeira do Professor:");
                        cadeira = Console.ReadLine();
                        Console.WriteLine("=====================================================");

                        Console.WriteLine("Digite o Salário do Professor:");
                        salario = float.Parse(Console.ReadLine());
                        Console.WriteLine("=====================================================");

                        contador2++;

                        if (contador2 < 4)
                        {
                            professores[contador2] = new Professor(nome, idade, cpf, cadeira, salario);
                            Console.WriteLine("Professor Cadastrado");
                            contador2++;
                        }
                        else if (contador2 > 3)
                        {
                            Console.WriteLine("Espaço Cheio");

                        }
                        Console.WriteLine((contador2) + "/4 Professores Cadastrados");
                    }
            }
            else if(controle1 == 2)
            {
                    float n1 = 0, n2 = 0;
                    Console.WriteLine("=====================================================");
                    for (int i = 0; i < alunos.Length; i++)
                    {
                        if (alunos[i] != null)
                        {
                            Console.WriteLine((i+1) + " | Nome do aluno: " + alunos[i].nome + " | Matéria: " + alunos[i].materia + " | Teste : " + alunos[i].teste + " | Prova: " + alunos[i].prova + " Média: " + (alunos[i].teste + alunos[i].prova) / 2 + "\n");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                        
                    }
                    Console.WriteLine("Coloque o numero do aluno para editar suas notas.");
                    controle1 = int.Parse(Console.ReadLine());

                    for (int i = 0; i < alunos.Length; i++)
                    {
                         if((controle1 - 1) == i)
                        {
                            Console.WriteLine("Aluno: "+ alunos[i].nome);
                            Console.WriteLine("=====================================");
                            Console.Write("Digite a Primeira nota: ");
                            n1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("=====================================");
                            Console.Write("Digite a Segunda nota: ");
                            n2 = float.Parse(Console.ReadLine());
                            Console.WriteLine("=====================================");
                            alunos[i].teste = n1;
                            alunos[i].prova = n2;
                            Console.WriteLine("Notas Atualizadas!");

                        }
                    }
                }


                Console.WriteLine("=====================================================");
            Console.WriteLine("0 = Voltar ao inicio");



                if (!int.TryParse(Console.ReadLine(), out controle1))
                {
                    Console.WriteLine("Entrada inválida. Pressione Enter para continuar.");
                    Console.ReadLine();
                }
            } while (controle1 == 0);
        }
    }
}
