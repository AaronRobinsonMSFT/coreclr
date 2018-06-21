// YehiaM 10:12 AM 3/19/2002

using System;
using System.Text;
using System.Runtime.InteropServices;

[assembly: BestFitMapping(false, ThrowOnUnmappableChar = true)]

[StructLayout(LayoutKind.Sequential)]
[BestFitMapping(false, ThrowOnUnmappableChar = false)]
public struct LPStrTestStruct
{
    [MarshalAs(UnmanagedType.LPStr)]
    public String str;
}

[StructLayout(LayoutKind.Sequential)]
[BestFitMapping(false, ThrowOnUnmappableChar = false)]
public class LPStrTestClass
{
    [MarshalAs(UnmanagedType.LPStr)]
    public String str;
}

public class BFM_LPStrMarshaler
{
    static int iCountErrors = 0;
    static int iCountTestCases = 0;

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = false)]
    public static extern bool LPStrBuffer_In_String([In][MarshalAs(UnmanagedType.LPStr)]String s);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = false)]
    public static extern bool LPStrBuffer_InByRef_String([In][MarshalAs(UnmanagedType.LPStr)]ref String s);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = false)]
    public static extern bool LPStrBuffer_InOutByRef_String([In, Out][MarshalAs(UnmanagedType.LPStr)]ref String s);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = false)]
    public static extern bool LPStrBuffer_In_StringBuilder([In][MarshalAs(UnmanagedType.LPStr)]StringBuilder s);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = false)]
    public static extern bool LPStrBuffer_InByRef_StringBuilder([In][MarshalAs(UnmanagedType.LPStr)]ref StringBuilder s);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = false)]
    public static extern bool LPStrBuffer_InOutByRef_StringBuilder([In, Out][MarshalAs(UnmanagedType.LPStr)]ref StringBuilder s);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = false)]
    public static extern bool LPStrBuffer_In_Struct_String([In][MarshalAs(UnmanagedType.Struct)]LPStrTestStruct strStruct);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = false)]
    public static extern bool LPStrBuffer_InByRef_Struct_String([In][MarshalAs(UnmanagedType.Struct)]ref LPStrTestStruct strStruct);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = false)]
    public static extern bool LPStrBuffer_InOutByRef_Struct_String([In, Out][MarshalAs(UnmanagedType.Struct)]ref LPStrTestStruct strStruct);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = false)]
    public static extern bool LPStrBuffer_In_Array_String([In][MarshalAs(UnmanagedType.LPArray)]String[] strArray);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = false)]
    public static extern bool LPStrBuffer_InByRef_Array_String([In][MarshalAs(UnmanagedType.LPArray)]ref String[] strArray);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = false)]
    public static extern bool LPStrBuffer_InOutByRef_Array_String([In, Out][MarshalAs(UnmanagedType.LPArray)]ref String[] Array);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = false)]
    public static extern bool LPStrBuffer_In_Class_String([In][MarshalAs(UnmanagedType.LPStruct)]LPStrTestClass strClass);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = false)]
    public static extern bool LPStrBuffer_InByRef_Class_String([In][MarshalAs(UnmanagedType.LPStruct)]ref LPStrTestClass strClass);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = false)]
    public static extern bool LPStrBuffer_InOutByRef_Class_String([In, Out][MarshalAs(UnmanagedType.LPStruct)]ref LPStrTestClass strClass);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = true, ThrowOnUnmappableChar = true)]
    public static extern bool LPStrBuffer_In_Array_Struct([In][MarshalAs(UnmanagedType.LPArray)]LPStrTestStruct[] structArray);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = true, ThrowOnUnmappableChar = true)]
    public static extern bool LPStrBuffer_InByRef_Array_Struct([In][MarshalAs(UnmanagedType.LPArray)]ref LPStrTestStruct[] structArray);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = true, ThrowOnUnmappableChar = true)]
    public static extern bool LPStrBuffer_InOutByRef_Array_Struct([In, Out][MarshalAs(UnmanagedType.LPArray)]ref LPStrTestStruct[] structArray);

    String GetValidString()
    {
        return "This is the initial test string.";
    }

    String GetInvalidString()
    {
        StringBuilder sbl = new StringBuilder();
        sbl.Append((char)0x2216);
        sbl.Append((char)0x2044);
        sbl.Append((char)0x2215);
        sbl.Append((char)0x0589);
        sbl.Append((char)0x2236);
        sbl.Append('乀');
        return sbl.ToString();
    }

    StringBuilder GetValidStringBuilder()
    {
        StringBuilder sb = new StringBuilder("test string.");
        return sb;
    }

    StringBuilder GetInvalidStringBuilder()
    {
        StringBuilder sbl = new StringBuilder();
        sbl.Append((char)0x2216);
        sbl.Append((char)0x2044);
        sbl.Append((char)0x2215);
        sbl.Append((char)0x0589);
        sbl.Append((char)0x2236);
        sbl.Append('乀');
        return sbl;
    }

    void testLPStrBufferString()
    {
        iCountTestCases++;
        if (!LPStrBuffer_In_String(GetInvalidString()))
        {
            Console.WriteLine("[Error] Location tcbs11");
            iCountErrors++;
        }

        iCountTestCases++;
        if (!LPStrBuffer_In_String(GetValidString()))
        {
            Console.WriteLine("[Error] Location tcbs22");
            iCountErrors++;
        }

        iCountTestCases++;
        String cTemp = GetInvalidString();
        if (!LPStrBuffer_InByRef_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tcbs33");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetValidString();
        if (!LPStrBuffer_InByRef_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tcbs44");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetInvalidString();
        String cTempClone = cTemp;
        if (!LPStrBuffer_InOutByRef_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tcbs55");
            iCountErrors++;
        }
        if (cTemp == cTempClone)
        {
            Console.WriteLine("The string should be changed");
            Console.WriteLine("[Error] Location tcbs66");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetValidString();
        cTempClone = cTemp;
        if (!LPStrBuffer_InOutByRef_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tcbs77");
            iCountErrors++;
        }
        if (cTemp != cTempClone)
        {
            Console.WriteLine("[Error] Location tcbs88");
            iCountErrors++;
        }
    }

    void testLPStrBufferStringBuilder()
    {
        iCountTestCases++;
        StringBuilder sb = GetInvalidStringBuilder();
        if (!LPStrBuffer_In_StringBuilder(sb))
        {
            Console.WriteLine("[Error] Location tcbsb11");
            iCountErrors++;
        }

        iCountTestCases++;
        if (!LPStrBuffer_In_StringBuilder(GetValidStringBuilder()))
        {
            Console.WriteLine("[Error] Location tcbsb22");
            iCountErrors++;
        }

        iCountTestCases++;
        StringBuilder cTemp = GetInvalidStringBuilder();
        if (!LPStrBuffer_InByRef_StringBuilder(ref cTemp))
        {
            Console.WriteLine("[Error] Location tcbsb33");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetValidStringBuilder();
        if (!LPStrBuffer_InByRef_StringBuilder(ref cTemp))
        {
            Console.WriteLine("[Error] Location tcbsb44");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetInvalidStringBuilder();
        StringBuilder cTempClone = cTemp;
        if (!LPStrBuffer_InOutByRef_StringBuilder(ref cTemp))
        {
            Console.WriteLine("[Error] Location tcbsb55");
            iCountErrors++;
        }
        if (cTemp.ToString() == cTempClone.ToString())
        {
            Console.WriteLine("The StringBuilder should be changed");
            Console.WriteLine("[Error] Location tcbsb66");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetValidStringBuilder();
        cTempClone = cTemp;
        if (!LPStrBuffer_InOutByRef_StringBuilder(ref cTemp))
        {
            Console.WriteLine("[Error] Location tcbsb77");
            iCountErrors++;
        }
        if (cTemp.ToString() != cTempClone.ToString())
        {
            Console.WriteLine("[Error] Location tcbsb88");
            iCountErrors++;
        }
    }

    LPStrTestStruct GetInvalidStruct()
    {
        LPStrTestStruct inValidStruct = new LPStrTestStruct();
        inValidStruct.str = GetInvalidString();

        return inValidStruct;
    }


    LPStrTestStruct GetValidStruct()
    {
        LPStrTestStruct validStruct = new LPStrTestStruct();
        validStruct.str = GetValidString();

        return validStruct;
    }

    String[] GetValidArray()
    {
        String[] s = new String[3];

        s[0] = GetValidString();
        s[1] = GetValidString();
        s[2] = GetValidString();

        return s;
    }

    String[] GetInvalidArray()
    {
        String[] s = new String[3];

        s[0] = GetInvalidString();
        s[1] = GetInvalidString();
        s[2] = GetInvalidString();

        return s;
    }

    void testLPStrBufferStruct()
    {
        iCountTestCases++;
        LPStrTestStruct lpss = GetInvalidStruct();
        if (!LPStrBuffer_In_Struct_String(lpss))
        {
            Console.WriteLine("[Error] Location tlpsbs11");
            iCountErrors++;
        }

        iCountTestCases++;
        if (!LPStrBuffer_In_Struct_String(GetValidStruct()))
        {
            Console.WriteLine("[Error] Location tlpsbs22");
            iCountErrors++;
        }

        iCountTestCases++;
        LPStrTestStruct cTemp = GetInvalidStruct();
        if (!LPStrBuffer_InByRef_Struct_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tlpsbs33");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetValidStruct();
        if (!LPStrBuffer_InByRef_Struct_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tlpsbs44");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetInvalidStruct();
        LPStrTestStruct cTempClone = cTemp;
        if (!LPStrBuffer_InOutByRef_Struct_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tlpsbs55");
            iCountErrors++;
        }
        if (cTemp.str == cTempClone.str)
        {
            Console.WriteLine("The Struct should be changed");
            Console.WriteLine("[Error] Location tlpsbs66");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetValidStruct();
        cTempClone = cTemp;
        if (!LPStrBuffer_InOutByRef_Struct_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tlpsbs77");
            iCountErrors++;
        }
        if (cTemp.str != cTempClone.str)
        {
            Console.WriteLine("[Error] Location tlpsbs88");
            iCountErrors++;
        }
    }

    void testLPStrBufferClass()
    {
        iCountTestCases++;
        LPStrTestClass lpss = new LPStrTestClass();
        lpss.str = GetInvalidString();
        if (!LPStrBuffer_In_Class_String(lpss))
        {
            Console.WriteLine("[Error] Location tlpsbc11");
            iCountErrors++;
        }

        iCountTestCases++;
        lpss.str = GetValidString();
        if (!LPStrBuffer_In_Class_String(lpss))
        {
            Console.WriteLine("[Error] Location tlpsbc22");
            iCountErrors++;
        }

        iCountTestCases++;
        LPStrTestClass cTemp = new LPStrTestClass();
        cTemp.str = GetInvalidString();
        if (!LPStrBuffer_InByRef_Class_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tlpsbc33");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp.str = GetValidString();
        if (!LPStrBuffer_InByRef_Class_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tlpsbc44");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp.str = GetInvalidString();
        LPStrTestClass cTempClone = new LPStrTestClass();
        cTempClone.str = cTemp.str;
        if (!LPStrBuffer_InOutByRef_Class_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tlpsbc55");
            iCountErrors++;
        }
        if (cTemp.str == cTempClone.str)
        {
            Console.WriteLine("The Class should be changed");
            Console.WriteLine("[Error] Location tlpsbc66");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp.str = GetValidString();
        cTempClone.str = cTemp.str;
        if (!LPStrBuffer_InOutByRef_Class_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tlpsbc77");
            iCountErrors++;
        }
        if (cTemp.str != cTempClone.str)
        {
            Console.WriteLine("[Error] Location tlpsbc88");
            iCountErrors++;
        }
    }

    void testLPStrBufferArray()
    {
        iCountTestCases++;
        String[] lpss = GetInvalidArray();
        if (!LPStrBuffer_In_Array_String(lpss))
        {
            Console.WriteLine("[Error] Location tlpsba11");
            iCountErrors++;
        }

        iCountTestCases++;
        if (!LPStrBuffer_In_Array_String(GetValidArray()))
        {
            Console.WriteLine("[Error] Location tlpsba22");
            iCountErrors++;
        }

        iCountTestCases++;
        String[] cTemp = GetInvalidArray();
        if (!LPStrBuffer_InByRef_Array_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tlpsba33");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetValidArray();
        if (!LPStrBuffer_InByRef_Array_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tlpsba44");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetInvalidArray();
        String[] cTempClone = new String[3];
        cTempClone[0] = cTemp[0];
        Console.WriteLine(cTemp.Length);
        if (!LPStrBuffer_InOutByRef_Array_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tlpsba55");
            iCountErrors++;
        }
        Console.WriteLine(cTemp.Length);
        if (cTemp[0] == cTempClone[0])
        {
            Console.WriteLine("The Array should be changed");
            Console.WriteLine("[Error] Location tlpsba66");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetValidArray();
        cTempClone[0] = cTemp[0];
        if (!LPStrBuffer_InOutByRef_Array_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tlpsba77");
            iCountErrors++;
        }
        if (cTemp[0] != cTempClone[0])
        {
            Console.WriteLine("[Error] Location tlpsba88");
            iCountErrors++;
        }
    }

    void testLPStrBufferArrayOfStructs()
    {
        iCountTestCases++;
        LPStrTestStruct[] lpss = new LPStrTestStruct[2];
        lpss[0] = GetInvalidStruct();
        lpss[1] = GetInvalidStruct();
        if (!LPStrBuffer_In_Array_Struct(lpss))
        {
            Console.WriteLine("[Error] Location tlpsba11");
            iCountErrors++;
        }

        iCountTestCases++;
        lpss = new LPStrTestStruct[2];
        lpss[0] = GetValidStruct();
        lpss[1] = GetValidStruct();
        if (!LPStrBuffer_In_Array_Struct(lpss))
        {
            Console.WriteLine("[Error] Location tlpsba22");
            iCountErrors++;
        }

        iCountTestCases++;
        lpss = new LPStrTestStruct[2];
        lpss[0] = GetInvalidStruct();
        lpss[1] = GetInvalidStruct();
        if (!LPStrBuffer_InByRef_Array_Struct(ref lpss))
        {
            Console.WriteLine("[Error] Location tlpsba33");
            iCountErrors++;
        }

        iCountTestCases++;
        lpss = new LPStrTestStruct[2];
        lpss[0] = GetValidStruct();
        lpss[1] = GetValidStruct();
        if (!LPStrBuffer_InByRef_Array_Struct(ref lpss))
        {
            Console.WriteLine("[Error] Location tlpsba44");
            iCountErrors++;
        }

        iCountTestCases++;
        lpss = new LPStrTestStruct[2];
        lpss[0] = GetInvalidStruct();
        lpss[1] = GetInvalidStruct();

        LPStrTestStruct[] lpssClone = new LPStrTestStruct[2];
        lpssClone[0].str = lpss[0].str;
        lpssClone[1].str = lpss[1].str;

        if (!LPStrBuffer_InOutByRef_Array_Struct(ref lpss))
        {
            Console.WriteLine("[Error] Location tlpsba55");
            iCountErrors++;
        }
        if (lpssClone[0].str == lpss[0].str)
        {
            Console.WriteLine("The Array should be changed");
            Console.WriteLine("[Error] Location tlpsba66");
            iCountErrors++;
        }

        iCountTestCases++;
        lpss = new LPStrTestStruct[2];
        lpss[0] = GetValidStruct();
        lpss[1] = GetValidStruct();

        lpssClone = new LPStrTestStruct[2];
        lpssClone[0].str = lpss[0].str;
        lpssClone[1].str = lpss[1].str;

        if (!LPStrBuffer_InOutByRef_Array_Struct(ref lpss))
        {
            Console.WriteLine("[Error] Location tlpsba77");
            iCountErrors++;
        }
        if (lpssClone[0].str != lpss[0].str)
        {
            Console.WriteLine("[Error] Location tlpsba88");
            iCountErrors++;
        }
    }

    Boolean runTest()
    {
        testLPStrBufferString();

        testLPStrBufferStringBuilder();

        testLPStrBufferStruct();

        testLPStrBufferArray();

        testLPStrBufferClass();

        testLPStrBufferArrayOfStructs();

        if (iCountErrors > 0)
            return false;

        return true;
    }

    public static int Main()
    {
        if (System.Globalization.CultureInfo.CurrentCulture.Name != "en-US")
        {
            Console.WriteLine("Non english platforms are not supported");
            Console.WriteLine("passing without running tests");

            Console.WriteLine("--- Sucess");
            return 100;
        }

        Boolean bResult = false;
        BFM_LPStrMarshaler v = new BFM_LPStrMarshaler();

        try
        {
            bResult = v.runTest();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            bResult = false;
        }

        // ---------- Final Result --------------

        Console.WriteLine("iCountTestCases : " + iCountTestCases);
        Console.WriteLine("iCountErrors    : " + iCountErrors);

        if (iCountErrors > 0)
            bResult = false;

        if (bResult == true)
        {
            Console.WriteLine("--- Sucess");
            return 100;
        }
        else
        {
            Console.WriteLine("--- FAIL!!");
            return 11;
        }
    }
}