using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bowling
{
    public class ScoreKeeper
    {

        private int ball;
        private int[] allThrows = new int[21];
        private int currentThrow = 0;

        public void AddThrowInGame(int pins)
        {
            allThrows[currentThrow++] = pins;
        }

        public int CalculateFrameScore(int theFrame)
        {
            ball = 0;
            int score = 0;
            for (int currentFrame = 0;currentFrame < theFrame;currentFrame++)
            {
                if (CheckStrike())
                    score = score+ 10 + NextBalls();
                else if (CheckSpare())
                    score = score + 10 + NextBall();
                else
                    score = score + TwoBalls();
            }

            return score;
        }

        private bool CheckStrike()
        {
            if (allThrows[ball] == 10)
            {
                ball++;
                return true;
            }
            return false;
        }

        private bool CheckSpare()
        {
            if ((allThrows[ball] + allThrows[ball + 1]) == 10)
            {
                ball = ball + 2;
                return true;
            }
            return false;
        }

        private int NextBalls()
        {
            return allThrows[ball] + allThrows[ball + 1];
        }
        private int NextBall()
        {
            return allThrows[ball];
        }

        private int TwoBalls()
        {
            return allThrows[ball++] + allThrows[ball++];
        }

        

    }



}
