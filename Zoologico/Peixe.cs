namespace Zoologico
{
    internal class Peixe : Animal
    {
        public bool AguaDoce { get; set; }

        public Peixe(string especie, string nome, DateOnly dataNascimento, bool aguaDoce) : base(especie, nome, dataNascimento)
        {
            Especie = "Peixe";
            AguaDoce = aguaDoce;
        }
    }
}
