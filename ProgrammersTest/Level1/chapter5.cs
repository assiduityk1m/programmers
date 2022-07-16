using System;
using System.Collections.Generic;
using System.Text;

namespace Level1
{
    //chapter5 - 콜라츠 추측
    public class chapter5
    {

        public static int solution(int num)
        {
            // 입력받은 int형의 num을 long으로 변환해준다.
            long temp = num;
            // 반복 횟수를 측정
            int answer = 0;
            // 숫자가 1이될때까지 반복한다.
            while (temp != 1)
            {
                // 반복횟수를 1 올려준다.
                ++answer;

                // 숫자가 짝수면 나누기 2 , 홀수면 3곱하고 1을 더함
                temp = temp % 2 == 0 ? temp / 2 : temp * 3 + 1;

                // 만약 반복숫자가 500이 넘어버리면
                if (answer > 500)
                {
                    return -1;
                }
            }
            // 몇번 반복했는지 리턴
            return answer;
        }


        public static void Chapter5()
        {
            int num = 6;
            Console.WriteLine(solution(num));
        }
    }
}
