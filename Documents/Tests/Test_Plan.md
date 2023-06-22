# Test Plan

<details>
<summary>📖 Table of Content</summary>

- [Test Plan](#test-plan)
  - [Tests.cs](#testscs)
    - [First Test Part](#first-test-part)
      - [A1A](#a1a)
      - [A1B](#a1b)
      - [A1C](#a1c)
      - [A1D](#a1d)
      - [A1E](#a1e)
    - [Second Test Part](#second-test-part)
      - [A2A](#a2a)
      - [A2B](#a2b)
      - [A2C](#a2c)
      - [A2D](#a2d)
      - [A2E](#a2e)
    - [Third Test Part](#third-test-part)
      - [A3A](#a3a)
      - [A3B](#a3b)
      - [A3C](#a3c)
      - [A3D](#a3d)
      - [A3E](#a3e)
    - [Fourth Test Part](#fourth-test-part)
      - [A4A](#a4a)
      - [A4B](#a4b)
      - [A4C](#a4c)
      - [A4D](#a4d)
      - [A4E](#a4e)
    - [Fifth Test Part](#fifth-test-part)
      - [A5A](#a5a)
      - [A5B](#a5b)
      - [A5C](#a5c)
      - [A5D](#a5d)
    - [Sixth Test Part](#sixth-test-part)
      - [A6A](#a6a)
      - [A6B](#a6b)
      - [A6C](#a6c)
      - [A6D](#a6d)
      - [A6E](#a6e)
    - [Seventh Test Part](#seventh-test-part)
      - [A7A](#a7a)
      - [A7B](#a7b)
      - [A7C](#a7c)
      - [A7D](#a7d)
      - [A7E](#a7e)
    - [Eight Test Part](#eight-test-part)
      - [A8A](#a8a)
    - [Ninth Test Part](#ninth-test-part)
      - [A9A](#a9a)
      - [A9B](#a9b)
      - [A9C](#a9c)
      - [A9D](#a9d)
      - [A9E](#a9e)
      - [A9F](#a9f)
    - [Tenth Test Part](#tenth-test-part)
      - [A10A](#a10a)
      - [A10B](#a10b)
      - [A10C](#a10c)
      - [A10D](#a10d)
    - [Eleventh Test Part](#eleventh-test-part)
      - [A11A](#a11a)
      - [A11B](#a11b)
      - [A11C](#a11c)
      - [A11D](#a11d)
      - [A11E](#a11e)
      - [A11F](#a11f)
    - [Twelfth Test Part](#twelfth-test-part)
      - [A12A](#a12a)
      - [A12B](#a12b)
      - [A12C](#a12c)
      - [A12D](#a12d)
      - [A12E](#a12e)
      - [A12F](#a12f)
    - [Thirteenth Test Part](#thirteenth-test-part)
      - [A13A](#a13a)
      - [A13B](#a13b)
      - [A13C](#a13c)
      - [A13D](#a13d)
      - [A13E](#a13e)
      - [A13F](#a13f)
    - [Fourteenth Test Part](#fourteenth-test-part)
      - [A14A](#a14a)
      - [A14B](#a14b)
      - [A14C](#a14c)
      - [A14D](#a14d)
      - [A14E](#a14e)
      - [A14F](#a14f)
      - [A14G](#a14g)
    - [Fifteenth Test Part](#fifteenth-test-part)
      - [A15A](#a15a)
      - [A15B](#a15b)
      - [A15C](#a15c)
      - [A15D](#a15d)
    - [Sixteenth Test Part](#sixteenth-test-part)
      - [A16A](#a16a)
      - [A16B](#a16b)
      - [A16C](#a16c)
      - [A16D](#a16d)
    - [Seventeenth Test Part](#seventeenth-test-part)
      - [A17A](#a17a)
      - [A17B](#a17b)
      - [A17C](#a17c)
      - [A17D](#a17d)
      - [A17E](#a17e)
    - [Eighteenth Test Part](#eighteenth-test-part)
      - [A18A](#a18a)
      - [A18B](#a18b)
      - [A18C](#a18c)
      - [A18D](#a18d)
  - [ProgramTests.cs](#programtestscs)
    - [First Test Part](#first-test-part-1)
      - [B1A](#b1a)
      - [B1B](#b1b)
      - [B1C](#b1c)
      - [B1D](#b1d)
      - [B1E](#b1e)
    - [Second Test Part](#second-test-part-1)
      - [B2A](#b2a)
      - [B2B](#b2b)
      - [B2C](#b2c)
      - [B2D](#b2d)
      - [B2E](#b2e)
    - [Third Test Part](#third-test-part-1)
      - [B3A](#b3a)
      - [B3B](#b3b)
      - [B3C](#b3c)
      - [B3D](#b3d)
    - [Fourth Test Part](#fourth-test-part-1)
      - [B4A](#b4a)
      - [B4B](#b4b)
      - [B4C](#b4c)
      - [B4D](#b4d)
      - [B4E](#b4e)
    - [Fifth Test Part](#fifth-test-part-1)
      - [B5A](#b5a)
      - [B5B](#b5b)
      - [B5C](#b5c)
    - [Sixth Test Part](#sixth-test-part-1)
      - [B6A](#b6a)
      - [B6B](#b6b)
      - [B6C](#b6c)
      - [B6D](#b6d)
      - [B6E](#b6e)
    - [Seventh Test Part](#seventh-test-part-1)
      - [B7A](#b7a)
      - [B7B](#b7b)
      - [B7C](#b7c)
      - [B7D](#b7d)
      - [B7E](#b7e)
    - [Eighth Test Part](#eighth-test-part)
    - [B8A](#b8a)
    - [B8B](#b8b)

</details>

## Tests.cs

The tests have been divided into different parts.
Each part has its own tests, all related to each other.

### First Test Part

**TITLE: Tank Default Constructor Tests Overview:**

#### A1A

**TITLE: Tank_DefaultConstructor_CreatesTankWithRandomCapacity():**

`
This test verifies that the default constructor of the Tank class creates a tank object with a randomly assigned capacity. The capacity value is not specified, and the test ensures that a tank is instantiated with a capacity value that falls within a specified range.
`

#### A1B

**TITLE: Tank_DefaultConstructor_CreatesDifferentRandomCapacityTanks():**

`
This test aims to confirm that multiple instances of the Tank class, created using the default constructor, have different randomly assigned capacity values. By repeating the instantiation process, this test ensures that each tank object has a unique capacity.
`

#### A1C

**TITLE: Tank_DefaultConstructor_CreatesTankWithCapacityWithinRange():**

`
The purpose of this test is to validate that the default constructor of the Tank class creates a tank object with a capacity that falls within a specified range. Unlike the first test, which checks for random capacity, this test ensures the capacity adheres to specific limits.
`

#### A1D

**TITLE: Tank_DefaultConstructor_CreatesTankWithEmptyWineArray():**

`
This test focuses on verifying that the default constructor initializes the wine array of a tank object as empty. The wine array represents the contents of the tank, and this test ensures that it is initially empty upon instantiation.
`

#### A1E

**TITLE: Tank_DefaultConstructor_InitializesCapacityAndWineArray():**

`
The final test in the list confirms that the default constructor of the Tank class successfully initializes both the capacity and wine array of a tank object. It ensures that both properties are set to their initial values, with the capacity falling within a specified range and the wine array being empty.
`

### Second Test Part

**TITLE: Tank Constructor with Capacity Tests Overview:**

#### A2A

**TITLE: Tank_ConstructorWithCapacity_CreatesTankWithGivenCapacity():**

`
This test ensures that the Tank class constructor with a specified capacity parameter successfully creates a tank object with the given capacity. The constructor is expected to set the capacity of the tank to the specified value.
`

#### A2B

**TITLE: Tank_ConstructorWithCapacity_CreatesTankWithZeroWineQuantities():**

`
This test verifies that when using the Tank class constructor with a capacity parameter, the created tank object has all wine quantities initialized to zero. It ensures that the wine array, representing the tank's contents, is initially empty in terms of the quantity of wine.
`

#### A2C

**TITLE: Tank_ConstructorWithCapacity_ThrowsExceptionForNegativeCapacity():**

`
The purpose of this test is to validate that the Tank class constructor with a capacity parameter throws an exception when provided with a negative capacity value. It ensures that attempting to create a tank with a negative capacity results in an appropriate error or exception being raised.
`

#### A2D

**TITLE: Tank_ConstructorWithCapacity_InitializesCapacityAndWineArray():**

`
This test confirms that the Tank class constructor with a capacity parameter successfully initializes both the capacity and wine array of the tank object. It ensures that the capacity is set to the specified value, and the wine array is initially empty.
`

#### A2E

**TITLE: Tank_ConstructorWithCapacity_CreatesTankWithCorrectCapacityAndEmptyWineArray():**

`
This test combines the validation of both the capacity and wine array initialization. It ensures that the Tank class constructor with a capacity parameter creates a tank object with the correct capacity and an empty wine array, representing that the tank is initially empty.
`

### Third Test Part

**TITLE: Tank Constructor Tests with Wine Array Overview:**

#### A3A

**TITLE: Tank_ConstructorWithEmptyWineArray_SetsCapacityToZero():**

`
This test ensures that the Tank class constructor with an empty wine array parameter sets the capacity of the tank to zero. It verifies that when initializing a tank with no wines, the capacity is correctly set to zero.
`

#### A3B

**TITLE: Tank_ConstructorWithWines_CalculatesTotalCapacityFromWinesWithPositiveQuantities():**

`
The purpose of this test is to validate that the Tank class constructor with a wine array parameter accurately calculates the total capacity of the tank based on wines with positive quantities. It ensures that the constructor sums up the quantities of all wines to determine the total capacity.
`

#### A3C

**TITLE: Tank_ConstructorWithWines_CalculatesTotalCapacityFromWinesWithZeroQuantities():**

`
This test verifies that the Tank class constructor with a wine array parameter correctly calculates the total capacity of the tank, even when some wines have zero quantities. It ensures that wines with zero quantities are included in the capacity calculation.
`

#### A3D

**TITLE: Tank_ConstructorWithWines_CalculatesTotalCapacityFromWinesWithNegativeQuantities():**

`
This test validates that the Tank class constructor with a wine array parameter correctly calculates the total capacity of the tank, considering wines with negative quantities. It ensures that the constructor correctly accounts for wines with negative quantities when determining the overall capacity.
`

#### A3E

**TITLE: Tank_ConstructorWithWines_CalculatesTotalCapacityFromMixedQuantities():**

`
The final test in the list combines wines with positive, zero, and negative quantities. It verifies that the Tank class constructor with a wine array parameter accurately calculates the total capacity of the tank, taking into account wines with mixed quantities. It ensures that the constructor correctly handles and sums up the quantities to determine the final capacity.
`

### Fourth Test Part

**TITLE: Operator Plus Tests for Wine Addition:**

#### A4A

**TITLE: OperatorPlus_AddTwoZeroQuantityWines_ReturnsWineWithZeroQuantity():**

`
This test verifies that the operator plus function (+) correctly adds two wines with zero quantities and returns a wine with a quantity of zero. It ensures that the addition of wines with no quantity results in a wine with zero quantity.
`

#### A4B

**TITLE: OperatorPlus_AddTwoPositiveQuantityWines_ReturnsWineWithSumOfQuantities():**

`
This test ensures that the operator plus function (+) accurately adds two wines with positive quantities and returns a wine with the sum of their quantities. It validates that the addition of wines with positive quantities yields a wine with the correct total quantity.
`

#### A4C

**TITLE: OperatorPlus_AddWineWithPositiveQuantityAndWineWithZeroQuantity_ReturnsWineWithPositiveQuantity():**

`
This test validates that the operator plus function (+) correctly adds a wine with a positive quantity and a wine with a zero quantity. It ensures that the addition of a wine with a positive quantity to a wine with no quantity results in a wine with a positive quantity.
`

#### A4D

**TITLEOperatorPlus_AddWineWithNegativeQuantityAndWineWithPositiveQuantity_ReturnsWineWithCorrectQuantity():**

`
This test verifies that the operator plus function (+) accurately adds a wine with a negative quantity and a wine with a positive quantity. It ensures that the addition of a wine with a negative quantity and a wine with a positive quantity returns a wine with the correct quantity.
`

#### A4E

**TITLE: OperatorPlus_AddWineWithNegativeQuantityAndWineWithZeroQuantity_ReturnsWineWithNegativeQuantity():**

`
The final test in the list ensures that the operator plus function (+) correctly adds a wine with a negative quantity and a wine with no quantity. It validates that the addition of a wine with a negative quantity and a wine with no quantity returns a wine with the correct negative quantity.
`

### Fifth Test Part

#### A5A

**TITLE: OperatorMinus_SubtractZeroQuantityWine_ReturnsOriginalQuantity():**

`
This test ensures that the operator minus function (-) correctly subtracts a wine with a zero quantity from another wine, and returns the original quantity of the latter wine. It validates that subtracting a wine with no quantity does not affect the quantity of the original wine.
`

#### A5B

**TITLE: OperatorMinus_SubtractWineWithFloatQuantity_SubtractsQuantities():**

`
This test verifies that the operator minus function (-) accurately subtracts a wine with a floating-point quantity from another wine, and returns the result as the difference between their quantities. It ensures that the subtraction of wines with floating-point quantities is correctly calculated.
`

#### A5C

**TITLE: OperatorMinus_SubtractWineFromZeroQuantityWine_ReturnsNegativeQuantity():**

`
This test validates that the operator minus function (-) correctly subtracts a wine from another wine with a zero quantity, and returns a negative quantity. It ensures that subtracting a wine from a wine with no quantity results in a negative quantity.
`

#### A5D

**TITLE: OperatorMinus_SubtractWineWithLargeQuantity_SubtractsQuantities():**

`
The final test in the list ensures that the operator minus function (-) accurately subtracts a wine with a large quantity from another wine, and returns the result as the difference between their quantities. It validates the correct calculation of subtraction when dealing with wines with large quantities.
`

### Sixth Test Part

#### A6A

**TITLE: OperatorMultiply_MultiplyTwoZeroQuantityWines_ReturnsWineWithZeroQuantity():**

`
This test ensures that the operator multiply function (*) correctly multiplies two wines with zero quantities and returns a wine with a quantity of zero. It validates that the multiplication of wines with no quantity results in a wine with zero quantity.
`

#### A6B

**TITLE: OperatorMultiply_MultiplyWineWithZeroQuantityAndWineWithPositiveQuantity_ReturnsWineWithZeroQuantity():**

`
This test verifies that the operator multiply function (*) correctly multiplies a wine with a zero quantity by a wine with a positive quantity, and returns a wine with a quantity of zero. It ensures that when multiplying a wine with no quantity by a wine with a positive quantity, the result is a wine with zero quantity.
`

#### A6C

**TITLE: OperatorMultiply_MultiplyWineWithPositiveQuantityAndWineWithZeroQuantity_ReturnsWineWithZeroQuantity():**

`
This test validates that the operator multiply function (*) correctly multiplies a wine with a positive quantity by a wine with a zero quantity, and returns a wine with a quantity of zero. It ensures that when multiplying a wine with a positive quantity by a wine with no quantity, the result is a wine with zero quantity.
`

#### A6D

**TITLE: OperatorMultiply_MultiplyTwoPositiveQuantityWines_ReturnsWineWithCorrectMultiplicationResult():**

`
This test ensures that the operator multiply function (*) accurately multiplies two wines with positive quantities and returns a wine with the correct multiplication result. It validates that the multiplication of wines with positive quantities yields a wine with the correct total quantity.
`

#### A6E

**TITLE: OperatorMultiply_MultiplyWineWithPositiveQuantityAndWineWithNegativeQuantity_ReturnsWineWithNegativeQuantity():**

`
The final test in the list verifies that the operator multiply function (*) correctly multiplies a wine with a positive quantity by a wine with a negative quantity, and returns a wine with the correct negative quantity. It ensures that the multiplication of a wine with a positive quantity by a wine with a negative quantity results in a wine with the correct negative quantity.
`

### Seventh Test Part

**TITLE: OperatorDivide Tests for Wine Division:**

#### A7A

**TITLE: OperatorDivide_DivideWineWithZeroQuantityByWineWithPositiveQuantity_ReturnsWineWithZeroQuantity():**

`
This test ensures that the operator divide function (/) correctly divides a wine with a zero quantity by a wine with a positive quantity and returns a wine with a quantity of zero. It validates that dividing a wine with no quantity by a wine with a positive quantity results in a wine with zero quantity.
`

#### A7B

**TITLE: OperatorDivide_DivideWineWithPositiveQuantityByWineWithZeroQuantity_ThrowsDivideByZeroException():**

`
This test verifies that the operator divide function (/) correctly throws a divide by zero exception when attempting to divide a wine with a positive quantity by a wine with no quantity. It ensures that dividing a wine with a positive quantity by a wine with no quantity is not allowed and results in an exception.
`

#### A7C

**TITLE: OperatorDivide_DivideWineWithPositiveQuantityByWineWithPositiveQuantity_ReturnsWineWithCorrectDivisionResult():**

`
This test ensures that the operator divide function (/) accurately divides a wine with a positive quantity by another wine with a positive quantity and returns a wine with the correct division result. It validates that the division of wines with positive quantities yields a wine with the correct divided quantity.
`

#### A7D

**TITLE: OperatorDivide_DivideWineWithNegativeQuantityByWineWithPositiveQuantity_ReturnsWineWithNegativeQuantity():**

`
This test verifies that the operator divide function (/) correctly divides a wine with a negative quantity by a wine with a positive quantity and returns a wine with the correct negative quantity. It ensures that dividing a wine with a negative quantity by a wine with a positive quantity results in a wine with the correct negative quantity.
`

#### A7E

**TITLE: OperatorDivide_DivideWineWithNegativeQuantityByWineWithNegativeQuantity_ReturnsWineWithPositiveQuantity():**

`
The final test in the list validates that the operator divide function (/) correctly divides a wine with a negative quantity by another wine with a negative quantity and returns a wine with the correct positive quantity. It ensures that the division of wines with negative quantities results in a wine with the correct positive quantity.
`

### Eight Test Part

**TITLE: Node Traversal Tests Overview:**

#### A8A

**TITLE: TestNodeTraversal():**

`
This test aims to verify the node traversal functionality in a "Tank" object using a simulated array of nodes. Here's a brief summary in English:
The purpose of this test is to ensure that the node traversal in a "Tank" object meets specific conditions. The test creates a simulated array of nodes and initializes them with different quantities. It then calls the "TraverseNodes" method and verifies the results. The assertions check that the number of results is correct, each node has a quantity within a valid range, and each node differs from its parent and siblings by at least 5 units. The test helps validate the correctness of the node traversal logic in the "Tank" object.
`

### Ninth Test Part

**TITLE: Is Moving Away Tests Overview:**

#### A9A

**TITLE: IsMovingAwayTest_1():**

`
This test case checks whether the IsMovingAway method correctly returns false when called with three tanks, parent, child, and target, all having a health value of 50. The IsMovingAway method determines if the tanks are moving away from each other.
`

#### A9B

**TITLE: IsMovingAwayTest_2():**

`
This test case examines the behavior of the IsMovingAway method with different tank health values. The test sets up three tanks (parent, child, and target) with health values of 60, 55, and 65, respectively.
`

#### A9C

**TITLE: IsMovingAwayTest_3():**

`
This test case checks whether the IsMovingAway method correctly returns false when called with three tanks (parent, child, and target) having health values of 100, 80, and 85 respectively. The test verifies that the tanks are not moving away from each other.
`

#### A9D

**TITLE: IsMovingAwayTest_4():**

`
This test case examines the behavior of the IsMovingAway method with different tank health values. The test sets up three tanks (parent, child, and target) with health values of 85, 95, and 100, respectively.
`

#### A9E

**TITLE: IsMovingAwayTest_5():**

`
This test case examines the behavior of the IsMovingAway method with different tank health values. The test sets up three tanks: parent, child, and target with health values of 100, 100, and 110, respectively.
`

#### A9F

**TITLE: IsMovingAwayTest_6():**

`
This test case examines the behavior of the IsMovingAway method with different tank health values. The test sets up three tanks: parent, child, and target with health values of 100, 110, and 110, respectively.
`

### Tenth Test Part

**TITLE: Similarity Tests Overview:**

#### A10A

**TITLE: Similarity_BothArraysNull_ThrowsArgumentException():**

`
Sets both input arrays a and b to null.
Calls the Program.Similarity method with the null arrays.
Expects an ArgumentException to be thrown.
If the exception is thrown, the test passes.
`

#### A10B

**Similarity_ArraysEmpty_ThrowsArgumentException():**

`
Creates empty arrays a and b of type Tank.
Calls the Program.Similarity method with the empty arrays.
Expects an ArgumentException to be thrown.
If the exception is thrown, the test passes.
`

#### A10C

**TITLE: Similarity_ValidInput_ReturnsExpectedSimilarity_1():**

`
Creates two arrays a and b of type Tank, each containing three Tank objects with a capacity of 100.
Defines the expected similarity value as 6.
Calls the Program.Similarity method with arrays a and b.
Compares the returned similarity value with the expected value using Assert.AreEqual.
If the values are equal, the test passes.
`

#### A10D

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

#### A11A

**TITLE: TransferTo_ArraysEmpty():**

`
Verifies that if both input arrays (a and b) are empty, the method Tank.TransferTo throws an exception with the message "Cannot transfer if the total capacity of the tanks is not equal to the capacity of the target tank."
`

#### A11B

**TITLE: TransferTo_ArraysNull():**

`
Verifies that if both input arrays (a and b) are null, the method Tank.TransferTo throws an exception with the message "Cannot transfer if the total capacity of the tanks is not equal to the capacity of the target tank."
`

#### A11C

**TITLE: TransferTo_ArraysTooBig():**

`
Verifies that if the total capacity of input array a is not equal to the capacity of input tank b, the method Tank.TransferTo throws an exception with the message "Cannot transfer if the total capacity of the tanks is not equal to the capacity of the target tank."
`

#### A11D

**TITLE: TransferTo_ArraysValid():**

`
Tests the method TransferTo with valid input arrays (a) and a valid target tank (b) of capacity 200.
Transfers the contents of tanks in array a to tank b if the total capacity of a is equal to the capacity of b.
Asserts that the capacity of tank b after the transfer is 200.
`

#### A11E

**TITLE: TransferTo_ArraysValid_2():**

`
Verifies the behavior of Tank.TransferTo when transferring from an array a with multiple tanks to a target tank b of capacity 200.
If the total capacity of tanks in array a is equal to the capacity of b, the transfer is successful.
Otherwise, an exception with the message "Cannot transfer if the total capacity of the tanks is not equal to the capacity of the target tank" is thrown.
`

#### A11F

**TITLE: TransferTo_ArraysValid_3():**

`
Verifies the behavior of Tank.TransferTo when transferring from an array a with multiple tanks to a target tank b of capacity 100.
If the total capacity of tanks in array a is equal to the capacity of b, the transfer is successful.
Otherwise, an exception with the message "Cannot transfer if the total capacity of the tanks is not equal to the capacity of the target tank" is thrown.
`

### Twelfth Test Part

**TITLE: Fill With One Wine Tests Overview:**

#### A12A

**TITLE: FillWithOneWine_1():**

`
Fills a tank with a capacity of 100 using one wine of quantity 100.
If the tank is empty (no existing wine), sets the quantity of the tank's wine to the tank's capacity (100).
Asserts that the quantity of the tank's wine is 100.
`

#### A12B

**TITLE: FillWithOneWine_2():**

`
Fills a tank with a capacity of 100 using one wine of quantity 50.
If the tank is empty (no existing wine), sets the quantity of the tank's wine to the quantity of the provided wine (50).
Asserts that the quantity of the tank's wine is 50.
`

#### A12C

**TITLE: FillWithOneWine_3():**

`
Fills a tank with a capacity of 100 using one wine of quantity 75.
If the tank is empty (no existing wine), sets the quantity of the tank's wine to the quantity of the provided wine (75).
Asserts that the quantity of the tank's wine is 75.
`

#### A12D

**TITLE: FillWithOneWine_4():**

`
Fills a tank with a capacity of 200 using one wine of quantity 150.
If the tank is empty (no existing wine), sets the quantity of the tank's wine to the quantity of the provided wine (150).
Asserts that the quantity of the tank's wine is 150.
`

#### A12E

**TITLE: FillWithOneWine_5():**

`
Fills a tank with a capacity of 200 using one wine of quantity 50.
If the tank is empty (no existing wine), sets the quantity of the tank's wine to the quantity of the provided wine (50).
Asserts that the quantity of the tank's wine is 50.
`

#### A12F

**TITLE: FillWithOneWine_6():**

`
Fills a tank with a capacity of 200 using one wine of quantity 250.
If the tank is empty (no existing wine), sets the quantity of the tank's wine to the quantity of the provided wine (250).
Asserts that the quantity of the tank's wine is 250.
`

### Thirteenth Test Part

**TITLE: Empty Array Tests Overview:**

#### A13A

**TITLE: EmptyTank_EmptyArray_NoExceptionThrown():**

`
Tests emptying an empty array of wines.
Calls the EmptyTank method with an empty array.
Expects no exceptions to be thrown.
Asserts that the length of the array is 0.
`

#### A13B

**TITLE: EmptyTank_NonEmptyArray_ArrayCleared():**

`
Tests emptying a non-empty array of wines.
Creates an array of wines with three elements.
Calls the EmptyTank method with the array.
Expects the array to be cleared, with all elements set to null.
Asserts that all elements of the array are null.
`

#### A13C

**TITLE: EmptyTank_NullArray_ThrowsNullReferenceException():**

`
Tests emptying a null array of wines.
Initializes the wines array as null.
Expects a NullReferenceException to be thrown when calling the EmptyTank method.
Asserts that the expected exception is thrown.
`

#### A13D

**TITLE: EmptyTank_EmptyArray_NoEffectOnOtherArrays():**

`
Tests emptying an empty array of wines and checks if it affects other arrays.
Initializes one empty wines array and another array with three wines.
Calls the EmptyTank method with the empty array.
Expects the empty array to be cleared, while the other array remains unaffected.
Asserts the length of the empty array is 0 and the length and quantities of the other array remain unchanged.
`

#### A13E

**TITLE: EmptyTank_EmptyArray_KeepsReferenceIntegrity():**

`
Tests emptying an empty array of wines and checks if reference integrity is maintained.
Creates two wine objects and an array of wines referencing those objects.
Calls the EmptyTank method with the array.
Expects the array to be cleared, while the original wine objects remain intact.
Asserts that the elements of the array are null and the original wine objects are not null.
`

#### A13F

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

#### A14A

**TITLE: TankFrom_EmptyTanks_ThrowsExceptionWithExpectedMessage():**

`
Tests the scenario where no tanks are provided.
Initializes an empty array of tanks.
Expects an exception to be thrown when calling the TankFrom method with the empty array.
Asserts that the exception message matches the expected message.
`

#### A14B

**TITLE: TankFrom_SingleTank_ReturnsTankWithCorrectWineQuantities():**

`
Tests the scenario where a single tank is provided.
Creates an array with a single tank.
Sets the capacity and wine quantities of the tank.
Calls the TankFrom method with the array of tanks.
Expects a tank object to be returned with the correct capacity and wine quantities.
Asserts that the returned tank object has the expected capacity and wine quantities.
`

#### A14C

**TITLE: TankFrom_TwoTanks_ReturnsTankWithCorrectWineQuantities():**

`
Tests the scenario where two tanks are provided.
Creates an array with two tanks.
Sets the capacities and wine quantities of the tanks.
Calls the TankFrom method with the array of tanks.
Expects a tank object to be returned with the correct capacity and combined wine quantities.
Asserts that the returned tank object has the expected capacity and combined wine quantities.
`

#### A14D

**TITLE: TankFrom_SingleTankWithZeroCapacity_ReturnsTankWithZeroCapacityAndZeroWineQuantities():**

`
Tests the scenario where a single tank with zero capacity and zero wine quantities is provided.
Creates an array with a single tank.
Sets the capacity and wine quantities of the tank to zero.
Calls the TankFrom method with the array of tanks.
Expects an exception to be thrown due to the tank having zero capacity.
Asserts that the exception is thrown.
`

#### A14E

**TITLE: TankFrom_SingleTankWithNoWineQuantities_ReturnsTankWithZeroCapacityAndZeroWineQuantities():**

`
Tests the scenario where a single tank with no wine quantities is provided.
Creates an array with a single tank.
Sets the capacity of the tank.
Calls the TankFrom method with the array of tanks.
Expects an exception to be thrown due to the tank having no wine quantities specified.
Asserts that the exception is thrown.
`

#### A14F

**TITLE: TankFrom_TwoTanksWithNoWineQuantities_ReturnsTankWithZeroCapacityAndZeroWineQuantities():**

`
Tests the scenario where two tanks with no wine quantities are provided.
Creates an array with two tanks.
Sets the capacities of the tanks to zero.
Calls the TankFrom method with the array of tanks.
Expects an exception to be thrown due to the tanks having no wine quantities specified.
Asserts that the exception is thrown.
`

#### A14G

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

#### A15A

**TITLE: CalculatePercentages_ReturnsCorrectPercentages_1():**

`
Tests the scenario where an array of tanks with different capacities is provided.
Creates an array with three tanks and sets their capacities.
Calls the CalculatePercentages method with the array of tanks.
Expects a new array of tanks with updated capacities representing the percentage of the total capacity.
Asserts that the returned tank objects have the expected capacities.
`

#### A15B

**TITLE: CalculatePercentages_ReturnsCorrectPercentages_2():**

`
Tests the scenario where an array of tanks with different capacities is provided.
Creates an array with four tanks and sets their capacities.
Calls the CalculatePercentages method with the array of tanks.
Expects a new array of tanks with updated capacities representing the percentage of the total capacity.
Asserts that the returned tank objects have the expected capacities.
`

#### A15C

**TITLE: CalculatePercentages_ReturnsZeroPercentForEmptyTanks():**

`
Tests the scenario where a tank with zero capacity is provided.
Creates a tank with zero capacity.
Calls the CalculatePercentages method with the tank.
Expects an exception to be thrown due to the tank having zero capacity.
Asserts that the exception is thrown.
`

#### A15D

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

#### A16A

**TITLE: CalculateSimilarity_ReturnsCorrectDifferences():**

`
Tests the scenario where an array of tanks and a formula of wines are provided.
Creates an array with three tanks and sets their capacities.
Creates an array with three wines and sets their quantities.
Calls the CalculateSimilarity method with the formula and tanks.
Expects a new array of wines with updated quantities representing the differences between the formula and the tanks.
Asserts that the returned wine objects have the expected quantities.
`

#### A16B

**TITLE: CalculateSimilarity_ReturnsZeroDifferences_ForIdenticalFormulaAndTankQuantities():**

`
Tests the scenario where an array of tanks and a formula with identical quantities are provided.
Creates an array with three tanks and sets their capacities.
Creates an array with three wines and sets their quantities to be identical to the tank capacities.
Calls the CalculateSimilarity method with the formula and tanks.
Expects a new array of wines with all quantities set to zero since the formula and tanks are identical.
Asserts that the returned wine objects have quantities equal to zero.
`

#### A16C

**TITLE: CalculateSimilarity_ReturnsPositiveDifferences_WhenFormulaQuantitiesAreGreater():**

`
Tests the scenario where an array of tanks and a formula with greater quantities than the tanks are provided.
Creates an array with three tanks and sets their capacities.
Creates an array with three wines and sets their quantities to be greater than the tank capacities.
Calls the CalculateSimilarity method with the formula and tanks.
Expects a new array of wines with updated quantities representing the negative differences between the formula and the tanks.
Asserts that the returned wine objects have the expected quantities.
`

#### A16D

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

#### A17A

**TITLE: GenerateSumCombinations_ReturnsEmptyList_WhenGivenEmptyInput():**

`
Tests the scenario where an empty array of tanks is provided. Creates an empty array of tanks.
Calls the GenerateSumCombinations method with the empty array.
Expects an empty list as the result.
Asserts that the returned list has a count of 0.
`

#### A17B

**TITLE: GenerateSumCombinations_ReturnsSingleCombination_WhenGivenSingleTank():**

`
Tests the scenario where a single tank is provided.
Creates an array with a single tank and sets its capacity.
Calls the GenerateSumCombinations method with the array of tanks.
Expects a list with a single combination, which contains the tank capacity as the only element.
Asserts that the returned list has a count of 1 and the single combination matches the expected array.
`

#### A17C

**TITLE: GenerateSumCombinations_WhenCalledWithMultipleTanks_ReturnsCorrectCombinations():**

`
Tests the scenario where an array of multiple tanks is provided.
Creates an array with three tanks and sets their capacities.
Calls the GenerateSumCombinations method with the array of tanks.
Expects a list of combinations representing all possible combinations of tank capacities.
Asserts that the returned list has the expected count of combinations.
`

#### A17D

**TITLE: GenerateSumCombinations_WhenCalledWithDifferentTanks_ReturnsCorrectCombinations():**

`
Tests the scenario where an array of tanks with different capacities is provided.
Creates an array with four tanks and sets their capacities.
Calls the GenerateSumCombinations method with the array of tanks.
Expects a list of combinations representing all possible combinations of tank capacities.
Asserts that the returned list has the expected count of combinations.
`

#### A17E

**TITLE: GenerateSumCombinations_WhenCalledWithAdditionalTanks_ReturnsCorrectCombinations():**

`
Tests the scenario where an array of additional tanks is provided.
Creates an array with five tanks and sets their capacities.
Calls the GenerateSumCombinations method with the array of tanks.
Expects a list of combinations representing all possible combinations of tank capacities.
Asserts that the returned list has the expected count of combinations.
`

### Eighteenth Test Part

**TITLE: Check Formula Tests Overview:**

#### A18A

**TITLE: CheckFormula_WhenTheDifferenceBetweenTheFormulaAndTheWineInTank_IsGreaterthanMargin_ReturnFalse():**

`
This test verifies if the CheckFormula method correctly determines whether the difference between the quantities of wine in a tank and the corresponding quantities in a formula exceeds a given margin. It creates a tank with wine quantities [50, 44, 57, 5] and a formula with quantities [50, 40, 60, 10]. The margin is set to 2.0. The test expects the CheckFormula method to return false.
`

#### A18B

**TITLE: GCheckFormula_WhenTheDifferenceBetweenTheFormulaAndTheWineInTank_IsLessthanOrEqualMargin_ReturnTrue():**

`
This test validates if the CheckFormula method accurately determines whether the difference between the quantities of wine in a tank and the corresponding quantities in a formula is within a specified margin. It constructs a tank with wine quantities [10, 20, 30] and a formula with identical quantities. The margin is set to 2.0. The test expects the CheckFormula method to return true.
`

#### A18C

**TITLE: CheckFormula_WhenATankIsEmpty():**

`
This test ensures that the CheckFormula method handles the scenario when a tank is empty. It creates an empty tank and a formula with quantities [10, 20, 30]. The margin is set to 2.0. The test expects the CheckFormula method to return false, indicating that the tank is empty and does not match the formula.
`

#### A18D

**TITLE: CheckFormula_WhenTheFormulaIsEmpty():**

`
This test checks if the CheckFormula method correctly handles the situation when the formula is empty. It generates a tank with quantities [50, 40, 10] and an empty formula. The margin is set to 2.0. The test expects the CheckFormula method to return false, indicating that the formula is empty and does not match the tank.
`

## ProgramTests.cs

### First Test Part

**TITLE: Similarity Point Tests Overview:**

#### B1A

**TITLE: Similarity_ArrayANull_ThrowsArgumentException():**

`
This test checks if the Similarity method handles the scenario when both input arrays (a and b) are null. It expects the method to throw an ArgumentException, indicating that the input arrays cannot be null.
`

#### B1B

**TITLE: Similarity_ArrayBNull_ThrowsArgumentException():**

`
This test verifies if the Similarity method correctly handles the situation when array a is null and array b is not null. It expects the method to throw an ArgumentException, indicating that array a cannot be null while array b is non-null.
`

#### B1C

**TITLE: Similarity_ArrayBNull_ThrowsArgumentException():**

`
This test ensures that the Similarity method properly handles the case when array b is null and array a is not null. It expects the method to throw an ArgumentException, indicating that array b cannot be null while array a is non-null.
`

#### B1D

**TITLE: Similarity_ArraysEmpty_ThrowsArgumentException():**

`
This test validates if the Similarity method handles the scenario when both input arrays (a and b) are empty. It expects the method to throw an ArgumentException, indicating that both input arrays must have elements for comparison.
`

#### B1E

**TITLE: Similarity_ValidArrays_ReturnsSimilarityIndicator():**

`
This test checks if the Similarity method accurately calculates the similarity indicator between two valid arrays (a and b) containing tanks with wine quantities. It creates two arrays with tanks and their respective wine quantities. The method calculates the similarity indicator by comparing the wine quantities in corresponding tanks and returns the result. The test asserts that the calculated similarity indicator matches the expected value of 10, indicating a high level of similarity between the two arrays.
`

### Second Test Part

**TITLE: Simi Point Tests Overview:**

#### B2A

**TITLE: SimiPoint_IdenticalIntegers_ReturnsTwo():**

`
This test verifies if the SimiPoint method correctly calculates the similarity point between two identical integers (c and d). It expects the method to return 2, indicating a high level of similarity between the integers.
`

#### B2B

**TITLE: SimiPoint_FirstIntegerGreaterThanSecond_ReturnsOne():**

`
This test checks if the SimiPoint method correctly determines the similarity point when the first integer (c) is greater than the second integer (d). It expects the method to return 1, indicating a moderate level of similarity between the integers.
`

#### B2C

**TITLE: SimiPoint_FirstIntegerLessThanSecond_ReturnsOne():**

`
This test ensures that the SimiPoint method accurately determines the similarity point when the first integer (c) is less than the second integer (d). It expects the method to return 1, indicating a moderate level of similarity between the integers.
`

#### B2D

**TITLE: SimiPoint_FirstIntegerGreaterButLessThanHalfOfSecond_ReturnsZero():**

`
This test validates if the SimiPoint method correctly handles the scenario when the first integer (c) is greater than the second integer (d) but less than half of the second integer. It expects the method to return 0, indicating a low level of similarity between the integers.
`

#### B2E

**TITLE: SimiPoint_FirstIntegerLessButGreaterThanHalfOfSecond_ReturnsZero():**

`
This test checks if the SimiPoint method properly handles the situation when the first integer (c) is less than the second integer (d) but greater than half of the second integer. It expects the method to return 0, indicating a low level of similarity between the integers.
`

### Third Test Part

**TITLE: Number Of Wine Tests Overview:**

#### B3A

**TITLE: NbrWines_EmptyTankArray_ReturnsZero():**

`
This test verifies if the NbrWines method correctly handles the scenario when the input tank array is empty. It expects the method to return 0, indicating that there are no wines in the tanks.
`

#### B3B

**TITLE: NbrWines_AllTanksWithZeroQuantity_ReturnsZero():**

`
This test checks if the NbrWines method handles the case when all tanks in the input array have zero quantities of wine. It expects the method to return 0, indicating that there are no wines in the tanks.
`

#### B3C

**TITLE: NbrWines_SomeWinesWithNonZeroQuantity_ReturnsCorrectCount():**

`
This test ensures that the NbrWines method accurately calculates the total count of wines in the tanks when there are some wines with non-zero quantities. It expects the method to return 5, indicating that there are a total of 5 wines across the tanks.
`

#### B3D

**TITLE: NbrWines_AllWinesWithNonZeroQuantity_ReturnsTotalWineCount():**

`
This test validates if the NbrWines method correctly calculates the total count of wines when all wines in the tanks have non-zero quantities. It expects the method to return 12, indicating that there are a total of 12 wines across the tanks.
`

### Fourth Test Part

**TITLE: Number of Tanks Test Overview:**

#### B4A

**TITLE: NbrTank_EmptyTankArray_ReturnsZero():**

`
This test verifies if the NbrTank method correctly handles the scenario when the input tank array is empty. It expects the method to return 0, indicating that there are no tanks.
`

#### B4B

**TITLE: NbrTank_AllTanksWithZeroQuantity_ReturnsZero():**

`
This test checks if the NbrTank method handles the case when all tanks in the input array have zero quantities of wine. It expects the method to return 0, indicating that there are no tanks.
`

#### B4C

**TITLE: NbrTank_SomeTanksWithNonZeroQuantity_ReturnsCorrectCount():**

`
This test ensures that the NbrTank method accurately calculates the count of tanks when there are some tanks with non-zero quantities. It expects the method to return 2, indicating that there are a total of 2 tanks with non-zero quantities.
`

#### B4D

**TITLE: NbrTank_AllTanksWithNonZeroQuantity_ReturnsTotalTankCount():**

`
This test validates if the NbrTank method correctly calculates the count of tanks when all tanks in the array have non-zero quantities. It expects the method to return 3, indicating that there are a total of 3 tanks.
`

#### B4E

**TITLE: NbrTank_AllHaveCapacity_ReturnsCorrectCount():**

`
This test checks if the NbrTank method handles the scenario where all tanks have both non-zero quantities and capacity. It expects the method to return 10, indicating that there are a total of 10 tanks.
`

### Fifth Test Part

**TITLE: Number Total of Wine Tests Overview:**

#### B5A

**TITLE: NbrTotalWine_EmptyTankArray_ReturnsZero():**

`
This test verifies if the NbrTotalWine method correctly handles the scenario when the input tank array is empty. It expects the method to return 0, indicating that there is no wine in any tank.
`

#### B5B

**TITLE: NbrTotalWine_TankArrayWithZeroQuantity_ReturnsZero():**

`
This test checks if the NbrTotalWine method handles the case when all tanks in the input array have zero quantities of wine. It expects the method to return 0, indicating that there is no wine in any tank.
`

#### B5C

**TITLE: NbrTotalWine_TankArrayWithPositiveQuantities_ReturnsCorrectTotal():**

`
This test ensures that the NbrTotalWine method accurately calculates the total quantity of wine when there are tanks with positive quantities. It expects the method to return 216, indicating that the total quantity of wine in all tanks is 216.
`

### Sixth Test Part

**TITLE: Similarity Test Overview:**

#### B6A

**TITLE: TestNbrEachWine():**

`
This test verifies if the NbrEachWine method correctly counts the number of wines that appear in both Tank arrays. It sets up two Tank arrays, 'a' and 'b', with the same wines and quantities. It expects the method to return 2, indicating that there are two wines present in both arrays.
`

#### B6B

**TITLE: NbrEachWine_TankAHasDoubleQuantity_ReturnsOne():**

`
This test checks if the NbrEachWine method handles the scenario when the wines in Tank 'a' have double the quantity compared to the wines in Tank 'b'. It expects the method to return 1, indicating that there is one wine present in both arrays, regardless of the difference in quantities.
`

#### B6C

**TITLE: NbrEachWine_TankAHasHalfQuantity_ReturnsOne():**

`
This test ensures that the NbrEachWine method handles the situation when the wines in Tank 'a' have half the quantity compared to the wines in Tank 'b'. It expects the method to return 1, indicating that there is one wine present in both arrays, regardless of the difference in quantities.
`

#### B6D

**TITLE: NbrEachWine_DifferentQuantities_ReturnsZero():**

`
This test checks if the NbrEachWine method returns 0 when the wines in Tank arrays 'a' and 'b' have different quantities. It sets up two Tank arrays with different quantities for the same wines. It expects the method to return 0, indicating that there are no wines present in both arrays.
`

#### B6E

**TITLE: NbrEachWine_DifferentWinesQuantity_ReturnsZero():**

`
This test verifies if the NbrEachWine method correctly handles the case when the Tank arrays 'a' and 'b' have different wines with different quantities. It sets up two Tank arrays with different wines and quantities. It expects the method to return 0, indicating that there are no wines present in both arrays.
`

### Seventh Test Part

**TITLE: Number of Mix Test Overview:**

#### B7A

**TITLE: NbrMix_ReturnsThree():**

`
This test verifies if the NbrMix method correctly counts the number of tanks that have a mix of wines. It sets up a Tank array 'a' with multiple tanks, some of which contain a mix of wines. It expects the method to return 3, indicating that there are three tanks with wine mixes.
`

#### B7B

**TITLE: NbrMix_ReturnsOne():**

`
This test checks if the NbrMix method returns 1 when there is only one tank with a mix of wines in the Tank array 'a'. It expects the method to return 1, indicating that there is one tank with a wine mix.
`

#### B7C

**TITLE: NbrMix_ReturnsTwo():**

`
This test ensures that the NbrMix method handles the case when there are two tanks with wine mixes in the Tank array 'a'. It expects the method to return 2, indicating that there are two tanks with wine mixes.
`

#### B7D

**TITLE: NbrMix_ReturnsFour():**

`
This test verifies if the NbrMix method correctly counts the number of tanks with wine mixes when all the tanks in the Tank array 'a' have wine mixes. It expects the method to return 4, indicating that all the tanks have wine mixes.
`

#### B7E

**TITLE: NbrMix_ReturnsZero():**

`
This test checks if the NbrMix method returns 0 when none of the tanks in the Tank array 'a' have a wine mix. It expects the method to return 0, indicating that there are no tanks with wine mixes.
`

### Eighth Test Part

**TITLE: CSV to Formula Test Overview:**

### B8A

**TITLE: CSVToFormula_One():**

`
This test case verifies the behavior of the CSVToFormula method by providing a valid CSV file path. It reads the CSV file located at the given path and converts it into an array of Wine objects. The expected result is an array of Wine objects with specific quantities. The test compares the expected array with the result array to ensure they are equal using the Assert.AreEqual method.
`

### B8B

**TITLE: CSVToFormula_Two():**

`
This test case checks the exception handling of the CSVToFormula method. It also provides a valid CSV file path, but the code is wrapped in a try-catch block to handle any exceptions that may occur. If an exception is caught, it prints the error message to the console. This test case does not include any assertions.
`
