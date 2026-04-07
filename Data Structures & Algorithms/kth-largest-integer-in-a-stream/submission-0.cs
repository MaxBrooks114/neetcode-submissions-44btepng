public class KthLargest {


    public List<int> list {get; set;}
    public int chosen {get; set;}
    public KthLargest(int k, int[] nums) {
        list = nums.ToList();
        chosen = k;
    }
    
    public int Add(int val) {
        list.Add(val);
        list = list.OrderByDescending(x => x).ToList();

        return list[chosen-1];
    }
}
