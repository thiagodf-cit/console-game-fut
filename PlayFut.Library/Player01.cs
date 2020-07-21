using PlayFut.Interface;

namespace PlayFut.Library
{
    
    public class Player01: IPlayer
    {
        public readonly string _name;
        
        public Player01(string name)
        {
            _name = name;
        }
        
        public string kickedIntoGoal()
         {
            return $"Jogador 01 - { _name } chutou para o gol";
         }
         
         public string RunningWithTheBall()
         {
            return $"Jogador 01 - { _name } está correndo com a bola";
         }
         
         public string PassedTheBall()
         {
            return $"Jogador 01 - { _name } passou a bola";
         }
         
         public string ReceivedTheBall()
         {
            return $"Jogador 01 - { _name } recebeu a bola";
         }
    }
}