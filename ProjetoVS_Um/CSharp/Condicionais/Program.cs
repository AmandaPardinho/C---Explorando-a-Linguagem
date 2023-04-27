using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadeDePessoas = 2;
        bool estaAcompanhado = true;

        if(idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar");
        }          
        else
        {
            /*if(quantidadeDePessoas > 1)
            {
                Console.WriteLine("Está acompanhado. Pode entrar!");
            }*/ //solução acima foi a feita na aula
            if(estaAcompanhado == true)
            {
                Console.WriteLine("Está acompanhado. Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }    
        }

        Console.WriteLine("Tecle enter para sair");
        Console.ReadLine();
    }
}
