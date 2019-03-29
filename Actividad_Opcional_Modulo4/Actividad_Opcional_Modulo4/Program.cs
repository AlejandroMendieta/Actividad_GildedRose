using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Opcional_Modulo4
{
    public class Program
    {
        private readonly IUpdateStrategyFactory _strategyFactory = new UpdateStrategyFactory();
        List<Item> Items;

        public List<Item> GetItems
        {
            get { return Items; }
            set { Items = value; }
        }

        public Program(List<Item> items)
        {
            this.Items = items;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Actividad GildedRose");



            List<Item> Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                    new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                    new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                    new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                    new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20},
                    new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                };

            var app = new Program(Items);
            app.UpdateQuality();
            System.Console.WriteLine(Items[0].Name + "-" + Items[0].SellIn + "-" + Items[0].Quality);
            System.Console.WriteLine(Items[1].Name + "-" + Items[1].SellIn + "-" + Items[1].Quality);
            System.Console.WriteLine(Items[2].Name + "-" + Items[2].SellIn + "-" + Items[2].Quality);
            System.Console.WriteLine(Items[3].Name + "-" + Items[3].SellIn + "-" + Items[3].Quality);
            System.Console.WriteLine(Items[4].Name + "-" + Items[4].SellIn + "-" + Items[4].Quality);
            System.Console.WriteLine(Items[5].Name + "-" + Items[5].SellIn + "-" + Items[5].Quality);
            System.Console.ReadKey();

        }

        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                var updateStrategy = _strategyFactory.Create(item.Name);
                updateStrategy.UpdateQuality(item);
            }
        }
    }
}
