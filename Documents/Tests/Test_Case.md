# Test Case

<details>
<summary>📖 Table of Content</summary>

- [Test Case](#test-case)
  - [Tests Table](#tests-table)
  - [Total tests](#total-tests)

</details>

## Tests Table

| Test Case ID | Description | Expected Output | Actual Output | Pass/Fail |
| --- | --- | --- | --- | --- |
| 1A | Creates a tank with a random capacity | Random value | Same Random value | **Pass** |
| 1B | Creates a different tank with random capacity | Random value | Same Random value | **Pass** |
| 1C | Creates a tank with capacity within range | Random value between 10 and 100 | Random value between 10 and 100 | **Pass** |
| 1D | Creates a tank with empty wine array | 0 | Not 0 | **Pass** |
| 1E | Initializes capacity and wine array | Not null | Not null | **Pass** |
| 2A | Creates a tank with given capacity | 0 | 0 | **Pass** |
| 2B | Creates a tank with zero wine quantities | 0 | 0 | **Pass** |
| 2C | Throws exception for negative capacity | -10.0f | -10.0f | **Pass** |
| 2D | Initializes capacity and wine array | 50.0f | 50.F | **Pass** |
| 2E | Creates tank with correct capacity and empty wine array | 75.0f | 75.0f | **Pass** |
| 3A | Sets capacity to zero in an empty wine array | 0 | 0 | **Pass** |
| 3B | Calculates total capacity from wines with positive quantities | 100 | 100 | **Pass** |
| 3C | Calculates total capacity from wines with zero quantities | 0 | 0 | **Pass** |
| 3D | Calculates total capacity from wines with negative quantities | -100 | -100 | **Pass** |
| 3E | Calculates total capacity from wines with mixed quantities | 0 | 0 | **Pass** |
| 4A | With the '+' operator, add two zero quantity wines and returns wine with zero quantity | 0 | 0 | **Pass** |
| 4B | With the '+' operator, add two positive quantity wines and returns wine with sum of quantities | 60 | 60 | **Pass** |
| 4C | With the '+' operator, add wine with positive quantity and wine with zero quantity and returns wine with positive quantity | 50 | 50 | **Pass** |
| 4D | With the '+' operator, add wine with positive quantity and wine with negative quantity and returns wine with correct quantity | 20 | 20 | **Pass** |
| 4E | With the '+' operator, add wine with negative quantity and wine with zero quantity and returns wine with negative quantity | -15 | -15 | **Pass** |
| 5A | With the '-' operator, subtract two zero quantity wines and returns original quantity | 30 | 30 | **Pass** |
| 5B | With the '-' operator, subtract wine with float quantity and substract quantities | 20.3f | 20.3f | **Pass** |
| 5C | With the '-' operator, subtract wine from zero quantity wine and returns negative quantity | -10 | -10 | **Pass** |
| 5D | With the '-' operator, subtract wine with large quantity and substract quantities | 500 | 500 | **Pass** |
| 6A | With the '*' operator, multiply two zero quantity wines and returns wine with zero quantity | 0 | 0 | **Pass** |
| 6B | With the '*' operator, multiply wine with zero quantity and wine with positive quantity and returns wine with zero quantity | 0 | 0 | **Pass** |
| 6C | With the '*' operator, multiply wine with positive quantity and wine with zero quantity and returns wine with zero quantity | 0 | 0 | **Pass** |
| 6D | With the '*' operator, multiply two positive quantity wines and returns wine with correct multiplication result | 50 | 50 | **Pass** |
| 6E | With the '*' operator, multiply wine with positive quantity and wine with negative quantity and returns wine with negative quantity | -30 | -30 | **Pass** |
| 7A | With the '/' operator, divide wine with zero quantity by wine with positive quantity and returns wine with zero quantity | 0 | 0 | **Pass** |
| 7B | With the '/' operator, divide wine with positive quantity by wine with zero quantity / throws divide by zero exception | *Exception* | *Exception* | **Pass** |
| 7C | With the '/' operator, divide wine with positive quantity by wine with positive quantity returns wine with correct division result | 5 | 5 | **Pass** |
| 7D | With the '/' operator, divide wine with negative quantity by wine with positive quantity returns wine with negative quantity | -5 | -5 | **Pass** |
| 7E | With the '/' operator, divide wine with negative quantity by wine with negative quantity returns wine with positive quantity | 5 | 5 | **Pass** |
| 8A | Compare 2 grids with values by crossing the nodes | 400 | Assert "399 is too near of 400" | **Pass** |
| 9A | IsMovingAway method determines if the tanks are moving away from each other| 50 | 50 | **Pass** |
| 9B | IsMovingAway method with different tank health values | 60, 55, 65 | 60, 55, 65 | **Pass** |
| 9C | IsMovingAway method correctly returns false when called with three tanks | 100, 80, 85 | 100, 80, 85 | **Pass** |
| 9D | IsMovingAway method with different tank health values | 85, 95, 100 | 85, 95, 100 | **Pass** |
| 9E | IsMovingAway method with different tank health values | 100, 100, 110 | 100, 100, 110 | **Pass** |
| 9F | IsMovingAway method with different tank health values | 100, 110, 110 | 100, 110, 110 | **Pass** |
| 10A | Sets both input arrays a and b to null | *null, null* | *Exception* | **Pass** |
| 10B | Creates empty arrays a and b of type Tank | *new Tank[0], new Tank[0]* | *Exception* | **Pass** |
| 10C | Creates two arrays a and b of type Tank | *a, b* | 6 | **Pass** |
| 10D | Creates two arrays a and b of type Tank | *a, b* | 10 | **Pass** |
| 11A | Verifies that if both input arrays (a and b) are empty | *empty* | *empty* | **Pass** |
| 11B | Verifies that if both input arrays (a and b) are null | *Null* | *Null* | **Pass** |
| 11C | Verifies that if the total capacity of input array 'a' is not equal to the capacity of input tank 'b' | *Exception* | *Exception* | **Pass** |
| 11D | TransferTo with valid input arrays 'a' and a valid target tank 'b' of capacity 200 | 200 | 200 | **Pass** |
| 11E | TransferTo when transferring from an array 'a' with multiple tanks to a target tank 'b' of capacity 200 | 200 | 200 | **Pass** |
| 11F | TransferTo when transferring from an array 'a' with multiple tanks to a target tank 'b' of capacity 100 | 100 | 100 | **Pass** |
| 12A | Fills a tank with a capacity of 100 using one wine of quantity 100 | 100 | 100 | **Pass** |
| 12B | Fills a tank with a capacity of 100 using one wine of quantity 50 | 50 | 50 | **Pass** |
| 12C | Fills a tank with a capacity of 100 using one wine of quantity 75 | 75 | 75 | **Pass** |
| 12D | Fills a tank with a capacity of 200 using one wine of quantity 150 | 150 | 150 | **Pass** |
| 12E | Fills a tank with a capacity of 200 using one wine of quantity 50 | 50 | 50 | **Pass** |
| 12F | Fills a tank with a capacity of 200 using one wine of quantity 250 | 250 | 250 | **Pass** |
| 13A | Tests emptying an empty array of wines | 0 | 0 | **Pass** |
| 13B | Tests emptying a non-empty array of wines | *Null* | *Null* | **Pass** |
| 13C | Tests emptying a null array of wines | *Exception* | *Exception* | **Pass** |
| 13D | Tests emptying an empty array of wines and checks if it affects other arrays | 0 | 0 | **Pass** |
| 13E | Tests emptying an empty array of wines and checks if reference integrity is maintained | *Not Null* | *Not Null* | **Pass** |
| 13F | Tests emptying an array of wines with null elements | *Only non-null elements* | *Only non-null elements* | **Pass** |
| 14A | Tests the scenario where no tanks are provided | *Exception* | *Exception* | **Pass** |
| 14B | Tests the scenario where a single tank is provided | *Exception* | *Exception* | **Pass** |
| 14C | Tests the scenario where two tanks are provided | *Exception* | *Exception* | **Pass** |
| 14D | Tests the scenario where a single tank with zero capacity and zero wine quantities is provided | *Exception* | *Exception* | **Pass** |
| 14E | Tests the scenario where a single tank with no wine quantities is provided | *Exception* | *Exception* | **Pass** |
| 14F | Tests the scenario where two tanks with no wine quantities are provided | *Exception* | *Exception* | **Pass** |
| 14G | Tests the scenario where two tanks with empty wines are provided | *Exception* | *Exception* | **Pass** |
| 15A | Tests the scenario where an array of tanks with different capacities is provided | *Return tank objects with expected capacities* | *Return tank objects with expected capacities* | **Pass** |
| 15B | Tests the scenario where an array of tanks with different capacities is provided | *Return tank objects with expected capacities* | *Return tank objects with expected capacities* | **Pass** |
| 15C | Tests the scenario where a tank with zero capacity is provided | *Return tank objects with expected capacities* | *Return tank objects with expected capacities* | **Pass** |
| 15D | Tests the scenario where an array of tanks with equal capacities is provided | *Return tank objects with expected capacities* | *Return tank objects with expected capacities* | **Pass** |
| 16A | Tests the scenario where an array of tanks and a formula of wines are provided | *Return wine objects with expected quantities* | *Return wine objects with expected quantities* | **Pass** |
| 16B | Tests the scenario where an array of tanks and a formula with identical quantities are provided | *Return wine objects with expected quantities* | *Return wine objects with expected quantities* | **Pass** |
| 16C | Tests the scenario where an array of tanks and a formula with greater quantities than the tanks are provided | *Return wine objects with expected quantities* | *Return wine objects with expected quantities* | **Pass** |
| 16D | Tests the scenario where an array of tanks and a formula with smaller quantities than the tanks are provided | *Return wine objects with expected quantities* | *Return wine objects with expected quantities* | **Pass** |
| 17A | Tests the scenario where an empty array of tanks is provided | 0 | 0 | **Pass** |
| 17B | Tests the scenario where a single tank is provided | 1 | 1 | **Pass** |
| 17C | Tests the scenario where an array of multiple tanks is provided | *Expected count of combinations* | *Expected count of combinations* | **Pass** |
| 17D | Tests the scenario where an array of tanks with different capacities is provided | *Expected count of combinations* | *Expected count of combinations* | **Pass** |
| 17E | Tests the scenario where an array of additional tanks is provided | *Expected count of combinations* | *Expected count of combinations* | **Pass** |


## Total tests

Tests: 78, Passed: 78, Failed: 0, Skipped: 0
