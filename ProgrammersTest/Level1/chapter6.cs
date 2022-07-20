using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Level1
{
    //chapter6- 유비케어 1번
    public class chapter6
    {
        public static int[] solution(int[] bricks)
        {

            int sum = bricks.Sum();
            //foreach (int item in bricks){sum += item;}

            int[] answer = new int[10];
            

            for (int i = 1; i < sum; i++)
            {
                if (sum % i == 0)
                {
                    int space = i;
                    for (int j = 0; j < answer.Length; j++)
                    {
                        answer[j] = space;
                        Console.WriteLine(Convert.ToString(answer[j]));
                        break;
                    }
                }
            }
            return answer;
        }
            
        public static void Chapter6()
        {
            int[] Bricks;
            Bricks = new int[] { 2, 1, 1, 2 };
            //Bricks = new int[] { 1, 2, 3, 2, 1 };
            //Bricks = new int[] { 1, 1, 1, 1, 1, 1 };

            int[] answer;
            answer = solution(Bricks);
            foreach (var item in answer)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
     

