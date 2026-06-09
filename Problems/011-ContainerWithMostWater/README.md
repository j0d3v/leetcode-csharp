# 011 - Container With Most Water

## Problem Description

You are given an array `height` of integers, where each element represents the height of a vertical line drawn at that index. The two endpoints of the `i-th` line are `(i, 0)` and `(i, height[i])`.

Find two lines that, together with the x-axis, form a container that holds the maximum amount of water.

Return the maximum water area that the container can store.

### Examples:

1. **Input**: `height = [1,8,6,2,5,4,8,3,7]`  
   **Output**: `49`

2. **Input**: `height = [1,1]`  
   **Output**: `1`

3. **Input**: `height = [4,3,2,1,4]`  
   **Output**: `16`

## Constraints:

- `2 <= height.length <= 10^5`
- `0 <= height[i] <= 10^4`
