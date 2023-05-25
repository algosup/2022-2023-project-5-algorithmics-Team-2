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

</details>

## Tests

The tests have been divided into different parts.
Each part has its own tests, all related to each other.

### First Test Part

**TITLE: Tank Default Constructor Tests Overview**

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

**TITLE: Tank Constructor with Capacity Tests Overview**

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

**TITLE: Tank Constructor Tests with Wine Array Overview**

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

**TITLE: Operator Plus Tests for Wine Addition**

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

**TITLE: OperatorDivide Tests for Wine Division**

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
