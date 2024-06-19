namespace Zoologico
{
    internal class Animal
    {
        public string Especie { get; set; }
        public string Nome { get; set; }
        public DateOnly DataNascimento { get; set; }

        public Animal(string especie, string nome, DateOnly dataNascimento)
        {
            Especie = especie;
            Nome = nome;
            DataNascimento = dataNascimento;
        }
    }
}
