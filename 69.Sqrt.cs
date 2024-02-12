public class Solution {
    public int MySqrt(int x) {
        for(long i=0;i<=x;i++) {
            if(i*i > x) {
                return (int)i-1;
            }
            if(i*i == x ) {
                return (int)i;
            }
        }
        return 0;
    }
}
