#include "stdafx.h"
using namespace Microsoft::VisualStudio::CppUnitTestFramework;
#include "UnInstantiableClass.h"
#include "InterestingClass.h"
#include "ExternalCalls.h"

using namespace legacycodepractice;

namespace mytests
{
	TEST_CLASS(GildedRoseUnitTests)
	{
	public:

		TEST_METHOD(UnInstantiableClassTest)
		{
			UnbelievableComplexClass *myUnbelievable = new UnbelievableComplexClass();
			UnInstantiableClass *myClass = new UnInstantiableClass(myUnbelievable);
			myClass->methodA(30);
			myClass->methodB(50);
			Assert::AreEqual(1004, myClass->getAmount());
		}

		TEST_METHOD(InterestingClassTest)
		{
			InterestingClass *myInteresting = new InterestingClass();
			Assert::AreEqual(2767200, myInteresting->longMethod(40));
		}

		
		TEST_METHOD(InterestingClassComplexVariableTest)
		{
			InterestingClass *myInteresting = new InterestingClass();
			UnbelievableComplexClass *myUnbelievable = new UnbelievableComplexClass();
			Assert::AreEqual(12, myInteresting->methodWithComplexParameters(myUnbelievable));
		}
	};
}
