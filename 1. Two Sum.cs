public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> complementMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            if (complementMap.ContainsKey(complement)) {
                return new int[] { complementMap[complement], i };
            }

            if (!complementMap.ContainsKey(nums[i])) {
                complementMap[nums[i]] = i;
            }
        }

        throw new ArgumentException("No two sum solution");
    }
}
