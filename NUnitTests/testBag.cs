/*
 * File: testBag.cs
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
    public class TestBag
    {
        private Bag _b1;
        private Bag _b2;
        private Item _testItem1;
        private Item _testItem2;
        private Item _testItem3;

        [SetUp]
        public void Setup()
        {
            _b1 = new Bag(new string[] { "bag 1" }, "a leather bag", "A stylish leather bag, doesn't hold much.");
            _b2 = new Bag(new string[] { "bag 2" }, "a canvas bag", "An old canvas bags, holds more than you think is possible.");
            _testItem1 = new Item(new string[] { "rock", "stone" }, "a rock", "You never know when you need a rock.");
            _testItem2 = new Item(new string[] { "wrench", "tool" }, "a wrench", "helpful for getting to new places");
            _testItem3 = new Item(new string[] { "sword", "blade" }, "a sword", "It's cardboard! Not steel...");
            _b1.Inventory.Put(_testItem1);
            _b1.Inventory.Put(_testItem2);
            _b2.Inventory.Put(_testItem3);
            _b1.Inventory.Put(_b2);

        }
        [Test]
        public void LocateItem()
        {
            Assert.AreEqual(_testItem2, _b1.Locate("wrench"));
        }

        [Test]
        public void LocateSelf()
        {
            Assert.AreEqual(_b1, _b1.Locate("bag 1" ));
        }

        [Test]
        public void LocateNull()
        {
            Assert.IsNull(_b1.Locate("piano"));
        }


        [Test]
        public void TestFullDesc()
        {
            Assert.AreEqual("In the bag 1 you can see:\n\ta rock (rock)\n\ta wrench (wrench)\n\ta canvas bag (bag 2)\n", _b1.FullDescription);
        }

        [Test]

        public void TestBagInBag()
        {
            Assert.AreEqual(_b2, _b1.Locate("bag 2"));
            Assert.AreEqual(_testItem1, _b1.Locate("rock"));
            Assert.AreNotEqual(_testItem3, _b1.Locate("sword"));
        }
    }
}