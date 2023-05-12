using KrugApp;

namespace KrugAppTest
{
    [TestClass]
    public class TankConstructor
    {
        //[TestMethod]
        //public void Tank_DefaultConstructor_CreatesTankWithRandomCapacity()
        //{
        //    // Arrange
        //    var tank = new Tank();

        //    // Assert
        //    Assert.IsTrue(tank.Capacity >= 10 && tank.Capacity <= 100);
        //    Assert.IsNotNull(tank.Wine);
        //    Assert.AreEqual(0, tank.Wine.Length);
        //}

        // The above code works if:

        //public Tank()
        //{
        //    Random rnd = new Random();
        //    this.Capacity = rnd.Next(10, 101); // Generates a random number between 10 and 100 (inclusive)
        //    this.Wine = new Wine[MAX_WINES];
        //}


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

        //[TestMethod]
        //public void Tank_DefaultConstructor_CreatesTankWithEmptyWineArray()
        //{
        //    // Arrange
        //    var tank = new Tank();

        //    // Assert
        //    Assert.IsNotNull(tank.Wine);
        //    Assert.AreEqual(0, tank.Wine.Length);
        //}

        // The above code works if:

        //public Tank()
        //{
        //    Random rnd = new Random();
        //    int num = rnd.Next(10, 100);
        //    this.Capacity = num;
        //    this.Wine = new Wine[MAX_WINES];
        //    EmptyArray(this.Wine);
        //}


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

        //[TestMethod]
        //public void Tank_ConstructorWithCapacity_CreatesTankWithGivenCapacity()
        //{
        //    // Arrange
        //    float capacity = 50.0f;

        //    // Act
        //    var tank = new Tank(capacity);

        //    // Assert
        //    Assert.AreEqual(capacity, tank.Capacity);
        //    Assert.IsNotNull(tank.Wine);
        //    Assert.AreEqual(0, tank.Wine.Length);
        //}

        // The above code works if:

        //public Tank(float capacity)
        //{
        //    this.Capacity = capacity;
        //    this.Wine = new Wine[MAX_WINES];
        //    EmptyArray(this.Wine);
        //}


        //[TestMethod]
        //public void Tank_ConstructorWithCapacity_CreatesTankWithZeroWineQuantities()
        //{
        //    // Arrange
        //    float capacity = 50.0f;

        //    // Act
        //    var tank = new Tank(capacity);

        //    // Assert
        //    foreach (var wine in tank.Wine)
        //    {
        //        Assert.AreEqual(0, wine.Quantity);
        //    }
        //}

        // The code above works if:

        //public Tank(float capacity)
        //{
        //    this.Capacity = capacity;
        //    this.Wine = new Wine[MAX_WINES];
        //    EmptyArray(this.Wine);
        //}


        //[TestMethod]
        //public void Tank_ConstructorWithCapacity_ThrowsExceptionForNegativeCapacity()
        //{
        //    // Arrange
        //    float capacity = -10.0f;

        //    // Assert
        //    Assert.ThrowsException<ArgumentException>(() => new Tank(capacity));
        //}

        // The above code works if:

        //public Tank(float capacity)
        //{
        //    if (capacity < 0)
        //    {
        //        throw new ArgumentException("Capacity cannot be negative.");
        //    }

        //    this.Capacity = capacity;
        //    this.Wine = new Wine[MAX_WINES];
        //}


        //[TestMethod]
        //public void Tank_ConstructorWithCapacity_InitializesCapacityAndWineArray()
        //{
        //    // Arrange
        //    float capacity = 50.0f;

        //    // Act
        //    var tank = new Tank(capacity);

        //    // Assert
        //    Assert.AreEqual(capacity, tank.Capacity);
        //    Assert.IsNotNull(tank.Wine);
        //}

        // The above code works if:

        //public Tank(float capacity)
        //{
        //    this.Capacity = capacity;
        //    this.Wine = new Wine[MAX_WINES];
        //    EmptyArray(this.Wine);
        //}


        //[TestMethod]
        //public void Tank_ConstructorWithCapacity_CreatesTankWithCorrectCapacityAndEmptyWineArray()
        //{
        //    // Arrange
        //    float capacity = 75.0f;

        //    // Act
        //    var tank = new Tank(capacity);

        //    // Assert
        //    Assert.AreEqual(capacity, tank.Capacity);
        //    Assert.AreEqual(0, tank.Wine.Length);
        //}

        // The above code works if:

        //public Tank(float capacity)
        //{
        //    this.Capacity = capacity;
        //    this.Wine = new Wine[MAX_WINES];
        //    EmptyArray(this.Wine);
        //}

    }

    [TestClass]
    public class TankWine
    {

        [TestMethod]
        public void Tank_ConstructorWithEmptyWineArray_SetsCapacityToZero()
        {
            // Arrange
            var wines = new Wine[0];

            // Act
            var tank = new Tank(wines);

            // Assert
            Assert.AreEqual(0, tank.Capacity);
        }

        [TestMethod]
        public void Tank_ConstructorWithWines_CalculatesTotalCapacityFromWinesWithPositiveQuantities()
        {
            // Arrange
            var wines = new Wine[]
            {
                new Wine(30),
                new Wine(20),
                new Wine(50)
            };

            // Act
            var tank = new Tank(wines);

            // Assert
            Assert.AreEqual(100, tank.Capacity);
        }

        [TestMethod]
        public void Tank_ConstructorWithWines_CalculatesTotalCapacityFromWinesWithZeroQuantities()
        {
            // Arrange
            var wines = new Wine[]
            {
                new Wine(0),
                new Wine(0),
                new Wine(0)
            };

            // Act
            var tank = new Tank(wines);

            // Assert
            Assert.AreEqual(0, tank.Capacity);
        }

        [TestMethod]
        public void Tank_ConstructorWithWines_CalculatesTotalCapacityFromWinesWithNegativeQuantities()
        {
            // Arrange
            var wines = new Wine[]
            {
                new Wine(-30),
                new Wine(-20),
                new Wine(-50)
            };

            // Act
            var tank = new Tank(wines);

            // Assert
            Assert.AreEqual(-100, tank.Capacity);
        }

        [TestMethod]
        public void Tank_ConstructorWithWines_CalculatesTotalCapacityFromMixedQuantities()
        {
            // Arrange
            var wines = new Wine[]
            {
                new Wine(30),
                new Wine(-20),
                new Wine(0),
                new Wine(-50),
                new Wine(40)
            };

            // Act
            var tank = new Tank(wines);

            // Assert
            Assert.AreEqual(0, tank.Capacity);
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
}