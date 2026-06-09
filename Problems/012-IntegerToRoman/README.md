# 012 - Integer to Roman

## Problem Description

Given an integer `num`, convert it to a Roman numeral.

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

1. **Input**: `num = 3`  
   **Output**: `"III"`  
   **Explanation**: The number 3 is represented as "III" in Roman numerals.

2. **Input**: `num = 58`  
   **Output**: `"LVIII"`  
   **Explanation**: The number 58 is represented as "LVIII" in Roman numerals.

3. **Input**: `num = 1994`  
   **Output**: `"MCMXCIV"`  
   **Explanation**: The number 1994 is represented as "MCMXCIV" in Roman numerals.

4. **Input**: `num = 9`  
   **Output**: `"IX"`  
   **Explanation**: The number 9 is represented as "IX" in Roman numerals.

5. **Input**: `num = 45`  
   **Output**: `"XLV"`  
   **Explanation**: The number 45 is represented as "XLV" in Roman numerals.

## Constraints:

- `1 <= num <= 3999`
