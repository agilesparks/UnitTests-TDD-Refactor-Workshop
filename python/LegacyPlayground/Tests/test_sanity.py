import unittest
from Production.UnbelievableComplexClass import UnbelivableComplexClass
from Production.UnInstantiableClass import UnInstantiableClass
from Production.InterestingClass import InterestingClass


class Sanity(unittest.TestCase):
    def test_method1(self):
        myUnbelivable = UnbelivableComplexClass()
        myClass = UnInstantiableClass(myUnbelivable)
        myClass.methodA(30)
        myClass.methodB(50)
        self.assertEqual(1004, myClass.getAmount())

    def test_method2(self):
        myInteresting = InterestingClass()
        self.assertEqual(2676, myInteresting.longMethod(5))

if __name__ == '__main__':
    unittest.main()