namespace Zoologico
{
    internal class Ave : Animal
    {
        public string? CorPenas { get; set; }

        public Ave(string especie, string nome, DateOnly dataNascimento, string corPenas) : base(especie, nome, dataNascimento)
        {
            Especie = "Ave";
            CorPenas = corPenas;
        }


    }
}
