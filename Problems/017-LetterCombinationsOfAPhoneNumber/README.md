# 017 - Letter Combinations of a Phone Number

## Problem Description

Given a string `digits` containing digits from `2` to `9` inclusive, return all possible letter combinations that the number could represent.

A mapping of digits to letters (just like on a telephone keypad) is given below:

| Digit | Letters |
|--------|---------|
| 2 | abc |
| 3 | def |
| 4 | ghi |
| 5 | jkl |
| 6 | mno |
| 7 | pqrs |
| 8 | tuv |
| 9 | wxyz |

Return the answer in **any order**.

### Examples:

1. **Input**: `digits = "23"`  
   **Output**: `["ad","ae","af","bd","be","bf","cd","ce","cf"]`  
   **Explanation**:
   - Digit `2` maps to `["a","b","c"]`
   - Digit `3` maps to `["d","e","f"]`
   - Combining each letter from `2` with each letter from `3` produces all possible combinations.

2. **Input**: `digits = ""`  
   **Output**: `[]`  
   **Explanation**: There are no digits, so no letter combinations can be formed.

3. **Input**: `digits = "2"`  
   **Output**: `["a","b","c"]`  
   **Explanation**: Digit `2` maps to the letters `a`, `b`, and `c`.

## Constraints:

- 0 <= `digits.length` <= 4
- `digits[i]` is a digit in the range `['2', '9']`
