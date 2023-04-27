using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 1.2 - Condicionais");

        int idade = 16;
        int quantidadeDePessoas = 2;
        bool estaAcompanhado = false;

        if(idade >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }else if/*(quantidadeDePessoas > 1)*/(estaAcompanhado)
        {
            Console.WriteLine("Está acompanhado. Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}
