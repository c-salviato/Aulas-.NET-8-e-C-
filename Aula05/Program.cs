namespace Aula05
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int sum = n1 + n2;
            int sub = n1 - n2;
            int div = n1 / n2;
            int mul = n1 * n2;
            int mod = n1 % n2;

            Console.WriteLine("O valor da soma é: " + sum);
            Console.WriteLine("O valor da subtração é: " + sub);
            Console.WriteLine("O valor da divisão é: " + div);
            Console.WriteLine("O valor da multiplicação é: " + mul);
            Console.WriteLine("O resto da divisão é: " + mod);
        }
    }
}