using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;


namespace Maze_parallel
{
    class Program
    {
       static List<string> lines = new List<string>();
       static int[] start,end;
        static async Task  readfile()
        {
            StreamReader file = File.OpenText(@"C:\Users\Z51\Desktop\Maze parallel\text1.txt");
            string line;
            while (!file.EndOfStream)
            { 
                line = await file.ReadLineAsync();
                lines.Add(line);
            }
          }
        static void Main(string[] args)
        {
            List<int[]> blocks = new List<int[]>();
            int row=-1, col=-1;
            Task t =readfile();
            Task.WaitAll(t);
           foreach(String line in lines )
            {     row++;
                 col = -1;
                foreach(char c in line)
                {
                    col++;
                    if (c == '*')
                        blocks.Add(new[] { row, col });
                    else if (c == 'c')
                        start = new[] { row, col }; 
                    else if (c == 'e')
                        end = new[] { row, col };
                }
               
            }

            matrixElement[,] matrix = new matrixElement[3, 3];
            operations op = new operations();
                matrix = op.Create_matrix((row + 1), (col + 1), blocks, start, end);
                op.finding_path(matrix, start, start, new[] { 5, 5 });
                List<int[,]> array = op.smallest_list();
                Console.ReadLine();
            //CanTok.Cancel();
            
            //ThreadPool.QueueUserWorkItem(l => operations.finding_path(matrix, new[] { 4, 0 }, new[] { 4, 0 }, new[] { 5, 5 }));
           //new Task(operations.finding_path,object{matrix, new[] { 4, 0 }, new[] { 4, 0 }, new[] { 5, 5 });
           
        }
    }
}
