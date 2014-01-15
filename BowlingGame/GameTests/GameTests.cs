using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling;

namespace GameTests
{
    [TestClass]
    public class GameTests
    {
        public IGame g;

        [TestInitialize]
        public void Init()
        {
            g = new Game();
        }

        [TestMethod]
        public void TestTwoThrowsNoMark()
        {

            g.RollBalls(5);
            g.RollBalls(4);
            Assert.AreEqual(9, g.Score());

        }
        [TestMethod]
        public void TestFourThrowsNoMark()
        {

            g.RollBalls(5);
            g.RollBalls(4);
            g.RollBalls(7);
            g.RollBalls(2);
            Assert.AreEqual(18, g.Score());

        }


        [TestMethod]
        public void TestSimpleStrike()
        {
            g.RollBalls(10);
            g.RollBalls(3);
            g.RollBalls(6);

            Assert.AreEqual(28, g.Score());

        }


        [TestMethod]
        public void TestPerfectGame()
        {
            for (int i = 0; i < 12; i++)
            {
                g.RollBalls(10);
            }
            Assert.AreEqual(300, g.Score());


        }
        [TestMethod]
        public void TestSampleGame()
        {
            g.RollBalls(1);
            g.RollBalls(4);
            g.RollBalls(4);
            g.RollBalls(5);
            g.RollBalls(6);
            g.RollBalls(4);
            g.RollBalls(5);
            g.RollBalls(5);
            g.RollBalls(10);
            g.RollBalls(0);
            g.RollBalls(1);
            g.RollBalls(7);
            g.RollBalls(3);
            g.RollBalls(6);
            g.RollBalls(4);
            g.RollBalls(10);
            g.RollBalls(2);
            g.RollBalls(8);
            g.RollBalls(6);
            Assert.AreEqual(133, g.Score());



        }
        [TestMethod]
        public void TestHeartBreak()
        {
            for (int i = 0; i < 11; i++)
                g.RollBalls(10);
            g.RollBalls(9);
            Assert.AreEqual(299, g.Score());
        }

        [TestMethod]
        public void TestTenthFrameSpare()
        {
            for (int i = 0; i < 9; i++)
                g.RollBalls(10);
            g.RollBalls(9);
            g.RollBalls(1);
            g.RollBalls(1);
            Assert.AreEqual(270, g.Score());


        }

        [TestMethod]
        public void TestGameForData()
        {


            g.RollBalls(1);
            g.RollBalls(4);
            g.RollBalls(4);
            g.RollBalls(5);
            g.RollBalls(6);
            g.RollBalls(4);
            g.RollBalls(5);
            g.RollBalls(5);
            g.RollBalls(10);
            g.RollBalls(0);
            g.RollBalls(1);
            g.RollBalls(7);
            g.RollBalls(3);
            g.RollBalls(6);
            g.RollBalls(4);
            g.RollBalls(10);
            g.RollBalls(2);
            g.RollBalls(8);
            g.RollBalls(6);
            Assert.AreEqual(133, g.Score());
        }
    }
}
