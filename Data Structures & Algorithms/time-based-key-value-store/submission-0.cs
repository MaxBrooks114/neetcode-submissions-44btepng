public class TimeMap {
    public Dictionary<string, List<(int, string)>> Map {get; set;} = new Dictionary<string, List<(int, string)>>();
 
    public TimeMap() {
        
    }
    
    public void Set(string key, string value, int timestamp) {
       
        if(Map.ContainsKey(key))
        {
            Map[key].Add((timestamp, value));
        }
        else
        {
            Map[key] = new List<(int, string)>(){(timestamp, value)};
        }
    }
    
    public string Get(string key, int timestamp) {
        if(!Map.ContainsKey(key))
            return "";
        
            var values = Map[key];
            var l = 0;
            var r = values.Count-1;
            string res = "";
            while(l <= r)
            {
                int mp  = l+((r-l)/2);

                if(values[mp].Item1 <= timestamp)
                {
                    res = values[mp].Item2;
                    l =mp+1;
                }
                else
                {
                    r = mp -1;
                }
            }
        

        return res;

           
    }
}
