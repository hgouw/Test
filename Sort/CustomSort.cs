using System;
using System.Collections.Generic;

namespace Sort
{
    class TitleComparer : IComparer<string>
    {
        int IComparer<string>.Compare(string s1, string s2)
        {
            // -1 (s1 < s2) s1 then s2
            // 0  (s1 = s2)
            // 1  (s1 > s2) s2 then s1

            for (int i = 0; i < s1.Length; i++)
            {
                if (s2.Length < (i + 1)) // s1 is longer than s2
                {
                    return 1;
                }

                if ((i == s1.Length - 1) && (i < s2.Length - 1)) // s2 is longer s1
                {
                    return -1;
                }

                char c1 = s1[i];
                char c2 = s2[i];

                if (char.IsNumber(c1))
                {
                    if (char.IsNumber(c2))
                    {
                        int diff = c1 - c2;
                        if (diff > 0) // s2 then s1
                        {
                            return 1;
                        }
                        else if (diff < 0) // s1 then s2
                        {
                            return -1;
                        }
                    }
                    else // s2 then s1
                    {
                        return 1;
                    }
                }
                else
                {
                    if (char.IsNumber(c2)) // s1 then s2
                    {
                        return -1;
                    }
                    else
                    {
                        var str1 = char.ToString(c1).ToUpper();
                        var str2 = char.ToString(c2).ToUpper();
                        if (!str1.Equals(str2))
                        {
                            return string.Compare(str1, str2, StringComparison.Ordinal);
                        }
                    }
                }
            }

            return 0;
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