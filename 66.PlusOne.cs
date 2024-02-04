public class Solution {
    public static int[] PlusOne(int[] digits) {

        int adder = 1;

        for(int i=digits.Length-1;i>=0;i--) {

            digits[i] += adder;
            adder = 0;

            if(digits[i] == 10) {
                digits[i] %= 10;
                adder = 1;

                if(i == 0) {
                    int[] brand = new int[digits.Length+1];
                    brand[0] = 1;
                    int c = 0;
                    for(int k = 1;k<brand.Length;k++) {
                        brand[k] = digits[c];
                        c++;
                    }
                    return brand;
                }
            }
        }

        return digits;
    }
}
