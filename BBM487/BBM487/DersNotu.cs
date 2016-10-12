using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBM487
{
    public static class DersNotu
    {
        public const float A1 = 4.0f;
        public const float A2 = 3.75f;
        public const float A3 = 3.50f;
        public const float B1 = 3.25f;
        public const float B2 = 3.0f;
        public const float B3 = 2.75f;
        public const float C1 = 2.50f;
        public const float C2 = 2.25f;
        public const float C3 = 2.0f;
        public const float D = 1.75f;
        public const float F1 = -1.0f;
        public const float F2 = -2.0f;
        public const float F3 = -3.0f;
        public const float YOK = -4.0f;

        public static String harfNotu(float not)
        {
            if (not == A1) return "A1";
            if (not == A2) return "A2";
            if (not == A3) return "A3";
            if (not == B1) return "B1";
            if (not == B2) return "B2";
            if (not == B3) return "B3";
            if (not == C1) return "C1";
            if (not == C2) return "C2";
            if (not == C3) return "C3";
            if (not == D) return "D";
            if (not == F1) return "F1";
            if (not == F2) return "F2";
            if (not == F3) return "F3";
            if (not == YOK) return "YOK";
            return "";
        }
        public static float rakamNotu(String harfNotu)
        {
            if (harfNotu.ToUpper().Equals("A1")) return A1;
            if (harfNotu.ToUpper().Equals("A2")) return A2;
            if (harfNotu.ToUpper().Equals("A3")) return A3;
            if (harfNotu.ToUpper().Equals("B1")) return B1;
            if (harfNotu.ToUpper().Equals("B2")) return B2;
            if (harfNotu.ToUpper().Equals("B3")) return B3;
            if (harfNotu.ToUpper().Equals("C1")) return C1;
            if (harfNotu.ToUpper().Equals("C2")) return C2;
            if (harfNotu.ToUpper().Equals("C3")) return C3;
            if (harfNotu.ToUpper().Equals("D")) return D;
            if (harfNotu.ToUpper().Equals("F1")) return F1;
            if (harfNotu.ToUpper().Equals("F2")) return F2;
            if (harfNotu.ToUpper().Equals("F3")) return F3;
            if (harfNotu.ToUpper().Equals("YOK")) return YOK;
            return 0;
        }
    }

}
