public class Solution {
    public bool IsHappy(int n) {
        var seen = new HashSet<int>();


        var sumSq = 0;
        var testNum = n;
        while(sumSq != 1)
        {
            sumSq = 0;
            var list = GetDigits(testNum);
            foreach(var num in list)
            {
               
                sumSq += num*num;
            }
            if(seen.Add(sumSq))
            {
                testNum = sumSq;
            }
            else
                return false;

           
        }



        return true;


    }


    private List<int> GetDigits(int n)
    {
        var list = new List<int>();
        while(n > 0)
        {
            
            list.Add(n%10);
            n/=10;
        }

        return list;
    }
}
