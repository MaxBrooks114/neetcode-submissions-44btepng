public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var ans = new List<List<string>>();
       
        var dict = new Dictionary<string, List<string>>();
        foreach(var str in strs)
        {
            var arr = new int[26];

            foreach(var c in str)
            {
              
                arr[c-'a']++;
            }

            string key = string.Join(",", arr);
            if(dict.ContainsKey(key))
            {
                dict[key].Add(str);
            }

            else
            {
                dict[key] = new List<string>{str};
            }
           
        }

        foreach(var val in dict.Values)
        {
            ans.Add(val);
        }

        return ans;
    }
}
