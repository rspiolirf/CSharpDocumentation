using System;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato kiki = new Gato("Kiki", "Marrom");
            Console.WriteLine($"{Gato.Tipo} - Nome: {kiki.Nome}, Cor: {kiki.Cor} -> Qtde: {Gato.Quantidade}");

            Gato katy = new Gato("Katy", "Branca");
            Console.WriteLine($"{Gato.Tipo} - Nome: {katy.Nome}, Cor: {katy.Cor} -> Qtde: {Gato.Quantidade}");

            Gato akuma = new Gato("Akuma", "Preta");
            Console.WriteLine($"{Gato.Tipo} - Nome: {akuma.Nome}, Cor: {akuma.Cor} -> Qtde: {Gato.Quantidade}");
        }
    }
}
