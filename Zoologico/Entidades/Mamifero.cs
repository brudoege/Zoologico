
using Zoologico.Entidades;
using Zoologico.Enums;
namespace Zoologico
{
    internal class Mamifero : Animal
    {
        public Mamifero()
        {
            Especie = Especie.Mamifero;
        }

        public bool Terrestre { get; set; }
        public string? TipoPelagem { get; set; }
        public string? CorPelagem { get; set; }
    }
}
