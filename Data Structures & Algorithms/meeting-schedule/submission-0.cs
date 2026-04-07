/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {

            intervals = intervals.OrderBy(x => x.start).ToList();

            for(var i = 0; i < intervals.Count(); i++)
            {
                if(i != intervals.Count()-1)
                {
                    if(intervals[i].end > intervals[i+1].start)
                        return false;

                }


            }



            return true;
    }
}
