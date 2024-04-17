﻿namespace LeedCode;

public class Problem_088
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int nums1Index = m - 1;
        int nums2Index = n - 1;
        int mergeIndex = m + n - 1;
        while (nums1Index >= 0 && nums2Index >= 0)
        {
            if (nums1[nums1Index] < nums2[nums2Index])
            {
                nums1[mergeIndex] = nums2[nums2Index];
                nums2Index--;
                mergeIndex--;
            }
            else
            {
                nums1[mergeIndex] = nums1[nums1Index];
                nums1Index--;
                mergeIndex--;
            }
        }

        while (nums2Index >= 0)
        {
            nums1[mergeIndex] = nums2[nums2Index];
            nums2Index--;
            mergeIndex--;
        }
    }
}