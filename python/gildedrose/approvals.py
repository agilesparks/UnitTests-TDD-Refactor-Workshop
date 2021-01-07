from approvaltests.approvals import verify
from approvaltests.reporters.generic_diff_reporter import GenericDiffReporter
import unittest

class GildedRoseTest(unittest.TestCase):
    def test_approval(self):
        result = "foobar"
        verify(result, GenericDiffReporter(('Custom', 'C:/Program Files/Beyond Compare 4/bcompare.exe')))

if __name__ == '__main__':
    unittest.main()