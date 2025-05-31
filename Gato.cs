using System;

namespace Estudo
{

    public class Gato : Animal
    {
        public Gato(string nome)
        : base(nome) // Chama o construtor da classe base
        {
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Sou um gato chamado {Nome} e faço Miau!");
        }
    }
}