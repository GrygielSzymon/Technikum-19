import unittest
from mujefunkcja import czyhex


class Test(unittest.TestCase):
    def test_containst(self):
        self.assertEqual("tak", czyhex(12))
