public class Solution {
    public bool IsPalindrome(int x) {

        int checkNumber = 0;
        int basamak = 1;

        while ((x/basamak) >= 10) {
            basamak *=10;
        }

        int basamaktemp = basamak;
        int carpan = 1;

        while (carpan != basamaktemp*10) {
            checkNumber += ((x/basamak)%10) * carpan;
            carpan*=10;
            basamak/=10;
        }


        if(x == checkNumber && x >= 0) {
            return true;

        }
        else {
            return false;
        }
    }
}
