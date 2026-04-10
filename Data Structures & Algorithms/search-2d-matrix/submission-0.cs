public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int l = 0, r = matrix.Length -1;
       while(l <= r)
       {
            int m = l + ((r - l) / 2);
            if(matrix[m][0] > target)
                r = m-1;
            else if(matrix[m][matrix[0].Length-1] < target)
                l = m+1;
            else 
            {
                int l2 = 0, r2 = matrix[m].Length -1;

                while(l2 <= r2)
                {
                    int m2 = l2 + ((r2 - l2) / 2);
                    // l
                    if(matrix[m][m2] > target)
                        r2 = m2-1;
                    else if(matrix[m][m2] < target)
                        l2 = m2+1;
                    else
                       return true;
                       
                  
                }


                return false;
            }


      
       }


       return false;

    }
}
