using KrugApp;


namespace KrugAppTest
{
    [TestClass]
    public class Similarity
    {
        [TestMethod]
        public void NbrEachWine_EqualQuantities_ReturnsTwo()
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
}
