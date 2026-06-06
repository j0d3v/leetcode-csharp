# 004 - Median of Two Sorted Arrays

## Problem Description

Given two sorted arrays `nums1` and `nums2` of size `m` and `n` respectively, find the **median** of the two sorted arrays. The overall run time complexity should be `O(log(min(m, n)))`.

The median is defined as:

- If the combined total number of elements (m + n) is odd, the median is the middle element.
- If the combined total number of elements (m + n) is even, the median is the average of the two middle elements.

### Examples:

1. **Input**: `nums1 = [1, 3], nums2 = [2]`  
   **Output**: `2.0`  
   **Explanation**: The merged array is `[1, 2, 3]`, and the median is `2.0`.

2. **Input**: `nums1 = [1, 2], nums2 = [3, 4]`  
   **Output**: `2.5`  
   **Explanation**: The merged array is `[1, 2, 3, 4]`, and the median is `(2 + 3) / 2 = 2.5`.

3. **Input**: `nums1 = [0, 0], nums2 = [0, 0]`  
   **Output**: `0.0`  
   **Explanation**: The merged array is `[0, 0, 0, 0]`, and the median is `(0 + 0) / 2 = 0.0`.

4. **Input**: `nums1 = [1], nums2 = [2, 3, 4]`  
   **Output**: `2.5`  
   **Explanation**: The merged array is `[1, 2, 3, 4]`, and the median is `(2 + 3) / 2 = 2.5`.

### Constraints:
- `nums1.length == m`
- `nums2.length == n`
- `0 <= m <= 1000`
- `0 <= n <= 1000`
- `1 <= m + n <= 2000`
- `-10^6 <= nums1[i], nums2[i] <= 10^6`

You must solve it in `O(log(min(m, n)))` time complexity.