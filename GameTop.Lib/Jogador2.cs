using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona estas pateaando \n";
        }

        public string Corre()
        {
            return "Maradona estas corriendo \n";
        }

        public string Passa()
        {
            return "Maradona estas pasando \n";
        }
    }
}