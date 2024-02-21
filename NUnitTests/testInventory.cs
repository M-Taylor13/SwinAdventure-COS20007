/*
* File: testInventory.cs
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
    public class TestInventory
    {
        private Inventory _testInv;
        private Item _testItem1;
        private Item _testItem2;
        private Item _removedItem;
        private string[] _itmIdents;
        private string _fakeItem;

        [SetUp]
        public void Setup()
        {
            _testInv = new Inventory();
            _testItem1 = new Item(new string[] { "rock", "stone" }, "a rock", "You never know when you need a rock.");
            _testItem2 = new Item(new string[] { "wrench", "tool" }, "a wrench", "helpful for getting to new places");
            _fakeItem = "balloon";
            _testInv.Put(_testItem1);
            _testInv.Put(_testItem2);
            _removedItem = _testInv.Take("wrench");
        }

        [TestCase("rock")]
        [TestCase("stone")]
        [TestCase("rOcK")]
        [TestCase("sTonE")]
        public void TestDoesHaveItem(string itm)
        {
            Assert.IsTrue(_testInv.HasItem(itm));
        }

        [Test]
        public void TestDoesNotHaveItem()
        {
            Assert.IsFalse(_testInv.HasItem(_fakeItem));
        }

        [Test]
        public void TestCanFetch()
        {
            Assert.AreEqual(_testItem1, _testInv.Fetch("rock"));
        }

        [Test]
        public void TestIsTaken()
        {
            Assert.False(_testInv.HasItem(_testItem2.FirstId()));
            Assert.AreEqual(_testItem2, _removedItem);
        }

        [Test]
        public void TestItemList()
        {
            _testInv.Put(_testItem2);
            Assert.AreEqual("\ta rock (rock)\n\ta wrench (wrench)\n", _testInv.ItemList);
        }
    }
}
