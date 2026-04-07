public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();

        if(s.Length < 2)
            return false;
        foreach(var c in s)
        {
          
          
              if(c == ']'  )
              {
                if(stack.Count > 0 && stack.Peek() == '[')
                    stack.Pop();
                else
                    return false;

              }
             if(c == '}'  )
              {
                if(stack.Count > 0 && stack.Peek() == '{')
                    stack.Pop();
                else
                    return false;

              }
               if(c == ')'  )
              {
                if(stack.Count > 0 && stack.Peek() == '(')
                    stack.Pop();
                else
                    return false;

              }
            
           
                if(c == '(' || c == '{' || c=='[')
                    stack.Push(c);

              
          
        }   

       
      


        return stack.Count == 0;
    }
}
