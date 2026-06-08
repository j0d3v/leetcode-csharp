# 007 - Reverse Integer

## Problem Description

Given a 32-bit signed integer `x`, reverse the digits of `x`.

Note:
- Assume that your function will return 0 when the reversed integer overflows.
- The reversed integer should be within the 32-bit signed integer range: `[-2^31, 2^31 - 1]`.
- Do not use built-in libraries or functions for reversing the integer.

### Examples:

1. **Input**: `x = 123`  
   **Output**: `321`  
   **Explanation**: The digits of the number `123` are reversed, yielding `321`.

2. **Input**: `x = -123`  
   **Output**: `-321`  
   **Explanation**: The digits of the number `-123` are reversed, yielding `-321`.

3. **Input**: `x = 120`  
   **Output**: `21`  
   **Explanation**: The digits of the number `120` are reversed, yielding `21`, with the leading zero removed.

4. **Input**: `x = 0`  
   **Output**: `0`  
   **Explanation**: Reversing `0` results in `0`.

5. **Input**: `x = 1534236469`  
   **Output**: `0`  
   **Explanation**: The result is out of the 32-bit integer range, so the function returns `0`.

## Constraints:
- The input integer `x` is a 32-bit signed integer.
- `-2^31 <= x <= 2^31 - 1`
- The function should handle overflows by returning `0` if the reversed integer exceeds the 32-bit signed integer range.