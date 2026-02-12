using System.Numerics;

namespace Aula04;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("---------- Cadastro de Usuário ----------");

        //Solicitar nome do usuário

        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();

        //Solicitar a Idade do Usuário
        Console.WriteLine("Digite sua Idade: ");
        int idd = Convert.ToInt32(Console.ReadLine());

        // Imprimindo dados no console
        Console.WriteLine("---------- Dados do usuário ----------");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("idade: " + idd);
        
    }
}