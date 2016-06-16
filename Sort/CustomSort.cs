using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class CustomStringComparer : IComparer<string>
    {
        int IComparer<string>.Compare(string s1, string s2)
        {
            char l1 = s1[0];
            char l2 = s2[0];

            switch (l1)
            {
                case 'g':
                    if (l2 == 'p')
                    {
                        return -1;
                    }
                    else
                    {
                        goto default;
                    }
                case 'r':
                    if (l2 == 'p' || l2 == 'g')
                    {
                        return -1;
                    }
                    else
                    {
                        goto default;
                    }
                case 'j':
                    if (l2 == 'p' || l2 == 'g' || l2 == 'r')
                    {
                        return -1;
                    }
                    else
                    {
                        goto default;
                    }
                default:
                    int ret = (l2 != l1) ? 1 : string.Compare(s1, s2, StringComparison.Ordinal);
                    return ret;
            }
        }

        //public int IComparer<string>.Compare(string s1, string s2)
        //{
        //    char l1 = s1[0];
        //    char l2 = s2[0];
        //    int ret;

        //    switch (l1)
        //    {
        //        case 'g':
        //            if (l2 == 'p')
        //            {
        //                return -1;
        //            }
        //            else
        //            {
        //                goto default;
        //            }
        //        case 'r':
        //            if (l2 == 'p' || l2 == 'g')
        //            {
        //                return -1;
        //            }
        //            else
        //            {
        //                goto default;
        //            }
        //        case 'j':
        //            if (l2 == 'p' || l2 == 'g' || l2 == 'r')
        //            {
        //                return -1;
        //            }
        //            else
        //            {
        //                goto default;
        //            }
        //        default: ret = (l2 != l1) ? 1 : s1.CompareTo(s2); return ret;
        //    }
        //    return ret;
        //}

        //public int Compare(string x, string y)
        //{
        //    int ix = x == "b" ? 0 : x == "c" ? 1 : 2;
        //    int iy = y == "b" ? 0 : y == "c" ? 1 : 2;
        //    return ix.CompareTo(iy);
        //}

        //public int Compare(string x, string y)
        //{
        //    //todo null checks on input
        //    var pairs = x.Zip(y, (a, b) => new { x = a, y = b });
        //    foreach (var pair in pairs)
        //    {
        //        int value = pair.x.CompareTo(pair.y);
        //        if (value != 0)
        //            return value;
        //    }
        //    //if we got here then either they are the same,
        //    //or one starts with the other
        //    return y.Length.CompareTo(x.Length); //note x and y are reversed here
        //}
    }
}