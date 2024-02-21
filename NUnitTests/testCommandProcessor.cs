/*
 * File: testCommandProcessor.cs
 * Author: Maddy Taylor
 * Date: 28/12/2023
 * Unit: COS20007 Object Oriented Programming
 * Institution: Swinburne Online
 */
using System;
using NUnit.Framework;
using SwinAdventure;
using SwinAdventureProg;

namespace NUnitTests
{
    public class TestCommandProcessor
    {
        private CommandProcessor _testProcessor;
        private Player _testPlayer;
        private string[] _testMoveCmd;
        private string[] _testLookCmd;
        private string[] _testFalseCmd;

        [SetUp]
        public void Setup()
        {
            _testProcessor = new CommandProcessor();
            _testPlayer = new Player("looker", "always looking...");
            _testMoveCmd = new string[] { "move" };
            _testLookCmd = new string[] { "look", "here" };
            _testFalseCmd = new string[] { "jump" };

        }

        [Test]
        public void TestCorrectCmd()
        {
            Assert.AreEqual("Where do you want to move?", _testProcessor.Execute(_testPlayer, _testMoveCmd));
            Assert.AreEqual("What do you want to look at?", _testProcessor.Execute(_testPlayer, _testLookCmd));
        }

        [Test]
        public void TestInvalidCmd()
        {
            Assert.AreEqual("Command not found", _testProcessor.Execute(_testPlayer, _testFalseCmd));
        }

    }
}