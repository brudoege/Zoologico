// See https://aka.ms/new-console-template for more information
using Zoologico;
using Zoologico.Entidades;
using Zoologico.Enums;


IAnimal vaca = new Mamifero() { Nome = "Vaca", Vooa = true };
Console.WriteLine(vaca.LevantarVoo());