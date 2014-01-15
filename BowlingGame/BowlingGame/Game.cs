using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class Game:IGame
    {
        private int currentFrameForGame = 1;
        private bool firstThrow = true;
        private ScoreKeeper keeper = new ScoreKeeper();

        public int Score()
        {
            return ScoreForFrame(GetCurrentFrame() - 1);
        }

        public int GetCurrentFrame()
        {
            return currentFrameForGame;
        }

        public void RollBalls(int pins)
        {
            keeper.AddThrowInGame(pins);
            AdjustFrame(pins);
        }

        private void AdjustFrame(int pins)
        {
            if (firstThrow == true)
            {
                if (pins == 10) // strike
                    NextFrame();
                else
                    firstThrow = false;
            }
            else
            {
                firstThrow = true;
                NextFrame();
            }
            
        }

        public void NextFrame()
        {
            currentFrameForGame = Math.Min(11, currentFrameForGame+1);
        }

        public int ScoreForFrame(int theFrame)
        {
            return keeper.CalculateFrameScore(theFrame);
        }

        
       
    }

}
