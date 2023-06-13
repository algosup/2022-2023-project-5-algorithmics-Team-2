using System.Threading.Tasks;
using KrugApp;


namespace KrugAppTest
{
    [TestClass]
    public class SimilarityPointsTests
    {
        [TestMethod]
        public void Similarity_BothArraysNull_ThrowsArgumentException()
        {
            Tank[] a = null;
            Tank[] b = null;

            Assert.ThrowsException<ArgumentException>(() => Program.Similarity(a, b));
        }

        [TestMethod]
        public void Similarity_ArrayANull_ThrowsArgumentException()
        {
            Tank[] a = null;
            Tank[] b = new Tank[] { new Tank(), new Tank() };

            Assert.ThrowsException<ArgumentException>(() => Program.Similarity(a, b));
        }

        [TestMethod]
        public void Similarity_ArrayBNull_ThrowsArgumentException()
        {
            Tank[] a = new Tank[] { new Tank(), new Tank() };
            Tank[] b = null;

            Assert.ThrowsException<ArgumentException>(() => Program.Similarity(a, b));
        }

        [TestMethod]
        public void Similarity_ArraysEmpty_ThrowsArgumentException()
        {
            Tank[] a = new Tank[0];
            Tank[] b = new Tank[0];

            Assert.ThrowsException<ArgumentException>(() => Program.Similarity(a, b));
        }

        [TestMethod]
        public void Similarity_ValidArrays_ReturnsSimilarityIndicator()
        {
            Tank[] a = new Tank[]
            {
            new Tank { Wine = new Wine[] { new Wine { Quantity = 10 }, new Wine { Quantity = 20 } } },
            new Tank { Wine = new Wine[] { new Wine { Quantity = 5 }, new Wine { Quantity = 15 } } }
            };

            Tank[] b = new Tank[]
            {
            new Tank { Wine = new Wine[] { new Wine { Quantity = 12 }, new Wine { Quantity = 18 } } },
            new Tank { Wine = new Wine[] { new Wine { Quantity = 7 }, new Wine { Quantity = 17 } } }
            };

            int result = Program.Similarity(a, b);

            Assert.AreEqual(10, result);
        }
    }


    [TestClass]
    public class SimiPointsTests
    {
        [TestMethod]
        public void SimiPoint_IdenticalIntegers_ReturnsTwo()
        {
            int c = 10;
            int d = 10;

            int result = Program.SimiPoint(c, d);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void SimiPoint_FirstIntegerGreaterThanSecond_ReturnsOne()
        {
            int c = 8;
            int d = 4;

            int result = Program.SimiPoint(c, d);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SimiPoint_FirstIntegerLessThanSecond_ReturnsOne()
        {
            int c = 4;
            int d = 8;

            int result = Program.SimiPoint(c, d);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SimiPoint_FirstIntegerGreaterButLessThanHalfOfSecond_ReturnsZero()
        {
            int c = 7;
            int d = 20;

            int result = Program.SimiPoint(c, d);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SimiPoint_FirstIntegerLessButGreaterThanHalfOfSecond_ReturnsZero()
        {
            int c = 20;
            int d = 7;

            int result = Program.SimiPoint(c, d);

            Assert.AreEqual(0, result);
        }
    }

    [TestClass]
    public class NbrWinesTests
    {
        [TestMethod]
        public void NbrWines_EmptyTankArray_ReturnsZero()
        {
            Tank[] tanks = new Tank[0];

            int result = Program.NbrWines(tanks);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void NbrWines_AllTanksWithZeroQuantity_ReturnsZero()
        {
            try
            {
                Tank[] tanks = new Tank[]
                {
                    new Tank(100),
                    new Tank(200),
                    new Tank(new Wine[] { new Wine(0), new Wine(0), new Wine(0) }),
                    new Tank(new Wine[] { new Wine(0), new Wine(0), new Wine(0), new Wine(0) })
                };

                int result = Program.NbrWines(tanks);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void NbrWines_SomeWinesWithNonZeroQuantity_ReturnsCorrectCount()
        {
            Tank[] tanks = new Tank[]
            {
            new Tank(100),
            new Tank(new Wine[] { new Wine(30), new Wine(10), new Wine(7), new Wine(100) }),
            new Tank(100),
            new Tank(new Wine[] { new Wine(0), new Wine(0), new Wine(2), new Wine(0) })
            };

            int result = Program.NbrWines(tanks);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void NbrWines_AllWinesWithNonZeroQuantity_ReturnsTotalWineCount()
        {
            // Arrange
            Tank[] tanks = new Tank[]
            {
            new Tank(new Wine[] { new Wine(30), new Wine(20), new Wine(15), new Wine(8) }),
            new Tank(new Wine[] { new Wine(5), new Wine(20), new Wine(15), new Wine(8) }),
            new Tank(new Wine[] { new Wine(20), new Wine(20), new Wine(15), new Wine(8) })
            };

            // Act
            int result = Program.NbrWines(tanks);

            // Assert
            Assert.AreEqual(12, result);
        }
    }


    [TestClass]
    public class NbrTankTests
    {
        [TestMethod]
        public void NbrTank_EmptyTankArray_ReturnsZero()
        {
            // Arrange
            Tank[] tanks = new Tank[0];

            // Act
            int result = Program.NbrTank(tanks);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void NbrTank_AllTanksWithZeroQuantity_ReturnsZero()
        {
            try
            {
                Tank[] tanks = new Tank[]
                {
                    new Tank(100),
                    new Tank(200),
                    new Tank(new Wine[] { new Wine(0), new Wine(0), new Wine(0) }),
                    new Tank(new Wine[] { new Wine(0), new Wine(0), new Wine(0), new Wine(0) })
                };

                // Act
                int result = Program.NbrTank(tanks);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // Assert
        }

        [TestMethod]
        public void NbrTank_SomeTanksWithNonZeroQuantity_ReturnsCorrectCount()
        {
            // Arrange
            Tank[] tanks = new Tank[]
            {
            new Tank(100),
            new Tank(new Wine[] { new Wine(30), new Wine(10), new Wine(7), new Wine(100) }),
            new Tank(100),
            new Tank(new Wine[] { new Wine(14), new Wine(4), new Wine(2), new Wine(49) })
            };

            // Act
            int result = Program.NbrTank(tanks);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void NbrTank_AllTanksWithNonZeroQuantity_ReturnsTotalTankCount()
        {
            try
            {
                Tank[] tanks = new Tank[]
                {
                new Tank(new Wine[] { new Wine(30), new Wine(10) }),
                new Tank(new Wine[] { new Wine(5) }),
                new Tank(new Wine[] { new Wine(20), new Wine(15), new Wine(8) })
                };

                int result = Program.NbrTank(tanks);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void NbrTank_AllHaveCapacity_ReturnsCorrectCount()
        {
            Tank[] tanks = new Tank[]
            {
            new Tank(new Wine[] { new Wine(30), new Wine(10), new Wine(7), new Wine(100) }),
            new Tank(new Wine[] { new Wine(30), new Wine(10), new Wine(7), new Wine(100) }),
            new Tank(new Wine[] { new Wine(30), new Wine(10), new Wine(7), new Wine(100) }),
            new Tank(new Wine[] { new Wine(30), new Wine(10), new Wine(7), new Wine(100) }),
            new Tank(new Wine[] { new Wine(30), new Wine(10), new Wine(7), new Wine(100) }),
            new Tank(new Wine[] { new Wine(30), new Wine(10), new Wine(7), new Wine(100) }),
            new Tank(new Wine[] { new Wine(30), new Wine(10), new Wine(7), new Wine(100) }),
            new Tank(new Wine[] { new Wine(30), new Wine(10), new Wine(7), new Wine(100) }),
            new Tank(new Wine[] { new Wine(30), new Wine(10), new Wine(7), new Wine(100) }),
            new Tank(new Wine[] { new Wine(14), new Wine(4), new Wine(2), new Wine(49) })
            };

            int result = Program.NbrTank(tanks);

            Assert.AreEqual(10, result);
        }
    }


    [TestClass]
    public class NbrTotalWineTests
    {
        [TestMethod]
        public void NbrTotalWine_EmptyTankArray_ReturnsZero()
        {
            // Arrange
            Tank[] tanks = new Tank[0];

            // Act
            int result = Program.NbrTotalWine(tanks);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void NbrTotalWine_TankArrayWithZeroQuantity_ReturnsZero()
        {
            try
            {
                Tank[] tanks = new Tank[]
                {
                    new Tank(100),
                    new Tank(200),
                    new Tank(new Wine[] { new Wine(0), new Wine(0), new Wine(0) }),
                    new Tank(new Wine[] { new Wine(0), new Wine(0), new Wine(0), new Wine(0) })
                };

                int result = Program.NbrTotalWine(tanks);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        [TestMethod]
        public void NbrTotalWine_TankArrayWithPositiveQuantities_ReturnsCorrectTotal()
        {
            // Arrange
            Tank[] tanks = new Tank[]
            {
            new Tank(100),
            new Tank(new Wine[] { new Wine(30), new Wine(10), new Wine(7), new Wine(100) }),
            new Tank(100),
            new Tank(new Wine[] { new Wine(14), new Wine(4), new Wine(2), new Wine(49) })
            };

            // Act
            int result = Program.NbrTotalWine(tanks);

            // Assert
            Assert.AreEqual(216, result);
        }
    }


    [TestClass]
    public class Similarity
    {
        [TestMethod]
        public void TestNbrEachWine()
        {
            // Arrange
            Tank[] a = new Tank[]
            {
                new Tank(new Wine[] { new Wine(30), new Wine(10), new Wine(7), new Wine(100)}),
            };
            Tank[] b = new Tank[]
            {
                new Tank(new Wine[] { new Wine(30), new Wine(10), new Wine(7), new Wine(100)}),
            };
            // Act
            var result = Program.NbrEachWine(a, b);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void NbrEachWine_TankAHasDoubleQuantity_ReturnsOne()
        {
            // Arrange
            var a = new Tank[] { new Tank { Wine = new Wine[] { new Wine { Quantity = 40 }, new Wine { Quantity = 30 } } } };
            var b = new Tank[] { new Tank { Wine = new Wine[] { new Wine { Quantity = 20 }, new Wine { Quantity = 15 } } } };

            // Act
            var result = Program.NbrEachWine(a, b);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void NbrEachWine_TankAHasHalfQuantity_ReturnsOne()
        {
            // Arrange
            var a = new Tank[] { new Tank { Wine = new Wine[] { new Wine { Quantity = 10 }, new Wine { Quantity = 5 } } } };
            var b = new Tank[] { new Tank { Wine = new Wine[] { new Wine { Quantity = 20 }, new Wine { Quantity = 10 } } } };

            // Act
            var result = Program.NbrEachWine(a, b);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void NbrEachWine_DifferentQuantities_ReturnsZero()
        {
            // Arrange
            Tank[] a = new Tank[]
            {
                new Tank(new Wine[] { new Wine(30), new Wine(10), new Wine(7), new Wine(100)}),
            };
            Tank[] b = new Tank[]
            {
                new Tank(new Wine[] { new Wine(14), new Wine(4), new Wine(2), new Wine(49)}),
            };

            // Act
            var result = Program.NbrEachWine(a, b);
            Console.WriteLine("result: " + result);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void NbrEachWine_DifferentWinesQuantity_ReturnsZero()
        {
            try
            {
                Tank[] a = new Tank[]
                {
                new Tank(new Wine[] { new Wine(30), new Wine(10), new Wine(7)}),
                };
                Tank[] b = new Tank[]
                {
                new Tank(new Wine[] { new Wine(14), new Wine(4), new Wine(3), new Wine(49)}),
                };

                // Act
                var result = Program.NbrEachWine(a, b);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    [TestClass]
    public class NumberOfMix
    {
        [TestMethod]
        public void NbrMix_ReturnsThree()
        {
            // Arrange
            Tank[] a = new Tank[]
            {
                new Tank(100),
                new Tank(new Wine[] { new Wine(70), new Wine(40), new Wine(0), new Wine(1) }),
                new Tank(100),
                new Tank(100),
                new Tank(new Wine[] { new Wine(8), new Wine(41), new Wine(28), new Wine(3) }),
                new Tank(new Wine[] { new Wine(0), new Wine(71), new Wine(5), new Wine(9) })
            };

            // Act
            var result = Program.NbrMix(a);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void NbrMix_ReturnsOne()
        {
            // Arrange
            Tank[] a = new Tank[]
            {
                new Tank(100),
                new Tank(new Wine[] { new Wine(70), new Wine(40), new Wine(0), new Wine(1) }),
                new Tank(100),
                new Tank(100),
                new Tank(new Wine[] { new Wine(0), new Wine(0), new Wine(28), new Wine(0) }),
                new Tank(new Wine[] { new Wine(0), new Wine(0), new Wine(0), new Wine(9) })
            };

            // Act
            var result = Program.NbrMix(a);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void NbrMix_ReturnsTwo()
        {
            // Arrange
            Tank[] a = new Tank[]
            {
                new Tank(100),
                new Tank(new Wine[] { new Wine(0), new Wine(0), new Wine(0), new Wine(1) }),
                new Tank(100),
                new Tank(100),
                new Tank(new Wine[] { new Wine(8), new Wine(41), new Wine(28), new Wine(3) }),
                new Tank(new Wine[] { new Wine(0), new Wine(71), new Wine(5), new Wine(9) })
            };

            // Act
            var result = Program.NbrMix(a);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void NbrMix_ReturnsFour()
        {
            // Arrange
            Tank[] a = new Tank[]
            {
                new Tank(100),
                new Tank(new Wine[] { new Wine(70), new Wine(40), new Wine(0), new Wine(0) }),
                new Tank(new Wine[] { new Wine(70), new Wine(40), new Wine(0), new Wine(1) }),
                new Tank(100),
                new Tank(new Wine[] { new Wine(8), new Wine(41), new Wine(28), new Wine(3) }),
                new Tank(new Wine[] { new Wine(0), new Wine(0), new Wine(10), new Wine(9) })
            };

            // Act
            var result = Program.NbrMix(a);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void NbrMix_ReturnsZero()
        {
            // Arrange
            Tank[] a = new Tank[]
            {
                new Tank(100),
                new Tank(new Wine[] { new Wine(70), new Wine(0), new Wine(0), new Wine(0) }),
                new Tank(100),
                new Tank(100),
                new Tank(new Wine[] { new Wine(0), new Wine(0), new Wine(0), new Wine(2) }),
                new Tank(new Wine[] { new Wine(90), new Wine(0), new Wine(0), new Wine(0) })
            };

            // Act
            var result = Program.NbrMix(a);

            // Assert
            Assert.AreEqual(0, result);
        }
    }

    [TestClass]
    public class CSVToFormula
    {
        [TestMethod]
        public void CSVToFormula_One()
        {
            var path = "/Users/clementine/Desktop/Projects/2022-2023-project-5-algorithmics-Team-2/KrugAppTest/formulaTest.csv";

            var result = Program.CSVToFormula(path);

            Wine[] expectation = new Wine[] { new Wine(0), new Wine(4), new Wine(0), new Wine(3) };

            var a = String.Empty;
            var c = String.Empty;

            foreach (var b in expectation)
                a = a + "," + b.ToString();

            a = a.TrimStart(',');


            foreach (var b in result)
                c = c + "," + b.ToString();

            c = c.TrimStart(',');

            Assert.AreEqual(a, c);
            //CollectionAssert.AreEqual(expectation, result);

        }

        [TestMethod]
        public void CSVToFormula_Two()
        {

            try
            {
                var path = "/Users/clementine/Desktop/Projects/2022-2023-project-5-algorithmics-Team-2/KrugAppTest/formulaTest.csv";

                var result = Program.CSVToFormula(path);

                Wine[] expectation = new Wine[] { new Wine(3), new Wine(4), new Wine(0), new Wine(3) };

                var a = String.Empty;
                var c = String.Empty;

                foreach (var b in expectation)
                    a = a + "," + b.ToString();

                a = a.TrimStart(',');


                foreach (var b in result)
                    c = c + "," + b.ToString();

                c = c.TrimStart(',');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}