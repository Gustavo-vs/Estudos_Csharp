namespace _05_operadores_relacionais;

class Program
{
    static void Main(string[] args)
    {
        //Podemos comparar qualquer tipod de dados
        //numeros, strings, bytes.

        //A comparação sempre retorna verdadeiro ou falso (TRUE or FALSE)

        //O operador == verifica de os dois valores são iguais.

        int a = 20;
        int b = 15;

        bool resultado = (a == b); //é verdade que o valor de a é igual ao valor de b
                                   //retorno TRUE ou FALSE
        
        Console.WriteLine("A é igual a B? " + resultado);
        Console.ReadKey();
        Console.WriteLine("----------------");
        //Operador diferente de != 

        resultado = (a!=b);
        Console.WriteLine("A é diferente de B: " + resultado);
        Console.ReadKey();
        Console.WriteLine("----------------");

        //Operador maior que >

        a = 6;
        b = 3;

        resultado = (a>b); //a é maior que b ?
        Console.WriteLine("A é maior que B? " + resultado);
        Console.ReadKey();
        Console.WriteLine("----------------");

        //Menor ou igual >=

        a = 6;
        b = 6;

        resultado = (a <= b); //a é menor ou igual b ?
        Console.WriteLine("A é menor ou igual B " + resultado);
        Console.ReadKey();
    }
}
