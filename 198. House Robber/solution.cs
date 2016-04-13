﻿using System;

public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];

        int[] dp = new int[nums.Length];
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[0], nums[1]);

        for (int i = 2; i < nums.Length; i++)
        {
            dp[i] = Math.Max(dp[i-1], dp[i-2]+nums[i]);
        }

        return Math.Max(dp[dp.Length-1], dp[dp.Length - 2]);
    }

    
    static void Main(string[] args)
    {
        Solution s = new Solution();

        int[] array = new int[3]{ 3, 9, 2 };

        var result = s.Rob(array);

        Console.WriteLine(result);
    }
}