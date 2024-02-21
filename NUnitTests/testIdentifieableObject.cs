/*
 * File: testIdentifiableObeject.cs
 * Author: Maddy Taylor
 * Date: 21/11/2023
 * Unit: COS20007 Object Oriented Programming
 * Institution: Swinburne Online
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SwinAdventureProg;


namespace NUnitTests
{
    public class TestIdentifiableObject
    {

        private IdentifiableObject _testId;
        private string[] _testArr;

        [SetUp]
        public void Setup()
        {
            _testArr = new string[] { "fred", "bob" };
            _testId = new IdentifiableObject(_testArr);
            _testId.AddIdentifier("wilma");

        }

        [TestCase("fred")]
        [TestCase("bob")]
        public void TestAreYou(string testName)
        {
            Assert.IsTrue(_testId.AreYou(testName));
        }

        [TestCase("wima")]
        [TestCase("boby")]
        public void TestNotAreYou(string testName)
        {
            Assert.IsFalse(_testId.AreYou(testName));
        }

        [TestCase("FRED")]
        [TestCase("bOB")]
        public void TestCaseSensitive(string testName)
        {
            Assert.IsTrue(_testId.AreYou(testName));
        }

        [Test]
        public void TestFirstId()
        {
            Assert.AreEqual("fred", _testId.FirstId());
        }

        [TestCase("fred")]
        [TestCase("bob")]
        [TestCase("wilma")]
        public void TestAddId(string testName)
        {
            Assert.IsTrue(_testId.AreYou(testName));
        }

    }
}