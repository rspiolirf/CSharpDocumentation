namespace Members
{
    public class Gato
    {
        public static string Tipo = "Felino";
        public static int Quantidade = 0;

        public string Nome { get; }
        public string Cor { get; }

        public Gato(string nome, string cor)
        {
            Nome = nome;
            Cor = cor;
            Quantidade += 1;
        }
    }
}