namespace Zoologico
{
    internal class Mamifero : Animal
    {
        public bool Terrestre { get; set; }
        public string? TipoPelagem { get; set; }
        public string? CorPelagem { get; set; }

        public Mamifero(string especie, string nome, DateOnly dataNascimento, bool terrestre, string tipoPelagem, string corPelagem) : base(especie, nome, dataNascimento)
        {
            Especie = "Mamifero";
            Terrestre = terrestre;
            TipoPelagem = tipoPelagem;
            CorPelagem = corPelagem;
        }
    }
}
