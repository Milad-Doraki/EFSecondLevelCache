﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EFSecondLevelCache.UnitTests
{
    internal sealed class TestConstants
    {
        public static readonly string Empty = "";
        public static readonly string FooBar = "foobar";
        public static readonly string LoremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.  Ut ornare aliquam mauris, at volutpat massa.  Phasellus pulvinar purus eu venenatis commodo.";
    }

    [TestClass]
    public class XxHashTests
    {
        [TestMethod]
        public void TestEmptyXxHashReturnsCorrectValue()
        {
            var hash = XxHashUnsafe.ComputeHash(TestConstants.Empty);
            Assert.AreEqual((uint)0x02cc5d05, hash);
        }

        [TestMethod]
        public void TestFooBarXxHashReturnsCorrectValue()
        {
            var hash = XxHashUnsafe.ComputeHash(TestConstants.FooBar);
            Assert.AreEqual((uint)2348340516, hash);
        }

        [TestMethod]
        public void TestLoremIpsumXxHashReturnsCorrectValue()
        {
            var hash = XxHashUnsafe.ComputeHash(TestConstants.LoremIpsum);
            Assert.AreEqual((uint)4046722717, hash);
        }
    }
}