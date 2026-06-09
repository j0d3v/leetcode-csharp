# 010 - Regular Expression Matching

## Problem Description

Implement regular expression matching with support for `.` and `*` where:

- `.` Matches any single character.
- `*` Matches zero or more of the preceding element.

Given an input string `s` and a pattern `p`, return `true` if `s` matches `p`, otherwise return `false`.

### Examples:

1. **Input**: `s = "aa", p = "a"`  
   **Output**: `false`  
   **Explanation**: `a` does not match the entire string `aa`.

2. **Input**: `s = "aa", p = "a*"`  
   **Output**: `true`  
   **Explanation**: `a*` means zero or more of `a` (which matches `aa`).

3. **Input**: `s = "ab", p = ".*"`  
   **Output**: `true`  
   **Explanation**: `.*` matches any string.

4. **Input**: `s = "aab", p = "c*a*b"`  
   **Output**: `true`  
   **Explanation**: `c*` can be ignored, `a*` matches `aa`, and `b` matches `b`.

5. **Input**: `s = "mississippi", p = "mis*is*p*."`  
   **Output**: `false`  
   **Explanation**: `mis*is*p*.` does not match `mississippi`.

## Constraints:

- The length of the input string `s` and the pattern `p` will be in the range `[0, 20]`.
- The input string `s` and pattern `p` consist of lowercase English letters and the characters `.` and `*`.
- It is guaranteed that the pattern does not contain consecutive `*`.
