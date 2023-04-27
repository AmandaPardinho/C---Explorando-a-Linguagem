using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8 - Condicionais 2");

        int idadeJuliana = 16;
        int quantidadeDePessoas = 2;
        bool grupo = quantidadeDePessoas > 1;

        if (idadeJuliana >= 18 || grupo)
        {
            Console.WriteLine("Pode entrar!");
        }else
        {
            Console.WriteLine("Lamento, mas não pode entrar");
        }

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}