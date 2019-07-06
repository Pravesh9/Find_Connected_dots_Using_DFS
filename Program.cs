using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_Search
{
    
    class Program
    {
      public static   int previous_row, previous_col,loopcount;
        public static int GetRigionSize(int[,] matrix,int row,int col)
        {
            if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1)) //these are check to boundary blocks
            {
                return 0;
            }
            if (matrix[row,col] !=1)
            {
                return 0;
            }
            matrix[row, col] = 0;//we are changing the element value '1' to '0'
            int size = 1;
            
            for (int r =row-1 ; r <= row+1; r++)
            {   
                    for (int c = col - 1; c <= col + 1; c++)
                    {
                    
                    //if take digonal(r!=row||c!=col)  and if without digonal(r==row||c==col)


                    if ( (r ==row || c == col))
                    {
                        previous_row = r; previous_col = c;
                        size += GetRigionSize(matrix, r, c);
              //          Console.WriteLine("({0},{1})", r, c);
                        loopcount++;
                    }
                    else
                    {

                    }
                    }
                
            }
            return size;
        }
        
        static void Main(string[] args)
        {
            int[,] a = new int[5, 5] { { 1,0,0,0,0},
                                       { 0,1,0,0,0},
                                       { 1,0,1,0,0},
                                       { 0,0,1,1,0},
                                       { 0,0,0,0,0},
                                      };
          
            Console.Write("Input the row Number");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Column Number");
            int col = Convert.ToInt32(Console.ReadLine());
            int size = GetRigionSize(a,row,col);


            Console.WriteLine("Size is {0}", size);
            //Console.WriteLine("loop is {0}", loopcount);
          
        }
    }
}
