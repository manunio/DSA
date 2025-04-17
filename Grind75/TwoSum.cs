namespace Grind75;

public static class TwoSum
{
    public static int[] BruteForceApproach(int[] nums, int target)
    {
        // 3, 2, 4 = 6
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }

        return [];
    }

    public static int[] HashMapApproach(int[] nums, int target)
    {
        // value : index
        Dictionary<int, int> hm = new(nums.Length);

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (hm.TryGetValue(diff, out int index)) // found if true
            {
                return [index, i];
            }
            hm.TryAdd(nums[i], i);
        }

        return [];
    }
}
