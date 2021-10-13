/*
 * For example to this pattern we will use the problem below:
 * 
 * Given an array of integers of size ‘n’.
 * Our aim is to calculate the maximum sum of ‘k’
 * consecutive elements in the array.
 *
 * Input  : arr[] = {100, 200, 300, 400}
 * k = 2
 * Output : 700
 *
 * Input  : arr[] = {1, 4, 2, 10, 23, 3, 1, 0, 20}
 * k = 4
 * Output : 39
 * We get maximum sum by adding subarray {4, 2, 10, 23}
 * of size 4.
 *
 * Input  : arr[] = {2, 3}
 * k = 3
 * Output : Invalid
 * There is no subarray of size 3 as size of whole
 * array is 2.
 */

using System;

namespace AlgoPatternsCore
{
    /// <summary>
    /// A complex way to solve the problem, with two nested loops, O(k*n)
    /// </summary>
    public class SolvingStandard
    {
        // Returns maximum sum in a
        // subarray of size k.
        public static int MaxSum(int[] arr, int n, int k)
        {
            // Initialize result
            int maxSum = int.MinValue;

            // Consider all blocks starting
            // with i.
            for (int i = 0; i < n - k + 1; i++)
            {
                int currentSum = 0;
                for (int j = 0; j < k; j++)
                    currentSum = currentSum + arr[i + j];

                // Update result if required.
                maxSum = Math.Max(currentSum, maxSum);
            }

            return maxSum;
        }
    }
    
    public class SlidingWindow
    {
        public static int MaxSum(int[] arr, int n, int k)
        {
 
            // n must be greater
            if (n < k) {
                Console.WriteLine("Invalid");
                return -1;
            }
 
            // Compute sum of first window of size k
            int maxSum = 0;
            for (int i = 0; i < k; i++)
                maxSum += arr[i];
 
            // Compute sums of remaining windows by
            // removing first element of previous
            // window and adding last element of
            // current window.
            int windowSum = maxSum;
            for (int i = k; i < n; i++) {
                windowSum += arr[i] - arr[i - k];
                maxSum = Math.Max(maxSum, windowSum);
            }
 
            return maxSum;
        }
    }
}