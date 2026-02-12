namespace Aula03;

public class Program
{
    public static void Main()
    {
        //VARIAVEL (TIPO INT)

        int number = 30;

        number = number / 10;

        Console.WriteLine("O valor antigo da variável era: " + number);
    
        number = number * 4;

        Console.WriteLine("Agora o valor novo é: " + number);

        // CONSTANTE

        const int number2 = 1000; //não é possível alterar esse valor

        Console.WriteLine(number2);

        // se colocar "var" no tipo da variável, o próprio código reconhece automaticamente qual é o tipo ideal (só a primeira atribuição vale, depois não da para trocar o tipo da variável)

        var nome = "Lucas Neto";

        Console.WriteLine(nome);

        // variável dinâmica, basicamente pode trocar de tipo da variavel (ex: de INT para STRING)

        dynamic test = 20;

        test = 30;
        test = "Marcelão";

        Console.WriteLine(test);



        
        
    }
}