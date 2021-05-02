#include "stdafx.h"
using namespace Microsoft::VisualStudio::CppUnitTestFramework;

#include "GildedRose.h"
using namespace gildedrose;

namespace mytests
{
	TEST_CLASS(GildedRoseUnitTests)
	{
	public:
		TEST_METHOD(TestMethod1)
		{
	
			vector<Item> items;
			items.push_back(Item("Foo", 0, 0));
			GildedRose app(items);
			app.updateQuality();
			Assert::AreEqual((std::string)"Foo",app.items[0].name);
		}
	};
}



