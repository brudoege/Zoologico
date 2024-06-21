using Zoologico.Entidades;
using Zoologico.Enums;

namespace Zoologico
{
    internal class Animal : IAnimal
    {
        public Especie Especie { get; set; }
        public string Nome { get; set; }
        public bool Vooa { get; set; }

        string IAnimal.LevantarVoo()
        {
            if (Vooa)
            {
                return $"Eu sou um {Nome} e levanto voo";
            }
            else
            {
                return $"Eu sou um {Nome} não sei voar";
            }
        }

        string IAnimal.Mergulhar(int metros)
        {
            throw new NotImplementedException();
        }

        string IAnimal.Pousar()
        {
            throw new NotImplementedException();
        }

        string IAnimal.Subir()
        {
            throw new NotImplementedException();
        }
    }
}
