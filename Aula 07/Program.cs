namespace Aula07
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("----------- Operadores de Atribuição -----------");

            // inicializar a variável
            int x = 10;
            Console.WriteLine("Valor inicial é : " + x);

            // Operador de atribuição simples
            x = 12;
            Console.WriteLine("Atribuição Simples (=): " + x);

            // Atribuição Composta
            x = x + 10;
            Console.WriteLine("Atribuição Composta (x = x + 10): " + x);

            // Atribuição composta com ++
            x++;
            Console.WriteLine("Atribuição Composta (x++): " + x);

            // Atribuição composta com +=
            x += 15;
            Console.WriteLine("Atribuição Composta (x += 15): " + x);

            // Atribuição composta com *=
            x *= 15;
            Console.WriteLine("Atribuição Composta (x *= 15): " + x);

            // Atribuição composta com /=
            x /= 15;
            Console.WriteLine("Atribuição Composta (x /= 15): " + x);
        }
    }
}