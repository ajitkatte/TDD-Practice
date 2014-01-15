using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bowling
{
    public interface IGame
    {
        void RollBalls(int pins);
        int Score();
    }
}
