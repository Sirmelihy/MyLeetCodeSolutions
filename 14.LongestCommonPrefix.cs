
class Solution
{
    public static string LongestCommonPrefix(string[] strs) {
        
        string starter = strs[0];
        string prefix = "";

        for(int i = 1; i < strs.Length ; i ++ ) {
            
            for(int j = 0; j < strs[i].Length ; j ++) {

                if( j < starter.Length && (starter[j] == strs[i][j] )) {
                    prefix += strs[i][j];
                }

                else {
                    
                    break;
                }

            }
            starter = prefix;
            prefix = "";
        }

        return starter;
    }
}
