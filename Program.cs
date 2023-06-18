using xadrez_console.tabuleiro;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            posicao P = new posicao(3, 4);

            Console.WriteLine("Posição: " + P);
            Console.ReadLine();
        }
    }
}