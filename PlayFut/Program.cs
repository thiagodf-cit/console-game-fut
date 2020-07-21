using PlayFut.Library;

namespace PlayFut
{
    class Program
    {
        static void Main(string[] args)
        {
            var startGame = new StartGame(
                new Player01("Ronaldo"),
                new Player02("Zico"),
                new Player03("Romario")
            );
            startGame.PlayFut();
        }
    }
}
