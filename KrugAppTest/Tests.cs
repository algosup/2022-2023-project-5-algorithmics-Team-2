using KrugApp;

namespace KrugAppTest
{
    [TestClass]
    public class TankConstructorTests
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
    public class TankCapacityTests
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
    public class TankWineTests
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
    public class OperatorPlusTests
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
    public class OperatorSubstractTests
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
    public class OperatorMultiplyTests
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
    public class OperatorDivideTests
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

    [TestClass]
    public class NodeTraversalTests
    {
        [TestMethod]
        public void TestNodeTraversal()
        {
            // Create a simulated array of nodes for testing
            Tank tank = new Tank(100, 0);
            Wine[] nodes = new Wine[Tank.MAX_WINES];

            // Initialise the simulated nodes with values
            for (int i = 0; i < Tank.MAX_WINES; i++)
            {
                nodes[i] = new Wine();
                nodes[i].Quantity = i + 1; // Assign a different value to each node
            }

            // Call the node traversal method and get the results
            Wine[] results = tank.TraverseNodes(nodes);

            // Carry out the assertions to check the specified conditions
            Assert.AreEqual(Tank.MAX_WINES, results.Length); // Verify that the number of results is correct

            foreach (Wine result in results)
            {
                // Verify that the node is not too far from the solution
                Assert.IsTrue(result.Quantity <= Tank.MAX_WINES);

                // Verify that the node is not too similar to a parent
                foreach (Wine parent in nodes)
                {
                    if (parent != result)
                    {
                        Assert.IsFalse(Math.Abs(result.Quantity - parent.Quantity) > 5 || result == parent,
                            $"The node {result.Quantity} is too similar to the parent {parent.Quantity}."); // Change the value of 5 as required
                    }
                }

                // Verify that the node is not too similar to a sibling
                foreach (Wine sibling in results)
                {
                    if (sibling != result)
                    {
                        Assert.IsFalse(Math.Abs(result.Quantity - sibling.Quantity) > 5 || result == sibling,
                            $"the node {result.Quantity} is too similar to the sibling {sibling.Quantity}."); // Change the value of 5 as required
                    }
                }
            }
        }
    }

    [TestClass]
    public class IsMovingAwayTests
    {
        [TestMethod]
        public void IsMovingAwayTest_1()
        {
            // Arrange
            Tank[] parent = new Tank[] { new Tank(50) };
            Tank[] child = new Tank[] { new Tank(50) };
            Tank[] target = new Tank[] { new Tank(50) };

            // Act
            bool isMovingAway = Program.IsMovingAway(parent, child, target);

            // Assert
            Assert.IsFalse(isMovingAway);
        }

        [TestMethod]
        public void IsMovingAwayTest_2()
        {
            // Arrange
            Tank[] parent = new Tank[] { new Tank(60) };
            Tank[] child = new Tank[] { new Tank(55) };
            Tank[] target = new Tank[] { new Tank(65) };

            // Act
            bool isMovingAway = Program.IsMovingAway(parent, child, target);

            // Assert
            Assert.IsFalse(isMovingAway);
        }

        [TestMethod]
        public void IsMovingAwayTest_3()
        {
            // Arrange
            Tank[] parent = new Tank[] { new Tank(100) };
            Tank[] child = new Tank[] { new Tank(80) };
            Tank[] target = new Tank[] { new Tank(85) };

            // Act
            bool isMovingAway = Program.IsMovingAway(parent, child, target);

            // Assert
            Assert.IsFalse(isMovingAway);
        }

        [TestMethod]
        public void IsMovingAwayTest_4()
        {
            // Arrange
            Tank[] parent = new Tank[] { new Tank(85) };
            Tank[] child = new Tank[] { new Tank(95) };
            Tank[] target = new Tank[] { new Tank(100) };

            // Act
            bool isMovingAway = Program.IsMovingAway(parent, child, target);

            // Assert
            Assert.IsFalse(isMovingAway);
        }

        [TestMethod]
        public void IsMovingAwayTest_5()
        {
            // Arrange
            Tank[] parent = new Tank[] { new Tank(100) };
            Tank[] child = new Tank[] { new Tank(100) };
            Tank[] target = new Tank[] { new Tank(110) };

            // Act
            bool isMovingAway = Program.IsMovingAway(parent, child, target);

            // Assert
            Assert.IsFalse(isMovingAway);
        }

        [TestMethod]
        public void IsMovingAwayTest_6()
        {
            // Arrange
            Tank[] parent = new Tank[] { new Tank(100) };
            Tank[] child = new Tank[] { new Tank(110) };
            Tank[] target = new Tank[] { new Tank(110) };

            // Act
            bool isMovingAway = Program.IsMovingAway(parent, child, target);

            // Assert
            Assert.IsTrue(isMovingAway);
        }
    }

    [TestClass]
    public class SimilarityTests 
    {
        [TestMethod] 
        public void Similarity_BothArraysNull_ThrowsArgumentException()
        {
            Tank[] a = null;
            Tank[] b = null;

            try
            {
                Program.Similarity(a, b);
                Assert.Fail("Expected ArgumentException was not thrown.");
            }
            catch (ArgumentException)
            {
                // The expected exception was thrown, test passes
            }
        }

        [TestMethod]
        public void Similarity_ArraysEmpty_ThrowsArgumentException()
        {
            Tank[] a = new Tank[0];
            Tank[] b = new Tank[0];

            try
            {
                Program.Similarity(a, b);
                Assert.Fail("Expected ArgumentException was not thrown.");
            }
            catch (ArgumentException)
            {
                // The expected exception was thrown, test passes
            }
        }

        [TestMethod]
        public void Similarity_ValidInput_ReturnsExpectedSimilarity_1()
        {
            Tank[] a =  new Tank[] { new Tank(100), new Tank(100), new Tank(100) };
            Tank[] b =  new Tank[] { new Tank(100), new Tank(100), new Tank(100) };
            int expectedSimilarity = 6;

            int actualSimilarity = Program.Similarity(a, b);

            Assert.AreEqual(expectedSimilarity, actualSimilarity);
        }

        [TestMethod]
        public void Similarity_ValidInput_ReturnsExpectedSimilarity_2()
        {
            Tank[] a =  new Tank[] { new Tank(20) };
            Tank[] b =  new Tank[] { new Tank(100) };
            int expectedSimilarity = 10;

            int actualSimilarity = Program.Similarity(a, b);

            Assert.AreEqual(expectedSimilarity, actualSimilarity);
        }
    }

    [TestClass]
    public class TransferToTests
    {
        [TestMethod]
        public void TransferTo_ArraysEmpty()
        {
            try
            {
               //arrange
                Tank[] a = new Tank[0];
                Tank b = new Tank(100);

                //act
                int totalCapacity = a.Sum(tank => tank.Capacity);
                if (totalCapacity == b.Capacity)
                {
                    Tank.TransferTo(a, b);
                }
                else
                {
                    // handle the error condition, e.g., throw an exception or log an error
                    throw new Exception("Cannot transfer if the total capacity of the tanks is not equal to the capacity of the target tank.");
                } 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void TransferTo_ArraysNull()
        {
            try
            {
                //arrange
                Tank[] a = null;
                Tank b = null;

                //act
                int totalCapacity = a.Sum(tank => tank.Capacity);
                if (totalCapacity == b.Capacity)
                {
                    Tank.TransferTo(a, b);
                }
                else
                {
                    // handle the error condition, e.g., throw an exception or log an error
                    throw new Exception("Cannot transfer if the total capacity of the tanks is not equal to the capacity of the target tank.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void TransferTo_ArraysTooBig()
        {
            try
            {
                //arrange
                Tank[] a = new Tank[] { new Tank(100), new Tank(100), new Tank(100) };
                Tank b = new Tank(300);

                //act
                int totalCapacity = a.Sum(tank => tank.Capacity);
                if (totalCapacity == b.Capacity)
                {
                    Tank.TransferTo(a, b);
                }
                else
                {
                    // handle the error condition, e.g., throw an exception or log an error
                    throw new Exception("Cannot transfer if the total capacity of the tanks is not equal to the capacity of the target tank.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void TransferTo_ArraysValid()
        {
            //arrange
            Tank[] a = new Tank[] { new Tank(50), new Tank(25), new Tank(100), new Tank(25) };
            Tank b = new Tank(200);

            //act
            int totalCapacity = a.Sum(tank => tank.Capacity);
            if (totalCapacity == b.Capacity)
            {
                Tank.TransferTo(a, b);
            }
            else
            {
                // handle the error condition, e.g., throw an exception or log an error
                throw new Exception("Cannot transfer if the total capacity of the tanks is not equal to the capacity of the target tank.");
            }

            // assert
            Assert.AreEqual(200, b.Capacity);
        }

        [TestMethod]
        public void TransferTo_ArraysValid_2()
        {
            try
            {
                //arrange
                Tank[] a = new Tank[] { new Tank(50), new Tank(25), new Tank(10), new Tank(30), new Tank(15), new Tank(40) };
                Tank b = new Tank(200);

                //act
                int totalCapacity = a.Sum(tank => tank.Capacity);
                if (totalCapacity == b.Capacity)
                {
                    Tank.TransferTo(a, b);
                }
                else
                {
                    // handle the error condition, e.g., throw an exception or log an error
                    throw new Exception("Cannot transfer if the total capacity of the tanks is not equal to the capacity of the target tank.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void TransferTo_ArraysValid_3()
        {
            try
            {
                //arrange
                Tank[] a = new Tank[] { new Tank(50), new Tank(25), new Tank(10), new Tank(30), new Tank(15), new Tank(40) };
                Tank b = new Tank(100);

                //act
                int totalCapacity = a.Sum(tank => tank.Capacity);
                if (totalCapacity == b.Capacity)
                {
                    Tank.TransferTo(a, b);
                }
                else
                {
                    // handle the error condition, e.g., throw an exception or log an error
                    throw new Exception("Cannot transfer if the total capacity of the tanks is not equal to the capacity of the target tank.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } 
    }

    [TestClass]
    public class FillWithOneWineTests
    {
        [TestMethod]
        public void FillWithOneWine_1()
        {
            Tank tank = new Tank(100);
            Wine[] wines = new Wine[] { new Wine(100) };

            if (tank.Wine.Sum(wine => wine.Quantity) == 0)
                tank.Wine[0].Quantity = tank.Capacity;
            else
                throw new Exception("Cannot fill a full tank.");

            Assert.AreEqual(100, tank.Wine[0].Quantity);
        }

        [TestMethod]
        public void FillWithOneWine_2()
        {
            Tank tank = new Tank(100);
            Wine[] wines = new Wine[] { new Wine(50) };

            if (tank.Wine.Sum(wine => wine.Quantity) == 0)
                tank.Wine[0].Quantity = wines[0].Quantity;
            else
                throw new Exception("Cannot fill a full tank.");

            Assert.AreEqual(50, tank.Wine[0].Quantity);
        }

        [TestMethod]
        public void FillWithOneWine_3()
        {
            Tank tank = new Tank(100);
            Wine[] wines = new Wine[] { new Wine(75) };

            if (tank.Wine.Sum(wine => wine.Quantity) == 0)
                tank.Wine[0].Quantity = wines[0].Quantity;
            else
                throw new Exception("Cannot fill a full tank.");

            Assert.AreEqual(75, tank.Wine[0].Quantity);
        }

        [TestMethod]
        public void FillWithOneWine_4()
        {
            Tank tank = new Tank(200);
            Wine[] wines = new Wine[] { new Wine(150) };

            if (tank.Wine.Sum(wine => wine.Quantity) == 0)
                tank.Wine[0].Quantity = wines[0].Quantity;
            else
                throw new Exception("Cannot fill a full tank.");

            Assert.AreEqual(150, tank.Wine[0].Quantity);
        }

        [TestMethod]
        public void FillWithOneWine_5()
        {
            Tank tank = new Tank(200);
            Wine[] wines = new Wine[] { new Wine(50) };

            if (tank.Wine.Sum(wine => wine.Quantity) == 0)
                tank.Wine[0].Quantity = wines[0].Quantity;
            else
                throw new Exception("Cannot fill a full tank.");

            Assert.AreEqual(50, tank.Wine[0].Quantity);
        }

        [TestMethod]
        public void FillWithOneWine_6()
        {
            Tank tank = new Tank(200);
            Wine[] wines = new Wine[] { new Wine(250) };

            if (tank.Wine.Sum(wine => wine.Quantity) == 0)
                tank.Wine[0].Quantity = wines[0].Quantity;
            else
                throw new Exception("Cannot fill a full tank.");

            Assert.AreEqual(250, tank.Wine[0].Quantity);
        }
    }

    [TestClass]
    public class EmptyArrayTests
    {
        [TestMethod]
        public void EmptyTank_EmptyArray_NoExceptionThrown()
        {
            Wine[] wines = new Wine[0];

            try
            {
                Tank.EmptyTank<Wine>(wines);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Unexpected exception: {ex.Message}");
            }

            Assert.AreEqual(0, wines.Length);
        }

        [TestMethod]
        public void EmptyTank_NonEmptyArray_ArrayCleared()
        {
            Wine[] wines = new Wine[] { new Wine(100), new Wine(200), new Wine(300) };

            Tank.EmptyTank<Wine>(wines);

            Assert.IsNull(wines[0]);
            Assert.IsNull(wines[1]);
            Assert.IsNull(wines[2]);
        }

        [TestMethod]
        public void EmptyTank_NullArray_ThrowsNullReferenceException()
        {
            Wine[] wines = null;

            Assert.ThrowsException<NullReferenceException>(() => Tank.EmptyTank<Wine>(wines));
        }

        [TestMethod]
        public void EmptyTank_EmptyArray_NoEffectOnOtherArrays()
        {
            Wine[] wines1 = new Wine[0];
            Wine[] wines2 = new Wine[] { new Wine(50), new Wine(100), new Wine(150) };

            Tank.EmptyTank<Wine>(wines1);

            Assert.AreEqual(0, wines1.Length);
            Assert.AreEqual(3, wines2.Length);
            Assert.AreEqual(50, wines2[0].Quantity);
            Assert.AreEqual(100, wines2[1].Quantity);
            Assert.AreEqual(150, wines2[2].Quantity);
        }

        [TestMethod]
        public void EmptyTank_EmptyArray_KeepsReferenceIntegrity()
        {
            Wine wine1 = new Wine(100);
            Wine wine2 = new Wine(200);
            Wine[] wines = new Wine[] { wine1, wine2 };

            Tank.EmptyTank<Wine>(wines);

            Assert.IsNull(wines[0]);
            Assert.IsNull(wines[1]);
            Assert.IsNotNull(wine1);
            Assert.IsNotNull(wine2);
        }

        [TestMethod]
        public void EmptyTank_ArrayWithNullElements_NullElementsCleared()
        {
            Wine[] wines = new Wine[] { null, new Wine(50), null, new Wine(100), null };

            Tank.EmptyTank<Wine>(wines);

            Assert.AreEqual(5, wines.Length);
            Assert.IsNull(wines[0]);
            Assert.IsNull(wines[2]);
            Assert.IsNull(wines[4]);
        }
    }
    [TestClass]
    public class TankFromTests
    {
        [TestMethod]
        public void TankFrom_EmptyTanks_ThrowsExceptionWithExpectedMessage()
        {
            Tank[] tanks = new Tank[0];
            string expectedMessage = "The total quantity of wine is too small for the tank.";

            Exception exception = Assert.ThrowsException<Exception>(() => Tank.TankFrom(tanks));
            Assert.AreEqual(expectedMessage, exception.Message);
        }

        [TestMethod]
        public void TankFrom_SingleTank_ReturnsTankWithCorrectWineQuantities()
        {
            Tank[] tanks = new Tank[] { new Tank() };

            tanks[0].Capacity = 100;
            tanks[0].Wine[0].Quantity = 50;
            tanks[0].Wine[1].Quantity = 60;

            Tank result = Tank.TankFrom(tanks);

            Assert.AreEqual(110, result.Capacity);
            Assert.AreEqual(50, result.Wine[0].Quantity);
            Assert.AreEqual(60, result.Wine[1].Quantity);
        }

        [TestMethod]
        public void TankFrom_TwoTanks_ReturnsTankWithCorrectWineQuantities()
        {
            Tank[] tanks = new Tank[] { new Tank(), new Tank() };

            tanks[0].Capacity = 10;
            tanks[0].Wine[0].Quantity = 30;
            tanks[0].Wine[1].Quantity = 40;

            tanks[1].Capacity = 190;
            tanks[1].Wine[0].Quantity = 50;
            tanks[1].Wine[1].Quantity = 80;

            Tank result = Tank.TankFrom(tanks);

            Assert.AreEqual(200, result.Capacity);
            Assert.AreEqual(80, result.Wine[0].Quantity);
            Assert.AreEqual(120, result.Wine[1].Quantity);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TankFrom_SingleTankWithZeroCapacity_ReturnsTankWithZeroCapacityAndZeroWineQuantities()
        {
            Tank[] tanks = new Tank[] { new Tank() };

            tanks[0].Capacity = 0;
            tanks[0].Wine[0].Quantity = 0;
            tanks[0].Wine[1].Quantity = 0;

            Tank result = Tank.TankFrom(tanks);

            Assert.AreEqual(0, result.Capacity);
            for (int i = 0; i < Tank.MAX_WINES; i++)
            {
                Assert.AreEqual(0, result.Wine[i].Quantity);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TankFrom_SingleTankWithNoWineQuantities_ReturnsTankWithZeroCapacityAndZeroWineQuantities()
        {
            Tank[] tanks = new Tank[] { new Tank() };

            tanks[0].Capacity = 100;

            Tank result = Tank.TankFrom(tanks);

            Assert.AreEqual(100, result.Capacity);
            for (int i = 0; i < Tank.MAX_WINES; i++)
            {
                Assert.AreEqual(0, result.Wine[i].Quantity);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TankFrom_TwoTanksWithNoWineQuantities_ReturnsTankWithZeroCapacityAndZeroWineQuantities()
        {
            Tank[] tanks = new Tank[] { new Tank(), new Tank() };

            tanks[0].Capacity = 0;
            tanks[1].Capacity = 0;

            Tank result = Tank.TankFrom(tanks);

            Assert.AreEqual(0, result.Capacity);
            for (int i = 0; i < Tank.MAX_WINES; i++)
            {
                Assert.AreEqual(0, result.Wine[i].Quantity);
            }
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TankFrom_TwoTanksWithEmptyWines_ThrowsException()
        {
            Tank[] tanks = new Tank[] { new Tank(), new Tank() };

            tanks[0].Capacity = 50;
            tanks[1].Capacity = 70;

            Tank result = Tank.TankFrom(tanks);
        }
    }

    [TestClass]
    public class CalculatePercentagesTests
    {
        [TestMethod]
        public void CalculatePercentages_ReturnsCorrectPercentages_1()
        {
            // Arrange
            Tank[] tanks = new Tank[]
            {
                new Tank(50),   // 50% of total capacity
                new Tank(30),   // 30% of total capacity
                new Tank(20)    // 20% of total capacity
            };
    
            // Act
            var result = Tank.CalculatePercentages(tanks);
    
            // Assert
            Assert.AreEqual(50, result[0].Capacity);
            Assert.AreEqual(30, result[1].Capacity);
            Assert.AreEqual(20, result[2].Capacity);
        }

        [TestMethod]
        public void CalculatePercentages_ReturnsCorrectPercentages_2()
        {
            // Arrange
            Tank[] tanks = new Tank[]
            {
                new Tank(50),
                new Tank(75),
                new Tank(100),
                new Tank(125)
            };

            // Act
            var result = Tank.CalculatePercentages(tanks);

            // Assert
            Assert.AreEqual(14, result[0].Capacity);
            Assert.AreEqual(21, result[1].Capacity);
            Assert.AreEqual(28, result[2].Capacity);
            Assert.AreEqual(35, result[3].Capacity);
        }
    
        [TestMethod]
        public void CalculatePercentages_ReturnsZeroPercentForEmptyTanks()
        {
            // Arrange & Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Tank(0));
        }
    
        [TestMethod]
        public void CalculatePercentages_ReturnsEqualPercentagesForEqualCapacityTanks()
        {
            // Arrange
            Tank[] tanks = new Tank[]
            {
                new Tank(50),
                new Tank(50),
                new Tank(50)
            };
    
            // Act
            var result = Tank.CalculatePercentages(tanks);
    
            // Assert
            Assert.AreEqual(33, result[0].Capacity);
            Assert.AreEqual(33, result[1].Capacity);
            Assert.AreEqual(33, result[2].Capacity);
        }
    }

    [TestClass]
    public class CalculateSimilarityTests
    {
        [TestMethod]
        public void CalculateSimilarity_ReturnsCorrectDifferences()
        {
            // Arrange
            Tank[] tanks = new Tank[]
            {
                new Tank(50),
                new Tank(75),
                new Tank(100)
            };

            Wine[] formula = new Wine[]
            {
                new Wine(30),
                new Wine(50),
                new Wine(80)
            };

            // Act
            Wine[] result = Tank.CalculateSimilarity(formula, tanks);

            // Assert
            Assert.AreEqual(20, result[0].Quantity);
            Assert.AreEqual(25, result[1].Quantity);
            Assert.AreEqual(20, result[2].Quantity);
        }

        [TestMethod]
        public void CalculateSimilarity_ReturnsZeroDifferences_ForIdenticalFormulaAndTankQuantities()
        {
            // Arrange
            Tank[] tanks = new Tank[]
            {
                new Tank(50),
                new Tank(75),
                new Tank(100)
            };

            Wine[] formula = new Wine[]
            {
                new Wine(50),
                new Wine(75),
                new Wine(100)
            };

            // Act
            Wine[] result = Tank.CalculateSimilarity(formula, tanks);

            // Assert
            Assert.AreEqual(0, result[0].Quantity);
            Assert.AreEqual(0, result[1].Quantity);
            Assert.AreEqual(0, result[2].Quantity);
        }

        [TestMethod]
        public void CalculateSimilarity_ReturnsPositiveDifferences_WhenFormulaQuantitiesAreGreater()
        {
            // Arrange
            Tank[] tanks = new Tank[]
            {
                new Tank(50),
                new Tank(75),
                new Tank(100)
            };

            Wine[] formula = new Wine[]
            {
                new Wine(60),
                new Wine(80),
                new Wine(120)
            };

            // Act
            Wine[] result = Tank.CalculateSimilarity(formula, tanks);

            // Assert
            Assert.AreEqual(-10, result[0].Quantity);
            Assert.AreEqual(-5, result[1].Quantity);
            Assert.AreEqual(-20, result[2].Quantity);
        }

        [TestMethod]
        public void CalculateSimilarity_ReturnsNegativeDifferences_WhenTankQuantitiesAreGreater()
        {
            // Arrange
            Tank[] tanks = new Tank[]
            {
                new Tank(50),
                new Tank(75),
                new Tank(100)
            };

            Wine[] formula = new Wine[]
            {
                new Wine(40),
                new Wine(70),
                new Wine(90)
            };

            // Act
            Wine[] result = Tank.CalculateSimilarity(formula, tanks);

            // Assert
            Assert.AreEqual(10, result[0].Quantity);
            Assert.AreEqual(5, result[1].Quantity);
            Assert.AreEqual(10, result[2].Quantity);
        }
    }

    [TestClass]
    public class GenerateSumCombiniationsTests
    {
        [TestMethod]
        public void GenerateSumCombinations_ReturnsEmptyList_WhenGivenEmptyInput()
        {
            // Arrange
            Tank[] tanks = new Tank[0];

            // Act
            List<int[]> combinations = Tank.GenerateSumCombinations(tanks);

            // Assert
            Assert.AreEqual(0, combinations.Count);
        }

        [TestMethod]
        public void GenerateSumCombinations_ReturnsSingleCombination_WhenGivenSingleTank()
        {
            // Arrange
            Tank[] tanks = new Tank[] { new Tank { Capacity = 5 } };

            // Act
            List<int[]> combinations = Tank.GenerateSumCombinations(tanks);

            // Assert
            Assert.AreEqual(1, combinations.Count);
            CollectionAssert.AreEqual(new int[] { 5 }, combinations[0]);
        }

        [TestMethod]
        public void GenerateSumCombinations_WhenCalledWithMultipleTanks_ReturnsCorrectCombinations()
        {
            // Arrange
            Tank[] values = new Tank[]
            {
                new Tank { Capacity = 5 },
                new Tank { Capacity = 10 },
                new Tank { Capacity = 15 }
            };

            // Act
            List<int[]> result = Tank.GenerateSumCombinations(values);

            // Assert
            Assert.AreEqual(8, result.Count);
        }

        [TestMethod]
        public void GenerateSumCombinations_WhenCalledWithDifferentTanks_ReturnsCorrectCombinations()
        {
            // Arrange
            Tank[] values = new Tank[]
            {
                new Tank { Capacity = 2 },
                new Tank { Capacity = 3 },
                new Tank { Capacity = 5 },
                new Tank { Capacity = 7 }
            };

            // Act
            List<int[]> result = Tank.GenerateSumCombinations(values);

            // Assert
            Assert.AreEqual(17, result.Count);
        }

        [TestMethod]
        public void GenerateSumCombinations_WhenCalledWithAdditionalTanks_ReturnsCorrectCombinations()
        {
            // Arrange
            Tank[] values = new Tank[]
            {
                new Tank { Capacity = 1 },
                new Tank { Capacity = 2 },
                new Tank { Capacity = 3 },
                new Tank { Capacity = 4 },
                new Tank { Capacity = 5 }
            };

            // Act
            List<int[]> result = Tank.GenerateSumCombinations(values);

            // Assert
            Assert.AreEqual(41, result.Count);
        }
    }

    [TestClass]
    public class CheckFormulaTests
    {
        [TestMethod]
        public void CheckFormula_WhenTheDifferenceBetweenTheFormulaAndTheWineInTank_IsGreaterthanMargin_ReturnFalse()
        {
            Tank[] table = new Tank[]
            {
                new Tank
                {
                    Wine = new Wine[]
                    {
                        new Wine { Quantity = 50 },
                        new Wine { Quantity = 44 },
                        new Wine { Quantity = 57 },
                        new Wine { Quantity = 5 },
                    }
                }
            };

            Wine[] formule = new Wine[]
            {
                new Wine { Quantity = 50 },
                new Wine { Quantity = 40 },
                new Wine { Quantity = 60 },
                new Wine { Quantity = 10 }
            };

            float a =2.0f;

            bool result = Tank.CheckFormula(table, formule, a);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckFormula_WhenTheDifferenceBetweenTheFormulaAndTheWineInTank_IsLessthanOrEqualMargin_ReturnTrue()
        {
            Tank[] table = new Tank[]
            {
                new Tank
                {
                    Wine = new Wine[]
                    {
                        new Wine { Quantity = 10 },
                        new Wine { Quantity = 20 },
                        new Wine { Quantity = 30 }
                    }
                }
            };

            Wine[] formule = new Wine[]
            {
                new Wine { Quantity = 10 },
                new Wine { Quantity = 20 },
                new Wine { Quantity = 30 }
            };

                float a = 2;

                bool result = Tank.CheckFormula(table, formule, a);

               
                Assert.IsTrue(result);
        }

        [TestMethod]

        public void CheckFormula_WhenATankIsEmpty()
        {
            Tank[] table = new Tank[]
            {
                new Tank
                {
                    Wine = new Wine[]
                    {
                        new Wine { Quantity = 0 },
                        new Wine { Quantity = 0 },
                        new Wine { Quantity = 0 }
                    }
                }
            };

            Wine[] formule = new Wine[]
            {
                new Wine { Quantity = 10 },
                new Wine { Quantity = 20 },
                new Wine { Quantity = 30 }
            };

            float a = 2;

            bool result = Tank.CheckFormula(table, formule, a);


            Assert.IsFalse(result);
        }

        [TestMethod]

        public void CheckFormula_WhenTheFormulaIsEmpty()
        {
            Tank[] table = new Tank[]
            {
                new Tank
                {
                    Wine = new Wine[]
                    {
                        new Wine { Quantity = 50 },
                        new Wine { Quantity = 40 },
                        new Wine { Quantity = 10 }
                    }
                }
            };

            Wine[] formule = new Wine[]
            {
                new Wine { Quantity = 0 },
                new Wine { Quantity = 0 },
                new Wine { Quantity = 0 }
            };

            float a = 2;

            bool result = Tank.CheckFormula(table, formule, a);


            Assert.IsFalse(result);
        }
    }
}
