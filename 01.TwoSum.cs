public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        int[] outputArr = {1,2};

        for (int i = 0;i<nums.Length;i++) {
            for(int k = 0;k<nums.Length;k++) {

                if(k != i) {
                    if(nums[i] + nums[k] == target) {
                        outputArr[0] = k;
                        outputArr[1] = i;
                    }
                }

            }
        }

        return outputArr;
    }
}
