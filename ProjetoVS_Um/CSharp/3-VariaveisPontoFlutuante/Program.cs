using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Variáveis Ponto Flutuante");
        
        double salario;
        salario = 3000.13;
        Console.WriteLine(salario);

        salario = 3000;
        Console.WriteLine(salario);

        /*Uma variável do tipo double aceita um número inteiro, mas uma variável inteiro não aceita um número com ponto flutuante.
          Quando fazemos uma divisão de dois inteiros, mas os declaram como double pois o resultado será um número com ponto flutuante, obteremos como resposta um número também inteiro.
          Para evitar isso, basta colocar o número inteiro seguido por .0 (por exemplo 9.0)
        */

        double idade;
        idade = 7.0 / 5;
        Console.WriteLine(idade);

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}
