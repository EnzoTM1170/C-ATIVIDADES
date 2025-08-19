using System;

namespace TrabalhoIdades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine(" COMPARADOR DE IDADES ESCOLARES");
            Console.WriteLine("====================================");
            Console.WriteLine(); // linha em branco

            // Pede a idade do primeiro aluno
            Console.Write("Por favor, digite a idade do primeiro aluno: ");
            string entrada1 = Console.ReadLine();
            int idadeAluno1 = Convert.ToInt32(entrada1);

            // Pede a idade do segundo aluno
            Console.Write("Agora digite a idade do segundo aluno: ");
            string entrada2 = Console.ReadLine();
            int idadeAluno2 = Convert.ToInt32(entrada2);

            Console.WriteLine();
            Console.WriteLine("============== RESULTADO ==============");

            // Verifica quem é mais velho usando if
            if (idadeAluno1 > idadeAluno2)
            {
                Console.WriteLine("O PRIMEIRO aluno é mais velho!");
                Console.WriteLine("Idades: " + idadeAluno1 + " anos e " + idadeAluno2 + " anos");
                Console.WriteLine("Diferença: " + (idadeAluno1 - idadeAluno2) + " anos");
            }
            else if (idadeAluno2 > idadeAluno1)
            {
                Console.WriteLine("O SEGUNDO aluno é mais velho!");
                Console.WriteLine("Idades: " + idadeAluno2 + " anos e " + idadeAluno1 + " anos");
                Console.WriteLine("Diferença: " + (idadeAluno2 - idadeAluno1) + " anos");
            }
            else
            {
                Console.WriteLine("Os dois alunos têm a MESMA idade!");
                Console.WriteLine("Ambos têm " + idadeAluno1 + " anos");
            }

            Console.WriteLine("====================================");
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para finalizar o programa...");
            Console.ReadLine();
        }
    }
}