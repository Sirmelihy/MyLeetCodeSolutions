public class Solution {
    public int RomanToInt(string s) {
       int year = 0;

        for (int i = 0; i<s.Length; i++) {

            switch(s[i]) {

                case 'M' :
                    year += 1000;
                    break;
                
                case 'D' :
                    if (i+1 < s.Length && s[i+1] == 'M') {
                        year -= 500;
                    }
                    else {
                        year += 500;
                    }

                    break;
                
                case 'C' :
                    if (i+1 < s.Length && (s[i+1] == 'M' || s[i+1] == 'D' )) {
                        year -= 100;
                    }
                    else {
                        year += 100;
                    }

                    break;

                case 'L' :
                    if (i+1 < s.Length && (s[i+1] == 'M' || s[i+1] == 'D' || s[i+1] == 'C'  )) {
                        year -= 50;
                    }
                    else {
                        year += 50;
                    }

                    break;

                case 'X' :
                    if (i+1 < s.Length && (s[i+1] == 'M' || s[i+1] == 'D' || s[i+1] == 'C' || s[i+1] == 'L'  )) {
                        year -= 10;
                    }
                    else {
                        year += 10;
                    }

                    break;
                
                case 'V' :
                    if (i+1 < s.Length && (s[i+1] == 'M' || s[i+1] == 'D' || s[i+1] == 'C' || s[i+1] == 'L' || s[i+1] == 'X'   )) {
                        year -= 5;
                    }
                    else {
                        year += 5;
                    }

                    break;

                case 'I' :
                    if (i+1 < s.Length && (s[i+1] == 'M' || s[i+1] == 'D' || s[i+1] == 'C' || s[i+1] == 'L' || s[i+1] == 'X' || s[i+1] == 'V'   )) {
                        year -= 1;
                    }
                    else {
                        year += 1;
                    }

                    break;
            }
        }
        return year; 
    }
}
