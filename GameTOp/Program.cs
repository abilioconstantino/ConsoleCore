using System;
using GameTOp.lib;

namespace GameTOp
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(
                
                
                new Jogador1("Abilio Constantino Bastos Junior"),
                new Jogador2());
            jogo.IniciarJogo();
        }
    }


}

