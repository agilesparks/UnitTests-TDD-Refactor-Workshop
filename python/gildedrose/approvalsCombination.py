from approvaltests import verify_all_combinations
from approvaltests.approvals import verify
from approvaltests.reporters.generic_diff_reporter import GenericDiffReporter
import unittest

class GildedRoseTest(unittest.TestCase):
    def multiply(self,x,y):
        return x*y

    def test_approval(self):
        verify_all_combinations(self.multiply,[[1,2,3],[10,20,30]], reporter=GenericDiffReporter(('Custom', 'C:/Program Files/Beyond Compare 4/bcompare.exe')))


if __name__ == '__main__':
    unittest.main()