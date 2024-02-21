/*
 * File: testPath.cs
 * Author: Maddy Taylor
 * Date: 28/12/2023
 * Unit: COS20007 Object Oriented Programming
 * Institution: Swinburne Online
 */
using System;
using System.Numerics;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SwinAdventureProg;
using Path = SwinAdventureProg.Path;

namespace NUnitTests
{
    public class TestPath
    {
        private Player _testPlayer;
        private Location _testLocation1;
        private Location _testLocation2;
        private Path _testPath;
        private Path _testFakePath;

        [SetUp]
        public void Setup()
        {
            _testLocation1 = new Location("the kitchen", "A kitchen with a fridge.");
            _testLocation2 = new Location("the kitchen", "A kitchen with a fridge.");
            _testPath = new Path(new string[] { "north", "up" }, "a hallway", "You open a wooden door", _testLocation2);
            _testFakePath = new Path(new string[] { "south", "down" }, "a wall", "You are walking into a wall", _testLocation2);
            _testPlayer = new Player("test player", "the test player");
            _testPlayer.Location = _testLocation1;
            _testLocation1.AddPath(_testPath);

        }

        [Test]
        public void TestPathDestination()
        {
           
            Assert.AreEqual(_testLocation2, _testPath.Destination);
        }

        [Test]
        public void TestLocationPath()
        {
            Assert.AreEqual(_testPath, _testLocation1.Locate("north"));
        }

        [Test]
        public void TestPlayerMove()
        {
            _testPlayer.Move(_testPath);
            Assert.AreEqual(_testPath.Destination, _testPlayer.Location);
        }

        [Test]
        public void TestFakePath()
        {
            Assert.IsNull(_testLocation1.Locate("south"));
        }
    }
}
