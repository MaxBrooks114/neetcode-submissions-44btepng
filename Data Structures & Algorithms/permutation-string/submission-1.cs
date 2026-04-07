public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        
       if(s2.Length < s1.Length)
          return false;

        var l = 0;
        var r = s1.Length;

        while(r <= s2.Length)
        {
            var sub = s2.Substring(l, (r-l));

            var map = new int[26];

            foreach(var c in sub)
            {
               map[c-'a']++;
            }

            foreach(var c in s1)
            {
               map[c -'a']--;
            }

            if(map.All(x => x <= 0))
              return true;

            r++;
            l++;
        }

        return false;
    }
}
