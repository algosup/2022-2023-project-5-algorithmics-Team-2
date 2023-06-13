# Test Plan

<details>
<summary>📖 Table of Content</summary>

- [Test Plan](#test-plan)
  - [Tests](#tests)
    - [First Test Part](#first-test-part)
      - [1A](#1a)
      - [1B](#1b)
      - [1C](#1c)
      - [1D](#1d)
      - [1E](#1e)
    - [Second Test Part](#second-test-part)
      - [2A](#2a)
      - [2B](#2b)
      - [2C](#2c)
      - [2D](#2d)
      - [2E](#2e)
    - [Third Test Part](#third-test-part)
      - [3A](#3a)
      - [3B](#3b)
      - [3C](#3c)
      - [3D](#3d)
      - [3E](#3e)
    - [Fourth Test Part](#fourth-test-part)
      - [4A](#4a)
      - [4B](#4b)
      - [4C](#4c)
      - [4D](#4d)
      - [4E](#4e)
    - [Fifth Test Part](#fifth-test-part)
      - [5A](#5a)
      - [5B](#5b)
      - [5C](#5c)
      - [5D](#5d)
    - [Sixth Test Part](#sixth-test-part)
      - [6A](#6a)
      - [6B](#6b)
      - [6C](#6c)
      - [6D](#6d)
      - [6E](#6e)
    - [Seventh Test Part](#seventh-test-part)
      - [7A](#7a)
      - [7B](#7b)
      - [7C](#7c)
      - [7D](#7d)
      - [7E](#7e)
    - [Eight Test Part](#eight-test-part)
      - [8A](#8a)
    - [Ninth Test Part](#ninth-test-part)
      - [9A](#9a)
      - [9B](#9b)
      - [9C](#9c)
      - [9D](#9d)
      - [9E](#9e)
      - [9F](#9f)
    - [Tenth Test Part](#tenth-test-part)
      - [10A](#10a)
      - [10B](#10b)
      - [10C](#10c)
      - [10D](#10d)
    - [Eleventh Test Part](#eleventh-test-part)
      - [11A](#11a)
      - [11B](#11b)
      - [11C](#11c)
      - [11D](#11d)
      - [11E](#11e)
      - [11F](#11f)
    - [Twelfth Test Part](#twelfth-test-part)
      - [12A](#12a)
      - [12B](#12b)
      - [12C](#12c)
      - [12D](#12d)
      - [12E](#12e)
      - [12F](#12f)
    - [Thirteenth Test Part](#thirteenth-test-part)
      - [13A](#13a)
      - [13B](#13b)
      - [13C](#13c)
      - [13D](#13d)
      - [13E](#13e)
      - [13F](#13f)
    - [Fourteenth Test Part](#fourteenth-test-part)
      - [14A](#14a)
      - [14B](#14b)
      - [14C](#14c)
      - [14D](#14d)
      - [14E](#14e)
      - [14F](#14f)
      - [14G](#14g)
    - [Fifteenth Test Part](#fifteenth-test-part)
      - [15A](#15a)
      - [15B](#15b)
      - [15C](#15c)
      - [15D](#15d)
    - [Sixteenth Test Part](#sixteenth-test-part)
      - [16A](#16a)
      - [16B](#16b)
      - [16C](#16c)
      - [16D](#16d)
    - [Seventeenth Test Part](#seventeenth-test-part)
      - [17A](#17a)
      - [17B](#17b)
      - [17C](#17c)
      - [17D](#17d)
      - [17E](#17e)

</details>

## Tests

The tests have been divided into different parts.
Each part has its own tests, all related to each other.

### First Test Part

**TITLE: Tank Default Constructor Tests Overview:**

#### 1A

**TITLE: Tank_DefaultConstructor_CreatesTankWithRandomCapacity():**

`
This test verifies that the default constructor of the Tank class creates a tank object with a randomly assigned capacity. The capacity value is not specified, and the test ensures that a tank is instantiated with a capacity value that falls within a specified range.
`

#### 1B

**TITLE: Tank_DefaultConstructor_CreatesDifferentRandomCapacityTanks():**

`
This test aims to confirm that multiple instances of the Tank class, created using the default constructor, have different randomly assigned capacity values. By repeating the instantiation process, this test ensures that each tank object has a unique capacity.
`

#### 1C

**TITLE: Tank_DefaultConstructor_CreatesTankWithCapacityWithinRange():**

`
The purpose of this test is to validate that the default constructor of the Tank class creates a tank object with a capacity that falls within a specified range. Unlike the first test, which checks for random capacity, this test ensures the capacity adheres to specific limits.
`

#### 1D

**TITLE: Tank_DefaultConstructor_CreatesTankWithEmptyWineArray():**

`
This test focuses on verifying that the default constructor initializes the wine array of a tank object as empty. The wine array represents the contents of the tank, and this test ensures that it is initially empty upon instantiation.
`

#### 1E

**TITLE: Tank_DefaultConstructor_InitializesCapacityAndWineArray():**

`
The final test in the list confirms that the default constructor of the Tank class successfully initializes both the capacity and wine array of a tank object. It ensures that both properties are set to their initial values, with the capacity falling within a specified range and the wine array being empty.
`

### Second Test Part

**TITLE: Tank Constructor with Capacity Tests Overview:**

#### 2A

**TITLE: Tank_ConstructorWithCapacity_CreatesTankWithGivenCapacity():**

`
This test ensures that the Tank class constructor with a specified capacity parameter successfully creates a tank object with the given capacity. The constructor is expected to set the capacity of the tank to the specified value.
`

#### 2B

**TITLE: Tank_ConstructorWithCapacity_CreatesTankWithZeroWineQuantities():**

`
This test verifies that when using the Tank class constructor with a capacity parameter, the created tank object has all wine quantities initialized to zero. It ensures that the wine array, representing the tank's contents, is initially empty in terms of the quantity of wine.
`

#### 2C

**TITLE: Tank_ConstructorWithCapacity_ThrowsExceptionForNegativeCapacity():**

`
The purpose of this test is to validate that the Tank class constructor with a capacity parameter throws an exception when provided with a negative capacity value. It ensures that attempting to create a tank with a negative capacity results in an appropriate error or exception being raised.
`

#### 2D

**TITLE: Tank_ConstructorWithCapacity_InitializesCapacityAndWineArray():**

`
This test confirms that the Tank class constructor with a capacity parameter successfully initializes both the capacity and wine array of the tank object. It ensures that the capacity is set to the specified value, and the wine array is initially empty.
`

#### 2E

**TITLE: Tank_ConstructorWithCapacity_CreatesTankWithCorrectCapacityAndEmptyWineArray():**

`
This test combines the validation of both the capacity and wine array initialization. It ensures that the Tank class constructor with a capacity parameter creates a tank object with the correct capacity and an empty wine array, representing that the tank is initially empty.
`

### Third Test Part

**TITLE: Tank Constructor Tests with Wine Array Overview:**

#### 3A

**TITLE: Tank_ConstructorWithEmptyWineArray_SetsCapacityToZero():**

`
This test ensures that the Tank class constructor with an empty wine array parameter sets the capacity of the tank to zero. It verifies that when initializing a tank with no wines, the capacity is correctly set to zero.
`

#### 3B

**TITLE: Tank_ConstructorWithWines_CalculatesTotalCapacityFromWinesWithPositiveQuantities():**

`
The purpose of this test is to validate that the Tank class constructor with a wine array parameter accurately calculates the total capacity of the tank based on wines with positive quantities. It ensures that the constructor sums up the quantities of all wines to determine the total capacity.
`

#### 3C

**TITLE: Tank_ConstructorWithWines_CalculatesTotalCapacityFromWinesWithZeroQuantities():**

`
This test verifies that the Tank class constructor with a wine array parameter correctly calculates the total capacity of the tank, even when some wines have zero quantities. It ensures that wines with zero quantities are included in the capacity calculation.
`

#### 3D

**TITLE: Tank_ConstructorWithWines_CalculatesTotalCapacityFromWinesWithNegativeQuantities():**

`
This test validates that the Tank class constructor with a wine array parameter correctly calculates the total capacity of the tank, considering wines with negative quantities. It ensures that the constructor correctly accounts for wines with negative quantities when determining the overall capacity.
`

#### 3E

**TITLE: Tank_ConstructorWithWines_CalculatesTotalCapacityFromMixedQuantities():**

`
The final test in the list combines wines with positive, zero, and negative quantities. It verifies that the Tank class constructor with a wine array parameter accurately calculates the total capacity of the tank, taking into account wines with mixed quantities. It ensures that the constructor correctly handles and sums up the quantities to determine the final capacity.
`

### Fourth Test Part

**TITLE: Operator Plus Tests for Wine Addition:**

#### 4A

**TITLE: OperatorPlus_AddTwoZeroQuantityWines_ReturnsWineWithZeroQuantity():**

`
This test verifies that the operator plus function (+) correctly adds two wines with zero quantities and returns a wine with a quantity of zero. It ensures that the addition of wines with no quantity results in a wine with zero quantity.
`

#### 4B

**TITLE: OperatorPlus_AddTwoPositiveQuantityWines_ReturnsWineWithSumOfQuantities():**

`
This test ensures that the operator plus function (+) accurately adds two wines with positive quantities and returns a wine with the sum of their quantities. It validates that the addition of wines with positive quantities yields a wine with the correct total quantity.
`

#### 4C

**TITLE: OperatorPlus_AddWineWithPositiveQuantityAndWineWithZeroQuantity_ReturnsWineWithPositiveQuantity():**

`
This test validates that the operator plus function (+) correctly adds a wine with a positive quantity and a wine with a zero quantity. It ensures that the addition of a wine with a positive quantity to a wine with no quantity results in a wine with a positive quantity.
`

#### 4D

**TITLEOperatorPlus_AddWineWithNegativeQuantityAndWineWithPositiveQuantity_ReturnsWineWithCorrectQuantity():**

`
This test verifies that the operator plus function (+) accurately adds a wine with a negative quantity and a wine with a positive quantity. It ensures that the addition of a wine with a negative quantity and a wine with a positive quantity returns a wine with the correct quantity.
`

#### 4E

**TITLE: OperatorPlus_AddWineWithNegativeQuantityAndWineWithZeroQuantity_ReturnsWineWithNegativeQuantity():**

`
The final test in the list ensures that the operator plus function (+) correctly adds a wine with a negative quantity and a wine with no quantity. It validates that the addition of a wine with a negative quantity and a wine with no quantity returns a wine with the correct negative quantity.
`

### Fifth Test Part

#### 5A

**TITLE: OperatorMinus_SubtractZeroQuantityWine_ReturnsOriginalQuantity():**

`
This test ensures that the operator minus function (-) correctly subtracts a wine with a zero quantity from another wine, and returns the original quantity of the latter wine. It validates that subtracting a wine with no quantity does not affect the quantity of the original wine.
`

#### 5B

**TITLE: OperatorMinus_SubtractWineWithFloatQuantity_SubtractsQuantities():**

`
This test verifies that the operator minus function (-) accurately subtracts a wine with a floating-point quantity from another wine, and returns the result as the difference between their quantities. It ensures that the subtraction of wines with floating-point quantities is correctly calculated.
`

#### 5C

**TITLE: OperatorMinus_SubtractWineFromZeroQuantityWine_ReturnsNegativeQuantity():**

`
This test validates that the operator minus function (-) correctly subtracts a wine from another wine with a zero quantity, and returns a negative quantity. It ensures that subtracting a wine from a wine with no quantity results in a negative quantity.
`

#### 5D

**TITLE: OperatorMinus_SubtractWineWithLargeQuantity_SubtractsQuantities():**

`
The final test in the list ensures that the operator minus function (-) accurately subtracts a wine with a large quantity from another wine, and returns the result as the difference between their quantities. It validates the correct calculation of subtraction when dealing with wines with large quantities.
`

### Sixth Test Part

#### 6A

**TITLE: OperatorMultiply_MultiplyTwoZeroQuantityWines_ReturnsWineWithZeroQuantity():**

`
This test ensures that the operator multiply function (*) correctly multiplies two wines with zero quantities and returns a wine with a quantity of zero. It validates that the multiplication of wines with no quantity results in a wine with zero quantity.
`

#### 6B

**TITLE: OperatorMultiply_MultiplyWineWithZeroQuantityAndWineWithPositiveQuantity_ReturnsWineWithZeroQuantity():**

`
This test verifies that the operator multiply function (*) correctly multiplies a wine with a zero quantity by a wine with a positive quantity, and returns a wine with a quantity of zero. It ensures that when multiplying a wine with no quantity by a wine with a positive quantity, the result is a wine with zero quantity.
`

#### 6C

**TITLE: OperatorMultiply_MultiplyWineWithPositiveQuantityAndWineWithZeroQuantity_ReturnsWineWithZeroQuantity():**

`
This test validates that the operator multiply function (*) correctly multiplies a wine with a positive quantity by a wine with a zero quantity, and returns a wine with a quantity of zero. It ensures that when multiplying a wine with a positive quantity by a wine with no quantity, the result is a wine with zero quantity.
`

#### 6D

**TITLE: OperatorMultiply_MultiplyTwoPositiveQuantityWines_ReturnsWineWithCorrectMultiplicationResult():**

`
This test ensures that the operator multiply function (*) accurately multiplies two wines with positive quantities and returns a wine with the correct multiplication result. It validates that the multiplication of wines with positive quantities yields a wine with the correct total quantity.
`

#### 6E

**TITLE: OperatorMultiply_MultiplyWineWithPositiveQuantityAndWineWithNegativeQuantity_ReturnsWineWithNegativeQuantity():**

`
The final test in the list verifies that the operator multiply function (*) correctly multiplies a wine with a positive quantity by a wine with a negative quantity, and returns a wine with the correct negative quantity. It ensures that the multiplication of a wine with a positive quantity by a wine with a negative quantity results in a wine with the correct negative quantity.
`

### Seventh Test Part

**TITLE: OperatorDivide Tests for Wine Division:**

#### 7A

**TITLE: OperatorDivide_DivideWineWithZeroQuantityByWineWithPositiveQuantity_ReturnsWineWithZeroQuantity():**

`
This test ensures that the operator divide function (/) correctly divides a wine with a zero quantity by a wine with a positive quantity and returns a wine with a quantity of zero. It validates that dividing a wine with no quantity by a wine with a positive quantity results in a wine with zero quantity.
`

#### 7B

**TITLE: OperatorDivide_DivideWineWithPositiveQuantityByWineWithZeroQuantity_ThrowsDivideByZeroException():**

`
This test verifies that the operator divide function (/) correctly throws a divide by zero exception when attempting to divide a wine with a positive quantity by a wine with no quantity. It ensures that dividing a wine with a positive quantity by a wine with no quantity is not allowed and results in an exception.
`

#### 7C

**TITLE: OperatorDivide_DivideWineWithPositiveQuantityByWineWithPositiveQuantity_ReturnsWineWithCorrectDivisionResult():**

`
This test ensures that the operator divide function (/) accurately divides a wine with a positive quantity by another wine with a positive quantity and returns a wine with the correct division result. It validates that the division of wines with positive quantities yields a wine with the correct divided quantity.
`

#### 7D

**TITLE: OperatorDivide_DivideWineWithNegativeQuantityByWineWithPositiveQuantity_ReturnsWineWithNegativeQuantity():**

`
This test verifies that the operator divide function (/) correctly divides a wine with a negative quantity by a wine with a positive quantity and returns a wine with the correct negative quantity. It ensures that dividing a wine with a negative quantity by a wine with a positive quantity results in a wine with the correct negative quantity.
`

#### 7E

**TITLE: OperatorDivide_DivideWineWithNegativeQuantityByWineWithNegativeQuantity_ReturnsWineWithPositiveQuantity():**

`
The final test in the list validates that the operator divide function (/) correctly divides a wine with a negative quantity by another wine with a negative quantity and returns a wine with the correct positive quantity. It ensures that the division of wines with negative quantities results in a wine with the correct positive quantity.
`

### Eight Test Part

**TITLE: Node Traversal Tests Overview:**

#### 8A

**TITLE: TestNodeTraversal():**

`
This test aims to verify the node traversal functionality in a "Tank" object using a simulated array of nodes. Here's a brief summary in English:
The purpose of this test is to ensure that the node traversal in a "Tank" object meets specific conditions. The test creates a simulated array of nodes and initializes them with different quantities. It then calls the "TraverseNodes" method and verifies the results. The assertions check that the number of results is correct, each node has a quantity within a valid range, and each node differs from its parent and siblings by at least 5 units. The test helps validate the correctness of the node traversal logic in the "Tank" object.
`

### Ninth Test Part

**TITLE: Is Moving Away Tests Overview:**

#### 9A

**TITLE: IsMovingAwayTest_1():**

`
This test case checks whether the IsMovingAway method correctly returns false when called with three tanks, parent, child, and target, all having a health value of 50. The IsMovingAway method determines if the tanks are moving away from each other.
`

#### 9B

**TITLE: IsMovingAwayTest_2():**

`
This test case examines the behavior of the IsMovingAway method with different tank health values. The test sets up three tanks (parent, child, and target) with health values of 60, 55, and 65, respectively.
`

#### 9C

**TITLE: IsMovingAwayTest_3():**

`
This test case checks whether the IsMovingAway method correctly returns false when called with three tanks (parent, child, and target) having health values of 100, 80, and 85 respectively. The test verifies that the tanks are not moving away from each other.
`

#### 9D

**TITLE: IsMovingAwayTest_4():**

`
This test case examines the behavior of the IsMovingAway method with different tank health values. The test sets up three tanks (parent, child, and target) with health values of 85, 95, and 100, respectively.
`

#### 9E

**TITLE: IsMovingAwayTest_5():**

`
This test case examines the behavior of the IsMovingAway method with different tank health values. The test sets up three tanks: parent, child, and target with health values of 100, 100, and 110, respectively.
`

#### 9F

**TITLE: IsMovingAwayTest_6():**

`
This test case examines the behavior of the IsMovingAway method with different tank health values. The test sets up three tanks: parent, child, and target with health values of 100, 110, and 110, respectively.
`

### Tenth Test Part

**TITLE: Similarity Tests Overview:**

#### 10A

**TITLE: Similarity_BothArraysNull_ThrowsArgumentException():**

`
Sets both input arrays a and b to null.
Calls the Program.Similarity method with the null arrays.
Expects an ArgumentException to be thrown.
If the exception is thrown, the test passes.
`

#### 10B

**Similarity_ArraysEmpty_ThrowsArgumentException():**

`
Creates empty arrays a and b of type Tank.
Calls the Program.Similarity method with the empty arrays.
Expects an ArgumentException to be thrown.
If the exception is thrown, the test passes.
`

#### 10C

**TITLE: Similarity_ValidInput_ReturnsExpectedSimilarity_1():**

`
Creates two arrays a and b of type Tank, each containing three Tank objects with a capacity of 100.
Defines the expected similarity value as 6.
Calls the Program.Similarity method with arrays a and b.
Compares the returned similarity value with the expected value using Assert.AreEqual.
If the values are equal, the test passes.
`

#### 10D

**TITLE: Similarity_ValidInput_ReturnsExpectedSimilarity_2():**

`
Creates two arrays a and b of type Tank, each containing one Tank object with capacities 20 and 100, respectively.
Defines the expected similarity value as 10.
Calls the Program.Similarity method with arrays a and b.
Compares the returned similarity value with the expected value using Assert.AreEqual.
If the values are equal, the test passes.
`

### Eleventh Test Part

**TITLE: Transfer To Tests Overview:**

#### 11A

**TITLE: TransferTo_ArraysEmpty():**

`
Verifies that if both input arrays (a and b) are empty, the method Tank.TransferTo throws an exception with the message "Cannot transfer if the total capacity of the tanks is not equal to the capacity of the target tank."
`

#### 11B

**TITLE: TransferTo_ArraysNull():**

`
Verifies that if both input arrays (a and b) are null, the method Tank.TransferTo throws an exception with the message "Cannot transfer if the total capacity of the tanks is not equal to the capacity of the target tank."
`

#### 11C

**TITLE: TransferTo_ArraysTooBig():**

`
Verifies that if the total capacity of input array a is not equal to the capacity of input tank b, the method Tank.TransferTo throws an exception with the message "Cannot transfer if the total capacity of the tanks is not equal to the capacity of the target tank."
`

#### 11D

**TITLE: TransferTo_ArraysValid():**

`
Tests the method TransferTo with valid input arrays (a) and a valid target tank (b) of capacity 200.
Transfers the contents of tanks in array a to tank b if the total capacity of a is equal to the capacity of b.
Asserts that the capacity of tank b after the transfer is 200.
`

#### 11E

**TITLE: TransferTo_ArraysValid_2():**

`
Verifies the behavior of Tank.TransferTo when transferring from an array a with multiple tanks to a target tank b of capacity 200.
If the total capacity of tanks in array a is equal to the capacity of b, the transfer is successful.
Otherwise, an exception with the message "Cannot transfer if the total capacity of the tanks is not equal to the capacity of the target tank" is thrown.
`

#### 11F

**TITLE: TransferTo_ArraysValid_3():**

`
Verifies the behavior of Tank.TransferTo when transferring from an array a with multiple tanks to a target tank b of capacity 100.
If the total capacity of tanks in array a is equal to the capacity of b, the transfer is successful.
Otherwise, an exception with the message "Cannot transfer if the total capacity of the tanks is not equal to the capacity of the target tank" is thrown.
`

### Twelfth Test Part

**TITLE: Fill With One Wine Tests Overview:**

#### 12A

**TITLE: FillWithOneWine_1():**

`
Fills a tank with a capacity of 100 using one wine of quantity 100.
If the tank is empty (no existing wine), sets the quantity of the tank's wine to the tank's capacity (100).
Asserts that the quantity of the tank's wine is 100.
`

#### 12B

**TITLE: FillWithOneWine_2():**

`
Fills a tank with a capacity of 100 using one wine of quantity 50.
If the tank is empty (no existing wine), sets the quantity of the tank's wine to the quantity of the provided wine (50).
Asserts that the quantity of the tank's wine is 50.
`

#### 12C

**TITLE: FillWithOneWine_3():**

`
Fills a tank with a capacity of 100 using one wine of quantity 75.
If the tank is empty (no existing wine), sets the quantity of the tank's wine to the quantity of the provided wine (75).
Asserts that the quantity of the tank's wine is 75.
`

#### 12D

**TITLE: FillWithOneWine_4():**

`
Fills a tank with a capacity of 200 using one wine of quantity 150.
If the tank is empty (no existing wine), sets the quantity of the tank's wine to the quantity of the provided wine (150).
Asserts that the quantity of the tank's wine is 150.
`

#### 12E

**TITLE: FillWithOneWine_5():**

`
Fills a tank with a capacity of 200 using one wine of quantity 50.
If the tank is empty (no existing wine), sets the quantity of the tank's wine to the quantity of the provided wine (50).
Asserts that the quantity of the tank's wine is 50.
`

#### 12F

**TITLE: FillWithOneWine_6():**

`
Fills a tank with a capacity of 200 using one wine of quantity 250.
If the tank is empty (no existing wine), sets the quantity of the tank's wine to the quantity of the provided wine (250).
Asserts that the quantity of the tank's wine is 250.
`

### Thirteenth Test Part

**TITLE: Empty Array Tests Overview:**

#### 13A

**TITLE: EmptyTank_EmptyArray_NoExceptionThrown():**

`
Tests emptying an empty array of wines.
Calls the EmptyTank method with an empty array.
Expects no exceptions to be thrown.
Asserts that the length of the array is 0.
`

#### 13B

**TITLE: EmptyTank_NonEmptyArray_ArrayCleared():**

`
Tests emptying a non-empty array of wines.
Creates an array of wines with three elements.
Calls the EmptyTank method with the array.
Expects the array to be cleared, with all elements set to null.
Asserts that all elements of the array are null.
`

#### 13C

**TITLE: EmptyTank_NullArray_ThrowsNullReferenceException():**

`
Tests emptying a null array of wines.
Initializes the wines array as null.
Expects a NullReferenceException to be thrown when calling the EmptyTank method.
Asserts that the expected exception is thrown.
`

#### 13D

**TITLE: EmptyTank_EmptyArray_NoEffectOnOtherArrays():**

`
Tests emptying an empty array of wines and checks if it affects other arrays.
Initializes one empty wines array and another array with three wines.
Calls the EmptyTank method with the empty array.
Expects the empty array to be cleared, while the other array remains unaffected.
Asserts the length of the empty array is 0 and the length and quantities of the other array remain unchanged.
`

#### 13E

**TITLE: EmptyTank_EmptyArray_KeepsReferenceIntegrity():**

`
Tests emptying an empty array of wines and checks if reference integrity is maintained.
Creates two wine objects and an array of wines referencing those objects.
Calls the EmptyTank method with the array.
Expects the array to be cleared, while the original wine objects remain intact.
Asserts that the elements of the array are null and the original wine objects are not null.
`

#### 13F

**TITLE: EmptyTank_ArrayWithNullElements_NullElementsCleared():**

`
Tests emptying an array of wines with null elements.
Creates an array of wines with null elements and non-null elements.
Calls the EmptyTank method with the array.
Expects the null elements to be cleared while the non-null elements remain unchanged.
Asserts the length of the array remains the same, and the null elements are cleared while the non-null elements are preserved.
`

### Fourteenth Test Part

**TITLE: Tank From Tests Overview:**

#### 14A

**TITLE: TankFrom_EmptyTanks_ThrowsExceptionWithExpectedMessage():**

`
Tests the scenario where no tanks are provided.
Initializes an empty array of tanks.
Expects an exception to be thrown when calling the TankFrom method with the empty array.
Asserts that the exception message matches the expected message.
`

#### 14B

**TITLE: TankFrom_SingleTank_ReturnsTankWithCorrectWineQuantities():**

`
Tests the scenario where a single tank is provided.
Creates an array with a single tank.
Sets the capacity and wine quantities of the tank.
Calls the TankFrom method with the array of tanks.
Expects a tank object to be returned with the correct capacity and wine quantities.
Asserts that the returned tank object has the expected capacity and wine quantities.
`

#### 14C

**TITLE: TankFrom_TwoTanks_ReturnsTankWithCorrectWineQuantities():**

`
Tests the scenario where two tanks are provided.
Creates an array with two tanks.
Sets the capacities and wine quantities of the tanks.
Calls the TankFrom method with the array of tanks.
Expects a tank object to be returned with the correct capacity and combined wine quantities.
Asserts that the returned tank object has the expected capacity and combined wine quantities.
`

#### 14D

**TITLE: TankFrom_SingleTankWithZeroCapacity_ReturnsTankWithZeroCapacityAndZeroWineQuantities():**

`
Tests the scenario where a single tank with zero capacity and zero wine quantities is provided.
Creates an array with a single tank.
Sets the capacity and wine quantities of the tank to zero.
Calls the TankFrom method with the array of tanks.
Expects an exception to be thrown due to the tank having zero capacity.
Asserts that the exception is thrown.
`

#### 14E

**TITLE: TankFrom_SingleTankWithNoWineQuantities_ReturnsTankWithZeroCapacityAndZeroWineQuantities():**

`
Tests the scenario where a single tank with no wine quantities is provided.
Creates an array with a single tank.
Sets the capacity of the tank.
Calls the TankFrom method with the array of tanks.
Expects an exception to be thrown due to the tank having no wine quantities specified.
Asserts that the exception is thrown.
`

#### 14F

**TITLE: TankFrom_TwoTanksWithNoWineQuantities_ReturnsTankWithZeroCapacityAndZeroWineQuantities():**

`
Tests the scenario where two tanks with no wine quantities are provided.
Creates an array with two tanks.
Sets the capacities of the tanks to zero.
Calls the TankFrom method with the array of tanks.
Expects an exception to be thrown due to the tanks having no wine quantities specified.
Asserts that the exception is thrown.
`

#### 14G

**TITLE: TankFrom_TwoTanksWithEmptyWines_ThrowsException():**

`
Tests the scenario where two tanks with empty wines are provided.
Creates an array with two tanks.
Sets the capacities of the tanks.
Calls the TankFrom method with the array of tanks.
Expects an exception to be thrown due to the tanks having empty wines.
Asserts that the exception is thrown.
`

### Fifteenth Test Part

**TITLE: Calculate Percentage Tests Overview:**

#### 15A

**TITLE: CalculatePercentages_ReturnsCorrectPercentages_1():**

`
Tests the scenario where an array of tanks with different capacities is provided.
Creates an array with three tanks and sets their capacities.
Calls the CalculatePercentages method with the array of tanks.
Expects a new array of tanks with updated capacities representing the percentage of the total capacity.
Asserts that the returned tank objects have the expected capacities.
`

#### 15B

**TITLE: CalculatePercentages_ReturnsCorrectPercentages_2():**

`
Tests the scenario where an array of tanks with different capacities is provided.
Creates an array with four tanks and sets their capacities.
Calls the CalculatePercentages method with the array of tanks.
Expects a new array of tanks with updated capacities representing the percentage of the total capacity.
Asserts that the returned tank objects have the expected capacities.
`

#### 15C

**TITLE: CalculatePercentages_ReturnsZeroPercentForEmptyTanks():**

`
Tests the scenario where a tank with zero capacity is provided.
Creates a tank with zero capacity.
Calls the CalculatePercentages method with the tank.
Expects an exception to be thrown due to the tank having zero capacity.
Asserts that the exception is thrown.
`

#### 15D

**TITLE: CalculatePercentages_ReturnsEqualPercentagesForEqualCapacityTanks():**

`
Tests the scenario where an array of tanks with equal capacities is provided.
Creates an array with three tanks and sets their capacities to be equal.
Calls the CalculatePercentages method with the array of tanks.
Expects a new array of tanks with updated capacities representing equal percentages.
Asserts that the returned tank objects have the expected capacities.
`

### Sixteenth Test Part

**TITLE: Calculate Similarity Tests Overview:**

#### 16A

**TITLE: CalculateSimilarity_ReturnsCorrectDifferences():**

`
Tests the scenario where an array of tanks and a formula of wines are provided.
Creates an array with three tanks and sets their capacities.
Creates an array with three wines and sets their quantities.
Calls the CalculateSimilarity method with the formula and tanks.
Expects a new array of wines with updated quantities representing the differences between the formula and the tanks.
Asserts that the returned wine objects have the expected quantities.
`

#### 16B

**TITLE: CalculateSimilarity_ReturnsZeroDifferences_ForIdenticalFormulaAndTankQuantities():**

`
Tests the scenario where an array of tanks and a formula with identical quantities are provided.
Creates an array with three tanks and sets their capacities.
Creates an array with three wines and sets their quantities to be identical to the tank capacities.
Calls the CalculateSimilarity method with the formula and tanks.
Expects a new array of wines with all quantities set to zero since the formula and tanks are identical.
Asserts that the returned wine objects have quantities equal to zero.
`

#### 16C

**TITLE: CalculateSimilarity_ReturnsPositiveDifferences_WhenFormulaQuantitiesAreGreater():**

`
Tests the scenario where an array of tanks and a formula with greater quantities than the tanks are provided.
Creates an array with three tanks and sets their capacities.
Creates an array with three wines and sets their quantities to be greater than the tank capacities.
Calls the CalculateSimilarity method with the formula and tanks.
Expects a new array of wines with updated quantities representing the negative differences between the formula and the tanks.
Asserts that the returned wine objects have the expected quantities.
`

#### 16D

**TITLE: CalculateSimilarity_ReturnsNegativeDifferences_WhenTankQuantitiesAreSmaller():**

`
Tests the scenario where an array of tanks and a formula with smaller quantities than the tanks are provided.
Creates an array with three tanks and sets their capacities.
Creates an array with three wines and sets their quantities to be smaller than the tank capacities.
Calls the CalculateSimilarity method with the formula and tanks.
Expects a new array of wines with updated quantities representing the positive differences between the formula and the tanks.
Asserts that the returned wine objects have the expected quantities.
`

### Seventeenth Test Part

**TITLE: Generate Sum Combinations Tests Overview:**

#### 17A

**TITLE: GenerateSumCombinations_ReturnsEmptyList_WhenGivenEmptyInput():**

`
Tests the scenario where an empty array of tanks is provided. Creates an empty array of tanks.
Calls the GenerateSumCombinations method with the empty array.
Expects an empty list as the result.
Asserts that the returned list has a count of 0.
`

#### 17B

**TITLE: GenerateSumCombinations_ReturnsSingleCombination_WhenGivenSingleTank():**

`
Tests the scenario where a single tank is provided.
Creates an array with a single tank and sets its capacity.
Calls the GenerateSumCombinations method with the array of tanks.
Expects a list with a single combination, which contains the tank capacity as the only element.
Asserts that the returned list has a count of 1 and the single combination matches the expected array.
`

#### 17C

**TITLE: GenerateSumCombinations_WhenCalledWithMultipleTanks_ReturnsCorrectCombinations():**

`
Tests the scenario where an array of multiple tanks is provided.
Creates an array with three tanks and sets their capacities.
Calls the GenerateSumCombinations method with the array of tanks.
Expects a list of combinations representing all possible combinations of tank capacities.
Asserts that the returned list has the expected count of combinations.
`

#### 17D

**TITLE: GenerateSumCombinations_WhenCalledWithDifferentTanks_ReturnsCorrectCombinations():**

`
Tests the scenario where an array of tanks with different capacities is provided.
Creates an array with four tanks and sets their capacities.
Calls the GenerateSumCombinations method with the array of tanks.
Expects a list of combinations representing all possible combinations of tank capacities.
Asserts that the returned list has the expected count of combinations.
`

#### 17E

**TITLE: GenerateSumCombinations_WhenCalledWithAdditionalTanks_ReturnsCorrectCombinations():**

`
Tests the scenario where an array of additional tanks is provided.
Creates an array with five tanks and sets their capacities.
Calls the GenerateSumCombinations method with the array of tanks.
Expects a list of combinations representing all possible combinations of tank capacities.
Asserts that the returned list has the expected count of combinations.
`
