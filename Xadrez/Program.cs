using System;
using tabuleiro;
using Xadrez;
using xadrez;
internal class Program {
    private static void Main(string[] args) {


        try {
            PartidaDeXadrez partida = new PartidaDeXadrez();
            while (!partida.terminada) {
                Console.Clear();
                Tela.imprimirTabuleiro(partida.tab);

                Console.WriteLine();
                Console.Write("Origem: ");
                Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveeis();

                Console.Clear();
                Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
                
                Console.Write("Destino ");
                Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                partida.execultaMovimento(origem, destino);
            }
        
        }
        catch (TabuleiroException e) {
            Console.WriteLine(e.Message);
        }

        Console.ReadLine();
    }
}