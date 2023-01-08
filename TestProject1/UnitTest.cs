using HashTable;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void AddInTableTest()
        {
            var mass = new int[] { 12, 180, 750, 125489, 5481, 36587, 2, 1548723, 165498435, 14894, 225544161, 5, 7, 6511, 658, 100, 1000, 21561};
            HashTable.Table table = new HashTable.Table();
            foreach(var item in mass)
                table.Add(item);
        }
        [Test]
        public void SearchInTableTest()
        {
            var mass = new int[] { 12, 180, 750, 125489, 5481, 36587, 2, 1548723, 165498435, 14894, 225544161, 5, 7, 6511, 658, 100, 1000, 21561 };
            HashTable.Table table = new HashTable.Table();
            foreach (var item in mass)
                table.Add(item);

            Assert.AreEqual(table.Search(12).Key, 12);
            Assert.AreEqual(table.Search(180).Key, 180);
            Assert.AreEqual(table.Search(750).Key, 750);
            Assert.AreEqual(table.Search(125489).Key, 125489);
            Assert.AreEqual(table.Search(5481).Key, 5481);
            Assert.AreEqual(table.Search(36587).Key, 36587);
            Assert.AreEqual(table.Search(2).Key, 2);
            Assert.AreEqual(table.Search(1548723).Key, 1548723);
            Assert.AreEqual(table.Search(165498435).Key, 165498435);
            Assert.AreEqual(table.Search(14894).Key, 14894);
            Assert.AreEqual(table.Search(225544161).Key, 225544161);
            Assert.AreEqual(table.Search(5).Key, 5);
            Assert.AreEqual(table.Search(7).Key, 7);
            Assert.AreEqual(table.Search(6511).Key, 6511);

            Assert.AreEqual(table.Search(658).Key, 658);
            Assert.AreEqual(table.Search(100).Key, 100);
            Assert.AreEqual(table.Search(1000).Key, 1000);
            Assert.AreEqual(table.Search(21561).Key, 21561);

            Assert.AreEqual(table.Search(65115841), null);
        }

        [Test]
        public void DeleteInTableTest()
        {
            var mass = new int[] { 12, 180, 750, 125489, 5481, 36587, 2, 1548723, 165498435, 14894, 225544161, 5, 7, 6511, 658, 100, 1000, 21561 };
            HashTable.Table table = new HashTable.Table();
            foreach (var item in mass)
                table.Add(item);

            Assert.AreEqual(table.Search(12).Key, 12);
            Assert.AreEqual(table.Search(180).Key, 180);
            Assert.AreEqual(table.Search(750).Key, 750);
            Assert.AreEqual(table.Search(125489).Key, 125489);
            Assert.AreEqual(table.Search(5481).Key, 5481);
            Assert.AreEqual(table.Search(36587).Key, 36587);
            Assert.AreEqual(table.Search(2).Key, 2);
            Assert.AreEqual(table.Search(1548723).Key, 1548723);
            Assert.AreEqual(table.Search(165498435).Key, 165498435);
            Assert.AreEqual(table.Search(14894).Key, 14894);
            Assert.AreEqual(table.Search(225544161).Key, 225544161);
            Assert.AreEqual(table.Search(5).Key, 5);
            Assert.AreEqual(table.Search(7).Key, 7);
            Assert.AreEqual(table.Search(6511).Key, 6511);
            Assert.AreEqual(table.Search(658).Key, 658);
            Assert.AreEqual(table.Search(100).Key, 100);
            Assert.AreEqual(table.Search(1000).Key, 1000);
            Assert.AreEqual(table.Search(21561).Key, 21561);

            table.Delete(12);

            Assert.AreEqual(table.Search(12), null);
            Assert.AreEqual(table.Search(180).Key, 180);
            Assert.AreEqual(table.Search(750).Key, 750);
            Assert.AreEqual(table.Search(125489).Key, 125489);
            Assert.AreEqual(table.Search(5481).Key, 5481);
            Assert.AreEqual(table.Search(36587).Key, 36587);
            Assert.AreEqual(table.Search(2).Key, 2);
            Assert.AreEqual(table.Search(1548723).Key, 1548723);
            Assert.AreEqual(table.Search(165498435).Key, 165498435);
            Assert.AreEqual(table.Search(14894).Key, 14894);
            Assert.AreEqual(table.Search(225544161).Key, 225544161);
            Assert.AreEqual(table.Search(5).Key, 5);
            Assert.AreEqual(table.Search(7).Key, 7);
            Assert.AreEqual(table.Search(6511).Key, 6511);
            Assert.AreEqual(table.Search(658).Key, 658);
            Assert.AreEqual(table.Search(100).Key, 100);
            Assert.AreEqual(table.Search(1000).Key, 1000);
            Assert.AreEqual(table.Search(21561).Key, 21561);

            table.Delete(100);

            Assert.AreEqual(table.Search(12), null);
            Assert.AreEqual(table.Search(180).Key, 180);
            Assert.AreEqual(table.Search(750).Key, 750);
            Assert.AreEqual(table.Search(125489).Key, 125489);
            Assert.AreEqual(table.Search(5481).Key, 5481);
            Assert.AreEqual(table.Search(36587).Key, 36587);
            Assert.AreEqual(table.Search(2).Key, 2);
            Assert.AreEqual(table.Search(1548723).Key, 1548723);
            Assert.AreEqual(table.Search(165498435).Key, 165498435);
            Assert.AreEqual(table.Search(14894).Key, 14894);
            Assert.AreEqual(table.Search(225544161).Key, 225544161);
            Assert.AreEqual(table.Search(5).Key, 5);
            Assert.AreEqual(table.Search(7).Key, 7);
            Assert.AreEqual(table.Search(6511).Key, 6511);
            Assert.AreEqual(table.Search(658).Key, 658);
            Assert.AreEqual(table.Search(100), null);
            Assert.AreEqual(table.Search(1000).Key, 1000);
            Assert.AreEqual(table.Search(21561).Key, 21561);
        }

    }
}