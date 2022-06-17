using System;
using System.Collections.Generic;
using System.Text;

namespace Level1
{
    class chapter1
    {
    
        /// <summary>
        /// 가운데 글자 가져오기
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string CenterValue(string s)
        {
            string answer = "";

            if (s.Length % 2 == 0 && s.Length != 0)
            {
                 
                //answer += s[s.Length / 2  - 1];
                //answer += s[s.Length / 2];

                //answer = s[s.Length / 2 - 1].ToString() + s[s.Length / 2].ToString();

                answer = Convert.ToString(s[s.Length / 2 - 1]) + Convert.ToString(s[s.Length / 2]);
            }
            else if (s.Length % 2 == 1)
            {
                answer += s[s.Length / 2];
            }

            return answer;
        }
    }
}
