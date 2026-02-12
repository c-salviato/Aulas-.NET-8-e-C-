namespace Aula08
{
    public class Program()
    {
        public static void Main()
        {
            Console.WriteLine("---------- Operadores Relacionais ----------\n");
            Console.WriteLine("Digite o primeiro número: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool equals = x == y;
            bool maior = x > y;
            bool menor = x < y;
            bool maiorouigual = x >= y;
            bool menorouigual = x <= y;

            string result;

            // Operador de igualdade (==)

            if (equals)
            {
                result = "São iguais";
            }
            else if (!equals)
            {
                result = "São diferentes";
            }
            else
            {
                result = "Não tem como dar isso"; // só pq se não da erro no Console.WriteLine
            }

            Console.WriteLine(result);

            // Operador maior que (>)
            if (maior)
            {
                result = "X é maior. (Ou Y é menor)";
            }
            Console.WriteLine(result);
            // Operador menor que (<)
            if (menor)
            {
                result = "Y é maior. (Ou X é menor)";
            }
            Console.WriteLine(result);
            // Operador maior ou igual que (>=)
            if (maiorouigual)
            {
                result = "X é maior ou igual a Y";
            }
            Console.WriteLine(result);
            // Operador menor ou igual que (<=)
            if (menorouigual)
            {
                result = "Y é maior ou igual a X";
            }
            Console.WriteLine(result);
        }
    }
}