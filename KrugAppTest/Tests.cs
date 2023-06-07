using KrugApp;

namespace KrugAppTest
{
    [TestClass]
    public class TankConstructor
    {
        [TestMethod]
        public void Tank_DefaultConstructor_CreatesTankWithRandomCapacity()
        {
            // Arrange
            var tank = new Tank();

            // Assert
            Assert.IsTrue(tank.Capacity >= Tank.MIN_CAPACITY && tank.Capacity <= Tank.MAX_CAPACITY);
            Assert.IsNotNull(tank.Wine);
            Assert.AreEqual(0, tank.Wine.Sum(w => w.Quantity));
        }

        [TestMethod]
        public void Tank_DefaultConstructor_CreatesDifferentRandomCapacityTanks()
        {
            // Arrange
            var tank1 = new Tank();
            var tank2 = new Tank();

            // Assert
            Assert.AreNotEqual(tank1.Capacity, tank2.Capacity);
        }

        [TestMethod]
        public void Tank_DefaultConstructor_CreatesTankWithCapacityWithinRange()
        {
            // Arrange
            var tank = new Tank();

            // Assert
            Assert.IsTrue(tank.Capacity >= 10 && tank.Capacity <= 100);
        }

        [TestMethod]
        public void Tank_DefaultConstructor_CreatesTankWithEmptyWineArray()
        {
            // Arrange
            var tank = new Tank();

            // Assert
            Assert.IsNotNull(tank.Wine);
            Assert.AreEqual(0, tank.Wine.Sum(w => w.Quantity));
        }

        [TestMethod]
        public void Tank_DefaultConstructor_InitializesCapacityAndWineArray()
        {
            // Arrange
            var tank = new Tank();

            // Assert
            Assert.IsNotNull(tank.Capacity);
            Assert.IsNotNull(tank.Wine);
        }
    }

    [TestClass]
    public class TankCapacity
    {

        [TestMethod]
        public void Tank_ConstructorWithCapacity_CreatesTankWithGivenCapacity()
        {
            // Arrange
            int capacity = 50;

            // Act
            var tank = new Tank(capacity);

            // Assert
            Assert.AreEqual(capacity, tank.Capacity);
            Assert.IsNotNull(tank.Wine);
            Assert.AreEqual(0, tank.Wine.Sum(w => w.Quantity));
        }

        [TestMethod]
        public void Tank_ConstructorWithCapacity_CreatesTankWithZeroWineQuantities()
        {
            // Arrange
            int capacity = 50;

            // Act
            var tank = new Tank(capacity);

            // Assert
            foreach (var wine in tank.Wine)
            {
                Assert.AreEqual(0, wine.Quantity);
            }
        }

        [TestMethod]
        public void Tank_ConstructorWithCapacity_ThrowsExceptionForNegativeCapacity()
        {
            // Arrange
            int capacity = -10;

            // Assert
            Assert.ThrowsException<ArgumentException>(() => new Tank(capacity));
        }

        [TestMethod]
        public void Tank_ConstructorWithCapacity_InitializesCapacityAndWineArray()
        {
            // Arrange
            int capacity = 50;

            // Act
            var tank = new Tank(capacity);

            // Assert
            Assert.AreEqual(capacity, tank.Capacity);
            Assert.IsNotNull(tank.Wine);
        }

        [TestMethod]
        public void Tank_ConstructorWithCapacity_CreatesTankWithCorrectCapacityAndEmptyWineArray()
        {
            // Arrange
            int capacity = 75;

            // Act
            var tank = new Tank(capacity);

            // Assert
            Assert.AreEqual(capacity, tank.Capacity);
            Assert.AreEqual(0, tank.Wine.Sum(w => w.Quantity));
        }
    }

    [TestClass]
    public class TankWine
    {

        [TestMethod]
        public void Tank_ConstructorWithEmptyWineArray_SetsCapacityToZero()
        {
            // Arrange
            var wines = new Wine[Tank.MAX_WINES];
            for (int i = 0; i < wines.Length; i++)
            {
                wines[i] = new Wine();
            }
            // Assert
            Assert.ThrowsException<Exception>(() => new Tank(wines));
        }

        [TestMethod]
        public void Tank_ConstructorWithWines_CalculatesTotalCapacityFromWinesWithPositiveQuantities()
        {
            // Arrange
            var wines = new Wine[Tank.MAX_WINES];
            for (int i = 0; i < wines.Length; i++)
            {
                wines[i] = new Wine();
            }
            wines[69].Quantity = 20;
            wines[42].Quantity = 20;
            wines[4].Quantity = 20;
            wines[12].Quantity = 20;
            wines[360].Quantity = 20;

            // Act
            var tank = new Tank(wines);

            // Assert
            Assert.AreEqual(100, tank.Capacity);
        }

        [TestMethod]
        public void Tank_ConstructorWithWines_CalculatesTotalCapacityFromWinesWithZeroQuantities()
        {
            // Arrange
            var wines = new Wine[Tank.MAX_WINES];
            for (int i = 0; i < wines.Length; i++)
            {
                wines[i] = new Wine();
            }
            wines[9] = new Wine(0);
            wines[19] = new Wine(0);
            wines[29] = new Wine(0);

            // Assert
            Assert.ThrowsException<Exception>(() => new Tank(wines));
        }

        [TestMethod]
        public void Tank_ConstructorWithWines_CalculatesTotalCapacityFromWinesWithNegativeQuantities()
        {
            // Arrange
            var wines = new Wine[Tank.MAX_WINES];
            for (int i = 0; i < wines.Length; i++)
            {
                wines[i] = new Wine();
            }
            wines[7] = new Wine(-30);
            wines[5] = new Wine(-20);
            wines[17] = new Wine(-50);

            // Assert
            Assert.ThrowsException<Exception>(() => new Tank(wines));
        }

        [TestMethod]
        public void Tank_ConstructorWithWines_CalculatesTotalCapacityFromMixedQuantities()
        {
            // Arrange
            var wines = new Wine[Tank.MAX_WINES];
            for (int i = 0; i < wines.Length; i++)
            {
                wines[i] = new Wine();
            }
            wines[1] = new Wine(-20);
            wines[2] = new Wine(0);
            wines[51] = new Wine(-50);
            wines[10] = new Wine(40);

            // Assert
            Assert.ThrowsException<Exception>(() => new Tank(wines));
        }
    }

    [TestClass]
    public class OperatorPlus
    {
        [TestMethod]
        public void OperatorPlus_AddTwoZeroQuantityWines_ReturnsWineWithZeroQuantity()
        {
            // Arrange
            var wine1 = new Wine(0);
            var wine2 = new Wine(0);

            // Act
            var result = wine1 + wine2;

            // Assert
            Assert.AreEqual(0, result.Quantity);
        }

        [TestMethod]
        public void OperatorPlus_AddTwoPositiveQuantityWines_ReturnsWineWithSumOfQuantities()
        {
            // Arrange
            var wine1 = new Wine(25);
            var wine2 = new Wine(35);

            // Act
            var result = wine1 + wine2;

            // Assert
            Assert.AreEqual(60, result.Quantity);
        }

        [TestMethod]
        public void OperatorPlus_AddWineWithPositiveQuantityAndWineWithZeroQuantity_ReturnsWineWithPositiveQuantity()
        {
            // Arrange
            var wine1 = new Wine(50);
            var wine2 = new Wine(0);

            // Act
            var result = wine1 + wine2;

            // Assert
            Assert.AreEqual(50, result.Quantity);
        }

        [TestMethod]
        public void OperatorPlus_AddWineWithNegativeQuantityAndWineWithPositiveQuantity_ReturnsWineWithCorrectQuantity()
        {
            // Arrange
            var wine1 = new Wine(-10);
            var wine2 = new Wine(30);

            // Act
            var result = wine1 + wine2;

            // Assert
            Assert.AreEqual(20, result.Quantity);
        }

        [TestMethod]
        public void OperatorPlus_AddWineWithNegativeQuantityAndWineWithZeroQuantity_ReturnsWineWithNegativeQuantity()
        {
            // Arrange
            var wine1 = new Wine(-15);
            var wine2 = new Wine(0);

            // Act
            var result = wine1 + wine2;

            // Assert
            Assert.AreEqual(-15, result.Quantity);
        }
    }

    [TestClass]
    public class OperatorSubstract
    {
        [TestMethod]
        public void OperatorMinus_SubtractZeroQuantityWine_ReturnsOriginalQuantity()
        {
            // Arrange
            var wine1 = new Wine(30);
            var wine2 = new Wine(0);

            // Act
            var result = wine1 - wine2;

            // Assert
            Assert.AreEqual(30, result.Quantity);
        }

        [TestMethod]
        public void OperatorMinus_SubtractWineWithFloatQuantity_SubtractsQuantities()
        {
            // Arrange
            var wine1 = new Wine(30.5f);
            var wine2 = new Wine(10.2f);

            // Act
            var result = wine1 - wine2;

            // Assert
            Assert.AreEqual(20.3f, result.Quantity);
        }

        [TestMethod]
        public void OperatorMinus_SubtractWineFromZeroQuantityWine_ReturnsNegativeQuantity()
        {
            // Arrange
            var wine1 = new Wine(0);
            var wine2 = new Wine(10);

            // Act
            var result = wine1 - wine2;

            // Assert
            Assert.AreEqual(-10, result.Quantity);
        }

        [TestMethod]
        public void OperatorMinus_SubtractWineWithLargeQuantity_SubtractsQuantities()
        {
            // Arrange
            var wine1 = new Wine(1000);
            var wine2 = new Wine(500);

            // Act
            var result = wine1 - wine2;

            // Assert
            Assert.AreEqual(500, result.Quantity);
        }
    }

    [TestClass]
    public class OperatorMultiply
    {
        [TestMethod]
        public void OperatorMultiply_MultiplyTwoZeroQuantityWines_ReturnsWineWithZeroQuantity()
        {
            // Arrange
            var wine1 = new Wine(0);
            var wine2 = new Wine(0);

            // Act
            var result = wine1 * wine2;

            // Assert
            Assert.AreEqual(0, result.Quantity);
        }

        [TestMethod]
        public void OperatorMultiply_MultiplyWineWithZeroQuantityAndWineWithPositiveQuantity_ReturnsWineWithZeroQuantity()
        {
            // Arrange
            var wine1 = new Wine(0);
            var wine2 = new Wine(50);

            // Act
            var result = wine1 * wine2;

            // Assert
            Assert.AreEqual(0, result.Quantity);
        }

        [TestMethod]
        public void OperatorMultiply_MultiplyWineWithPositiveQuantityAndWineWithZeroQuantity_ReturnsWineWithZeroQuantity()
        {
            // Arrange
            var wine1 = new Wine(30);
            var wine2 = new Wine(0);

            // Act
            var result = wine1 * wine2;

            // Assert
            Assert.AreEqual(0, result.Quantity);
        }

        [TestMethod]
        public void OperatorMultiply_MultiplyTwoPositiveQuantityWines_ReturnsWineWithCorrectMultiplicationResult()
        {
            // Arrange
            var wine1 = new Wine(5);
            var wine2 = new Wine(10);

            // Act
            var result = wine1 * wine2;

            // Assert
            Assert.AreEqual(50, result.Quantity);
        }

        [TestMethod]
        public void OperatorMultiply_MultiplyWineWithPositiveQuantityAndWineWithNegativeQuantity_ReturnsWineWithNegativeQuantity()
        {
            // Arrange
            var wine1 = new Wine(15);
            var wine2 = new Wine(-2);

            // Act
            var result = wine1 * wine2;

            // Assert
            Assert.AreEqual(-30, result.Quantity);
        }
    }

    [TestClass]
    public class OperatorDivide
    {

        [TestMethod]
        public void OperatorDivide_DivideWineWithZeroQuantityByWineWithPositiveQuantity_ReturnsWineWithZeroQuantity()
        {
            // Arrange
            var wine1 = new Wine(0);
            var wine2 = new Wine(50);

            // Act
            var result = wine1 / wine2;

            // Assert
            Assert.AreEqual(0, result.Quantity);
        }

        [TestMethod]
        public void OperatorDivide_DivideWineWithPositiveQuantityByWineWithZeroQuantity_ThrowsDivideByZeroException()
        {
            // Arrange
            var wine1 = new Wine(30);
            var wine2 = new Wine(0);

            // Act and Assert
            Assert.ThrowsException<DivideByZeroException>(() => wine1 / wine2);
        }

        [TestMethod]
        public void OperatorDivide_DivideWineWithPositiveQuantityByWineWithPositiveQuantity_ReturnsWineWithCorrectDivisionResult()
        {
            // Arrange
            var wine1 = new Wine(50);
            var wine2 = new Wine(10);

            // Act
            var result = wine1 / wine2;

            // Assert
            Assert.AreEqual(5, result.Quantity);
        }

        [TestMethod]
        public void OperatorDivide_DivideWineWithNegativeQuantityByWineWithPositiveQuantity_ReturnsWineWithNegativeQuantity()
        {
            // Arrange
            var wine1 = new Wine(-20);
            var wine2 = new Wine(4);

            // Act
            var result = wine1 / wine2;

            // Assert
            Assert.AreEqual(-5, result.Quantity);
        }

        [TestMethod]
        public void OperatorDivide_DivideWineWithNegativeQuantityByWineWithNegativeQuantity_ReturnsWineWithPositiveQuantity()
        {
            // Arrange
            var wine1 = new Wine(-30);
            var wine2 = new Wine(-6);

            // Act
            var result = wine1 / wine2;

            // Assert
            Assert.AreEqual(5, result.Quantity);
        }
    }

    /*[TestClass]
    public class GridComparison {

        [TestMethod]
        public void GridComparison_1()
        {
            // Create the first grid
            int[][] grid1 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            // Create the second grid
            int[][] grid2 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            // Compare
            bool result = CompareGrids(grid1, grid2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GridComparison_2()
        {
            int[][] grid1 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            int[][] grid2 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 0, 6 },
                new int[] { 7, 8, 9 }
            };

            bool result = CompareGrids(grid1, grid2);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GridComparison_3()
        {
            int[][] grid1 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 }
            };

            int[][] grid2 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 }
            };

            bool result = CompareGrids(grid1, grid2);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GridComparison_4()
        {
            int[][] grid1 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 }
            };

            int[][] grid2 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 5 }
            };

            bool result = CompareGrids(grid1, grid2);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GridComparison_5()
        {
            int[][] grid1 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 }
            };

            int[][] grid2 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 },
                new int[] { 5, 6 }
            };

            bool result = CompareGrids(grid1, grid2);
            Assert.IsFalse(result);
        }
    }*/

    [TestClass]
    public class TankTests
    {
        [TestMethod]
        public void TestNodeTraversal()
        {
            // Créer un tableau de nœuds simulé pour les tests
            Tank tank = new Tank(100, 0);
            Wine[] nodes = new Wine[Tank.MAX_WINES];

            // Initialiser les nœuds simulés avec des valeurs
            for (int i = 0; i < Tank.MAX_WINES; i++)
            {
                nodes[i] = new Wine();
                nodes[i].Quantity = i + 1; // Assigner une quantité différente à chaque nœud pour les tests
            }

            // Appeler la méthode de parcours des nœuds et obtenir les résultats
            Wine[] results = tank.TraverseNodes(nodes);

            // Effectuer les assertions pour vérifier les conditions spécifiées
            Assert.AreEqual(Tank.MAX_WINES, results.Length); // Vérifier si le nombre de nœuds retournés est correct

            foreach (Wine result in results)
            {
                // Vérifier si le nœud est éloigné de la solution
                Assert.IsTrue(result.Quantity <= Tank.MAX_WINES);

                // Vérifier si le nœud est trop similaire à un parent
                foreach (Wine parent in nodes)
                {
                    if (parent != result)
                    {
                        Assert.IsTrue(Math.Abs(result.Quantity - parent.Quantity) > 5 || result == parent,
                            $"The node {result.Quantity} is too similar to the parent {parent.Quantity}."); // Changer la valeur de 5 selon vos besoins
                    }
                }

                // Vérifier si le nœud est trop similaire à une sœur
                foreach (Wine sibling in results)
                {
                    if (sibling != result)
                    {
                        Assert.IsTrue(Math.Abs(result.Quantity - sibling.Quantity) > 5 || result == sibling,
                            $"the node {result.Quantity} is too similar to the sibling {sibling.Quantity}."); // Changer la valeur de 5 selon vos besoins
                    }
                }
            }
        }
    }
}