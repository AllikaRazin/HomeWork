using NUnit.Framework;
using BinaryTree.Ext;
using BinaryTree.Base;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        Tree<int> treeInt;
        int[] valuesTree;

        [SetUp]
        public void SetUp()
        {
            treeInt = new Tree<int>();
            valuesTree = new int[] { 15, 27, 10, 7, 17, 11, 3, 9, 30, 28, 20, 1, 31 };
            foreach (int item in valuesTree)
            {
                treeInt.Add(item);
            }
        }
        [Test]
        public void Sum_int_Test()
        {
            long trueSum = valuesTree.Sum();

            long sum = treeInt.Task1_Sum();
            Assert.AreEqual(trueSum, sum);
        }
        [Test]
        public void DifferentChildCount_Test()
        {
            int[] list = treeInt.Task2_DifferentChildCount().ToArray();
            Assert.IsTrue(list.Contains(10));
            Assert.IsTrue(list.Contains(17));
            Assert.IsTrue(list.Contains(7));
            Assert.IsTrue(list.Contains(27));
            Assert.IsTrue(list.Contains(3));
        }
        [Test]
        public void DifferentSubtreeHeight_Test()
        {
            int[] list = treeInt.Task3_DifferentSubtreeHeight().ToArray();
            Assert.IsTrue(list.Contains(10));
            Assert.IsTrue(list.Contains(15));
            Assert.IsTrue(list.Contains(17));
            Assert.IsTrue(list.Contains(7));
            Assert.IsTrue(list.Contains(3));
        }
        [Test]
        public void ElementCount_Test()
        {
            treeInt.Add(15);
            Assert.AreEqual(treeInt.Task4_ElementCount(15), 2);
            Assert.AreEqual(treeInt.Task4_ElementCount(30), 1);
            Assert.AreEqual(treeInt.Task4_ElementCount(2), 0);
        }
        [Test]
        public void MaxElement_Test()
        {
            int count;
            Assert.AreEqual(treeInt.Task5_MaxElement(out count), 31);
            Assert.AreEqual(count, 1);
            treeInt.Add(31);
            Assert.AreEqual(treeInt.Task5_MaxElement(out count), 31);
            Assert.AreEqual(count, 2);
            treeInt.Add(32);
            Assert.AreEqual(treeInt.Task5_MaxElement(out count), 32);
            Assert.AreEqual(count, 1);
        }
        [Test]
        public void Singleton_Test()
        {
            Assert.IsFalse(treeInt.Task6_Singleton());
            treeInt.Add(15);
            Assert.IsTrue(treeInt.Task6_Singleton());
        }
        [Test]
        public void MaxCount_Test()
        {
            int count;
            Assert.AreEqual(treeInt.Task7_MaxCount(out count), 15);
            Assert.AreEqual(count, 1);
            treeInt.Add(30);
            Assert.AreEqual(treeInt.Task7_MaxCount(out count), 30);
            Assert.AreEqual(count, 2);
        }
        [Test]
        public void IsTreeSimetric_Test()
        {
            Assert.IsFalse(treeInt.Task8_IsTreeSimetric());
            treeInt = new Tree<int>();
            valuesTree = new int[] { 15, 10, 20, 3, 30, 7, 25 };
            foreach (int item in valuesTree)
                treeInt.Add(item);
            Assert.IsTrue(treeInt.Task8_IsTreeSimetric());
            treeInt.Add(30);
            Assert.IsFalse(treeInt.Task8_IsTreeSimetric());
        }
        [Test]
        public void MaxElementsByLevels_Test()
        {
            int[] values = treeInt.Task9_MaxElementsByLevels().ToArray();
            Assert.AreEqual(values[0], 15);
            Assert.AreEqual(values[1], 27);
            Assert.AreEqual(values[2], 30);
            Assert.AreEqual(values[3], 31);
            Assert.AreEqual(values[4], 1);
            treeInt.Add(25);
            values = treeInt.Task9_MaxElementsByLevels().ToArray();
            Assert.AreEqual(values[4], 25);
        }
        [Test]
        public void CountNodsAndSheetsByLevels_Test()
        {
            var otvet = new TreeTasksExt.Task10_LevelResult[]
                {
                    new TreeTasksExt.Task10_LevelResult{ CountNods = 1, CountSheets = 0 },
                    new TreeTasksExt.Task10_LevelResult{ CountNods = 2, CountSheets = 0 },
                    new TreeTasksExt.Task10_LevelResult{ CountNods = 3, CountSheets = 1 },
                    new TreeTasksExt.Task10_LevelResult{ CountNods = 1, CountSheets = 4 },
                    new TreeTasksExt.Task10_LevelResult{ CountNods = 0, CountSheets = 1 },
                }.AsEnumerable();
            var resul = treeInt.Task10_CountNodsAndSheetsByLevels();
            Assert.AreEqual(otvet, resul);
        }
        [Test]
        public void EvenSum_Test()
        {
            Assert.AreEqual(treeInt.Task11_EvenSum(), 81);
        }
    }
}