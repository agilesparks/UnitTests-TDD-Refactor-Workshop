#include <gtest/gtest.h>
#include "UnInstantiableClass.h"
#include "InterestingClass.h"
#include "ExternalCalls.h"
#include "CInterestingFunctions.h"

#define TESTING

#ifdef TESTING
#define myA() 0
#endif
TEST(SanityTest, UnInstantiableClass)
{
    UnbelievableComplexClass *myUnbelievable = new UnbelievableComplexClass();
    UnInstantiableClass *myClass = new UnInstantiableClass(myUnbelievable);
    myClass->methodA(30);
    myClass->methodB(50);
    EXPECT_EQ(1004, myClass->getAmount());
}

TEST(SanityTest, InterestingClass)
{
    InterestingClass *myInteresting = new InterestingClass();
    EXPECT_EQ(2777066, myInteresting->longMethod(40));
}

TEST(SanityTest, testMyA)
{
    EXPECT_EQ(0, myA());
}

TEST(SanityTest, cLongMethod)
{
    EXPECT_EQ(26700, cLongMethod(5));
}

TEST(SanityTest, InterestingClassComplexVariable)
{
    InterestingClass *myInteresting = new InterestingClass();
    UnbelievableComplexClass *myUnbelievable = new UnbelievableComplexClass();
    EXPECT_EQ(12, myInteresting->methodWithComplexParameters(myUnbelievable));
}
