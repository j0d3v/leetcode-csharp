# 013 - Roman to Integer

## Problem Description

Given a Roman numeral string `s`, convert it to an integer.

### Roman Numeral System

In the Roman numeral system, the following symbols are used:

| Symbol | Value |
| ------ | ----- |
| I      | 1     |
| V      | 5     |
| X      | 10    |
| L      | 50    |
| C      | 100   |
| D      | 500   |
| M      | 1000  |

The rules of Roman numerals are as follows:

- Roman numerals are written from largest to smallest, left to right. For example, `II` is 2 and `XIII` is 13.
- When a smaller numeral appears before a larger numeral, it is subtracted. For example, `IV` is 4, `IX` is 9, `XL` is 40, `XC` is 90, `CD` is 400, and `CM` is 900.

### Example:

1. **Input**: `s = "III"`  
   **Output**: `3`  
   **Explanation**: The Roman numeral "III" represents the integer 3.

2. **Input**: `s = "LVIII"`  
   **Output**: `58`  
   **Explanation**: The Roman numeral "LVIII" represents the integer 58.

3. **Input**: `s = "MCMXCIV"`  
   **Output**: `1994`  
   **Explanation**: The Roman numeral "MCMXCIV" represents the integer 1994.

4. **Input**: `s = "IX"`  
   **Output**: `9`  
   **Explanation**: The Roman numeral "IX" represents the integer 9.

5. **Input**: `s = "XLV"`  
   **Output**: `45`  
   **Explanation**: The Roman numeral "XLV" represents the integer 45.

### Constraints:

- `1 <= s.length <= 15`
- `s` is a valid Roman numeral in the range from `1` to `3999`.
