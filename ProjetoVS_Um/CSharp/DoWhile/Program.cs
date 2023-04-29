using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto - Do - While");

        //Escreva um contador que imprima os números de 0 a 10

        int number = 0;

        do
        {
            Console.WriteLine(number);
            number++;
        } while (number <= 10);

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}
