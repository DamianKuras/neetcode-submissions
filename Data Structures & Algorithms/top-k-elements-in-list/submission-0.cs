public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        SortedDictionary<int,int> frequency = new();
        foreach (int num in nums){
            frequency[num] = frequency.GetValueOrDefault(num, 0) + 1;
        }
        int[] ans = frequency.OrderByDescending(x=>x.Value).Select(x=>x.Key).Take(k).ToArray();
        return ans;
    }
}
