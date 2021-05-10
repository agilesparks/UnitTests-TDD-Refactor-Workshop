// LegacyCode.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "GildedRose.h"
using namespace gildedrose;


int _tmain(int argc, _TCHAR* argv[])
{
	vector<Item> items;
	GildedRose app(items);
	printf("hi");
	app.runApp();
	return 0;
}


