/*
 * File: testItem.cs
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
    public class TestItem
    {
        private Item _testItem;
        private string[] _testIdents;

        [SetUp]
        public void Setup()
        {
            _testIdents = new string[] { "sword", "blade" };
            _testItem = new Item(_testIdents, "a sword", "It's cardboard! Not steel..." );

        }

        [TestCase("sword")]
        [TestCase("blade")]
        [TestCase("SWORD")]
        [TestCase("bLAde")]
        public void TestIdentifiers(string ident)
        {
            Assert.IsTrue(_testItem.AreYou(ident));
        }

        [Test]
        public void TestShortDesc()
        {
            Assert.AreEqual("a sword (sword)", _testItem.ShortDescription);
        }

        [Test]
        public void TestFullDesc()
        {
            Assert.AreEqual("It's cardboard! Not steel...", _testItem.FullDescription);
        }
    }
}
