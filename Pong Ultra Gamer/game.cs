using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong_Ultra_Gamer
{
    internal class Game
    {
        Ball _ball;
        int consoleHeight;
        int consoleWidth;
        public Game(Ball ball)
        {
            _ball = ball;
            consoleHeight = Console.WindowHeight -1;
            consoleWidth = Console.WindowWidth -1;
        }

        public void updateBall()
        {


            if (_ball.x == 0 || _ball.x == consoleWidth)
            {
                _ball.HitHorizontalWall();
            }
            if (_ball.y == 0 || _ball.y == consoleHeight) 
            {
                _ball.HitVerticalWall();
            }
            _ball.x += _ball.xVel;
            _ball.y += _ball.yVel;
        }

        public void DrawBall()
        {
            Console.SetCursorPosition(_ball.x, _ball.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("O");
        }

        public void UpdateDimesions()
        {
            consoleHeight = Console.WindowHeight -1;
            consoleWidth = Console.WindowWidth -1;
        }

        public void GameLoop()
        {
            Console.CursorVisible = false;
            while(true)
            {
                UpdateDimesions();
                Console.SetCursorPosition(_ball.x, _ball.y);
                Console.Write(" ");
                updateBall();
                DrawBall();
                Thread.Sleep(100);
            }
        }
    }
}
