
namespace Zoologico
{
    internal class Anfibio : Animal
    {
        public bool Terrestre { get; set; }
        public Anfibio(string especie, string nome, DateOnly dataNascimento, bool terrestre) : base(especie, nome, dataNascimento)
        {
            Especie = "Anfibio";
            Terrestre = terrestre;
        }
    }
}
