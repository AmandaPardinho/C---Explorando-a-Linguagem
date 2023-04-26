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

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}