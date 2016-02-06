namespace Bowling
{
    public class ScoreKeeper
    {
        private int _ball;
        private readonly int[] _allThrows = new int[21];
        private int _currentThrow;

        public void AddThrowInGame(int pins)
        {
            _allThrows[_currentThrow++] = pins;
        }

        public int CalculateFrameScore(int theFrame)
        {
            _ball = 0;
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
            if (_allThrows[_ball] == 10)
            {
                _ball++;
                return true;
            }
            return false;
        }

        private bool CheckSpare()
        {
            if ((_allThrows[_ball] + _allThrows[_ball + 1]) == 10)
            {
                _ball = _ball + 2;
                return true;
            }
            return false;
        }

        private int NextBalls()
        {
            return _allThrows[_ball] + _allThrows[_ball + 1];
        }
        private int NextBall()
        {
            return _allThrows[_ball];
        }

        private int TwoBalls()
        {
            return _allThrows[_ball++] + _allThrows[_ball++];
        }
    }
}
