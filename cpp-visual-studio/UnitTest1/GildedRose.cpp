#include "stdafx.h"
#include "GildedRose.h"
#include <cstdio>

using namespace gildedrose;

		GildedRose::GildedRose(vector<Item> &items) : items(items)
		{
		}

		void GildedRose::runApp()
		{
			int option;
			printf("Welcome to Guilded Rose inventory management\n");
			printf("********************************************\n");
			while (true)
			{
				printf("Options:\n");
				printf("    Add Items: 1-Brie, 2-Backstage pass, 3-Sulfuras, 4-Beer\n");
				printf("    0-Tick (advance a day), 9-Exit\n");
				scanf("%d", &option);
				switch (option)
				{
				case 1:
					items.push_back(Item("Aged Brie", 15, 20));
					break;
				case 2:
					items.push_back(Item("Backstage passes to a TAFKAL80ETC concert", 15, 20));
					break;
				case 3:
					items.push_back(Item("Sulfuras, Hand of Ragnaros", 15, 20));
					break;
				case 4:
					items.push_back(Item("Beer", 15, 20));
					break;
				case 0:
					updateQuality();
					break;
				case 9:
					return;
				}

				if (items.size() >= 0)
				{
					printf("Current Inventory:\n");
					for (vector<Item>::iterator item = items.begin(); item != items.end(); ++item)
					{
						printf("Name:%s, SellIn:%d, Quality:%d\n", item->name.c_str(), item->sellIn, item->quality);
					}
					printf("\n");
				}
			}
		}

		void GildedRose::updateQuality()
		{
			for (size_t i = 0; i < items.size(); i++)
			{
				if (items[i].name != "Aged Brie" && items[i].name != "Backstage passes to a TAFKAL80ETC concert")
				{
					if (items[i].quality > 0)
					{
						if (items[i].name != "Sulfuras, Hand of Ragnaros")
						{
							items[i].quality = items[i].quality - 1;
						}
					}
				}
				else
				{
					if (items[i].quality < 50)
					{
						items[i].quality = items[i].quality + 1;

						if (items[i].name == "Backstage passes to a TAFKAL80ETC concert")
						{
							if (items[i].sellIn < 11)
							{
								if (items[i].quality < 50)
								{
									items[i].quality = items[i].quality + 1;
								}
							}

							if (items[i].sellIn < 6)
							{
								if (items[i].quality < 50)
								{
									items[i].quality = items[i].quality + 1;
								}
							}
						}
					}
				}

				if (items[i].name != "Sulfuras, Hand of Ragnaros")
				{
					items[i].sellIn = items[i].sellIn - 1;
				}

				if (items[i].sellIn < 0)
				{
					if (items[i].name != "Aged Brie")
					{
						if (items[i].name != "Backstage passes to a TAFKAL80ETC concert")
						{
							if (items[i].quality > 0)
							{
								if (items[i].name != "Sulfuras, Hand of Ragnaros")
								{
									items[i].quality = items[i].quality - 1;
								}
							}
						}
						else
						{
							items[i].quality = items[i].quality - items[i].quality;
						}
					}
					else
					{
						if (items[i].quality < 50)
						{
							items[i].quality = items[i].quality + 1;
						}
					}
				}
			}
		}
	