# -*- coding: utf-8 -*-
import unittest

class MyTests(unittest.TestCase):
    def test_foo(self):
        self.assertEquals(1,0)

if __name__ == '__main__':
    unittest.main()