# 018 - 4Sum

## Problem Description

Given an array of integers `nums` and an integer `target`, return all unique quadruplets `[nums[a], nums[b], nums[c], nums[d]]` such that:

- `0 <= a, b, c, d < nums.length`
- All indices are distinct
- The sum of `nums[a] + nums[b] + nums[c] + nums[d]` is equal to `target`

You may return the answer in any order.

### Examples:

1. **Input**: `nums = [1,0,-1,0,-2,2], target = 0`  
   **Output**: `[[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]`  
   **Explanation**: The unique quadruplets that sum to 0 are listed above.

2. **Input**: `nums = [2,2,2,2,2], target = 8`  
   **Output**: `[[2,2,2,2]]`

## Constraints:

- 1 <= `nums.length` <= 200  
- -10^9 <= `nums[i]` <= 10^9  
- -10^9 <= `target` <= 10^9  
- All valid quadruplets must be unique
