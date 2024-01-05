namespace Pong_Ultra_Gamer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var ball = new Ball(15, 15, 1, 1);
            var game = new Game(ball);
            game.GameLoop();
        }
    }
}






