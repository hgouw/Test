using System;
using System.Collections.Generic;

namespace Sort
{
    class TitleComparer : IComparer<string>
    {
        int IComparer<string>.Compare(string s1, string s2)
        {
            int ret = 0;

            char c1 = s1[0];
            char c2 = s2[0];

            if (char.IsNumber(c1))
            {
                if (char.IsNumber(c2))
                {

                    //-1 (c1 < c2)
                    //0  (c1 = c2)
                    //1  (c1 > c2)
                }
                else
                {

                }
            }
            else
            {
                if (char.IsNumber(c2))
                {

                }
                else
                {

                }
            }

            return ret;
        }
    }

    //int CompareChar(char c1, char c2)
    //{
    //    int dif;
    //    dif = char.ToUpper(c1) - char.ToUpper(c2);
    //    if (diff != 0)
    //        dif = char.ToLower(c1) - char.ToLower(c2);
    //    return dif;
    //}

    //char x = '9'; // '9' = ASCII 57
    //int b = x - '0'; //That is '9' - '0' = 57 - 48 = 9

    class CustomStringComparer : IComparer<string>
    {
        // Sort as Paul, George, Ringo, John then the rest
        int IComparer<string>.Compare(string s1, string s2)
        {
            char c1 = s1[0];
            char c2 = s2[0];

            switch (c1)
            {
                case 'g':
                    if (c2 == 'p')
                    {
                        return -1;
                    }
                    else
                    {
                        goto default;
                    }
                case 'r':
                    if (c2 == 'p' || c2 == 'g')
                    {
                        return -1;
                    }
                    else
                    {
                        goto default;
                    }
                case 'j':
                    if (c2 == 'p' || c2 == 'g' || c2 == 'r')
                    {
                        return -1;
                    }
                    else
                    {
                        goto default;
                    }
                default:
                    int ret = (c2 != c1) ? 1 : string.Compare(s1, s2, StringComparison.Ordinal);
                    return ret;
            }
        }
    }
}