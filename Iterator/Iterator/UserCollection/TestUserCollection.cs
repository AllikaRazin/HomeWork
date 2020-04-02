using NUnit.Framework;
using System.Collections.Generic;

namespace UserCollection
{
    [TestFixture]
    class TestUserCollection
    {
        [Test]
        public void Test1()
        {
            UserCollection<Element> elements = new UserCollection<Element>();
            elements[0] = new Element("Nikol", "Smit");
            elements[1] = new Element("Binar", "Pinity");
            elements[2] = new Element("Faust", "Felsh");
            elements[3] = new Element("Brock", "Markin");

            List<Element> result = new List<Element>();

            foreach (var element in elements)
            {
                result.Add(element);
            }

            Assert.AreEqual(result[0].Name, "Nikol");
            Assert.AreEqual(result[0].Surname, "Smit");

            Assert.AreEqual(result[1].Name, "Binar");
            Assert.AreEqual(result[1].Surname, "Pinity");

            Assert.AreEqual(result[2].Name, "Faust");
            Assert.AreEqual(result[2].Surname, "Felsh");

            Assert.AreEqual(result[3].Name, "Brock");
            Assert.AreEqual(result[3].Surname, "Markin");
        }
    }
}
