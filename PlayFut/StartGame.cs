using PlayFut.Interface;

namespace PlayFut
{
    public class StartGame 
    {
        private readonly IPlayer _player01;
        private readonly IPlayer _player02;
        private readonly IPlayer _player03;
        
        public StartGame(
            IPlayer player01,
            IPlayer player02,
            IPlayer player03
            )
        {
            _player01 = player01;
            _player02 = player02;
            _player03 = player03;
        }
        
        public void PlayFut()
        {
           System.Console.WriteLine(_player01.ReceivedTheBall());
           System.Console.WriteLine(_player01.RunningWithTheBall());
           System.Console.WriteLine(_player01.PassedTheBall());
           
           System.Console.WriteLine(_player02.ReceivedTheBall());
           System.Console.WriteLine(_player02.RunningWithTheBall());
           System.Console.WriteLine(_player02.RunningWithTheBall());
           System.Console.WriteLine(_player02.PassedTheBall());
           
           System.Console.WriteLine(_player03.ReceivedTheBall());
           System.Console.WriteLine(_player03.RunningWithTheBall());
           System.Console.WriteLine(_player03.RunningWithTheBall());
           System.Console.WriteLine(_player03.RunningWithTheBall());
           System.Console.WriteLine(_player03.kickedIntoGoal());
        }
    }
}