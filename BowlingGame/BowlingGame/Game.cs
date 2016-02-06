using System;

namespace Bowling
{
    public class Game:IGame
    {
        private int _currentFrameForGame = 1;
        private bool _firstThrow = true;
        private readonly ScoreKeeper _keeper = new ScoreKeeper();

        public int Score()
        {
            return ScoreForFrame(GetCurrentFrame() - 1);
        }

        public int GetCurrentFrame()
        {
            return _currentFrameForGame;
        }

        public void RollBalls(int pins)
        {
            _keeper.AddThrowInGame(pins);
            AdjustFrame(pins);
        }

        private void AdjustFrame(int pins)
        {
            if (_firstThrow)
            {
                if (pins == 10) 
                    NextFrame();
                else
                    _firstThrow = false;
            }
            else
            {
                _firstThrow = true;
                NextFrame();
            }   
        }

        public void NextFrame()
        {
            _currentFrameForGame = Math.Min(11, _currentFrameForGame+1);
        }

        public int ScoreForFrame(int theFrame)
        {
            return _keeper.CalculateFrameScore(theFrame);
        }  
    }
}
