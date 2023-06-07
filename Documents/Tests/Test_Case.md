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
| 61 | With the '*' operator, multiply two zero quantity wines and returns wine with zero quantity | 0 | 0 | **Pass** |
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

## Total tests

Tests: 35, Passed: 35, Failed: 0, Skipped: 0
