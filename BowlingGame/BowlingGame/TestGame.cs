using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling.Test
{
    [TestFixture]
    class TestGame
    {
        private IGame g;
        
        [SetUp]
        public void setUp()
        {
            g = new Game();
        }

        

        [Test]
        public void TestTwoThrowsNoMark()
        {

            g.RollBalls(5);
            g.RollBalls(4);
            Assert.AreEqual(9, g.Score());
           
        }

       
        [Test]
        public void TestFourThrowsNoMark()
        {

            g.RollBalls(5);
            g.RollBalls(4);
            g.RollBalls(7);
            g.RollBalls(2);
            Assert.AreEqual(18, g.Score());

        }

     
        [Test]
        public void TestSimpleStrike()
        {
            g.RollBalls(10);
            g.RollBalls(3);
            g.RollBalls(6);
            
            Assert.AreEqual(28, g.Score());
            
        }


        [Test]
        public void TestPerfectGame()
        {
            for (int i = 0; i < 12; i++)
            {
                g.RollBalls(10);
            }
            Assert.AreEqual(300, g.Score());
            

        }
        [Test]
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
        [Test]
        public void TestTenStrikesAndLastBreak()
        {
            for (int i = 0; i < 11; i++)
                g.RollBalls(10);
            g.RollBalls(9);
            Assert.AreEqual(299, g.Score());
        }

        [Test]
        public void TestTenthFrameSpare()
        {
            for (int i = 0; i < 9; i++)
                g.RollBalls(10);
            g.RollBalls(9);
            g.RollBalls(1);
            g.RollBalls(1);
            Assert.AreEqual(270, g.Score());


        }

        [Test]
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
            Assert.AreEqual(133,g.Score());
        }
    }
}
