﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Level1
{
    //chapter3 - 직사각형 별찍기
    public class chapter3
    {      
       
           public static void Chapter3()
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' '); //입력후 스페이스바





            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
