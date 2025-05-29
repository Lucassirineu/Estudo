using System;

namespace Estudo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Deseja cadastrar um cachorro ou gato?");
            Console.WriteLine("1 - Cachorro");
            Console.WriteLine("2 - Gato");

            var escolha = Console.ReadLine(); // A entrada do usuário é uma string

            switch (escolha) // Compara a string 'escolha' com strings
            {
                case "1": Cachorro(); break;
                case "2": Gato(); break;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
        static void Cachorro()
        {
            Console.WriteLine("Cadastro de Cachorro");
            Console.Write("Digite o nome do cachorro: ");
            string nome = Console.ReadLine();
            Cachorro cachorro = new Cachorro(nome);
            cachorro.Apresentar();
        }
        static void Gato()
        {
            Console.WriteLine("Cadastro de Gato");
            Console.Write("Digite o nome do gato: ");
            string nome = Console.ReadLine();
            Gato gato = new Gato(nome);
            gato.Apresentar();
        }
    }
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