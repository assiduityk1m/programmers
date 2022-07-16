using System;
using System.Collections.Generic;
using System.Text;

namespace Level1

{
    //chapter4 - 평균 구하기
    public class chapter4
    {
        public static double solution(int[] arr)
        {
            double avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                avg += arr[i];
            }
            double answer = avg / arr.Length;
            return answer;
        }

        public static void Chapter4()
        {
            int[] arry;
            arry = new int[4] { 1, 2, 3, 4};               
            
            Console.WriteLine(solution(arry));

        }
    }
}
