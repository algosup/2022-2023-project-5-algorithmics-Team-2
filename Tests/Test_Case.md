# Test Case

<details>
<summary>📖 Table of Content</summary>

- [Test Case](#test-case)
  - [Calculating Total Quantity of Wine](#calculating-total-quantity-of-wine)
    - [Inputs](#inputs)
    - [Outputs](#outputs)
    - [Test Cases](#test-cases)

</details>

## Calculating Total Quantity of Wine

This test case part is for a function that calculates the total quantity of wine from a dictionary of wine quantities indexed by their ID.

### Inputs

`wine_quantities = {0:14.1, 1:3, 2:2.3, 3:6.5, 4:0, 5:10.8, 6:18.2, 7:5, 8:3.7, 9:12.9}`

The input is a dictionary of wine quantities indexed by their ID.

### Outputs

`total_quantity = 76.5`

The output is the total quantity of wine as a float.

### Test Cases

Test that the function returns the correct total quantity of wine for the input provided:
`calculate_total_quantity(wine_quantities) == 76.5`
This test case verifies that the function returns the correct total quantity of wine for the input provided.

Test that the function correctly handles a dictionary with all values set to 0:
`calculate_total_quantity({0:0, 1:0, 2:0, 3:0, 4:0, 5:0, 6:0, 7:0, 8:0, 9:0}) == 0`
This test case verifies that the function correctly handles a dictionary with all values set to 0.

Test that the function correctly handles a dictionary with only one non-zero value:
`calculate_total_quantity({0:0, 1:0, 2:0, 3:0, 4:0, 5:0, 6:0, 7:0, 8:0, 9:5.5}) == 5.5`
This test case verifies that the function correctly handles a dictionary with only one non-zero value.

Test that the function returns 0 for an empty dictionary:
`calculate_total_quantity({}) == 0`
This test case verifies that the function returns 0 for an empty dictionary.

Overall, these test cases verify that the calculate_total_quantity() function works correctly for different inputs and edge cases.
