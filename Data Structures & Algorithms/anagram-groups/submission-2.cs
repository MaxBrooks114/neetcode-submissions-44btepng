public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var map = new Dictionary<string, List<string>>();
        var ans = new List<List<string>>();
        foreach(var str in strs)
        {
            var wordMap = new int[26];
            foreach(var c in str)
            {
                wordMap[c -'a']++;
            }
            var key  = string.Join(",", wordMap);
           
            if(map.ContainsKey(key))
            {
                map[key].Add(str);

            }
            else
                map[key] = new List<string>(){str};

        }


        
        foreach(var str in map.Keys)
        {
           ans.Add(map[str]);
        }

        return ans;
    }
}
