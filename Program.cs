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

}