using NUnit.Framework;

namespace Iterator
{
    [TestFixture]
    class TestIterator
    {
        Aggregate aggregate;
        Iterator iterator;

        [SetUp]
        public void SetUp()
        {
            aggregate = new ConcreteAggregate();

            aggregate[0] = "Element 1";
            aggregate[1] = "Element 2";
            aggregate[2] = "Element 3";
            aggregate[3] = "Element 4";
            aggregate[4] = "Element 5";
            aggregate[5] = "Element 6";

            iterator = aggregate.CreateIterator();
        }

        [Test]
        public void Test_Ferst()
        {
            Assert.AreEqual(iterator.First(), "Element 1");
        }
        [Test]
        public void Test_Next()
        {
            Assert.AreEqual(iterator.Next(), "Element 2");
        }
        [Test]
        public void Test_CurrentItem()
        {
            iterator.Next();
            iterator.Next();
            iterator.Next();

            Assert.AreEqual(iterator.CurrentItem(), "Element 4");
        }
        [Test]
        public void Test_IsDone_false()
        {
            iterator.Next();
            iterator.Next();
            iterator.Next();

            Assert.AreEqual(iterator.IsDone(), false);
        }
        [Test]
        public void Test_IsDone_true()
        {
            iterator.Next();
            iterator.Next();
            iterator.Next();
            iterator.Next();
            iterator.Next();

            Assert.AreEqual(iterator.IsDone(), true);
        }

    }
}
