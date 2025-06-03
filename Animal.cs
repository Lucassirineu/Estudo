using System;

namespace Estudo
{
    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }
        public virtual void Apresentar()
        {
            Console.WriteLine("Som genérico de animal");
        }
    }
}