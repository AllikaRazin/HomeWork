using NUnit.Framework;
using System;

namespace ABLTree
{
    [TestFixture]
    class AVLTreeTest
    {
        AVLTree<int> avl1;
        AVLTree<int> avl2;

        [SetUp]
        public void SetUp()
        {
            avl1 = new AVLTree<int> { 10, 14, 18, 3, 51, 85, 7 };
        }

        [Test]
        public void Add_Test()
        {
            avl2 = new AVLTree<int> { 10, 14, 18, 3, 51, 85, 7, 15 };
            avl1.Add(15);

            CollectionAssert.AreEqual(avl1, avl2);
        }

        [Test]
        public void Remove_Test()
        {
            avl1.Remove(3);
            avl2 = new AVLTree<int> { 10, 14, 18, 51, 85, 7 };

            CollectionAssert.AreEqual(avl1, avl2);
        }

        [Test]
        public void Find_Test_False()
        {
            bool result = avl1.Contains(66);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void Find_Test_True()
        {
            bool result = avl1.Contains(18);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void BalanceRight_Test()
        {
            avl2 = new AVLTree<int> { 11, 10, 20, 16, 14, 15 };
            avl2 = new AVLTree<int> { 14 };

            Assert.AreEqual(avl1.Head.Value, avl2.Head.Value);
        }

        [Test]
        public void BalanceLeft_Test()
        {
            avl1 = new AVLTree<int> { 6, 16, 19, 11, 10 };
            avl1.Remove(11);
            avl2 = new AVLTree<int> { 16 };

            Assert.AreEqual(avl1.Head.Value, avl2.Head.Value);
        }
    }
}
