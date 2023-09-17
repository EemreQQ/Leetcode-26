using System.Collections;
using System.Linq;
public class Solution
{
    public int RemoveDuplicates(params int[] nums)
    {
            List<int> values = new List<int>();
            Hashtable hashtable = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
             {
            if (hashtable.Contains(nums[i]) == false)
            {
                hashtable.Add(nums[i], i);
                values.Add(nums[i]);
            }
             }
        Array.Copy(values.ToArray(),0, nums, 0,values.Count);
        return values.Count;
    }
}