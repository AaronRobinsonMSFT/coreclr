// YehiaM 10:12 AM 3/19/2002

using System;
using System.Text;
using System.Runtime.InteropServices;

[assembly: BestFitMapping(true, ThrowOnUnmappableChar = true)]

[StructLayout(LayoutKind.Sequential)]
[BestFitMapping(false, ThrowOnUnmappableChar = true)]
public struct LPStrTestStruct
{
    [MarshalAs(UnmanagedType.LPStr)]
    public String str;
}

[StructLayout(LayoutKind.Sequential)]
[BestFitMapping(false, ThrowOnUnmappableChar = true)]
public class LPStrTestClass
{
    [MarshalAs(UnmanagedType.LPStr)]
    public String str;
}

public class BFM_LPStrMarshaler
{
    static int iCountErrors = 0;
    static int iCountTestCases = 0;

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = true)]
    public static extern bool LPStrBuffer_In_String([In][MarshalAs(UnmanagedType.LPStr)]String s);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = true)]
    public static extern bool LPStrBuffer_InByRef_String([In][MarshalAs(UnmanagedType.LPStr)]ref String s);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = true)]
    public static extern bool LPStrBuffer_InOutByRef_String([In, Out][MarshalAs(UnmanagedType.LPStr)]ref String s);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = true)]
    public static extern bool LPStrBuffer_In_StringBuilder([In][MarshalAs(UnmanagedType.LPStr)]StringBuilder s);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = true)]
    public static extern bool LPStrBuffer_InByRef_StringBuilder([In][MarshalAs(UnmanagedType.LPStr)]ref StringBuilder s);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = true)]
    public static extern bool LPStrBuffer_InOutByRef_StringBuilder([In, Out][MarshalAs(UnmanagedType.LPStr)]ref StringBuilder s);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = true)]
    public static extern bool LPStrBuffer_In_Struct_String([In][MarshalAs(UnmanagedType.Struct)]LPStrTestStruct strStruct);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = true)]
    public static extern bool LPStrBuffer_InByRef_Struct_String([In][MarshalAs(UnmanagedType.Struct)]ref LPStrTestStruct strStruct);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = true)]
    public static extern bool LPStrBuffer_InOutByRef_Struct_String([In, Out][MarshalAs(UnmanagedType.Struct)]ref LPStrTestStruct strStruct);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = true)]
    public static extern bool LPStrBuffer_In_Array_String([In][MarshalAs(UnmanagedType.LPArray)]String[] strArray);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = true)]
    public static extern bool LPStrBuffer_InByRef_Array_String([In][MarshalAs(UnmanagedType.LPArray)]ref String[] strArray);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = true)]
    public static extern bool LPStrBuffer_InOutByRef_Array_String([In, Out][MarshalAs(UnmanagedType.LPArray)]ref String[] Array);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = true)]
    public static extern bool LPStrBuffer_In_Class_String([In][MarshalAs(UnmanagedType.LPStruct)]LPStrTestClass strClass);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = true)]
    public static extern bool LPStrBuffer_InByRef_Class_String([In][MarshalAs(UnmanagedType.LPStruct)]ref LPStrTestClass strClass);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = false, ThrowOnUnmappableChar = true)]
    public static extern bool LPStrBuffer_InOutByRef_Class_String([In, Out][MarshalAs(UnmanagedType.LPStruct)]ref LPStrTestClass strClass);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = true, ThrowOnUnmappableChar = false)]
    public static extern bool LPStrBuffer_In_Array_Struct([In][MarshalAs(UnmanagedType.LPArray)]LPStrTestStruct[] structArray);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = true, ThrowOnUnmappableChar = false)]
    public static extern bool LPStrBuffer_InByRef_Array_Struct([In][MarshalAs(UnmanagedType.LPArray)]ref LPStrTestStruct[] structArray);

    [DllImport("LPStr_BestFitMappingNative", BestFitMapping = true, ThrowOnUnmappableChar = false)]
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
        try
        {
            if (!LPStrBuffer_In_String(GetInvalidString()))
            {
                Console.WriteLine("[Error] Location tc11");
                iCountErrors++;
            }
            throw new Exception("[Err tc111] Last call should have thrown");
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Expected excpetion tce111");
        }

        iCountTestCases++;
        if (!LPStrBuffer_In_String(GetValidString()))
        {
            Console.WriteLine("[Error] Location tc22");
            iCountErrors++;
        }

        iCountTestCases++;
        String cTemp = GetInvalidString();
        try
        {
            if (!LPStrBuffer_InByRef_String(ref cTemp))
            {
                Console.WriteLine("[Error] Location tc33");
                iCountErrors++;
            }
            throw new Exception("[Err tc333] Last call should have thrown");
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Expected excpetion tce333");
        }

        iCountTestCases++;
        cTemp = GetValidString();
        if (!LPStrBuffer_InByRef_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tc44");
            iCountErrors++;
        }

        iCountTestCases++;
        try
        {
            cTemp = GetInvalidString();
            if (!LPStrBuffer_InOutByRef_String(ref cTemp))
            {
                Console.WriteLine("[Error] Location tc55");
                iCountErrors++;
            }
            throw new Exception("[Err tc555] Last call should have thrown");
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Expected excpetion tce555");
        }

        iCountTestCases++;
        cTemp = GetValidString();
        String cTempClone = cTemp;
        if (!LPStrBuffer_InOutByRef_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tc66");
            iCountErrors++;
        }
        if (cTemp != cTempClone)
        {
            Console.WriteLine("[Error] Location tc77");
            iCountErrors++;
        }
    }

    void testLPStrBufferStringBuilder()
    {
        iCountTestCases++;
        try
        {
            if (!LPStrBuffer_In_StringBuilder(GetInvalidStringBuilder()))
            {
                Console.WriteLine("[Error] Location tc11");
                iCountErrors++;
            }
            throw new Exception("[Err tc111] Last call should have thrown");
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Expected excpetion tce111");
        }

        iCountTestCases++;
        if (!LPStrBuffer_In_StringBuilder(GetValidStringBuilder()))
        {
            Console.WriteLine("[Error] Location tc22");
            iCountErrors++;
        }

        iCountTestCases++;
        StringBuilder cTemp = GetInvalidStringBuilder();
        try
        {
            if (!LPStrBuffer_InByRef_StringBuilder(ref cTemp))
            {
                Console.WriteLine("[Error] Location tc33");
                iCountErrors++;
            }
            throw new Exception("[Err tc333] Last call should have thrown");
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Expected excpetion tce333");
        }

        iCountTestCases++;
        cTemp = GetValidStringBuilder();
        if (!LPStrBuffer_InByRef_StringBuilder(ref cTemp))
        {
            Console.WriteLine("[Error] Location tc44");
            iCountErrors++;
        }

        iCountTestCases++;
        try
        {
            cTemp = GetInvalidStringBuilder();
            if (!LPStrBuffer_InOutByRef_StringBuilder(ref cTemp))
            {
                Console.WriteLine("[Error] Location tc55");
                iCountErrors++;
            }
            throw new Exception("[Err tc555] Last call should have thrown");
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Expected excpetion tce555");
        }

        iCountTestCases++;
        cTemp = GetValidStringBuilder();
        StringBuilder cTempClone = cTemp;
        if (!LPStrBuffer_InOutByRef_StringBuilder(ref cTemp))
        {
            Console.WriteLine("[Error] Location tc66");
            iCountErrors++;
        }
        if (cTemp.ToString() != cTempClone.ToString())
        {
            Console.WriteLine("[Error] Location tc77");
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
        try
        {
            if (!LPStrBuffer_In_Struct_String(GetInvalidStruct()))
            {
                Console.WriteLine("[Error] Location tlpsbs11");
                iCountErrors++;
            }
            throw new Exception("[Err tlpsbs111] Last call should have thrown");
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Expected excpetion tlpsbse111");
        }

        iCountTestCases++;
        if (!LPStrBuffer_In_Struct_String(GetValidStruct()))
        {
            Console.WriteLine("[Error] Location tlpsbs22");
            iCountErrors++;
        }

        iCountTestCases++;
        LPStrTestStruct cTemp = GetInvalidStruct();
        try
        {
            if (!LPStrBuffer_InByRef_Struct_String(ref cTemp))
            {
                Console.WriteLine("[Error] Location tlpsbs33");
                iCountErrors++;
            }
            throw new Exception("[Err tlpsbs333] Last call should have thrown");
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Expected excpetion tlpsbse333");
        }

        iCountTestCases++;
        cTemp = GetValidStruct();
        if (!LPStrBuffer_InByRef_Struct_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tlpsbs44");
            iCountErrors++;
        }

        iCountTestCases++;
        try
        {
            cTemp = GetInvalidStruct();
            if (!LPStrBuffer_InOutByRef_Struct_String(ref cTemp))
            {
                Console.WriteLine("[Error] Location tlpsbs55");
                iCountErrors++;
            }
            throw new Exception("[Err tlpsbs555] Last call should have thrown");
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Expected excpetion tlpsbse555");
        }

        iCountTestCases++;
        cTemp = GetValidStruct();
        LPStrTestStruct cTempClone = new LPStrTestStruct();
        cTempClone.str = cTemp.str;
        if (!LPStrBuffer_InOutByRef_Struct_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tlpsbs66");
            iCountErrors++;
        }
        if (cTemp.str != cTempClone.str)
        {
            Console.WriteLine("[Error] Location tlpsbs77");
            iCountErrors++;
        }
    }

    void testLPStrBufferClass()
    {
        iCountTestCases++;
        LPStrTestClass cTest = new LPStrTestClass();
        try
        {
            cTest.str = GetInvalidString();
            if (!LPStrBuffer_In_Class_String(cTest))
            {
                Console.WriteLine("[Error] Location tlpsbc11");
                iCountErrors++;
            }
            throw new Exception("[Err tlpsbc111] Last call should have thrown");
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Expected excpetion tlpsbce111");
        }

        iCountTestCases++;
        cTest.str = GetValidString();
        if (!LPStrBuffer_In_Class_String(cTest))
        {
            Console.WriteLine("[Error] Location tlpsbc22");
            iCountErrors++;
        }

        iCountTestCases++;
        LPStrTestClass cTemp = new LPStrTestClass();
        cTemp.str = GetInvalidString();
        try
        {
            if (!LPStrBuffer_InByRef_Class_String(ref cTemp))
            {
                Console.WriteLine("[Error] Location tlpsbc33");
                iCountErrors++;
            }
            throw new Exception("[Err tlpsbc333] Last call should have thrown");
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Expected excpetion tlpsbce333");
        }

        iCountTestCases++;
        cTemp.str = GetValidString();
        if (!LPStrBuffer_InByRef_Class_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tlpsbc44");
            iCountErrors++;
        }

        iCountTestCases++;
        try
        {
            cTemp.str = GetInvalidString();
            if (!LPStrBuffer_InOutByRef_Class_String(ref cTemp))
            {
                Console.WriteLine("[Error] Location tlpsbc55");
                iCountErrors++;
            }
            throw new Exception("[Err tlpsbc555] Last call should have thrown");
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Expected excpetion tlpsbce555");
        }

        iCountTestCases++;
        cTemp.str = GetValidString();
        LPStrTestClass cTempClone = new LPStrTestClass();
        cTempClone.str = cTemp.str;
        if (!LPStrBuffer_InOutByRef_Class_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tlpsbc66");
            iCountErrors++;
        }
        if (cTemp.str != cTempClone.str)
        {
            Console.WriteLine("[Error] Location tlpsbc77");
            iCountErrors++;
        }
    }

    void testLPStrBufferArray()
    {
        iCountTestCases++;
        String[] cTest = null;
        try
        {
            cTest = GetInvalidArray();
            Console.WriteLine(cTest[0] + " " + cTest[1] + " " + cTest[2] + " ");
            if (!LPStrBuffer_In_Array_String(cTest))
            {
                Console.WriteLine("[Error] Location tlpsba11");
                iCountErrors++;
            }
            throw new Exception("[Err tlpsba111] Last call should have thrown");
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Expected excpetion tlpsbae111");
        }

        iCountTestCases++;
        cTest = GetValidArray();
        if (!LPStrBuffer_In_Array_String(cTest))
        {
            Console.WriteLine("[Error] Location tlpsba22");
            iCountErrors++;
        }

        iCountTestCases++;
        String[] cTemp = GetInvalidArray();
        try
        {
            if (!LPStrBuffer_InByRef_Array_String(ref cTemp))
            {
                Console.WriteLine("[Error] Location tlpsba33");
                iCountErrors++;
            }
            throw new Exception("[Err tlpsba333] Last call should have thrown");
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Expected excpetion tlpsbae333");
        }

        iCountTestCases++;
        cTemp = GetValidArray();
        if (!LPStrBuffer_InByRef_Array_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tlpsba44");
            iCountErrors++;
        }

        iCountTestCases++;
        try
        {
            cTemp = GetInvalidArray();
            if (!LPStrBuffer_InOutByRef_Array_String(ref cTemp))
            {
                Console.WriteLine("[Error] Location tlpsba55");
                iCountErrors++;
            }
            throw new Exception("[Err tlpsba555] Last call should have thrown");
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Expected excpetion tlpsbae555");
        }

        iCountTestCases++;
        cTemp = GetValidArray();
        String[] cTempClone = new String[3];
        cTempClone[0] = cTemp[0];
        if (!LPStrBuffer_InOutByRef_Array_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tlpsba66");
            iCountErrors++;
        }
        if (cTemp[0] != cTempClone[0])
        {
            Console.WriteLine("[Error] Location tlpsba77");
            iCountErrors++;
        }
    }

    void testLPStrBufferArrayOfStructs()
    {
        iCountTestCases++;
        LPStrTestStruct[] lpss = null;
        try
        {
            lpss = new LPStrTestStruct[2];
            lpss[0] = GetInvalidStruct();
            lpss[1] = GetInvalidStruct();

            if (!LPStrBuffer_In_Array_Struct(lpss))
            {
                Console.WriteLine("[Error] Location tlpsba11");
                iCountErrors++;
            }
            throw new Exception("[Err tlpsba111] Last call should have thrown");
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Expected excpetion tlpsbae111");
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

        try
        {
            if (!LPStrBuffer_InByRef_Array_Struct(ref lpss))
            {
                Console.WriteLine("[Error] Location tlpsba33");
                iCountErrors++;
            }
            throw new Exception("[Err tlpsba333] Last call should have thrown");
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Expected excpetion tlpsbae333");
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
        try
        {
            lpss = new LPStrTestStruct[2];
            lpss[0] = GetInvalidStruct();
            lpss[1] = GetInvalidStruct();

            if (!LPStrBuffer_InOutByRef_Array_Struct(ref lpss))
            {
                Console.WriteLine("[Error] Location tlpsba55");
                iCountErrors++;
            }
            throw new Exception("[Err tlpsba555] Last call should have thrown");
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Expected excpetion tlpsbae555");
        }

        iCountTestCases++;
        lpss = new LPStrTestStruct[2];
        lpss[0] = GetValidStruct();
        lpss[1] = GetValidStruct();

        LPStrTestStruct[] lpssClone = new LPStrTestStruct[2];
        lpssClone[0].str = lpss[0].str;
        lpssClone[1].str = lpss[1].str;

        if (!LPStrBuffer_InOutByRef_Array_Struct(ref lpss))
        {
            Console.WriteLine("[Error] Location tlpsba66");
            iCountErrors++;
        }
        if (lpssClone[0].str != lpss[0].str)
        {
            Console.WriteLine("[Error] Location tlpsba77");
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