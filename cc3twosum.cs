using System;
using System.Collections.Generic;

public class Solution {
public int[] TwoSum(int[] nums, int target) {
Dictionary<int, int> numIndices = new Dictionary<int, int>();
for (int i = 0; i < nums.Length; i++) {
int complement = target - nums[i];
if (numIndices.ContainsKey(complement)) {
return new int[] { numIndices[complement], i };
}
numIndices[nums[i]] = i;
}
return new int[0];
}
}

public class Program {
public static void Main(string[] args) {
Solution solution = new Solution();

int[] nums1 = { 2, 7, 11, 15 };
int target1 = 9;
int[] result1 = solution.TwoSum(nums1, target1);
Console.WriteLine($"[{result1[0]}, {result1[1]}]");

int[] nums2 = { 3, 2, 4 };
int target2 = 6;
int[] result2 = solution.TwoSum(nums2, target2);
Console.WriteLine($"[{result2[0]}, {result2[1]}]");

int[] nums3 = { 3, 3 };
int target3 = 6;
int[] result3 = solution.TwoSum(nums3, target3);
Console.WriteLine($"[{result3[0]}, {result3[1]}]");
}
}