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

        public static void Chapter2()
        {
            int[] Lottos;
            int[] Win_nums;
            Lottos = new int[6] { 44, 1, 0, 0, 31, 25 };
            Win_nums = new int[6] { 31, 10, 45, 1, 6, 19 };

            int[] answer;
            answer = solution(Lottos, Win_nums);

            //Console.WriteLine("로또의 최고순위는 " +  Convert.ToString(answer[0]) + "등 최저순위는 " +  Convert.ToString(answer[1]) + "등 입니다.");

            //한번에 배열 출력하기
            foreach (var item in answer)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
