using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling;

namespace GameTests
{
    [TestClass]
    public class GameTests
    {
        private IGame _game;

        [TestInitialize]
        public void Init()
        {
            _game = new Game();
        }

        [TestMethod]
        public void TestTwoThrowsNoMark()
        {
            _game.RollBalls(5);
            _game.RollBalls(4);
            Assert.AreEqual(9, _game.Score());
        }

        [TestMethod]
        public void TestFourThrowsNoMark()
        {
            _game.RollBalls(5);
            _game.RollBalls(4);
            _game.RollBalls(7);
            _game.RollBalls(2);
            Assert.AreEqual(18, _game.Score());
        }


        [TestMethod]
        public void TestSimpleStrike()
        {
            _game.RollBalls(10);
            _game.RollBalls(3);
            _game.RollBalls(6);
            Assert.AreEqual(28, _game.Score());
        }


        [TestMethod]
        public void TestPerfectGame()
        {
            for (int i = 0; i < 12; i++)
            {
                _game.RollBalls(10);
            }
            Assert.AreEqual(300, _game.Score());
        }

        [TestMethod]
        public void TestSampleGame()
        {
            _game.RollBalls(1);
            _game.RollBalls(4);
            _game.RollBalls(4);
            _game.RollBalls(5);
            _game.RollBalls(6);
            _game.RollBalls(4);
            _game.RollBalls(5);
            _game.RollBalls(5);
            _game.RollBalls(10);
            _game.RollBalls(0);
            _game.RollBalls(1);
            _game.RollBalls(7);
            _game.RollBalls(3);
            _game.RollBalls(6);
            _game.RollBalls(4);
            _game.RollBalls(10);
            _game.RollBalls(2);
            _game.RollBalls(8);
            _game.RollBalls(6);
            Assert.AreEqual(133, _game.Score());
        }

        [TestMethod]
        public void TestHeartBreak()
        {
            for (int i = 0; i < 11; i++)
            {
                _game.RollBalls(10);
            }
            _game.RollBalls(9);
            Assert.AreEqual(299, _game.Score());
        }

        [TestMethod]
        public void TestTenthFrameSpare()
        {
            for (int i = 0; i < 9; i++)
                _game.RollBalls(10);
            _game.RollBalls(9);
            _game.RollBalls(1);
            _game.RollBalls(1);
            Assert.AreEqual(270, _game.Score());
        }

        [TestMethod]
        public void TestGameForData()
        {
            _game.RollBalls(1);
            _game.RollBalls(4);
            _game.RollBalls(4);
            _game.RollBalls(5);
            _game.RollBalls(6);
            _game.RollBalls(4);
            _game.RollBalls(5);
            _game.RollBalls(5);
            _game.RollBalls(10);
            _game.RollBalls(0);
            _game.RollBalls(1);
            _game.RollBalls(7);
            _game.RollBalls(3);
            _game.RollBalls(6);
            _game.RollBalls(4);
            _game.RollBalls(10);
            _game.RollBalls(2);
            _game.RollBalls(8);
            _game.RollBalls(6);
            Assert.AreEqual(133, _game.Score());
        }
    }
}
