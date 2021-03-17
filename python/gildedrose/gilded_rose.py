# -*- coding: utf-8 -*-

class GildedRose(object):
    def run(self):
        items = list()
        option = '0'
        print("Welcome to Guilded Rose inventory management\n")
        print("********************************************\n")
        while True:
            if len(items) >= 0:
                print("\nCurrent Inventory:")
                for item in items:
                    print("SellIn:" + str(item.sell_in) + ", Quality:" + str(item.quality) + ", Name: " + str(item.name))
                print("")
            print("Options:")
            print("    Add items: 1-Brie, 2-Backstage pass, 3-Sulfuras, 4-Beer")
            print("    0-Tick (advance a day), 9-Exit")
            option = input()
            if option == '9':
                return
            if option=='1':
                items.append(Item("Aged Brie", 15, 20))
                continue
            if option=='2':
                items.append(Item("Backstage passes to a TAFKAL80ETC concert", 15, 20))
                continue
            if option=='3':
                items.append(Item("Sulfuras, Hand of Ragnaros", 15, 20))
                continue
            if option=='4':
                items.append(Item("Beer", 15, 20))
                continue
            if option =='0':
                for item in items:
                    if item.name != "Aged Brie" and item.name != "Backstage passes to a TAFKAL80ETC concert":
                        if item.quality > 0:
                            if item.name != "Sulfuras, Hand of Ragnaros":
                                item.quality = item.quality - 1
                    else:
                        if item.quality < 50:
                            item.quality = item.quality + 1
                            if item.name == "Backstage passes to a TAFKAL80ETC concert":
                                if item.sell_in < 11:
                                    if item.quality < 50:
                                        item.quality = item.quality + 1
                                if item.sell_in < 6:
                                    if item.quality < 50:
                                        item.quality = item.quality + 1
                    if item.name != "Sulfuras, Hand of Ragnaros":
                        item.sell_in = item.sell_in - 1
                    if item.sell_in < 0:
                        if item.name != "Aged Brie":
                            if item.name != "Backstage passes to a TAFKAL80ETC concert":
                                if item.quality > 0:
                                    if item.name != "Sulfuras, Hand of Ragnaros":
                                        item.quality = item.quality - 1
                            else:
                                item.quality = item.quality - item.quality
                        else:
                            if item.quality < 50:
                                item.quality = item.quality + 1

class Item:
    def __init__(self, name, sell_in, quality):
        self.name = name
        self.sell_in = sell_in
        self.quality = quality

    def __repr__(self):
        return "%s, %s, %s" % (self.name, self.sell_in, self.quality)

if __name__ == '__main__':
    myRose = GildedRose()
    myRose.run()