namespace _04_operadores_atribuicao;

class Program
{
    static void Main(string[] args)
    {
        int x = 5;

        //adicionar 5 ao valor atual de x

        x = x + 5;
        Console.WriteLine("Valor atual de x: " + x);
        Console.ReadKey();

        Console.WriteLine("-------------------");

        //Para atribuir um valor a variavel.

        x += 5;
        Console.WriteLine("Valor atual de x: " + x);
        Console.ReadKey();

        Console.WriteLine("-------------------");

        //Podemos Utilizar outros Operadores.

        x -= 1;
        Console.WriteLine("Valor atual de x após o x-=1: " + x);
        Console.ReadKey();

        Console.WriteLine("-------------------");

        

    }
}
 