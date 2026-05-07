namespace _03_operadores_aritmeticos;

class Program
{
    static void Main(string[] args)
    {
        /* Definição 
        Soma => +
        Subtração => -
        Multiplicação => *
        Divisão => /
        */


        /*
        Multiplicação vem em primeiro 
        Caso queira executar em outra ordem, usar os parenteses
        */


        //OPERADOR DE SOMA
        int a = 3;
        int b = 4;

        int resultado_soma = a + b;

        Console.WriteLine("O resultado da soma entre a + b é igual a: " + resultado_soma);
        Console.ReadKey();//aguarda uma ação do usúario via teclado

        //OPERAÇÃO DE SUBTRAÇÃO
        a = 5;
        b = 2;

        int resultado_subtrcao = a - b;

        Console.WriteLine("O resultado da subtração entre a - b é igual a: " + resultado_subtrcao);
        Console.ReadKey();

        //COM PARENTESES ALTERAMOS A ORDEM DA CONTA.

        int c = 20;
        int resultadoComParenteses = (a + b) * c; //Primeiro faz a soma e depois a multiplicação

        Console.WriteLine("O Resultado da conta com parenteses é igual a: " + resultadoComParenteses);
        Console.ReadKey();
    }
}
