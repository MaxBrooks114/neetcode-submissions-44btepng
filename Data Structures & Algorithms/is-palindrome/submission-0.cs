public class Solution {
    public bool IsPalindrome(string s) {
        
            var l = 0;
            var r = s.Length-1;

           while(l < r)
           {
                if(!char.IsLetter(s[r]) && !char.IsNumber(s[r]))
                {
                    
                    r--;
                    continue;
                }
                if(!char.IsLetter(s[l]) && !char.IsNumber(s[l]))
                {
                    l++;
                    continue;
                }


                if(char.ToLower(s[l]) != char.ToLower(s[r]))
                    return false;

                l++;
                r--;
           }


        return true;
    }
}
