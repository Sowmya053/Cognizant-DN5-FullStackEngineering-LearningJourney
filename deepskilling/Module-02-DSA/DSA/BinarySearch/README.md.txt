# Binary Search

## Definition

Binary Search is an efficient searching algorithm that works on sorted arrays by repeatedly dividing the search interval into half.

## Algorithm

1. Find the middle element.
2. Compare it with the target.
3. If equal, return the index.
4. If the target is greater, search the right half.
5. If the target is smaller, search the left half.

## Time Complexity

- Best Case: O(1)
- Average Case: O(log n)
- Worst Case: O(log n)

## Output

Element found at index: 4