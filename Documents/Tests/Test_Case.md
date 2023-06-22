# Test Case

<details>
<summary>📖 Table of Content</summary>

- [Test Case](#test-case)
  - [Tests Table](#tests-table)
    - [Tests.cs](#testscs)
    - [ProgramTests.cs](#programtestscs)
  - [Total tests](#total-tests)

</details>

## Tests Table

### Tests.cs

| Test Case ID | Description | Expected Output | Actual Output | Pass/Fail |
| --- | --- | --- | --- | --- |
| Tests.cs | - | - | - | - |
| A1A | Creates a tank with a random capacity | *Random value* | *Same Random value* | **Pass** |
| A1B | Creates a different tank with random capacity | *Random value* | *Same Random value* | **Pass** |
| A1C | Creates a tank with capacity within range | *Random value between 10 and 100* | *Random value between 10 and 100* | **Pass** |
| A1D | Creates a tank with empty wine array | Not 0 | Not 0 | **Pass** |
| A1E | Initializes capacity and wine array | *Not null* | *Not null* | **Pass** |
| A2A | Creates a tank with given capacity | 0 | 0 | **Pass** |
| A2B | Creates a tank with zero wine quantities | 0 | 0 | **Pass** |
| A2C | Throws exception for negative capacity | -10.0f | -10.0f | **Pass** |
| A2D | Initializes capacity and wine array | 50.0f | 50.F | **Pass** |
| A2E | Creates tank with correct capacity and empty wine array | 75.0f | 75.0f | **Pass** |
| A3A | Sets capacity to zero in an empty wine array | 0 | 0 | **Pass** |
| A3B | Calculates total capacity from wines with positive quantities | 100 | 100 | **Pass** |
| A3C | Calculates total capacity from wines with zero quantities | 0 | 0 | **Pass** |
| A3D | Calculates total capacity from wines with negative quantities | -100 | -100 | **Pass** |
| A3E | Calculates total capacity from wines with mixed quantities | 0 | 0 | **Pass** |
| A4A | With the '+' operator, add two zero quantity wines and returns wine with zero quantity | 0 | 0 | **Pass** |
| A4B | With the '+' operator, add two positive quantity wines and returns wine with sum of quantities | 60 | 60 | **Pass** |
| A4C | With the '+' operator, add wine with positive quantity and wine with zero quantity and returns wine with positive quantity | 50 | 50 | **Pass** |
| A4D | With the '+' operator, add wine with positive quantity and wine with negative quantity and returns wine with correct quantity | 20 | 20 | **Pass** |
| A4E | With the '+' operator, add wine with negative quantity and wine with zero quantity and returns wine with negative quantity | -15 | -15 | **Pass** |
| A5A | With the '-' operator, subtract two zero quantity wines and returns original quantity | 30 | 30 | **Pass** |
| A5B | With the '-' operator, subtract wine with float quantity and substract quantities | 20.3f | 20.3f | **Pass** |
| A5C | With the '-' operator, subtract wine from zero quantity wine and returns negative quantity | -10 | -10 | **Pass** |
| A5D | With the '-' operator, subtract wine with large quantity and substract quantities | 500 | 500 | **Pass** |
| A6A | With the '*' operator, multiply two zero quantity wines and returns wine with zero quantity | 0 | 0 | **Pass** |
| A6B | With the '*' operator, multiply wine with zero quantity and wine with positive quantity and returns wine with zero quantity | 0 | 0 | **Pass** |
| A6C | With the '*' operator, multiply wine with positive quantity and wine with zero quantity and returns wine with zero quantity | 0 | 0 | **Pass** |
| A6D | With the '*' operator, multiply two positive quantity wines and returns wine with correct multiplication result | 50 | 50 | **Pass** |
| A6E | With the '*' operator, multiply wine with positive quantity and wine with negative quantity and returns wine with negative quantity | -30 | -30 | **Pass** |
| A7A | With the '/' operator, divide wine with zero quantity by wine with positive quantity and returns wine with zero quantity | 0 | 0 | **Pass** |
| A7B | With the '/' operator, divide wine with positive quantity by wine with zero quantity / throws divide by zero exception | *Exception* | *Exception* | **Pass** |
| A7C | With the '/' operator, divide wine with positive quantity by wine with positive quantity returns wine with correct division result | 5 | 5 | **Pass** |
| A7D | With the '/' operator, divide wine with negative quantity by wine with positive quantity returns wine with negative quantity | -5 | -5 | **Pass** |
| A7E | With the '/' operator, divide wine with negative quantity by wine with negative quantity returns wine with positive quantity | 5 | 5 | **Pass** |
| A8A | Compare 2 grids with values by crossing the nodes | 400 | Assert "399 is too near of 400" | **Pass** |
| A9A | IsMovingAway method determines if the tanks are moving away from each other| 50 | 50 | **Pass** |
| A9B | IsMovingAway method with different tank health values | 60, 55, 65 | 60, 55, 65 | **Pass** |
| A9C | IsMovingAway method correctly returns false when called with three tanks | 100, 80, 85 | 100, 80, 85 | **Pass** |
| A9D | IsMovingAway method with different tank health values | 85, 95, 100 | 85, 95, 100 | **Pass** |
| A9E | IsMovingAway method with different tank health values | 100, 100, 110 | 100, 100, 110 | **Pass** |
| A9F | IsMovingAway method with different tank health values | 100, 110, 110 | 100, 110, 110 | **Pass** |
| A10A | Sets both input arrays a and b to null | *Exception* | *Exception* | **Pass** |
| A10B | Creates empty arrays a and b of type Tank | *new Tank[0], new Tank[0]* | *Exception* | **Pass** |
| A10C | Creates two arrays a and b of type Tank | *a, b* | 6 | **Pass** |
| A10D | Creates two arrays a and b of type Tank | *a, b* | 10 | **Pass** |
| A11A | Verifies that if both input arrays (a and b) are empty | *empty* | *empty* | **Pass** |
| A11B | Verifies that if both input arrays (a and b) are null | *Null* | *Null* | **Pass** |
| A11C | Verifies that if the total capacity of input array 'a' is not equal to the capacity of input tank 'b' | *Exception* | *Exception* | **Pass** |
| A11D | TransferTo with valid input arrays 'a' and a valid target tank 'b' of capacity 200 | 200 | 200 | **Pass** |
| A11E | TransferTo when transferring from an array 'a' with multiple tanks to a target tank 'b' of capacity 200 | 200 | 200 | **Pass** |
| A11F | TransferTo when transferring from an array 'a' with multiple tanks to a target tank 'b' of capacity 100 | 100 | 100 | **Pass** |
| A12A | Fills a tank with a capacity of 100 using one wine of quantity 100 | 100 | 100 | **Pass** |
| A12B | Fills a tank with a capacity of 100 using one wine of quantity 50 | 50 | 50 | **Pass** |
| A12C | Fills a tank with a capacity of 100 using one wine of quantity 75 | 75 | 75 | **Pass** |
| A12D | Fills a tank with a capacity of 200 using one wine of quantity 150 | 150 | 150 | **Pass** |
| A12E | Fills a tank with a capacity of 200 using one wine of quantity 50 | 50 | 50 | **Pass** |
| A12F | Fills a tank with a capacity of 200 using one wine of quantity 250 | 250 | 250 | **Pass** |
| A13A | Tests emptying an empty array of wines | 0 | 0 | **Pass** |
| A13B | Tests emptying a non-empty array of wines | *Null* | *Null* | **Pass** |
| A13C | Tests emptying a null array of wines | *Exception* | *Exception* | **Pass** |
| A13D | Tests emptying an empty array of wines and checks if it affects other arrays | 0 | 0 | **Pass** |
| A13E | Tests emptying an empty array of wines and checks if reference integrity is maintained | *Not Null* | *Not Null* | **Pass** |
| A13F | Tests emptying an array of wines with null elements | *Only non-null elements* | *Only non-null elements* | **Pass** |
| A14A | Tests the scenario where no tanks are provided | *Exception* | *Exception* | **Pass** |
| A14B | Tests the scenario where a single tank is provided | *Exception* | *Exception* | **Pass** |
| A14C | Tests the scenario where two tanks are provided | *Exception* | *Exception* | **Pass** |
| A14D | Tests the scenario where a single tank with zero capacity and zero wine quantities is provided | *Exception* | *Exception* | **Pass** |
| A14E | Tests the scenario where a single tank with no wine quantities is provided | *Exception* | *Exception* | **Pass** |
| A14F | Tests the scenario where two tanks with no wine quantities are provided | *Exception* | *Exception* | **Pass** |
| A14G | Tests the scenario where two tanks with empty wines are provided | *Exception* | *Exception* | **Pass** |
| A15A | Tests the scenario where an array of tanks with different capacities is provided | *Return tank objects with expected capacities* | *Return tank objects with expected capacities* | **Pass** |
| A15B | Tests the scenario where an array of tanks with different capacities is provided | *Return tank objects with expected capacities* | *Return tank objects with expected capacities* | **Pass** |
| A15C | Tests the scenario where a tank with zero capacity is provided | *Return tank objects with expected capacities* | *Return tank objects with expected capacities* | **Pass** |
| A15D | Tests the scenario where an array of tanks with equal capacities is provided | *Return tank objects with expected capacities* | *Return tank objects with expected capacities* | **Pass** |
| A16A | Tests the scenario where an array of tanks and a formula of wines are provided | *Return wine objects with expected quantities* | *Return wine objects with expected quantities* | **Pass** |
| A16B | Tests the scenario where an array of tanks and a formula with identical quantities are provided | *Return wine objects with expected quantities* | *Return wine objects with expected quantities* | **Pass** |
| A16C | Tests the scenario where an array of tanks and a formula with greater quantities than the tanks are provided | *Return wine objects with expected quantities* | *Return wine objects with expected quantities* | **Pass** |
| A16D | Tests the scenario where an array of tanks and a formula with smaller quantities than the tanks are provided | *Return wine objects with expected quantities* | *Return wine objects with expected quantities* | **Pass** |
| A17A | Tests the scenario where an empty array of tanks is provided | 0 | 0 | **Pass** |
| A17B | Tests the scenario where a single tank is provided | 1 | 1 | **Pass** |
| A17C | Tests the scenario where an array of multiple tanks is provided | *Expected count of combinations* | *Expected count of combinations* | **Pass** |
| A17D | Tests the scenario where an array of tanks with different capacities is provided | *Expected count of combinations* | *Expected count of combinations* | **Pass** |
| A17E | Tests the scenario where an array of additional tanks is provided | *Expected count of combinations* | *Expected count of combinations* | **Pass** |
| A18A | Checks whether the difference between the quantities of wine in a tank and the corresponding quantities in a formula is greater than a given margin | 2.0 | 2.0 | **Pass** |
| A18B | Checks whether the difference between the quantities of wine in a tank and the corresponding quantities in a formula is less than or equal to a given margin | 2.0 | 2.0 | **Pass** |
| A18C | Checks whether the CheckFormula method handles the case when a tank is empty | *empty* | *empty* | **Pass** |
| A18D | Checks whether the CheckFormula method handles the case when the formula is empty | *empty* | *empty* | **Pass** |

### ProgramTests.cs

| Test Case ID | Description | Expected Output | Actual Output | Pass/Fail |
| --- | --- | --- | --- | --- |
| B1A | Checks if the Similarity method handles the scenario when both input arrays (a and b) are null | *Not null* | *Not null* | **Pass** |
| B1B | Verifies if the Similarity method correctly handles the situation when array a is null and array b is not null. | *Null* & *Not null* | *Null* & *Not null* | **Pass** |
| B1C | Ensures that the Similarity method properly handles the case when array b is null and array a is not null | *Not null* & *Null* | *Not null* & *Null* | **Pass** |
| B1D | Validates if the Similarity method handles the scenario when both input arrays (a and b) are empty | *empty* | *empty* | **Pass** |
| B1E | Checks if the Similarity method accurately calculates the similarity indicator between two valid arrays (a and b) containing tanks with wine quantities | 10 | 10 | **Pass** |
| B2A | Verifies if the SimiPoint method correctly calculates the similarity point between two identical integers (c and d) | 2 | 2 | **Pass** |
| B2B | Checks if the SimiPoint method correctly determines the similarity point when the first integer (c) is greater than the second integer (d) | 1 | 1 | **Pass** |
| B2C | Ensures that the SimiPoint method accurately determines the similarity point when the first integer (c) is less than the second integer (d) | 1 | 1 | **Pass** |
| B2D | Validates if the SimiPoint method correctly handles the scenario when the first integer (c) is greater than the second integer (d) but less than half of the second integer | 0 | 0 | **Pass** |
| B2E | Checks if the SimiPoint method properly handles the situation when the first integer (c) is less than the second integer (d) but greater than half of the second integer | 0 | 0 | **Pass** |
| B3A | Verifies if the NbrWines method correctly handles the scenario when the input tank array is empty | 0 | 0 | **Pass** |
| B3B | Checks if the NbrWines method handles the case when all tanks in the input array have zero quantities of wine | 0 | 0 | **Pass** |
| B3C | Ensures that the NbrWines method accurately calculates the total count of wines in the tanks when there are some wines with non-zero quantities | 5 | 5 | **Pass** |
| B3D | Validates if the NbrWines method correctly calculates the total count of wines when all wines in the tanks have non-zero quantities | 12 | 12 | **Pass** |
| B4A | Verifies if the NbrTank method correctly handles the scenario when the input tank array is empty | 0 | 0 | **Pass** |
| B4B | Checks if the NbrTank method handles the case when all tanks in the input array have zero quantities of wine | 0 | 0 | **Pass** |
| B4C | Ensures that the NbrTank method accurately calculates the count of tanks when there are some tanks with non-zero quantities | 2 | 2 | **Pass** |
| B4D | Validates if the NbrTank method correctly calculates the count of tanks when all tanks in the array have non-zero quantities | 3 | 3 | **Pass** |
| B4E | Checks if the NbrTank method handles the scenario where all tanks have both non-zero quantities and capacity | 10 | 10 | **Pass** |
| B5A | This test verifies if the NbrTotalWine method correctly handles the scenario when the input tank array is empty | 0 | 0 | **Pass** |
| B5B | This test checks if the NbrTotalWine method handles the case when all tanks in the input array have zero quantities of wine | 0 | 0 | **Pass** |
| B5C | This test ensures that the NbrTotalWine method accurately calculates the total quantity of wine when there are tanks with positive quantities | 216 | 216 | **Pass** |
| B6A | This test verifies if the NbrEachWine method correctly counts the number of wines that appear in both Tank arrays | 2 | 2 | **Pass** |
| B6B | This test checks if the NbrEachWine method handles the scenario when the wines in Tank 'a' have double the quantity compared to the wines in Tank 'b' | 1 | 1 | **Pass** |
| B6C | This test ensures that the NbrEachWine method handles the situation when the wines in Tank 'a' have half the quantity compared to the wines in Tank 'b' | 1 | 1 | **Pass** |
| B6D | This test checks if the NbrEachWine method returns 0 when the wines in Tank arrays 'a' and 'b' have different quantities | 0 | 0 | **Pass** |
| B6E | This test verifies if the NbrEachWine method correctly handles the case when the Tank arrays 'a' and 'b' have different wines with different quantities | 0 | 0 | **Pass** |
| B7A | This test verifies if the NbrMix method correctly counts the number of tanks that have a mix of wines | 3 | 3 | **Pass** |
| B7B | This test checks if the NbrMix method returns 1 when there is only one tank with a mix of wines in the Tank array 'a' | 1 | 1 | **Pass** |
| B7C | This test ensures that the NbrMix method handles the case when there are two tanks with wine mixes in the Tank array 'a' | 2 | 2 | **Pass** |
| B7D | This test verifies if the NbrMix method correctly counts the number of tanks with wine mixes when all the tanks in the Tank array 'a' have wine mixes | 4 | 4 | **Pass** |
| B7E | This test checks if the NbrMix method returns 0 when none of the tanks in the Tank array 'a' have a wine mix | 0 | 0 | **Pass** |
| B8A | This test case verifies the behavior of the CSVToFormula method by providing a valid CSV file path | *Array of Wine objects with specific quantities* | *Array of Wine objects with same specific quantities* | **Pass** |
| B8B | This test case checks the exception handling of the CSVToFormula method | `Console.WriteLine()` | `Console.WriteLine()` | **Pass** |

## Total tests

Tests: 121, Passed: 121, Failed: 0, Skipped: 0
