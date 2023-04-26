using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);
        /*Char => armazena um único caracter;
          É delimitado por aspas simples;
          É representado como um número no computador (ASII Table), tornando possível, assim, representar uma letra pelo seu número correspondente na ASII Table => para essa conversão usa-se o type casting;
         */

        letra = (char)65;
        Console.WriteLine(letra);

        //É possível manipular os números que correspondem a um char, fazendo operações matemáticas com eles
        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        letra = (char)(48 / 4);
        Console.WriteLine(letra);

        //Char vazio => não é possível => é necessário ter pelo menos um espaço
        letra = ' ';

        //String
        string primeiraFrase = "Alura - Cursos de Tecnologia";
        Console.WriteLine(primeiraFrase);

        //Concatenação com strings
        primeiraFrase = "Alura - Cursos de Tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        //String vazia
        string vazia = "";
        Console.WriteLine(vazia);

        /* Separando itens em uma string => uso do @;
         * Os itens, ao serem "separados" da primeira parte da string, perdem a identação => caso seja identado novamente, a formatação do resultado depois da compilação será alterada também"         
         */
        string cursos = @"Cursos disponíveis: 
-Go 
-C# 
-Python 
-Java";
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}