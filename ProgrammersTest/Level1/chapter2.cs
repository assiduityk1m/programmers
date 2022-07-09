using System;
using System.Collections.Generic;
using System.Text;

namespace Level1
{
    //chapter2 - 로또의 최고 순위와 최저 순위
    public class chapter2
    {
        public static int[] solution(int[] lottos, int[] win_nums)
        {
            int sameValue = 0;
            int zeroValue = 0;
            int[] rank = new int[7] { 6, 6, 5, 4, 3, 2, 1 };

            for (int i = 0; i < lottos.Length; i++)
            {
                if (lottos[i] == 0)
                {
                    zeroValue++;
                    continue;
                }

                for (int j = 0; j < win_nums.Length; j++)
                {
                    if (lottos[i] == win_nums[j])
                    {
                        sameValue++;
                        break;
                    }
                }
            }

            int min = sameValue;
            int max = min + zeroValue;

            int[] answer = new int[2] { rank[max], rank[min] };

            return answer;
        }
    }

   
}
