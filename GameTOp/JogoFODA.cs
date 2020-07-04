

using GameTOp.Interface;

namespace GameTOp
{
    public class JogoFODA
    {

        private iJogador _jogadorA;

        private iJogador _jogadorB;
        public JogoFODA(iJogador jogadorA, iJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }


        public void IniciarJogo()
        {

            System.Console.Write(_jogadorA.Corre());
            System.Console.Write(_jogadorA.Chuta());
            System.Console.Write(_jogadorA.Passe());

            System.Console.Write("\nPROXIMO JOGADOR!! \n\n");

            System.Console.Write(_jogadorB.Corre());
            System.Console.Write(_jogadorB.Chuta());
            System.Console.Write(_jogadorB.Passe());
        }

    }
}

