public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.Trim();
        string[] convertedArr = s.Split(" ");

        return convertedArr[convertedArr.Length-1].Length;
    }
}
