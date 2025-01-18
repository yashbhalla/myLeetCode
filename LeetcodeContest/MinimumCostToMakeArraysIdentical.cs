public class Solution
{
    public long MinCost(int[] arr, int[] brr, long k)
    {
        int n = arr.Length;

        long directAdjustmentCost = 0;
        for (int i = 0; i < n; i++)
        {
            directAdjustmentCost += Math.Abs(arr[i] - brr[i]);
        }


        Array.Sort(arr);
        Array.Sort(brr);

        long rearrangementAdjustmentCost = 0;
        for (int i = 0; i < n; i++)
        {
            rearrangementAdjustmentCost += Math.Abs(arr[i] - brr[i]);
        }

        long totalRearrangementCost = rearrangementAdjustmentCost + k;

        return Math.Min(directAdjustmentCost, totalRearrangementCost);
    }
}