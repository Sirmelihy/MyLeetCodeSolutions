public class Solution {
    public static int StrStr(string haystack, string needle) {
        
        int temp = 0;
        int appearence = -1;
        bool appearenceChecker = false;
        bool startAvailable = true;

        if (needle.Length > haystack.Length) {
            startAvailable = false;
        }

        if(startAvailable == true) {

            for(int i = 0;i<haystack.Length;i++) {
            temp = i;
                for(int j = 0;j<needle.Length;j++){
                    if(temp >= haystack.Length) {
                            break;
                        }
                    if(needle[j] != haystack[temp]) {
                        break;
                    }
                    else {
                        temp++;
                        if(j==needle.Length-1) {
                            appearence = i;
                            appearenceChecker = true;
                        }
                    }
                }
                if(appearenceChecker) {
                    break;
                }
            }
        }

        if(appearence != -1) {
            return appearence;
        }
        else {
            return -1;
        }
    }
}
