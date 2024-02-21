/*
      * File: testPlayer.cs
      * Author: Maddy Taylor
      * Date: 12/12/2023
      * Unit: COS20007 Object Oriented Programming
      * Institution: Swinburne Online
*/
using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using NUnit.Framework;
using NUnit.Framework.Internal.Commands;
using SwinAdventureProg;

namespace NUnitTests
{
    public class TestLocation
    {
        private Location _testLocation;
        private Player _testPlayer;
        private Item _testItem;
        private LookCommand _testCmd;

        [SetUp]
        public void Setup()
        {
            _testLocation = new Location("a chemistry lab", "There are potions and chemicals everywhere.");
            _testPlayer = new Player("Joe", "Regular Joe");
            _testItem = new Item(new string[] { "medicine" }, "a medicine jar", "fully restores health");
            _testCmd = new LookCommand();
            _testLocation.Inventory.Put(_testItem);
            _testPlayer.Location = _testLocation;
            
        }

        [TestCase("room")]
        [TestCase("here")]
        public void IdentifiableLocation(string ident)
        {
            Assert.IsTrue(_testLocation.AreYou(ident));
            Assert.AreEqual(_testLocation, _testLocation.Locate(ident));
        }

        [Test]
        public void TestLookLocation()
        {
            Assert.AreEqual(_testLocation.FullDescription, 
                _testCmd.Execute(_testPlayer, new string[] { "look" }));
        }

        [Test]
        public void LocationLocateItem()
        {
            Assert.AreEqual(_testItem, _testLocation.Locate("medicine"));
        }
      

        [Test]
        public void PlayerLocateItem()
        {
            Assert.AreEqual(_testItem, _testPlayer.Locate("medicine"));
        }

        [Test]

        public void CorrectFullDesc()
        {
            string expectedDesc = "\nYou are in a chemistry lab\nThere are potions and chemicals everywhere." +
                                  "\nIn this room you can see:\n\ta medicine jar";
            StringAssert.Contains(expectedDesc, _testLocation.FullDescription);
        }
    }
}
