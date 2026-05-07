using System.Reflection.Metadata.Ecma335;
#pragma warning disable CS0219
namespace _02_variaveis;

class Program
{
    static void Main(string[] args)
    {
        //Variaveis inteiras
        sbyte medida = 127; // esse tipo de variavel (sbyte) vai dos valores -128 até 127
        byte tamanho = 255; // esse tipo de variavel (byte) vai dos valores 0 até 255
        short quantidade = 100; // esse tipo de variavel (short) vai dos valores -32.768 até 32.768
        int idade = 34; // esse tipo de variavel (int) vai dos valores -2.147.483.648 até 2.147.483.648
       
        /*Cada tipo das variaveis acima tem sua aplicação certa desde programações voltadas
        *a maquininhas de crédito onde tenho pouco espaço na mémoria ate programações demandas de valores maiores
        */


        //Variaveis de Texto 
        //String: armazena sequencia de caracteres.
        string nome = "Gustavo Vinicius Souza";
        //char: armazena somente um caracter.
        char inicialNome = 'G';


        //Variaveis Booleanas
        //Usado para armazenar valores booleanos (TRUE ou FALSE)
        bool estaLogado = true;
        bool possuiPermissao = false;


        //Variaveis Flutuante (ponto flutoante)
        //float: armazena valores com casas decimais
        float altura = 1.85f; //Usado para valores menos precisos, e ocupa menos espaço da memória.
        //double: armazena valores com casas decimais
        double peso = 96.60; //Usado para valores mais precisos, e ocupa mais espaço da memória.
    }
}
