using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variáveis");

        int idade;
        idade = 27;
        Console.WriteLine("Ana tem " + idade + " anos"); /*ConsoleWriteLine => faz um print do resultado e pula uma linha*/

        idade = 27 - 5;
        Console.WriteLine(idade);

        idade = 5 * 2 - 6;
        Console.WriteLine(idade);

        idade = (5 - 2) * 3;
        Console.Write(idade);/*ConsoleWrite => faz um print do resultado, mas não pula uma linha*/

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}/*https://www.alura.com.br/artigos/convencoes-nomenclatura-camel-pascal-kebab-snake-case*/