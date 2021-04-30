#include <gtest/gtest.h>
#include <gmock/gmock.h>

class Turtle {
  public: 
  virtual ~Turtle() {};
  virtual void Forward(int distance) = 0;
  virtual int GetX() const = 0;
};

class MockTurtle : public Turtle {
 public:
  MOCK_METHOD(void, Forward, (int distance), (override));
  MOCK_METHOD(int, GetX, (), (const, override));
};

using testing::AtLeast;
using testing::Return;

TEST(SanityTest, Mocking) {
    MockTurtle turtle; 
    EXPECT_CALL(turtle, Forward(100));   
    EXPECT_CALL(turtle, Forward(99));                          
    EXPECT_CALL(turtle, GetX())                  
            .Times(AtLeast(1)).WillOnce(Return(100)).WillOnce(Return(200)).WillRepeatedly(Return(300));
    EXPECT_EQ(100,turtle.GetX());
    EXPECT_EQ(200,turtle.GetX());
    EXPECT_EQ(300,turtle.GetX());
    EXPECT_EQ(300,turtle.GetX());
    turtle.Forward(100);
    turtle.Forward(99);
}