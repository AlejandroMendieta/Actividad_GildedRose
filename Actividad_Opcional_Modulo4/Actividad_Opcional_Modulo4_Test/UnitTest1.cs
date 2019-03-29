using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Actividad_Opcional_Modulo4;

namespace Actividad_Opcional_Modulo4_Test
{
    [TestClass]
    public class GlidedRoseTest
    {
        [TestMethod]
        public void testDecrementQuality()
        {
            List<Item> Items = new List<Item>()
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}
            };

            var app = new Program(Items);
            app.UpdateQuality();
            Assert.AreEqual(19, Items[0].Quality);
        }

        [TestMethod]
        public void testDecrementX2Quality() 
        {
            List<Item> Items = new List<Item>()
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20}
            };

            var app = new Program(Items);
            app.UpdateQuality();
            Assert.AreEqual(18, Items[0].Quality);
        }

        [TestMethod]
        public void testDecrementNonNegativeQuality() 
        {
            List<Item> Items = new List<Item>()
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 20, Quality = 0}
            };

            var app = new Program(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality);
        }

        [TestMethod]
        public void testIncrementQuality()
        {
            List<Item> Items = new List<Item>()
            {
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0}
            };
            var app = new Program(Items);
            app.UpdateQuality();
            Assert.AreEqual(1, Items[0].Quality);
        }

        [TestMethod]
        public void testIncrementQualityNoMoreThan50() 
        {
            List<Item> Items = new List<Item>()
            {
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 50}
            };

            var app = new Program(Items);
            app.UpdateQuality();
            Assert.AreEqual(50, Items[0].Quality);
        }

        [TestMethod]
        public void testIncrementLegendary() 
        {
            List<Item> Items = new List<Item>()
            {
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80}
            };
            var app = new Program(Items);
            app.UpdateQuality();
            Assert.AreEqual(80, Items[0].Quality);
        }

        [TestMethod]
        public void testIncrementBackstage() 
        {
            List<Item> Items = new List<Item>()
            {
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20}
            };
            var app = new Program(Items);
            app.UpdateQuality();
            Assert.AreEqual(21, Items[0].Quality);
        }

        [TestMethod]
        public void testIncrementBackstagex2()
        {
            List<Item> Items = new List<Item>()
            {
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20}
            };
            var app = new Program(Items);
            app.UpdateQuality();
            Assert.AreEqual(23, Items[0].Quality);
        }

        [TestMethod]
        public void testIncrementBackstagex3()
        {
            List<Item> Items = new List<Item>()
            {
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20}
            };
            var app = new Program(Items);
            app.UpdateQuality();
            Assert.AreEqual(22, Items[0].Quality);
        }

        [TestMethod]
        public void testIncrementBackstagex4()
        {
            List<Item> Items = new List<Item>()
            {
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 20}
            };
            var app = new Program(Items);
            app.UpdateQuality();
            Assert.AreEqual(23, Items[0].Quality);
        }

        [TestMethod]
        public void testIncrementBackstagex5()
        {
            List<Item> Items = new List<Item>()
            {
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20}
            };
            var app = new Program(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality);
        }

        [TestMethod]
        public void testDecrementConjured()
        {
            List<Item> Items = new List<Item>()
            {
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };
            var app = new Program(Items);
            app.UpdateQuality();
            Assert.AreEqual(4, Items[0].Quality);
        }

        [TestMethod]
        public void testDecrementConjuredx2()
        {
            List<Item> Items = new List<Item>()
            {
                new Item {Name = "Conjured Mana Cake", SellIn = 0, Quality = 8}
            };
            var app = new Program(Items);
            app.UpdateQuality();
            Assert.AreEqual(4, Items[0].Quality);
        }

        [TestMethod]
        public void testDecrementConjuredNonNegative()
        {
            List<Item> Items = new List<Item>()
            {
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 0}
            };
            var app = new Program(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality);
        }
    }
}
