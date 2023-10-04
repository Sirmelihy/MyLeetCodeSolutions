using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO.Compression;

class Solution
{

    public static bool IsValid(string s) {

        Stack<char> myStack = new Stack<char>();

        for (int i = 0 ; i < s.Length ; i++) {

            if( s[i] == '{' || s[i] == '[' || s[i] == '(' ) {
                myStack.Push(s[i]);
            }

            else if (myStack.Count == 0 && (s[i] == '}' || s[i] == ']' || s[i] == ')')) {
                return false;
            }

            else {
                if ( s[i] == '}' && myStack.Peek() == '{' ) {
                    myStack.Pop();
                }

                else if ( s[i] == ']' && myStack.Peek() == '[' ) {
                    myStack.Pop();
                }

                else if ( s[i] == ')' && myStack.Peek() == '(' ) {
                    myStack.Pop();
                }
                else {
                    return false;
                }
            } 
        }

        return myStack.Count == 0;
    }
   
    static void Main(string[] args)
    {
        string testinput = "(])";
        Console.WriteLine(IsValid(testinput));
    }
}
