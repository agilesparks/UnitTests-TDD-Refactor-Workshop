using System;
using System.Collections.Generic;
using System.IO;

namespace Gildedrose
{
    public class GildedRoseManager
    {
        public IList<Item> Items = new List<Item> { };
        public void Run()
        {
            char option = '0';
            Console.Write("Welcome to Guilded Rose inventory management\n");
            Console.Write("********************************************\n");
            while (true)
            {
                Console.Write("Options:\n");
                Console.Write("    Add Items: 1-Brie, 2-Backstage pass, 3-Sulfuras, 4-Beer\n");
                Console.Write("    0-Tick (advance a day), 9-Exit\n");
                try
                {
                    option = Console.ReadLine()[0];
                }
                catch (IOException e)
                {
                    Console.Write("Error reading from user:" + e);
                }
                if (option == '9')
                {
                    return;
                }
                switch (option)
                {
                    case '1':
                        Items.Add(new Item("Aged Brie", 15, 20));
                        ExternalAgencyReporter.ReportItem(Items[Items.Count - 1]);
                        break;
                    case '2':
                        Items.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20));
                        ExternalAgencyReporter.ReportItem(Items[Items.Count - 1]);
                        break;
                    case '3':
                        Items.Add(new Item("Sulfuras, Hand of Ragnaros", 15, 20));
                        ExternalAgencyReporter.ReportItem(Items[Items.Count - 1]);
                        break;
                    case '4':
                        Items.Add(new Item("Beer", 15, 20));
                        ExternalAgencyReporter.ReportItem(Items[Items.Count - 1]);
                        break;
                    case '0':
                        for (int i = 0; i < Items.Count; i++)
                        {
                            updateItem(Items[i]);
                        }
                        break;

                }

                if (Items.Count >= 0)
                {
                    Console.Write("Current Inventory:\n");

                    for (int i = 0; i < Items.Count; i++)
                    {
                        Console.Write("SellIn:" + Items[i].SellIn + ", Quality:" + Items[i].Quality + ", Name: " + Items[i].Name + "\n");
                    }
                }
            }
        }

        public void updateItem(Item item)
        {
            if (!item.Name.Equals("Aged Brie")
                && !item.Name.Equals("Backstage passes to a TAFKAL80ETC concert"))
            {
                if (item.Quality > 0)
                {
                    if (!item.Name.Equals("Sulfuras, Hand of Ragnaros"))
                    {
                        item.Quality = item.Quality - 1;
                    }
                }
            }
            else
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;

                    if (item.Name.Equals("Backstage passes to a TAFKAL80ETC concert"))
                    {
                        if (item.SellIn < 11)
                        {
                            if (item.Quality < 50)
                            {
                                item.Quality = item.Quality + 1;
                            }
                        }

                        if (item.SellIn < 6)
                        {
                            if (item.Quality < 50)
                            {
                                item.Quality = item.Quality + 1;
                            }
                        }
                    }
                }
            }

            if (!item.Name.Equals("Sulfuras, Hand of Ragnaros"))
            {
                item.SellIn = item.SellIn - 1;
            }

            if (item.SellIn < 0)
            {
                if (!item.Name.Equals("Aged Brie"))
                {
                    if (!item.Name.Equals("Backstage passes to a TAFKAL80ETC concert"))
                    {
                        if (item.Quality > 0)
                        {
                            if (!item.Name.Equals("Sulfuras, Hand of Ragnaros"))
                            {
                                item.Quality = item.Quality - 1;
                            }
                        }
                    }
                    else
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }
        }
    }


}