using System.Linq;

namespace DW_Test
{
    public class CompareMethod
    {
        public static int Compare(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return 1;
            }
            else if (b.Length < a.Length)
            {
                return -1;
            }

            return a.CompareTo(b);
        }
    }
}
