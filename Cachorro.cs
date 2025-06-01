using System;

namespace Estudo
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome)
        : base(nome) // Chama o construtor da classe base
        {
        }
        public override void Apresentar()
        {
            Console.WriteLine($"Sou um cachorro chamado {Nome} e faço Au au!");
        }
    }
}