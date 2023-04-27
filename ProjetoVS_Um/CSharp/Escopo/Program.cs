using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 9 - Escopo");

        int idadeVitor = 30;
        int quantidadeDePessoas = 2;
        bool estaAcompanhado = quantidadeDePessoas > 1;

        string textoAdicional; // variável de escopo global

        if(estaAcompanhado == true)
        {
            /*string => gera uma variável de escopo local*/textoAdicional = "Vitor está acompanhado";
        }
        else
        {
            /*string => gera uma variável de escopo local*/
            textoAdicional = "Vitor não está acompanhado";
        }

        if(idadeVitor >= 18 || estaAcompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar");
        }
        else
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Não pode entra");
        }

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}
