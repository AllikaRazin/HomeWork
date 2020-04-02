using System;
using NUnit.Framework;

namespace ICollection
{
    [TestFixture]
    class TestICollection
    {
        UserCollection<int> collectoin;

        [SetUp]
        public void SetUp()
        {
            collectoin = new UserCollection<int>();
            collectoin.Add(4);
        }
        [Test]
        public void Test_Add()
        {
            collectoin.Add(6);
            Assert.AreEqual(collectoin.Contains(6), true);
            Assert.AreEqual(collectoin.Count, 2);
        }
        [Test]
        public void Test_Clear()
        {
            collectoin.Clear();
            Assert.AreEqual(collectoin.Contains(4), false);
            Assert.AreEqual(collectoin.Count, 0);
        }
        [Test]
        public void Test_Contains_true()
        {
            Assert.AreEqual(collectoin.Contains(4), true);
        }
        [Test]
        public void Test_Contains_false()
        {
            Assert.AreEqual(collectoin.Contains(8), false);
        }
        [Test]
        public void Test_CopyTo()
        {
            collectoin.Add(9);
            collectoin.Add(6);
            collectoin.Add(7);
            int[] value = new int[5];
            collectoin.CopyTo(value, 1);
            Assert.AreEqual(value[1],4);
            Assert.AreEqual(value[2],9);
            Assert.AreEqual(value[3],6);
            Assert.AreEqual(value[4],7);
        }
        [Test]
        public void Test_Remove()
        {
            collectoin.Add(9);
            collectoin.Add(6);
            collectoin.Add(7);
            collectoin.Remove(9);
            Assert.AreEqual(collectoin.Contains(9), false);
            Assert.AreEqual(collectoin.Count, 3);
        }
    }
}
