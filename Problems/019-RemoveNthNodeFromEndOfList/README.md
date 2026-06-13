# 019 - Remove Nth Node From End of List

## Problem Description

Given the `head` of a linked list, remove the `n`th node from the end of the list and return its head.

### Example:

1. **Input**: `head = [1,2,3,4,5]`, `n = 2`  
   **Output**: `[1,2,3,5]`  
   **Explanation**: The 2nd node from the end is `4`, so it is removed.

2. **Input**: `head = [1]`, `n = 1`  
   **Output**: `[]`  
   **Explanation**: The only node in the list is removed.

3. **Input**: `head = [1,2]`, `n = 1`  
   **Output**: `[1]`  
   **Explanation**: The last node (`2`) is removed.

### Constraints:

- The number of nodes in the list is `sz`.
- `1 <= sz <= 30`
- `0 <= Node.val <= 100`
- `1 <= n <= sz`

### Follow-up:

Can you solve this problem in one pass?
