import unittest
from unittest.mock import Mock
from Production.UnbelievableComplexClass import UnbelivableComplexClass
from Production.UnInstantiableClass import UnInstantiableClass
from Production.InterestingClass import InterestingClass


class Sanity(unittest.TestCase):
    def test_method(self):
        myInteresting = InterestingClass()
        self.assertEqual(2676, myInteresting.longMethod(5))
        mock=Mock()
        mock.return_value=-200
        myInteresting.getSomethingFromDB=mock
        self.assertEqual(1801, myInteresting.longMethod(5))

