using System.Runtime.InteropServices;
using System;
using System.Reflection;
using System.Text;

class Test
{
    class Ansi
    {
        [DllImport(@"PInvoke_ExactSpellingServer", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int Marshal_Int_InOut([In, Out] int intValue);

        [DllImport(@"PInvoke_ExactSpellingServer", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int MarshalPointer_Int_InOut([In, Out] ref int intValue);

        [DllImport(@"PInvoke_ExactSpellingServer", CharSet = CharSet.Ansi, ExactSpelling = false)]
        public static extern int Marshal_Int_InOut2([In, Out] int intValue);

        [DllImport(@"PInvoke_ExactSpellingServer", CharSet = CharSet.Ansi, ExactSpelling = false)]
        public static extern int MarshalPointer_Int_InOut2([In, Out] ref int intValue);
    }

    class Unicode
    {
        [DllImport(@"PInvoke_ExactSpellingServer", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int Marshal_Int_InOut([In, Out] int intValue);

        [DllImport(@"PInvoke_ExactSpellingServer", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern int MarshalPointer_Int_InOut([In, Out] ref int intValue);

        [DllImport(@"PInvoke_ExactSpellingServer", CharSet = CharSet.Unicode, ExactSpelling = false)]
        public static extern int Marshal_Int_InOut2([In, Out] int intValue);

        [DllImport(@"PInvoke_ExactSpellingServer", CharSet = CharSet.Unicode, ExactSpelling = false)]
        public static extern int MarshalPointer_Int_InOut2([In, Out] ref int intValue);
    }

    public static int Main(string[] args)
    {
        int intManaged = 1000;
        int intNative = 2000;
        int intReturn = 3000;

        TestHelper.BeginSubScenario("Method Unicode.Marshal_Int_InOut: ExactSpelling = true");
        int int1 = intManaged;
        int intRet1 = Unicode.Marshal_Int_InOut(int1);
        TestHelper.Assert(intReturn, intRet1, "The return value is wrong");
        TestHelper.Assert(intManaged, int1, "The parameter value is changed");

        TestHelper.BeginSubScenario("Method Unicode.MarshalPointer_Int_InOut: ExactSpelling = true");
        int int2 = intManaged;
        int intRet2 = Unicode.MarshalPointer_Int_InOut(ref int2);
        TestHelper.Assert(intReturn, intRet2, "The return value is wrong");
        TestHelper.Assert(intNative, int2, "The parameter value is wrong");

        TestHelper.BeginSubScenario("Method Ansi.Marshal_Int_InOut: ExactSpelling = true");
        int int3 = intManaged;
        int intRet3 = Ansi.Marshal_Int_InOut(int3);
        TestHelper.Assert(intReturn, intRet3, "The return value is wrong");
        TestHelper.Assert(intManaged, int3, "The parameter value is changed");

        TestHelper.BeginSubScenario("Method Ansi.MarshalPointer_Int_InOut: ExactSpelling = true");
        int int4 = intManaged;
        int intRet4 = Ansi.MarshalPointer_Int_InOut(ref int4);
        TestHelper.Assert(intReturn, intRet4, "The return value is wrong");
        TestHelper.Assert(intNative, int4, "The parameter value is changed");

#if BUG709925
        int intReturnAnsi = 4000;
        int intReturnUnicode = 5000;

        TestHelper.BeginSubScenario("Method Unicode.Marshal_Int_InOut2: ExactSpelling = false");
        int int5 = intManaged;
        int intRet5 = Unicode.Marshal_Int_InOut2(int5);
        TestHelper.Assert(intReturnUnicode, intRet5, "The return value is wrong");
        TestHelper.Assert(intManaged, int5, "The parameter value is changed");
        
        TestHelper.BeginSubScenario("Method Unicode.MarshalPointer_Int_InOut2: ExactSpelling = false");
        int int6 = intManaged;
        int intRet6 = Unicode.MarshalPointer_Int_InOut2(ref int6);
        TestHelper.Assert(intReturnAnsi, intRet6, "The return value is wrong");
        TestHelper.Assert(intNative, int6, "The parameter value is changed");

        TestHelper.BeginSubScenario("Method Ansi.Marshal_Int_InOut2: ExactSpelling = false");
        int int7 = intManaged;
        int intRet7 = Ansi.Marshal_Int_InOut2(int7);
        TestHelper.Assert(intReturnUnicode, intRet7, "The return value is wrong");
        TestHelper.Assert(intManaged, int7, "The parameter value is changed");

        TestHelper.BeginSubScenario("Method Ansi.MarshalPointer_Int_InOut2: ExactSpelling = false");
        int int8 = intManaged;
        int intRet8 = Ansi.MarshalPointer_Int_InOut2(ref int8);
        TestHelper.Assert(intReturnAnsi, intRet8, "The return value is wrong");
        TestHelper.Assert(intNative, int8, "The parameter value is changed");
#endif

        if (TestHelper.Pass)
        {
            Console.WriteLine("Passed!");
            return 100;
        }
        else
        {
            Console.WriteLine("Failed");
            return 101;
        }
    }
}