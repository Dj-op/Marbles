namespace MarblesTests
{
    [TestClass]
    public class MarbleTest
    {
        [TestMethod]
        public void TestPalindrome()
        {
            Assert.IsTrue(StringHelper.IsPalindrome("bob"));
            Assert.IsTrue(StringHelper.IsPalindrome("Bob"));
            Assert.IsTrue(StringHelper.IsPalindrome("b-ob"));
            Assert.IsTrue(StringHelper.IsPalindrome("Bob O' Bob"));
            Assert.IsFalse(StringHelper.IsPalindrome("Ryan O Ryan"));

        }
       
        [TestMethod]
        public void TestMarbleOrdering()
        {
            Marble redMarble = new Marble(1, "red", "redMarble", 1.0);
            Marble orangeMarble = new Marble(1, "orange", "orangeMarble", 1.0);
            Marble yellowMarble = new Marble(1, "yellow", "yellowMarble", 1.0);
            Marble greenMarble = new Marble(1, "green", "greenMarble", 1.0);
            Marble blueMarble = new Marble(1,"blue", "blueMarble", 1.0);
            Marble indigoMarble = new Marble(1, "indigo", "indigoMarble", 1.0);
            Marble violetMarble = new Marble(1, "violet", "violetMarble", 1.0);
            Marble aquaMarble = new Marble(1,  "aqua", "aquaMarble", 1.0);

            Assert.AreEqual(redMarble.Ordering, 0);
            Assert.AreEqual(orangeMarble.Ordering, 1);
            Assert.AreEqual(yellowMarble.Ordering, 2);
            Assert.AreEqual(greenMarble.Ordering, 3);
            Assert.AreEqual(blueMarble.Ordering, 4);
            Assert.AreEqual(indigoMarble.Ordering, 5);
            Assert.AreEqual(violetMarble.Ordering, 6);
            Assert.AreEqual(aquaMarble.Ordering, -1);



        }

        [TestMethod]
        public void TestSortAndFilter()
        {
            Marble marble1 = new Marble(1, "blue", "Bob", 0.5);
            Marble marble2 = new Marble(2, "red", "John Smith", 0.25);
            Marble marble3 = new Marble(3, "violet", "Bob O' Bob", 0.5);
            Marble marble4 = new Marble(4, "indigo", "Bob Dad-Bob", 0.75);
            Marble marble5 = new Marble(5, "yellow", "John", 0.5);
            Marble marble6 = new Marble(6, "orange", "Bob", 0.25);
            Marble marble7 = new Marble(7, "blue", "Smith", 0.5);
            Marble marble8 = new Marble(8, "blue", "Bob", 0.25);
            Marble marble9 = new Marble(9, "green", "Bobb Ob", 0.75);
            Marble marble10 = new Marble(10, "blue", "Bob", 0.5);

            List<Marble> inputMarbles = new List<Marble>();

            inputMarbles.Add(marble1);
            inputMarbles.Add(marble2);
            inputMarbles.Add(marble3);
            inputMarbles.Add(marble4);
            inputMarbles.Add(marble5);
            inputMarbles.Add(marble6);
            inputMarbles.Add(marble7);
            inputMarbles.Add(marble8);
            inputMarbles.Add(marble9);
            inputMarbles.Add(marble10);

            List<Marble> outputMarbles = MarbleProcessor.ShortAndFilter(inputMarbles);

            Assert.AreEqual(5, outputMarbles.Count);
            Assert.AreEqual(9, outputMarbles[0].Id);
            Assert.AreEqual(1, outputMarbles[1].Id);
            Assert.AreEqual(10, outputMarbles[2].Id);
            Assert.AreEqual(4, outputMarbles[3].Id);
            Assert.AreEqual(3, outputMarbles[4].Id);
        }

    }
}
