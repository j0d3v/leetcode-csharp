# 005 - Longest Palindromic Substring

## Problem Description

Given a string `s`, return the longest palindromic substring in `s`.

A **palindrome** is a string that reads the same backward as forward.

### Examples:

1. **Input**: `s = "babad"`  
   **Output**: `"bab"` or `"aba"`  
   **Explanation**: Both `"bab"` and `"aba"` are valid longest palindromes.

2. **Input**: `s = "cbbd"`  
   **Output**: `"bb"`  
   **Explanation**: `"bb"` is the longest palindromic substring.

3. **Input**: `s = "a"`  
   **Output**: `"a"`  
   **Explanation**: The input string is a single character, which is a palindrome itself.

4. **Input**: `s = "ac"`  
   **Output**: `"a"`  
   **Explanation**: The longest palindromic substring is just a single character.

## Constraints:

- `1 <= s.length <= 1000`
- `s` consists of only lowercase English letters.
