# 006 - Zigzag Conversion

## Problem Description

The string `s` is written in a zigzag pattern on a given number of rows. You are to convert the zigzag pattern back into a string by reading it row by row.

Write the function `convert(s string, numRows int) string` to perform this task.

### Example 1:

**Input**:  
`"PAYPALISHIRING", 3`

**Output**:  
`"PAHNAPLSIIGYIR"`

**Explanation**:  
The string "PAYPALISHIRING" is arranged in the following zigzag pattern:

```
P   A   H   N
A P L S I I G
Y   I   R
```

Reading line by line gives: `"PAHNAPLSIIGYIR"`.

### Example 2:

**Input**:  
`"PAYPALISHIRING", 4`

**Output**:  
`"PINALSIGYAHRPI"`

**Explanation**:  
The string "PAYPALISHIRING" is arranged in the following zigzag pattern:

```
P     I    N
A   L S  I G
Y A   H R
P     I
```

Reading line by line gives: `"PINALSIGYAHRPI"`.

### Example 3:

**Input**:  
`"A", 1`

**Output**:  
`"A"`

### Example 4:

**Input**:  
`"AB", 1`

**Output**:  
`"AB"`

## Constraints:
- The input string `s` will have a length between `1` and `1000`.
- The number of rows, `numRows`, will be between `1` and `1000`.
- `s` is guaranteed to have at least one character.