// YehiaM 10:12 AM 3/19/2002

using System;
using System.Text;
using System.Runtime.InteropServices;

[assembly: BestFitMapping(true, ThrowOnUnmappableChar = true)]

public class BFM_CharMarshaler
{
    static int iCountErrors = 0;
    static int iCountTestCases = 0;

    [DllImport("Char_BestFitMappingNative")]
    public static extern bool Char_In([In]char c);

    [DllImport("Char_BestFitMappingNative")]
    public static extern bool Char_InByRef([In]ref char c);

    [DllImport("Char_BestFitMappingNative")]
    public static extern bool Char_InOutByRef([In, Out]ref char c);

    [DllImport("Char_BestFitMappingNative")]
    public static extern bool CharBuffer_In_String([In]String s);

    [DllImport("Char_BestFitMappingNative")]
    public static extern bool CharBuffer_InByRef_String([In]ref String s);

    [DllImport("Char_BestFitMappingNative")]
    public static extern bool CharBuffer_InOutByRef_String([In, Out]ref String s);

    [DllImport("Char_BestFitMappingNative")]
    public static extern bool CharBuffer_In_StringBuilder([In]StringBuilder s);

    [DllImport("Char_BestFitMappingNative")]
    public static extern bool CharBuffer_InByRef_StringBuilder([In]ref StringBuilder s);

    [DllImport("Char_BestFitMappingNative")]
    public static extern bool CharBuffer_InOutByRef_StringBuilder([In, Out]ref StringBuilder s);

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
        //sbl.Append ('乀');

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
        //sbl.Append ('乀');
        return sbl;
    }

    char GetInvalidChar()
    {
        return (char)0x2216;
    }

    char GetValidChar()
    {
        return 'c';
    }

    void testChar()
    {
        iCountTestCases++;
        if (!Char_In(GetInvalidChar()))
        {
            Console.WriteLine("[Error] Location tc11");
            iCountErrors++;
        }

        iCountTestCases++;
        if (!Char_In(GetValidChar()))
        {
            Console.WriteLine("[Error] Location tc22");
            iCountErrors++;
        }

        iCountTestCases++;
        char cTemp = GetInvalidChar();
        char cTempClone = GetInvalidChar();
        if (!Char_InByRef(ref cTemp))
        {
            Console.WriteLine("[Error] Location tc33");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetValidChar();
        cTempClone = cTemp;
        if (!Char_InByRef(ref cTemp))
        {
            Console.WriteLine("[Error] Location tc44");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetInvalidChar();
        cTempClone = cTemp;
        if (!Char_InOutByRef(ref cTemp))
        {
            Console.WriteLine("[Error] Location tc55");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetValidChar();
        cTempClone = cTemp;
        if (!Char_InOutByRef(ref cTemp))
        {
            Console.WriteLine("[Error] Location tc66");
            iCountErrors++;
        }
    }

    void testCharBufferString()
    {
        iCountTestCases++;
        if (!CharBuffer_In_String(GetInvalidString()))
        {
            Console.WriteLine("[Error] Location tcbs11");
            iCountErrors++;
        }

        iCountTestCases++;
        if (!CharBuffer_In_String(GetValidString()))
        {
            Console.WriteLine("[Error] Location tcbs22");
            iCountErrors++;
        }

        iCountTestCases++;
        String cTemp = GetInvalidString();
        String cTempClone = GetInvalidString();
        if (!CharBuffer_InByRef_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tcbs33");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetValidString();
        cTempClone = cTemp;
        if (!CharBuffer_InByRef_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tcbs44");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetInvalidString();
        cTempClone = cTemp;
        if (!CharBuffer_InOutByRef_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tcbs55");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetValidString();
        cTempClone = cTemp;
        if (!CharBuffer_InOutByRef_String(ref cTemp))
        {
            Console.WriteLine("[Error] Location tcbs66");
            iCountErrors++;
        }
    }

    void testCharBufferStringBuilder()
    {
        iCountTestCases++;
        if (!CharBuffer_In_StringBuilder(GetInvalidStringBuilder()))
        {
            Console.WriteLine("[Error] Location tcbsb11");
            iCountErrors++;
        }

        iCountTestCases++;
        if (!CharBuffer_In_StringBuilder(GetValidStringBuilder()))
        {
            Console.WriteLine("[Error] Location tcbsb22");
            iCountErrors++;
        }

        iCountTestCases++;
        StringBuilder cTemp = GetInvalidStringBuilder();
        StringBuilder cTempClone = cTemp;
        if (!CharBuffer_InByRef_StringBuilder(ref cTemp))
        {
            Console.WriteLine("[Error] Location tcbsb33");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetValidStringBuilder();
        cTempClone = cTemp;
        if (!CharBuffer_InByRef_StringBuilder(ref cTemp))
        {
            Console.WriteLine("[Error] Location tcbsb44");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetInvalidStringBuilder();
        cTempClone = cTemp;
        if (!CharBuffer_InOutByRef_StringBuilder(ref cTemp))
        {
            Console.WriteLine("[Error] Location tcbsb55");
            iCountErrors++;
        }

        iCountTestCases++;
        cTemp = GetValidStringBuilder();
        cTempClone = cTemp;
        if (!CharBuffer_InOutByRef_StringBuilder(ref cTemp))
        {
            Console.WriteLine("[Error] Location tcbsb66");
            iCountErrors++;
        }
    }

    Boolean runTest()
    {
        testChar();

        testCharBufferString();

        testCharBufferStringBuilder();

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
        BFM_CharMarshaler v = new BFM_CharMarshaler();

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