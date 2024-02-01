public class Solution {

    public static int SearchInsert(int[] nums, int target) {

        int returner = 0;


        for (int i = 0;i<nums.Length;i++){
            if(target == nums[i]) {
                returner = i;
                return i;
            }

            else if (target > nums[i]) {
                returner = i+1;
                return i+1;
            }
        }

        return returner;

    }
}
