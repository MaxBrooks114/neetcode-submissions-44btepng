public class MinStack {

    public List<int> Stack {get; set;} = new List<int>();
    public List<int> MinS {get; set;} = new List<int>();
    public int Count {get; set;} = 0;
    public MinStack() {
        
      
    }
    
    public void Push(int val) {
        this.Stack.Add(val);
        if(this.Count == 0)
            this.MinS.Add(val);
        else
            this.MinS.Add(Math.Min(this.MinS[this.Count-1], val));
        this.Count++;
    }
    
    public void Pop() {
        this.Stack.RemoveAt(this.Count-1);
        this.MinS.RemoveAt(this.Count-1);
        this.Count--;
    }
    
    public int Top() {
        return this.Stack[this.Count-1];
    }
    
    public int GetMin() {
        return this.MinS[this.Count-1];
    }
}