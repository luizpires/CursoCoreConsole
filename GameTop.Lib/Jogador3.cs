using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
             return "teste Chuta \n";
        }

        public string Corre()
        {
            return "teste Corre \n";
        }

        public string Passa()
        {
            return "teste Passa \n";
        }
    }
}