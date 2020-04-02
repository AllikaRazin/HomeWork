using NUnit.Framework;

namespace LList
{
    [TestFixture]
    class TestLinkedList
    {
        LinkedList<int> linkedList;

        [SetUp]
        public void SetUp()
        {
            linkedList = new LinkedList<int>();

            linkedList.Add(4);
            linkedList.Add(2);
            linkedList.Add(6);
            linkedList.Add(4);
            linkedList.Add(9);
        }
        [Test]
        public void Test_Count()
        {
            Assert.AreEqual(linkedList.Count, 5);
        }
        [Test]
        public void Test_Find()
        {
            LinkedListNode<int> temp = linkedList.Find(4);
            Assert.AreEqual(temp.Next.Value, 2);
            Assert.AreEqual(temp.Previous, null);
        }
        [Test]
        public void Test_FindLast()
        {
            LinkedListNode<int> temp = linkedList.FindLast(4);
            Assert.AreEqual(temp.Next.Value, 9);
            Assert.AreEqual(temp.Previous.Value, 6);
        }
        [Test]
        public void Test_AddAfter()
        {
            linkedList.AddAfter(15, 2);
            Assert.AreEqual(linkedList.Count, 6);
            LinkedListNode<int> temp = linkedList.Find(15);
            Assert.AreEqual(temp.Next.Value, 4);
            Assert.AreEqual(temp.Previous.Value, 6);
        }
        [Test]
        public void Test_AddBefore()
        {
            linkedList.AddBefore(17, 2);
            Assert.AreEqual(linkedList.Count, 6);
            LinkedListNode<int> temp = linkedList.Find(17);
            Assert.AreEqual(temp.Next.Value, 6);
            Assert.AreEqual(temp.Previous.Value, 2);
        }
        [Test]
        public void Test_AddFirst()
        {
            linkedList.AddFirst(1);
            Assert.AreEqual(linkedList.Count, 6);
            LinkedListNode<int> temp = linkedList.Find(1);
            Assert.AreEqual(temp.Next.Value, 4);
            Assert.AreEqual(temp.Previous, null);
        }
        [Test]
        public void Test_AddLast()
        {
            linkedList.AddLast(20);
            Assert.AreEqual(linkedList.Count, 6);
            LinkedListNode<int> temp = linkedList.Find(20);
            Assert.AreEqual(temp.Value, 20);
            Assert.AreEqual(temp.Next, null);
            Assert.AreEqual(temp.Previous.Value, 9);
        }
        [Test]
        public void Test_RemoveFirst()
        {
            linkedList.RemoveFirst();
            LinkedListNode<int> temp = linkedList.Find(2);
            Assert.AreEqual(linkedList.Count, 4);
            Assert.AreEqual(temp.Next.Value, 6);
            Assert.AreEqual(temp.Previous, null);
        }
        [Test]
        public void Test_RemoveLast()
        {
            linkedList.RemoveLast();
            Assert.AreEqual(linkedList.Find(9), null) ;
            Assert.AreEqual(linkedList.Count, 4);
            LinkedListNode<int> temp = linkedList.FindLast(4);
            Assert.AreEqual(temp.Next, null);
            Assert.AreEqual(temp.Previous.Value, 6);
        }
    }
}
