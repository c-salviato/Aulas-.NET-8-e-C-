using System;

namespace Aula09;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("-------- Operadores Lógicos --------");

        bool isLogged = true;
        bool hasAdminAccess = false;

        Console.WriteLine("\nInformações Usuário:");
        Console.WriteLine("Usuário Logado " + isLogged);
        Console.WriteLine("Acesso ao painel de adminstrador: " + hasAdminAccess);

        // Operador (||) OR
        if (isLogged || hasAdminAccess)
        {
            Console.WriteLine("Está logado");
        }
        else
        {
            Console.WriteLine("Não está logado");
        }

        // Operador (&&) AND
        if (isLogged && hasAdminAccess)
        {
            Console.WriteLine("Acesso ao painel de administrador consedido");
        }
        else
        {
            Console.WriteLine("Acesso ao painel de administrador negado");
        }

        // Operador de negação (!) NO
        if (!isLogged)
        {
            Console.WriteLine("Não está logado");
        }
        else
        {
            Console.WriteLine("Está logado");
        }
    }
}