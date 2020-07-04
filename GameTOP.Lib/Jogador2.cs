using GameTOp.Interface;

namespace GameTOp.lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
           return "Maradona estas  pateando \n";
        }

        public string Corre()
        {
           return "Maradona estas  corriendo \n";
        }

        public string Passe()
        {
           return "Maradona estas  paseando \n";
        } 
    }
}      