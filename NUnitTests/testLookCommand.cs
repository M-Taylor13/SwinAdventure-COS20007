/*
 * File: testLookCommand.cs
 * Author: Maddy Taylor
 * Date: 2/12/2023
 * Unit: COS20007 Object Oriented Programming
 * Institution: Swinburne Online
 */
using System;
using NUnit.Framework;
using SwinAdventureProg;

namespace NUnitTests
{
    public class TestLookCommand
    {
        private Item _testGem;
        private Player _testPlayer;
        private Bag _testBag;
        private LookCommand _testLookCmd;
        private string[] _testArray1;
        private string[] _testArray2;
        private string[] _testArray3;
        private string[] _testArray4;

        [SetUp]
        public void Setup()
        {
            _testLookCmd = new LookCommand();
            _testPlayer = new Player("looker", "always looking...");
            _testBag = new Bag(new string[] { "bag" }, "leather bag", "A stylish leather bag, doesn't hold much.");
            _testGem = new Item(new string[] { "gem"}, "gem", "a glimmering green gem");
            _testArray1 = new string[] {"look", "at","inventory"};
            _testArray2 = new string[] { "look", "at", "gem" };
            _testArray3 = new string[] { "look", "at", "gem", "in", "inventory"};
            _testArray4 = new string[] { "look", "at", "gem", "in", "bag" };
            _testPlayer.Inventory.Put(_testGem);
            _testPlayer.Inventory.Put(_testBag);
            _testBag.Inventory.Put(_testGem);

        }

        [Test]
        public void TestLookAtMe()
        {
            Assert.AreEqual(_testPlayer.FullDescription, _testLookCmd.Execute(_testPlayer, _testArray1));
        }

        [Test]
        public void TestLookAtGem()
        {
            Assert.AreEqual(_testGem.FullDescription, _testLookCmd.Execute(_testPlayer, _testArray2));
        }

        [Test]
        public void TestLookAtUnkn()
        {
            _testPlayer.Inventory.Take("gem");
            Assert.AreEqual("I cannot find gem in looker", _testLookCmd.Execute(_testPlayer, _testArray2));
        }

        [Test]
        public void TestLookAtGemInMe()
        {
            Assert.AreEqual(_testGem.FullDescription, _testLookCmd.Execute(_testPlayer, _testArray3));
        }

        [Test]
        public void TestLookAtGemInBag()
        {
            Assert.AreEqual(_testGem.FullDescription, _testLookCmd.Execute(_testPlayer, _testArray4));
        }

        [Test]
        public void TestLookInNoBag()
        {
            _testPlayer.Inventory.Take("bag");
            Assert.AreEqual("I cannot find the bag", _testLookCmd.Execute(_testPlayer, _testArray4));
        }

        [Test]
        public void TestLookAtNoGemInBag()
        {
            _testBag.Inventory.Take("gem");
            Assert.AreEqual("I cannot find gem in leather bag", _testLookCmd.Execute(_testPlayer, _testArray4));
        }

        [Test]
        public void TestInvalidLook()
        {
            Assert.AreEqual("Error in look input", _testLookCmd.Execute(_testPlayer, new string[]{"howdy"}));
            Assert.AreEqual("What do you want to look at?", _testLookCmd.Execute(_testPlayer, new string[] { "look", "up" }));
            Assert.AreEqual("What do you want to look in?", _testLookCmd.Execute(_testPlayer, new string[] { "look", "at", "this", "thing", "now"  }));
            Assert.AreEqual("I don't know how to look like that", _testLookCmd.Execute(_testPlayer, new string[] { "look", "at", "gem", "in" }));
        }
    }
}