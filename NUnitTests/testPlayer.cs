/*
 * File: testPlayer.cs
 * Author: Maddy Taylor
 * Date: 1/12/2023
 * Unit: COS20007 Object Oriented Programming
 * Institution: Swinburne Online
 */
using System;
using NUnit.Framework;
using SwinAdventureProg;

namespace NUnitTests
{
    public class TestPlayer
    {
        private Player _testPlayer;
        private Item _testItem;


        [SetUp]
        public void Setup()
        {
            _testPlayer = new Player("Ishmael", "The whale hunter");
            _testItem = new Item(new String[] {"journal", "book"}, "a journal", "contains writings of the great leviathan" );
            Inventory _testInv = _testPlayer.Inventory;
            _testInv.Put(_testItem);
        }

        [TestCase("me")]
        [TestCase("inventory")]
        public void IdentifyPlayer(string ident)
        {
            Assert.IsTrue(_testPlayer.AreYou(ident));
        }

        [Test]
        public void LocateItem()
        {
            Assert.AreEqual(_testItem, _testPlayer.Locate("journal"));
        }

        [TestCase("me")]
        [TestCase("inventory")]
        public void LocatePlayer(string selfID)
        {
            Assert.AreEqual(_testPlayer, _testPlayer.Locate(selfID));
        }

        [Test]
        public void LocateNull()
        {
            Assert.IsNull(_testPlayer.Locate("hat")); //(it blew off)
        }

        [Test]

        public void CorrectFullDesc()
        {
            StringAssert.Contains("You are carrying:\n\ta journal (journal)\n", _testPlayer.FullDescription);
        }
    }
}
