# 003 - Longest Substring Without Repeating Characters

## Problem Description

Given a string `s`, find the length of the longest substring without repeating characters.

A **substring** is a contiguous sequence of characters within a string.

### Examples:

1. **Input**: `s = "abcabcbb"`  
   **Output**: `3`  
   **Explanation**: The answer is `"abc"`, with the length of 3.

2. **Input**: `s = "bbbbb"`  
   **Output**: `1`  
   **Explanation**: The answer is `"b"`, with the length of 1.

3. **Input**: `s = "pwwkew"`  
   **Output**: `3`  
   **Explanation**: The answer is `"wke"`, with the length of 3.  
   Notice that the answer must be a substring, not a subsequence. `"pwke"` is a subsequence and not a substring.

### Constraints:
- `0 <= s.length <= 5 * 10^4`
- `s` consists of English letters, digits, symbols, and spaces.