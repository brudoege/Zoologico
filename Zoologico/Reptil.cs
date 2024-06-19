namespace Zoologico
{
    internal class Reptil : Animal
    {
        public bool TemEscamas { get; set; }
        public bool PoeOvos { get; set; }

        public Reptil(string especie, string nome, DateOnly dataNascimento, bool temEscamas, bool poeOvos) : base(especie, nome, dataNascimento)
        {
            Especie = "Reptil";
            TemEscamas = temEscamas;
            PoeOvos = poeOvos;
        }


    }
}
