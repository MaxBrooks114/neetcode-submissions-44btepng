public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s == "")
            return 0;
        var l = 0;
        var r = 1;
        var uniq = 1;    
        var hash = new HashSet<char>();
        while(r < s.Length)
        {
            
            if((hash.Count == 0 && hash.Add(s[l])) && hash.Add(s[r]))
            {                    
              
                uniq = Math.Max(hash.Count, uniq);
                 r++;
            }
            else if(hash.Add(s[r]))
            {
                 uniq = Math.Max(hash.Count, uniq);
                  r++;
            }
            else
            {
               
               
                hash.Clear();
                l++;
                r=l+1;
                
            }
          
           

        }

        return uniq;
    }
}
