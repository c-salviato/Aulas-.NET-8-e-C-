namespace Aula10
{
    public class Program
    {
        public static void Main()
        {

            double n1, n2, res = 0;
            int opc;
            
            Console.WriteLine("--------- Calculadora Simples ---------");
            Console.WriteLine("Digite o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha um operador: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            opc = Convert.ToInt32(Console.ReadLine());

            if (opc == 1)
            {
                res = n1 + n2;
            }
            else if (opc == 2)
            {
                res = n1 - n2;
            }
            else if (opc == 3)
            {
                res = n1 * n2;
            }
            else if (opc == 4)
            {
                res = n1 / n2;
            }

            Console.WriteLine("O resultado é: " + res);




        }
    }
}