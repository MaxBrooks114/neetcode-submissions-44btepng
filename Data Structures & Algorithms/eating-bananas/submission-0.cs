public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        var max = piles.Max();

        var l = 1;
        var r = max;
        var k = 0;
        while(l <= r)
        {
            int mp = l+ ((r-l)/2);
            var time = 0;

            foreach(var pile in piles)
            {
                time+=(int)Math.Ceiling((double)pile/mp);
                if(time > h)
                    break;
            
            }

            if(time > h)
            {
                l = mp+1;

            }

            if(time <= h)
            {
                k = mp;
                r=mp-1;
            }


        }


        return k;
    }
}
