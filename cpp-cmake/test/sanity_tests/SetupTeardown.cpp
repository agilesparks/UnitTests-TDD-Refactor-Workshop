#include <gtest/gtest.h>

namespace {
  class MyTest:public::testing::Test {
    public : int myNumber=0;

    MyTest() {
    }

    virtual void SetUp() {
      myNumber = 5;
    }

    virtual void TearDown() {
    }
  };

    TEST_F(MyTest, Test1) {
        myNumber+=5;
        EXPECT_EQ(10,myNumber);
    }

    TEST_F(MyTest, Test2) {
        myNumber+=3;
        EXPECT_EQ(8,myNumber);
    }
}
