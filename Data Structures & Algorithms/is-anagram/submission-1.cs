public class Solution {
    public bool IsAnagram(string s, string t) {
        var map = new Dictionary<char, int>();
        foreach(var c in s)
        {
            map[c] = map.GetValueOrDefault(c)+1;
        }

        foreach(var c in t)
        {
            if(!map.ContainsKey(c))
                return false;
            
            else
            {
                map[c]--;
                if(map[c] < 0)
                    return false;
            }
        }

        foreach(var key in map.Keys)
        {
            if(map[key] > 0)
                return false;
        }



        return true;
    }
}
