from approvaltests.approvals import verify
from approvaltests.reporters.generic_diff_reporter import GenericDiffReporter
from approvaltests.reporters.generic_diff_reporter_factory import GenericDiffReporterFactory
import unittest

class GildedRoseTest(unittest.TestCase):
    def setUp(self):
        self.myReporter = GenericDiffReporter(('Custom', "C:/Program Files (x86)/WinMerge/WinMergeU.exe"))

    def test_approval(self):
        result = "foobar"
        verify(result, self.myReporter )

if __name__ == '__main__':
    unittest.main()