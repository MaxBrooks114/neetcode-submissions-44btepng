public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length)
            return false;

        var map1 = new int[27];
        var map2 = new int[27];
        foreach(var c in s)
        {
           
            map1[c-'0'-48]++;
        }

        foreach(var c in t)
        {
            map2[c-'0'-48]++;

           
        }

        for(var i = 0; i < map1.Length; i++)
        {
            if(map1[i] != map2[i])
                return false;
        }

        return true;

    }
}
