using NUnit.Framework;
using Stigespill;

namespace StigespilletTDD.Test
{
    public class GameTest
    {

        [Test]
        public void TestStartAt0()
        {
            var game = new Game(4);
            var positions = game.GetPlayerPositions(0);
            Assert.AreEqual(0, positions);
        }


        [Test]
        public void TestInitalMove()
        {

            var game = new Game(4);
            game.Move(0, 4);
            var positions = game.GetPlayerPositions(0);
            Assert.AreEqual(4, positions);
        }


        [Test]
        public void TestmultiplePlayerPosition()
        {

            var game = new Game(2);
            game.Move(0, 3);
            game.Move(1, 4);
            var positions0 = game.GetPlayerPositions(0);
            var positions1 = game.GetPlayerPositions(1);
            Assert.AreEqual(3, positions0);
            Assert.AreEqual(4, positions1);
        }

        [Test]
        public void TestLadderFrom1To40()
        {

            var game = new Game(1);
            game.Move(0, 1);
            Assert.AreEqual(40, game.GetPlayerPositions(0));
        }



        [TestCase(1, 40)]
        [TestCase(36, 52)]
        [TestCase(24, 5)]
        public void TestLadder(int posFrom, int posTo)
        {
            var game = new Game(1);
            game.Move(0, posFrom);
            Assert.AreEqual(posTo, game.GetPlayerPositions(0));
        }

        [Test]
        public void TestDiceMax6()
        {
            var game = new Game(1);
            game.Move(0, 7);
            Assert.AreEqual(0, game.GetPlayerPositions(0));
        }

        [Test]
        public void TestNotWinning()
        {
            var game = new Game(1);
            game.Move(0, 2);
            var winner = game.GetWinner();
            Assert.IsNull(winner);
        }

        [Test]
        public void TestWinning()
        {
            var game = new Game(1);
            game.Move(0, 1);
            game.Move(0, 3);
            game.Move(0, 3);
            game.Move(0, 6);
            game.Move(0, 2);
           var winner =  game.GetWinner();
            Assert.AreEqual(0, winner);
        }
    }
}  