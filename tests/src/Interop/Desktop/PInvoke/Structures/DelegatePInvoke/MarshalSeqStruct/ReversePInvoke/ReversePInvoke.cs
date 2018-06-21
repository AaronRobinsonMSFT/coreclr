using System;
using System.Text;
using System.Security;
using System.Runtime.InteropServices;
//using TestLibrary;


public class MarshalStructTest
{
    const int iNative = 11;//the value passed from Native side to Managed side
    const int iManaged = 10;//The value passed from Managed side to Native side

    private static string strOne;
    private static string strTwo;

    enum StructID
    {
        InnerSequentialId,
        InnerArraySequentialId,
        CharSetAnsiSequentialId,
        CharSetUnicodeSequentialId,
        NumberSequentialId,
        S3Id,
        S5Id,
        StringStructSequentialAnsiId,
        StringStructSequentialUnicodeId,
        S8Id,
        S9Id,
        IncludeOuterIntergerStructSequentialId,
        S11Id,
        ComplexStructId
    }


    private static void testMethod(S9 s9)
    {
        Console.WriteLine("\tThe first field of s9 is:", s9.i32);
    }

    #region Methods for the struct InnerSequential declaration

    #region PassByRef

    //For Reverse Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool InnerSequentialByRefCdeclcaller([In, Out]ref InnerSequential argStr);
    private static bool TestMethodForStructInnerSequential_ReversePInvokeByRef_Cdecl(ref InnerSequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,Cdecl");
        InnerSequential change_is = Helper.NewInnerSequential(77, 77.0F, "changed string");
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateInnerSequential(argstr, change_is, "TestMethodForStructInnerSequential_ReversePInvokeByRef_Cdecl"))
            {
                breturn = false;
                Helper.PrintInnerSequential(argstr, "argstr");
                TestFramework.LogError("001", "TestMethodForStructInnerSequential_ReversePInvokeByRef_Cdecl. The InnerSequential is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.f1 = 1;
            argstr.f2 = 1.0F;
            argstr.f3 = "some string";
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("002", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool InnerSequentialByRefStdCallcaller([In, Out]ref InnerSequential argStr);
    private static bool TestMethodForStructInnerSequential_ReversePInvokeByRef_StdCall(ref InnerSequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,StdCall");
        InnerSequential change_is = Helper.NewInnerSequential(77, 77.0F, "changed string");
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateInnerSequential(argstr, change_is, "TestMethodForStructInnerSequential_ReversePInvokeByRef_StdCall"))
            {
                breturn = false;
                Helper.PrintInnerSequential(argstr, "argstr");
                TestFramework.LogError("003", "TestMethodForStructInnerSequential_ReversePInvokeByRef_StdCall. The InnerSequential is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.f1 = 1;
            argstr.f2 = 1.0F;
            argstr.f3 = "some string";
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("004", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructInnerSequentialByRef_Cdecl(InnerSequentialByRefCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructInnerSequentialByRef_StdCall(InnerSequentialByRefStdCallcaller caller);

    #endregion

    #region PassByValue

    //For Reverse Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool InnerSequentialByValCdeclcaller([In, Out] InnerSequential argStr);
    private static bool TestMethodForStructInnerSequential_ReversePInvokeByVal_Cdecl(InnerSequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,Cdecl");
        InnerSequential change_is = Helper.NewInnerSequential(77, 77.0F, "changed string");
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateInnerSequential(argstr, change_is, "TestMethodForStructInnerSequential_ReversePInvokeByVal_Cdecl"))
            {
                breturn = false;
                Helper.PrintInnerSequential(argstr, "argstr");
                TestFramework.LogError("005", "TestMethodForStructInnerSequential_ReversePInvokeByVal_Cdecl. The InnerSequential is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.f1 = 1;
            argstr.f2 = 1.0F;
            argstr.f3 = "some string";
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("006", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool InnerSequentialByValStdCallcaller([In, Out] InnerSequential argStr);
    private static bool TestMethodForStructInnerSequential_ReversePInvokeByVal_StdCall(InnerSequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,StdCall");
        InnerSequential change_is = Helper.NewInnerSequential(77, 77.0F, "changed string");
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateInnerSequential(argstr, change_is, "TestMethodForStructInnerSequential_ReversePInvokeByVal_StdCall"))
            {
                breturn = false;
                Helper.PrintInnerSequential(argstr, "argstr");
                TestFramework.LogError("007", "TestMethodForStructInnerSequential_ReversePInvokeByVal_StdCall. The InnerSequential is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.f1 = 1;
            argstr.f2 = 1.0F;
            argstr.f3 = "some string";
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("008", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructInnerSequentialByVal_Cdecl(InnerSequentialByValCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructInnerSequentialByVal_StdCall(InnerSequentialByValStdCallcaller caller);

    #endregion

    #endregion

    #region Methods for the struct InnerArraySequential declaration

    #region PassByRef

    //For Reverse Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool InnerArraySequentialByRefCdeclcaller([In, Out]ref InnerArraySequential argStr);
    private static bool TestMethodForStructInnerArraySequential_ReversePInvokeByRef_Cdecl(ref InnerArraySequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,Cdecl");
        InnerArraySequential change_is = Helper.NewInnerArraySequential(77, 77.0F, "changed string");
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateInnerArraySequential(argstr, change_is, "TestMethodForStructInnerArraySequential_ReversePInvokeByRef_Cdecl"))
            {
                breturn = false;
                Helper.PrintInnerArraySequential(argstr, "argstr");
                TestFramework.LogError("009", "TestMethodForStructInnerArraySequential_ReversePInvokeByRef_Cdecl. The InnerArraySequential is wrong(Managed Side)");
            }
            //Chanage the value
            for (int i = 0; i < Common.NumArrElements; i++)
            {
                argstr.arr[i].f1 = 1;
                argstr.arr[i].f2 = 1.0F;
                argstr.arr[i].f3 = "some string";
            }
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("010", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool InnerArraySequentialByRefStdCallcaller([In, Out]ref InnerArraySequential argStr);
    private static bool TestMethodForStructInnerArraySequential_ReversePInvokeByRef_StdCall(ref InnerArraySequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,StdCall");
        InnerArraySequential change_is = Helper.NewInnerArraySequential(77, 77.0F, "changed string");
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateInnerArraySequential(argstr, change_is, "TestMethodForStructInnerArraySequential_ReversePInvokeByRef_StdCall"))
            {
                breturn = false;
                Helper.PrintInnerArraySequential(argstr, "argstr");
                TestFramework.LogError("011", "TestMethodForStructInnerArraySequential_ReversePInvokeByRef_StdCall. The InnerArraySequential is wrong(Managed Side)");
            }
            //Chanage the value
            for (int i = 0; i < Common.NumArrElements; i++)
            {
                argstr.arr[i].f1 = 1;
                argstr.arr[i].f2 = 1.0F;
                argstr.arr[i].f3 = "some string";
            }
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("012", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructInnerArraySequentialByRef_Cdecl(InnerArraySequentialByRefCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructInnerArraySequentialByRef_StdCall(InnerArraySequentialByRefStdCallcaller caller);

    #endregion

    #region PassByValue

    //For Reverse Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool InnerArraySequentialByValCdeclcaller([In, Out] InnerArraySequential argStr);
    private static bool TestMethodForStructInnerArraySequential_ReversePInvokeByVal_Cdecl(InnerArraySequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,Cdecl");
        InnerArraySequential change_is = Helper.NewInnerArraySequential(77, 77.0F, "changed string");
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateInnerArraySequential(argstr, change_is, "TestMethodForStructInnerArraySequential_ReversePInvokeByVal_Cdecl"))
            {
                breturn = false;
                Helper.PrintInnerArraySequential(argstr, "argstr");
                TestFramework.LogError("013", "TestMethodForStructInnerArraySequential_ReversePInvokeByVal_Cdecl. The InnerArraySequential is wrong(Managed Side)");
            }
            //Chanage the value
            for (int i = 0; i < Common.NumArrElements; i++)
            {
                argstr.arr[i].f1 = 1;
                argstr.arr[i].f2 = 1.0F;
                argstr.arr[i].f3 = "some string";
            }
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("014", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool InnerArraySequentialByValStdCallcaller([In, Out] InnerArraySequential argStr);
    private static bool TestMethodForStructInnerArraySequential_ReversePInvokeByVal_StdCall(InnerArraySequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,StdCall");
        InnerArraySequential change_is = Helper.NewInnerArraySequential(77, 77.0F, "changed string");
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateInnerArraySequential(argstr, change_is, "TestMethodForStructInnerArraySequential_ReversePInvokeByVal_StdCall"))
            {
                breturn = false;
                Helper.PrintInnerArraySequential(argstr, "argstr");
                TestFramework.LogError("015", "TestMethodForStructInnerArraySequential_ReversePInvokeByVal_StdCall. The InnerArraySequential is wrong(Managed Side)");
            }
            //Chanage the value
            for (int i = 0; i < Common.NumArrElements; i++)
            {
                argstr.arr[i].f1 = 1;
                argstr.arr[i].f2 = 1.0F;
                argstr.arr[i].f3 = "some string";
            }
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("016", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructInnerArraySequentialByVal_Cdecl(InnerArraySequentialByValCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructInnerArraySequentialByVal_StdCall(InnerArraySequentialByValStdCallcaller caller);

    #endregion

    #endregion

    #region Methods for the struct CharSetAnsiSequential declaration

    #region PassByRef

    //For Reverse Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool CharSetAnsiSequentialByRefCdeclcaller([In, Out]ref CharSetAnsiSequential argStr);
    private static bool TestMethodForStructCharSetAnsiSequential_ReversePInvokeByRef_Cdecl(ref CharSetAnsiSequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,Cdecl");
        CharSetAnsiSequential change_is = Helper.NewCharSetAnsiSequential("change string", 'n');
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateCharSetAnsiSequential(argstr, change_is, "TestMethodForStructCharSetAnsiSequential_ReversePInvokeByRef_Cdecl"))
            {
                breturn = false;
                Helper.PrintCharSetAnsiSequential(argstr, "argstr");
                TestFramework.LogError("017", "TestMethodForStructCharSetAnsiSequential_ReversePInvokeByRef_Cdecl. The CharSetAnsiSequential is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.f1 = "some string";
            argstr.f2 = 'c';
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("018", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool CharSetAnsiSequentialByRefStdCallcaller([In, Out]ref CharSetAnsiSequential argStr);
    private static bool TestMethodForStructCharSetAnsiSequential_ReversePInvokeByRef_StdCall(ref CharSetAnsiSequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,StdCall");
        CharSetAnsiSequential change_is = Helper.NewCharSetAnsiSequential("change string", 'n');
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateCharSetAnsiSequential(argstr, change_is, "TestMethodForStructCharSetAnsiSequential_ReversePInvokeByRef_StdCall"))
            {
                breturn = false;
                Helper.PrintCharSetAnsiSequential(argstr, "argstr");
                TestFramework.LogError("019", "TestMethodForStructCharSetAnsiSequential_ReversePInvokeByRef_StdCall. The CharSetAnsiSequential is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.f1 = "some string";
            argstr.f2 = 'c';
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("020", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructCharSetAnsiSequentialByRef_Cdecl(CharSetAnsiSequentialByRefCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructCharSetAnsiSequentialByRef_StdCall(CharSetAnsiSequentialByRefStdCallcaller caller);

    #endregion

    #region PassByValue

    //For Reverse Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool CharSetAnsiSequentialByValCdeclcaller([In, Out] CharSetAnsiSequential argStr);
    private static bool TestMethodForStructCharSetAnsiSequential_ReversePInvokeByVal_Cdecl(CharSetAnsiSequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,Cdecl");
        CharSetAnsiSequential change_is = Helper.NewCharSetAnsiSequential("change string", 'n');
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateCharSetAnsiSequential(argstr, change_is, "TestMethodForStructCharSetAnsiSequential_ReversePInvokeByVal_Cdecl"))
            {
                breturn = false;
                Helper.PrintCharSetAnsiSequential(argstr, "argstr");
                TestFramework.LogError("021", "TestMethodForStructCharSetAnsiSequential_ReversePInvokeByVal_Cdecl. The CharSetAnsiSequential is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.f1 = "some string";
            argstr.f2 = 'c';
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("022", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool CharSetAnsiSequentialByValStdCallcaller([In, Out] CharSetAnsiSequential argStr);
    private static bool TestMethodForStructCharSetAnsiSequential_ReversePInvokeByVal_StdCall(CharSetAnsiSequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,StdCall");
        CharSetAnsiSequential change_is = Helper.NewCharSetAnsiSequential("change string", 'n');
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateCharSetAnsiSequential(argstr, change_is, "TestMethodForStructCharSetAnsiSequential_ReversePInvokeByVal_StdCall"))
            {
                breturn = false;
                Helper.PrintCharSetAnsiSequential(argstr, "argstr");
                TestFramework.LogError("023", "TestMethodForStructCharSetAnsiSequential_ReversePInvokeByVal_StdCall. The CharSetAnsiSequential is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.f1 = "some string";
            argstr.f2 = 'c';
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("024", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructCharSetAnsiSequentialByVal_Cdecl(CharSetAnsiSequentialByValCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructCharSetAnsiSequentialByVal_StdCall(CharSetAnsiSequentialByValStdCallcaller caller);

    #endregion

    #endregion

    #region Methods for the struct CharSetUnicodeSequential declaration

    #region PassByRef

    //For Reverse Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool CharSetUnicodeSequentialByRefCdeclcaller([In, Out]ref CharSetUnicodeSequential argStr);
    private static bool TestMethodForStructCharSetUnicodeSequential_ReversePInvokeByRef_Cdecl(ref CharSetUnicodeSequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,Cdecl");
        CharSetUnicodeSequential change_is = Helper.NewCharSetUnicodeSequential("change string", 'n');
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateCharSetUnicodeSequential(argstr, change_is, "TestMethodForStructCharSetUnicodeSequential_ReversePInvokeByRef_Cdecl"))
            {
                breturn = false;
                Helper.PrintCharSetUnicodeSequential(argstr, "argstr");
                TestFramework.LogError("025", "TestMethodForStructCharSetUnicodeSequential_ReversePInvokeByRef_Cdecl. The CharSetUnicodeSequential is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.f1 = "some string";
            argstr.f2 = 'c';
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("026", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool CharSetUnicodeSequentialByRefStdCallcaller([In, Out]ref CharSetUnicodeSequential argStr);
    private static bool TestMethodForStructCharSetUnicodeSequential_ReversePInvokeByRef_StdCall(ref CharSetUnicodeSequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,StdCall");
        CharSetUnicodeSequential change_is = Helper.NewCharSetUnicodeSequential("change string", 'n');
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateCharSetUnicodeSequential(argstr, change_is, "TestMethodForStructCharSetUnicodeSequential_ReversePInvokeByRef_StdCall"))
            {
                breturn = false;
                Helper.PrintCharSetUnicodeSequential(argstr, "argstr");
                TestFramework.LogError("027", "TestMethodForStructCharSetUnicodeSequential_ReversePInvokeByRef_StdCall. The CharSetUnicodeSequential is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.f1 = "some string";
            argstr.f2 = 'c';
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("028", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructCharSetUnicodeSequentialByRef_Cdecl(CharSetUnicodeSequentialByRefCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructCharSetUnicodeSequentialByRef_StdCall(CharSetUnicodeSequentialByRefStdCallcaller caller);

    #endregion

    #region PassByValue

    //For Reverse Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool CharSetUnicodeSequentialByValCdeclcaller([In, Out] CharSetUnicodeSequential argStr);
    private static bool TestMethodForStructCharSetUnicodeSequential_ReversePInvokeByVal_Cdecl(CharSetUnicodeSequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,Cdecl");
        CharSetUnicodeSequential change_is = Helper.NewCharSetUnicodeSequential("change string", 'n');
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateCharSetUnicodeSequential(argstr, change_is, "TestMethodForStructCharSetUnicodeSequential_ReversePInvokeByVal_Cdecl"))
            {
                breturn = false;
                Helper.PrintCharSetUnicodeSequential(argstr, "argstr");
                TestFramework.LogError("029", "TestMethodForStructCharSetUnicodeSequential_ReversePInvokeByVal_Cdecl. The CharSetUnicodeSequential is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.f1 = "some string";
            argstr.f2 = 'c';
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("030", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool CharSetUnicodeSequentialByValStdCallcaller([In, Out] CharSetUnicodeSequential argStr);
    private static bool TestMethodForStructCharSetUnicodeSequential_ReversePInvokeByVal_StdCall(CharSetUnicodeSequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,StdCall");
        CharSetUnicodeSequential change_is = Helper.NewCharSetUnicodeSequential("change string", 'n');
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateCharSetUnicodeSequential(argstr, change_is, "TestMethodForStructCharSetUnicodeSequential_ReversePInvokeByVal_StdCall"))
            {
                breturn = false;
                Helper.PrintCharSetUnicodeSequential(argstr, "argstr");
                TestFramework.LogError("031", "TestMethodForStructCharSetUnicodeSequential_ReversePInvokeByVal_StdCall. The CharSetUnicodeSequential is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.f1 = "some string";
            argstr.f2 = 'c';
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("032", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructCharSetUnicodeSequentialByVal_Cdecl(CharSetUnicodeSequentialByValCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructCharSetUnicodeSequentialByVal_StdCall(CharSetUnicodeSequentialByValStdCallcaller caller);

    #endregion

    #endregion

    #region Methods for the struct NumberSequential declaration

    #region PassByRef

    //For Reverse Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool NumberSequentialByRefCdeclcaller([In, Out]ref NumberSequential argStr);
    private static bool TestMethodForStructNumberSequential_ReversePInvokeByRef_Cdecl(ref NumberSequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,Cdecl");
        //NumberSequential change_is = Helper.NewNumberSequential("change string", 'n');

        NumberSequential change_is = Helper.NewNumberSequential(0, 32, 0, 16, 0, 8, 0, 16, 0, 64, 64.0F, 6.4);
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateNumberSequential(argstr, change_is, "TestMethodForStructNumberSequential_ReversePInvokeByRef_Cdecl"))
            {
                breturn = false;
                Helper.PrintNumberSequential(argstr, "argstr");
                TestFramework.LogError("033", "TestMethodForStructNumberSequential_ReversePInvokeByRef_Cdecl. The NumberSequential is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.i32 = Int32.MinValue;
            argstr.ui32 = UInt32.MaxValue;
            argstr.s1 = short.MinValue;
            argstr.us1 = ushort.MaxValue;
            argstr.b = byte.MinValue;
            argstr.sb = sbyte.MaxValue;
            argstr.i16 = Int16.MinValue;
            argstr.ui16 = UInt16.MaxValue;
            argstr.i64 = -1234567890;
            argstr.ui64 = 1234567890;
            argstr.sgl = 32.0F;
            argstr.d = 3.2;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("034", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool NumberSequentialByRefStdCallcaller([In, Out]ref NumberSequential argStr);
    private static bool TestMethodForStructNumberSequential_ReversePInvokeByRef_StdCall(ref NumberSequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,StdCall");
        NumberSequential change_is = Helper.NewNumberSequential(0, 32, 0, 16, 0, 8, 0, 16, 0, 64, 64.0F, 6.4);
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateNumberSequential(argstr, change_is, "TestMethodForStructNumberSequential_ReversePInvokeByRef_StdCall"))
            {
                breturn = false;
                Helper.PrintNumberSequential(argstr, "argstr");
                TestFramework.LogError("035", "TestMethodForStructNumberSequential_ReversePInvokeByRef_StdCall. The NumberSequential is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.i32 = Int32.MinValue;
            argstr.ui32 = UInt32.MaxValue;
            argstr.s1 = short.MinValue;
            argstr.us1 = ushort.MaxValue;
            argstr.b = byte.MinValue;
            argstr.sb = sbyte.MaxValue;
            argstr.i16 = Int16.MinValue;
            argstr.ui16 = UInt16.MaxValue;
            argstr.i64 = -1234567890;
            argstr.ui64 = 1234567890;
            argstr.sgl = 32.0F;
            argstr.d = 3.2;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("036", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructNumberSequentialByRef_Cdecl(NumberSequentialByRefCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructNumberSequentialByRef_StdCall(NumberSequentialByRefStdCallcaller caller);

    #endregion

    #region PassByValue

    //For Reverse Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool NumberSequentialByValCdeclcaller([In, Out] NumberSequential argStr);
    private static bool TestMethodForStructNumberSequential_ReversePInvokeByVal_Cdecl(NumberSequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,Cdecl");
        NumberSequential change_is = Helper.NewNumberSequential(0, 32, 0, 16, 0, 8, 0, 16, 0, 64, 64.0F, 6.4);
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateNumberSequential(argstr, change_is, "TestMethodForStructNumberSequential_ReversePInvokeByVal_Cdecl"))
            {
                breturn = false;
                Helper.PrintNumberSequential(argstr, "argstr");
                TestFramework.LogError("037", "TestMethodForStructNumberSequential_ReversePInvokeByVal_Cdecl. The NumberSequential is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.i32 = Int32.MinValue;
            argstr.ui32 = UInt32.MaxValue;
            argstr.s1 = short.MinValue;
            argstr.us1 = ushort.MaxValue;
            argstr.b = byte.MinValue;
            argstr.sb = sbyte.MaxValue;
            argstr.i16 = Int16.MinValue;
            argstr.ui16 = UInt16.MaxValue;
            argstr.i64 = -1234567890;
            argstr.ui64 = 1234567890;
            argstr.sgl = 32.0F;
            argstr.d = 3.2;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("038", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool NumberSequentialByValStdCallcaller([In, Out] NumberSequential argStr);
    private static bool TestMethodForStructNumberSequential_ReversePInvokeByVal_StdCall(NumberSequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,StdCall");
        NumberSequential change_is = Helper.NewNumberSequential(0, 32, 0, 16, 0, 8, 0, 16, 0, 64, 64.0F, 6.4);
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateNumberSequential(argstr, change_is, "TestMethodForStructNumberSequential_ReversePInvokeByVal_StdCall"))
            {
                breturn = false;
                Helper.PrintNumberSequential(argstr, "argstr");
                TestFramework.LogError("039", "TestMethodForStructNumberSequential_ReversePInvokeByVal_StdCall. The NumberSequential is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.i32 = Int32.MinValue;
            argstr.ui32 = UInt32.MaxValue;
            argstr.s1 = short.MinValue;
            argstr.us1 = ushort.MaxValue;
            argstr.b = byte.MinValue;
            argstr.sb = sbyte.MaxValue;
            argstr.i16 = Int16.MinValue;
            argstr.ui16 = UInt16.MaxValue;
            argstr.i64 = -1234567890;
            argstr.ui64 = 1234567890;
            argstr.sgl = 32.0F;
            argstr.d = 3.2;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("040", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructNumberSequentialByVal_Cdecl(NumberSequentialByValCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructNumberSequentialByVal_StdCall(NumberSequentialByValStdCallcaller caller);

    #endregion

    #endregion

    #region Methods for the struct S3 declaration

    #region PassByRef

    //For Reverse Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool S3ByRefCdeclcaller([In, Out]ref S3 argStr);
    private static bool TestMethodForStructS3_ReversePInvokeByRef_Cdecl(ref S3 argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,Cdecl");
        int[] iarr = new int[256];
        int[] icarr = new int[256];
        Helper.InitialArray(iarr, icarr);

        S3 changeS3 = Helper.NewS3(false, "change string", icarr);
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateS3(argstr, changeS3, "TestMethodForStructS3_ReversePInvokeByRef_Cdecl"))
            {
                breturn = false;
                Helper.PrintS3(argstr, "argstr");
                TestFramework.LogError("041", "TestMethodForStructS3_ReversePInvokeByRef_Cdecl. The S3 is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.flag = true;
            argstr.str = "some string";
            argstr.vals = iarr;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("042", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool S3ByRefStdCallcaller([In, Out]ref S3 argStr);
    private static bool TestMethodForStructS3_ReversePInvokeByRef_StdCall(ref S3 argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,StdCall");
        int[] iarr = new int[256];
        int[] icarr = new int[256];
        Helper.InitialArray(iarr, icarr);

        S3 changeS3 = Helper.NewS3(false, "change string", icarr);
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateS3(argstr, changeS3, "TestMethodForStructS3_ReversePInvokeByRef_Cdecl"))
            {
                breturn = false;
                Helper.PrintS3(argstr, "argstr");
                TestFramework.LogError("043", "TestMethodForStructS3_ReversePInvokeByRef_Cdecl. The S3 is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.flag = true;
            argstr.str = "some string";
            argstr.vals = iarr;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("044", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructS3ByRef_Cdecl(S3ByRefCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructS3ByRef_StdCall(S3ByRefStdCallcaller caller);

    #endregion

    #region PassByValue

    //For Reverse Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool S3ByValCdeclcaller([In, Out] S3 argStr);
    private static bool TestMethodForStructS3_ReversePInvokeByVal_Cdecl(S3 argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,Cdecl");
        int[] iarr = new int[256];
        int[] icarr = new int[256];
        Helper.InitialArray(iarr, icarr);

        S3 changeS3 = Helper.NewS3(false, "change string", icarr);
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateS3(argstr, changeS3, "TestMethodForStructS3_ReversePInvokeByVal_Cdecl"))
            {
                breturn = false;
                Helper.PrintS3(argstr, "argstr");
                TestFramework.LogError("045", "TestMethodForStructS3_ReversePInvokeByVal_Cdecl. The S3 is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.flag = true;
            argstr.str = "some string";
            argstr.vals = iarr;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("046", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool S3ByValStdCallcaller([In, Out] S3 argStr);
    private static bool TestMethodForStructS3_ReversePInvokeByVal_StdCall(S3 argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,StdCall");
        int[] iarr = new int[256];
        int[] icarr = new int[256];
        Helper.InitialArray(iarr, icarr);

        S3 changeS3 = Helper.NewS3(false, "change string", icarr);
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateS3(argstr, changeS3, "TestMethodForStructS3_ReversePInvokeByVal_StdCall"))
            {
                breturn = false;
                Helper.PrintS3(argstr, "argstr");
                TestFramework.LogError("047", "TestMethodForStructS3_ReversePInvokeByVal_StdCall. The S3 is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.flag = true;
            argstr.str = "some string";
            argstr.vals = iarr;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("048", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructS3ByVal_Cdecl(S3ByValCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructS3ByVal_StdCall(S3ByValStdCallcaller caller);

    #endregion

    #endregion

    #region Methods for the struct S5 declaration
  
    #region PassByRef
  
    //For Reverse Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool S5ByRefCdeclcaller([In, Out]ref S5 argStr);
    private static bool TestMethodForStructS5_ReversePInvokeByRef_Cdecl(ref S5 argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,Cdecl");

        Enum1 enums = Enum1.e1;
        Enum1 enumch = Enum1.e2;

        S4 s4 = new S4();
        s4.age = 32;
        s4.name = "some string";

        S5 changeS5 = Helper.NewS5(64, "change string", enumch);

        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateS5(argstr, changeS5, "TestMethodForStructS5_ReversePInvokeByRef_Cdecl"))
            {
                breturn = false;
                Helper.PrintS5(argstr, "argstr");
                TestFramework.LogError("049", "TestMethodForStructS5_ReversePInvokeByRef_Cdecl. The S5 is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.s4 = s4;
            argstr.ef = enums;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("050", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }
   
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool S5ByRefStdCallcaller([In, Out]ref S5 argStr);
    private static bool TestMethodForStructS5_ReversePInvokeByRef_StdCall(ref S5 argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,StdCall");
        Enum1 enums = Enum1.e1;
        Enum1 enumch = Enum1.e2;

        S4 s4 = new S4();
        s4.age = 32;
        s4.name = "some string";

        S5 changeS5 = Helper.NewS5(64, "change string", enumch);

        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateS5(argstr, changeS5, "TestMethodForStructS5_ReversePInvokeByRef_StdCall"))
            {
                breturn = false;
                Helper.PrintS5(argstr, "argstr");
                TestFramework.LogError("051", "TestMethodForStructS5_ReversePInvokeByRef_StdCall. The S5 is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.s4 = s4;
            argstr.ef = enums;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("052", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructS5ByRef_Cdecl(S5ByRefCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructS5ByRef_StdCall(S5ByRefStdCallcaller caller);
  
    #endregion
    
    #region PassByValue
   
    //For Reverse Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool S5ByValCdeclcaller([In, Out] S5 argStr);
    private static bool TestMethodForStructS5_ReversePInvokeByVal_Cdecl(S5 argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,Cdecl");
        Enum1 enums = Enum1.e1;
        Enum1 enumch = Enum1.e2;

        S4 s4 = new S4();
        s4.age = 32;
        s4.name = "some string";

        S5 changeS5 = Helper.NewS5(64, "change string", enumch);

        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateS5(argstr, changeS5, "TestMethodForStructS5_ReversePInvokeByVal_Cdecl"))
            {
                breturn = false;
                Helper.PrintS5(argstr, "argstr");
                TestFramework.LogError("053", "TestMethodForStructS5_ReversePInvokeByVal_Cdecl. The S5 is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.s4 = s4;
            argstr.ef = enums;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("054", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool S5ByValStdCallcaller([In, Out] S5 argStr);
    private static bool TestMethodForStructS5_ReversePInvokeByVal_StdCall(S5 argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,StdCall");
        Enum1 enums = Enum1.e1;
        Enum1 enumch = Enum1.e2;

        S4 s4 = new S4();
        s4.age = 32;
        s4.name = "some string";

        S5 changeS5 = Helper.NewS5(64, "change string", enumch);

        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateS5(argstr, changeS5, "TestMethodForStructS5_ReversePInvokeByVal_StdCall"))
            {
                breturn = false;
                Helper.PrintS5(argstr, "argstr");
                TestFramework.LogError("055", "TestMethodForStructS5_ReversePInvokeByVal_StdCall. The S5 is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.s4 = s4;
            argstr.ef = enums;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("056", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructS5ByVal_Cdecl(S5ByValCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructS5ByVal_StdCall(S5ByValStdCallcaller caller);
  
    #endregion
  
    #endregion

    #region Methods for the struct StringStructSequentialAnsi declaration
   
    #region PassByRef
   
    //For Reverse Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool StringStructSequentialAnsiByRefCdeclcaller([In, Out]ref StringStructSequentialAnsi argStr);
    private static bool TestMethodForStructStringStructSequentialAnsi_ReversePInvokeByRef_Cdecl(ref StringStructSequentialAnsi argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,Cdecl");
        strOne = new String('a', 512);
        strTwo = new String('b', 512);
        StringStructSequentialAnsi change_sssa = Helper.NewStringStructSequentialAnsi(strTwo, strOne);

        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateStringStructSequentialAnsi(argstr, change_sssa, "TestMethodForStructStringStructSequentialAnsi_ReversePInvokeByRef_Cdecl"))
            {
                breturn = false;
                Helper.PrintStringStructSequentialAnsi(argstr, "argstr");
                TestFramework.LogError("057", "TestMethodForStructStringStructSequentialAnsi_ReversePInvokeByRef_Cdecl. The StringStructSequentialAnsi is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.first = strOne;
            argstr.last = strTwo;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("058", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }
   
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool StringStructSequentialAnsiByRefStdCallcaller([In, Out]ref StringStructSequentialAnsi argStr);
    private static bool TestMethodForStructStringStructSequentialAnsi_ReversePInvokeByRef_StdCall(ref StringStructSequentialAnsi argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,StdCall");
        strOne = new String('a', 512);
        strTwo = new String('b', 512);
        StringStructSequentialAnsi change_sssa = Helper.NewStringStructSequentialAnsi(strTwo, strOne);

        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateStringStructSequentialAnsi(argstr, change_sssa, "TestMethodForStructStringStructSequentialAnsi_ReversePInvokeByRef_StdCall"))
            {
                breturn = false;
                Helper.PrintStringStructSequentialAnsi(argstr, "argstr");
                TestFramework.LogError("059", "TestMethodForStructStringStructSequentialAnsi_ReversePInvokeByRef_StdCall. The StringStructSequentialAnsi is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.first = strOne;
            argstr.last = strTwo;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("060", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructStringStructSequentialAnsiByRef_Cdecl(StringStructSequentialAnsiByRefCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructStringStructSequentialAnsiByRef_StdCall(StringStructSequentialAnsiByRefStdCallcaller caller);
    
    #endregion
   
    #region PassByValue
    
    //For Reverse Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool StringStructSequentialAnsiByValCdeclcaller([In, Out] StringStructSequentialAnsi argStr);
    private static bool TestMethodForStructStringStructSequentialAnsi_ReversePInvokeByVal_Cdecl(StringStructSequentialAnsi argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,Cdecl");
        strOne = new String('a', 512);
        strTwo = new String('b', 512);
        StringStructSequentialAnsi change_sssa = Helper.NewStringStructSequentialAnsi(strTwo, strOne);

        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateStringStructSequentialAnsi(argstr, change_sssa, "TestMethodForStructStringStructSequentialAnsi_ReversePInvokeByVal_Cdecl"))
            {
                breturn = false;
                Helper.PrintStringStructSequentialAnsi(argstr, "argstr");
                TestFramework.LogError("061", "TestMethodForStructStringStructSequentialAnsi_ReversePInvokeByVal_Cdecl. The StringStructSequentialAnsi is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.first = strOne;
            argstr.last = strTwo;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("062", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool StringStructSequentialAnsiByValStdCallcaller([In, Out] StringStructSequentialAnsi argStr);
    private static bool TestMethodForStructStringStructSequentialAnsi_ReversePInvokeByVal_StdCall(StringStructSequentialAnsi argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,StdCall");
        strOne = new String('a', 512);
        strTwo = new String('b', 512);
        StringStructSequentialAnsi change_sssa = Helper.NewStringStructSequentialAnsi(strTwo, strOne);

        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateStringStructSequentialAnsi(argstr, change_sssa, "TestMethodForStructStringStructSequentialAnsi_ReversePInvokeByVal_StdCall"))
            {
                breturn = false;
                Helper.PrintStringStructSequentialAnsi(argstr, "argstr");
                TestFramework.LogError("063", "TestMethodForStructStringStructSequentialAnsi_ReversePInvokeByVal_StdCall. The StringStructSequentialAnsi is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.first = strOne;
            argstr.last = strTwo;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("064", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructStringStructSequentialAnsiByVal_Cdecl(StringStructSequentialAnsiByValCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructStringStructSequentialAnsiByVal_StdCall(StringStructSequentialAnsiByValStdCallcaller caller);
   
    #endregion
   
    #endregion

    #region Methods for the struct StringStructSequentialUnicode declaration
   
    #region PassByRef
   
    //For Reverse Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool StringStructSequentialUnicodeByRefCdeclcaller([In, Out]ref StringStructSequentialUnicode argStr);
    private static bool TestMethodForStructStringStructSequentialUnicode_ReversePInvokeByRef_Cdecl(ref StringStructSequentialUnicode argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,Cdecl");
        strOne = new String('a', 256);
        strTwo = new String('b', 256);
        StringStructSequentialUnicode change_sssa = Helper.NewStringStructSequentialUnicode(strTwo, strOne);

        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateStringStructSequentialUnicode(argstr, change_sssa, "TestMethodForStructStringStructSequentialUnicode_ReversePInvokeByRef_Cdecl"))
            {
                breturn = false;
                Helper.PrintStringStructSequentialUnicode(argstr, "argstr");
                TestFramework.LogError("065", "TestMethodForStructStringStructSequentialUnicode_ReversePInvokeByRef_Cdecl. The StringStructSequentialUnicode is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.first = strOne;
            argstr.last = strTwo;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("066", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }
   
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool StringStructSequentialUnicodeByRefStdCallcaller([In, Out]ref StringStructSequentialUnicode argStr);
    private static bool TestMethodForStructStringStructSequentialUnicode_ReversePInvokeByRef_StdCall(ref StringStructSequentialUnicode argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,StdCall");
        strOne = new String('a', 256);
        strTwo = new String('b', 256);
        StringStructSequentialUnicode change_sssa = Helper.NewStringStructSequentialUnicode(strTwo, strOne);

        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateStringStructSequentialUnicode(argstr, change_sssa, "TestMethodForStructStringStructSequentialUnicode_ReversePInvokeByRef_StdCall"))
            {
                breturn = false;
                Helper.PrintStringStructSequentialUnicode(argstr, "argstr");
                TestFramework.LogError("067", "TestMethodForStructStringStructSequentialUnicode_ReversePInvokeByRef_StdCall. The StringStructSequentialUnicode is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.first = strOne;
            argstr.last = strTwo;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("068", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructStringStructSequentialUnicodeByRef_Cdecl(StringStructSequentialUnicodeByRefCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructStringStructSequentialUnicodeByRef_StdCall(StringStructSequentialUnicodeByRefStdCallcaller caller);
   
    #endregion
      
    #region PassByValue
    //For Reverse Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool StringStructSequentialUnicodeByValCdeclcaller([In, Out] StringStructSequentialUnicode argStr);
    private static bool TestMethodForStructStringStructSequentialUnicode_ReversePInvokeByVal_Cdecl(StringStructSequentialUnicode argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,Cdecl");
        strOne = new String('a', 256);
        strTwo = new String('b', 256);
        StringStructSequentialUnicode change_sssa = Helper.NewStringStructSequentialUnicode(strTwo, strOne);

        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateStringStructSequentialUnicode(argstr, change_sssa, "TestMethodForStructStringStructSequentialUnicode_ReversePInvokeByVal_Cdecl"))
            {
                breturn = false;
                Helper.PrintStringStructSequentialUnicode(argstr, "argstr");
                TestFramework.LogError("069", "TestMethodForStructStringStructSequentialUnicode_ReversePInvokeByVal_Cdecl. The StringStructSequentialUnicode is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.first = strOne;
            argstr.last = strTwo;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("070", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool StringStructSequentialUnicodeByValStdCallcaller([In, Out] StringStructSequentialUnicode argStr);
    private static bool TestMethodForStructStringStructSequentialUnicode_ReversePInvokeByVal_StdCall(StringStructSequentialUnicode argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,StdCall");
        strOne = new String('a', 256);
        strTwo = new String('b', 256);
        StringStructSequentialUnicode change_sssa = Helper.NewStringStructSequentialUnicode(strTwo, strOne);

        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateStringStructSequentialUnicode(argstr, change_sssa, "TestMethodForStructStringStructSequentialUnicode_ReversePInvokeByVal_StdCall"))
            {
                breturn = false;
                Helper.PrintStringStructSequentialUnicode(argstr, "argstr");
                TestFramework.LogError("071", "TestMethodForStructStringStructSequentialUnicode_ReversePInvokeByVal_StdCall. The StringStructSequentialUnicode is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.first = strOne;
            argstr.last = strTwo;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("072", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructStringStructSequentialUnicodeByVal_Cdecl(StringStructSequentialUnicodeByValCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructStringStructSequentialUnicodeByVal_StdCall(StringStructSequentialUnicodeByValStdCallcaller caller);
   
    #endregion
   
    #endregion

    #region Methods for the struct S8 declaration
  
    #region PassByRef
   
    //For Reverse Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool S8ByRefCdeclcaller([In, Out]ref S8 argStr);
    private static bool TestMethodForStructS8_ReversePInvokeByRef_Cdecl(ref S8 argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,Cdecl");
        S8 changeS8 = Helper.NewS8("world", false, 1, 256, 256, 64);
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateS8(argstr, changeS8, "TestMethodForStructS8_ReversePInvokeByRef_Cdecl"))
            {
                breturn = false;
                Helper.PrintS8(argstr, "argstr");
                TestFramework.LogError("073", "TestMethodForStructS8_ReversePInvokeByRef_Cdecl. The S8 is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.name = "hello";
            argstr.gender = true;
            argstr.jobNum = 10;
            argstr.i32 = 128;
            argstr.ui32 = 128;
            argstr.mySByte = 32;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("074", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }
  
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool S8ByRefStdCallcaller([In, Out]ref S8 argStr);
    private static bool TestMethodForStructS8_ReversePInvokeByRef_StdCall(ref S8 argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,StdCall");
        S8 changeS8 = Helper.NewS8("world", false, 1, 256, 256, 64);

        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateS8(argstr, changeS8, "TestMethodForStructS8_ReversePInvokeByRef_Cdecl"))
            {
                breturn = false;
                Helper.PrintS8(argstr, "argstr");
                TestFramework.LogError("075", "TestMethodForStructS8_ReversePInvokeByRef_Cdecl. The S8 is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.name = "hello";
            argstr.gender = true;
            argstr.jobNum = 10;
            argstr.i32 = 128;
            argstr.ui32 = 128;
            argstr.mySByte = 32;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("076", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructS8ByRef_Cdecl(S8ByRefCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructS8ByRef_StdCall(S8ByRefStdCallcaller caller);
  
    #endregion
  
    #region PassByValue
   
    //For Reverse Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool S8ByValCdeclcaller([In, Out] S8 argStr);
    private static bool TestMethodForStructS8_ReversePInvokeByVal_Cdecl(S8 argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,Cdecl");
        S8 changeS8 = Helper.NewS8("world", false, 1, 256, 256, 64);
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateS8(argstr, changeS8, "TestMethodForStructS8_ReversePInvokeByVal_Cdecl"))
            {
                breturn = false;
                Helper.PrintS8(argstr, "argstr");
                TestFramework.LogError("077", "TestMethodForStructS8_ReversePInvokeByVal_Cdecl. The S8 is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.name = "hello";
            argstr.gender = true;
            argstr.jobNum = 10;
            argstr.i32 = 128;
            argstr.ui32 = 128;
            argstr.mySByte = 32;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("078", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool S8ByValStdCallcaller([In, Out] S8 argStr);
    private static bool TestMethodForStructS8_ReversePInvokeByVal_StdCall(S8 argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,StdCall");
        S8 changeS8 = Helper.NewS8("world", false, 1, 256, 256, 64);
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateS8(argstr, changeS8, "TestMethodForStructS8_ReversePInvokeByVal_StdCall"))
            {
                breturn = false;
                Helper.PrintS8(argstr, "argstr");
                TestFramework.LogError("079", "TestMethodForStructS8_ReversePInvokeByVal_StdCall. The S8 is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.name = "hello";
            argstr.gender = true;
            argstr.jobNum = 10;
            argstr.i32 = 128;
            argstr.ui32 = 128;
            argstr.mySByte = 32;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("080", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructS8ByVal_Cdecl(S8ByValCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructS8ByVal_StdCall(S8ByValStdCallcaller caller);
   
    #endregion
  
    #endregion

    #region Methods for the struct S9 declaration
  
    #region PassByRef
    
    //For Reverse Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool S9ByRefCdeclcaller([In, Out]ref S9 argStr);
    private static bool TestMethodForStructS9_ReversePInvokeByRef_Cdecl(ref S9 argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,Cdecl");

        S9 changeS9 = Helper.NewS9(256, null);
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateS9(argstr, changeS9, "TestMethodForStructS9_ReversePInvokeByRef_Cdecl"))
            {
                breturn = false;
                TestFramework.LogError("081", "TestMethodForStructS9_ReversePInvokeByRef_Cdecl. The S9 is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.i32 = 128;
            argstr.myDelegate1 = new TestDelegate1(testMethod);
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("082", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }
   
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool S9ByRefStdCallcaller([In, Out]ref S9 argStr);
    private static bool TestMethodForStructS9_ReversePInvokeByRef_StdCall(ref S9 argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,StdCall");
        S9 changeS9 = Helper.NewS9(256, null);

        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateS9(argstr, changeS9, "TestMethodForStructS9_ReversePInvokeByRef_StdCall"))
            {
                breturn = false;
                TestFramework.LogError("083", "TestMethodForStructS9_ReversePInvokeByRef_StdCall. The S9 is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.i32 = 128;
            argstr.myDelegate1 = new TestDelegate1(testMethod);
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("084", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructS9ByRef_Cdecl(S9ByRefCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructS9ByRef_StdCall(S9ByRefStdCallcaller caller);
  
    #endregion
 
    #region PassByValue
    
    //For Reverse Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool S9ByValCdeclcaller([In, Out] S9 argStr);
    private static bool TestMethodForStructS9_ReversePInvokeByVal_Cdecl(S9 argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,Cdecl");
        S9 changeS9 = Helper.NewS9(256, null);

        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateS9(argstr, changeS9, "TestMethodForStructS9_ReversePInvokeByVal_Cdecl"))
            {
                breturn = false;
                TestFramework.LogError("085", "TestMethodForStructS9_ReversePInvokeByVal_Cdecl. The S9 is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.i32 = 128;
            argstr.myDelegate1 = new TestDelegate1(testMethod);
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("086", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool S9ByValStdCallcaller([In, Out] S9 argStr);
    private static bool TestMethodForStructS9_ReversePInvokeByVal_StdCall(S9 argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,StdCall");
        S9 changeS9 = Helper.NewS9(256, null);

        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateS9(argstr, changeS9, "TestMethodForStructS9_ReversePInvokeByVal_StdCall"))
            {
                breturn = false;
                TestFramework.LogError("087", "TestMethodForStructS9_ReversePInvokeByVal_StdCall. The S9 is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.i32 = 128;
            argstr.myDelegate1 = new TestDelegate1(testMethod);
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("088", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructS9ByVal_Cdecl(S9ByValCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructS9ByVal_StdCall(S9ByValStdCallcaller caller);
   
    #endregion
   
    #endregion

    #region Methods for the struct IncludeOuterIntergerStructSequential declaration
   
    #region PassByRef
   
    //For Reverse Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool IncludeOuterIntergerStructSequentialByRefCdeclcaller([In, Out]ref IncludeOuterIntergerStructSequential argStr);
    private static bool TestMethodForStructIncludeOuterIntergerStructSequential_ReversePInvokeByRef_Cdecl(ref IncludeOuterIntergerStructSequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,Cdecl");
        IncludeOuterIntergerStructSequential changeIncludeOuterIntergerStructSequential = Helper.NewIncludeOuterIntergerStructSequential(64, 64);
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateIncludeOuterIntergerStructSequential(argstr, 
                changeIncludeOuterIntergerStructSequential, "TestMethodForStructIncludeOuterIntergerStructSequential_ReversePInvokeByRef_Cdecl"))
            {
                breturn = false;
                Helper.PrintIncludeOuterIntergerStructSequential(argstr, "argstr");
                TestFramework.LogError("089", "TestMethodForStructIncludeOuterIntergerStructSequential_ReversePInvokeByRef_Cdecl. The IncludeOuterIntergerStructSequential is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.s.s_int.i = 32;
            argstr.s.i = 32;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("090", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }
  
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool IncludeOuterIntergerStructSequentialByRefStdCallcaller([In, Out]ref IncludeOuterIntergerStructSequential argStr);
    private static bool TestMethodForStructIncludeOuterIntergerStructSequential_ReversePInvokeByRef_StdCall(ref IncludeOuterIntergerStructSequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,StdCall");
        IncludeOuterIntergerStructSequential changeIncludeOuterIntergerStructSequential = Helper.NewIncludeOuterIntergerStructSequential(64, 64);

        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateIncludeOuterIntergerStructSequential(argstr, 
                changeIncludeOuterIntergerStructSequential, "TestMethodForStructIncludeOuterIntergerStructSequential_ReversePInvokeByRef_Cdecl"))
            {
                breturn = false;
                Helper.PrintIncludeOuterIntergerStructSequential(argstr, "argstr");
                TestFramework.LogError("091", "TestMethodForStructIncludeOuterIntergerStructSequential_ReversePInvokeByRef_Cdecl. The IncludeOuterIntergerStructSequential is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.s.s_int.i = 32;
            argstr.s.i = 32;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("092", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructIncludeOuterIntergerStructSequentialByRef_Cdecl(IncludeOuterIntergerStructSequentialByRefCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructIncludeOuterIntergerStructSequentialByRef_StdCall(IncludeOuterIntergerStructSequentialByRefStdCallcaller caller);
   
    #endregion
   
    #region PassByValue
    
    //For Reverse Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool IncludeOuterIntergerStructSequentialByValCdeclcaller([In, Out] IncludeOuterIntergerStructSequential argStr);
    private static bool TestMethodForStructIncludeOuterIntergerStructSequential_ReversePInvokeByVal_Cdecl(IncludeOuterIntergerStructSequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,Cdecl");
        IncludeOuterIntergerStructSequential changeIncludeOuterIntergerStructSequential = Helper.NewIncludeOuterIntergerStructSequential(64, 64);
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateIncludeOuterIntergerStructSequential(argstr, 
                changeIncludeOuterIntergerStructSequential, "TestMethodForStructIncludeOuterIntergerStructSequential_ReversePInvokeByVal_Cdecl"))
            {
                breturn = false;
                Helper.PrintIncludeOuterIntergerStructSequential(argstr, "argstr");
                TestFramework.LogError("093", "TestMethodForStructIncludeOuterIntergerStructSequential_ReversePInvokeByVal_Cdecl. The IncludeOuterIntergerStructSequential is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.s.s_int.i = 32;
            argstr.s.i = 32;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("094", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool IncludeOuterIntergerStructSequentialByValStdCallcaller([In, Out] IncludeOuterIntergerStructSequential argStr);
    private static bool TestMethodForStructIncludeOuterIntergerStructSequential_ReversePInvokeByVal_StdCall(IncludeOuterIntergerStructSequential argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,StdCall");
        IncludeOuterIntergerStructSequential changeIncludeOuterIntergerStructSequential = Helper.NewIncludeOuterIntergerStructSequential(64, 64);
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateIncludeOuterIntergerStructSequential(argstr, 
                changeIncludeOuterIntergerStructSequential, "TestMethodForStructIncludeOuterIntergerStructSequential_ReversePInvokeByVal_StdCall"))
            {
                breturn = false;
                Helper.PrintIncludeOuterIntergerStructSequential(argstr, "argstr");
                TestFramework.LogError("095", "TestMethodForStructIncludeOuterIntergerStructSequential_ReversePInvokeByVal_StdCall. The IncludeOuterIntergerStructSequential is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.s.s_int.i = 32;
            argstr.s.i = 32;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("096", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructIncludeOuterIntergerStructSequentialByVal_Cdecl(IncludeOuterIntergerStructSequentialByValCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructIncludeOuterIntergerStructSequentialByVal_StdCall(IncludeOuterIntergerStructSequentialByValStdCallcaller caller);
   
    #endregion
   
    #endregion

    #region Methods for the struct S11 declaration
  
    #region PassByRef
   
    //For Reverse Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool S11ByRefCdeclcaller([In, Out]ref S11 argStr);
    unsafe private static bool TestMethodForStructS11_ReversePInvokeByRef_Cdecl(ref S11 argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,Cdecl");

        S11 changeS11 = Helper.NewS11((int*)(64), 64);
        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateS11(argstr, changeS11, "TestMethodForStructS11_ReversePInvokeByRef_Cdecl"))
            {
                breturn = false;
                Helper.PrintS11(argstr, "argstr");
                TestFramework.LogError("097", "TestMethodForStructS11_ReversePInvokeByRef_Cdecl. The S11 is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.i32 = (int*)(32);
            argstr.i = 32;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("098", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }
   
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool S11ByRefStdCallcaller([In, Out]ref S11 argStr);
    unsafe private static bool TestMethodForStructS11_ReversePInvokeByRef_StdCall(ref S11 argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,StdCall");
        S11 changeS11 = Helper.NewS11((int*)(64), 64);

        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateS11(argstr, changeS11, "TestMethodForStructS11_ReversePInvokeByRef_StdCall"))
            {
                breturn = false;
                Helper.PrintS11(argstr, "argstr");
                TestFramework.LogError("099", "TestMethodForStructS11_ReversePInvokeByRef_StdCall. The S11 is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.i32 = (int*)(32);
            argstr.i = 32;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("100", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructS11ByRef_Cdecl(S11ByRefCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructS11ByRef_StdCall(S11ByRefStdCallcaller caller);
  
    #endregion
  
    #region PassByValue
   
    //For Reverse Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool S11ByValCdeclcaller([In, Out] S11 argStr);
    unsafe private static bool TestMethodForStructS11_ReversePInvokeByVal_Cdecl(S11 argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,Cdecl");
        S11 changeS11 = Helper.NewS11((int*)(64), 64);

        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateS11(argstr, changeS11, "TestMethodForStructS11_ReversePInvokeByVal_Cdecl"))
            {
                breturn = false;
                Helper.PrintS11(argstr, "argstr");
                TestFramework.LogError("101", "TestMethodForStructS11_ReversePInvokeByVal_Cdecl. The S11 is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.i32 = (int*)(32);
            argstr.i = 32;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("102", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool S11ByValStdCallcaller([In, Out] S11 argStr);
    unsafe private static bool TestMethodForStructS11_ReversePInvokeByVal_StdCall(S11 argstr)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,StdCall");
        S11 changeS11 = Helper.NewS11((int*)(64), 64);

        bool breturn = true;
        try
        {
            //Check the input
            if (!Helper.ValidateS11(argstr, changeS11, "TestMethodForStructS11_ReversePInvokeByVal_StdCall"))
            {
                breturn = false;
                Helper.PrintS11(argstr, "argstr");
                TestFramework.LogError("103", "TestMethodForStructS11_ReversePInvokeByVal_StdCall. The S11 is wrong(Managed Side)");
            }
            //Chanage the value
            argstr.i32 = (int*)(32);
            argstr.i = 32;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("104", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructS11ByVal_Cdecl(S11ByValCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructS11ByVal_StdCall(S11ByValStdCallcaller caller);
  
    #endregion
  
    #endregion

    #region Methods for the struct ComplexStruct declaration
   
    #region PassByRef
   
    //For Reverse Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool ComplexStructByRefCdeclcaller([In, Out]ref ComplexStruct argStr);
    private static bool TestMethodForStructComplexStruct_ReversePInvokeByRef_Cdecl(ref ComplexStruct cs)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,Cdecl");
        bool breturn = true;
        try
        {
            //Check the input
            if ((9999 != cs.i) || cs.b || !cs.str.Equals("Native") || (-1 != cs.type.idata) || (3.14159 != cs.type.ddata))
            {
                breturn = false;
                Console.WriteLine(cs.i);
                Console.WriteLine(cs.b);
                Console.WriteLine(cs.str);
                Console.WriteLine(cs.type.idata);
                Console.WriteLine(cs.type.ddata);
                TestFramework.LogError("105", "TestMethodForStructComplexStruct_ReversePInvokeByRef_Cdecl. The ComplexStruct is wrong(Managed Side)");
            }
            //Chanage the value
            cs.i = 321;
            cs.b = true;
            cs.str = "Managed";
            cs.type.idata = 123;
            cs.type.ptrdata = (IntPtr)0x120000;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("106", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool ComplexStructByRefStdCallcaller([In, Out]ref ComplexStruct argStr);
    private static bool TestMethodForStructComplexStruct_ReversePInvokeByRef_StdCall(ref ComplexStruct cs)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Ref,StdCall");
        bool breturn = true;
        try
        {
            //Check the input
            if ((9999 != cs.i) || cs.b || !cs.str.Equals("Native") || (-1 != cs.type.idata) || (3.14159 != cs.type.ddata))
            {
                breturn = false;
                Console.WriteLine(cs.i);
                Console.WriteLine(cs.b);
                Console.WriteLine(cs.str);
                Console.WriteLine(cs.type.idata);
                Console.WriteLine(cs.type.ddata);
                TestFramework.LogError("107", "TestMethodForStructComplexStruct_ReversePInvokeByRef_StdCall. The ComplexStruct is wrong(Managed Side)");
            }
            //Chanage the value
            cs.i = 321;
            cs.b = true;
            cs.str = "Managed";
            cs.type.idata = 123;
            cs.type.ptrdata = (IntPtr)0x120000;
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("108", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructComplexStructByRef_Cdecl(ComplexStructByRefCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructComplexStructByRef_StdCall(ComplexStructByRefStdCallcaller caller);
   
    #endregion
   
    #region PassByValue
   
    //For Reverse Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool ComplexStructByValCdeclcaller([In, Out] ComplexStruct argStr);
    private static bool TestMethodForStructComplexStruct_ReversePInvokeByVal_Cdecl(ComplexStruct cs)
    {
        TestFramework.BeginScenario("ReversePinvoke,By Value,Cdecl");
        bool bresult = true;
        try
        {
            //Check the input
            if ((9999 != cs.i) || cs.b || !cs.str.Equals("Native") || (-1 != cs.type.idata) || (3.14159 != cs.type.ddata))
            {
                bresult = false;
                TestFramework.LogError("109", "TestMethod_ReversePInvokeByVal_Cdecl. The ComplexStruct is wrong(Managed Side)");
            }
            //Try to Chanage the value
            cs.i = 321;
            cs.b = true;
            cs.str = "Managed";
            cs.type.idata = 123;
            cs.type.ptrdata = (IntPtr)0x120000;
        }
        catch (Exception e)
        {
            bresult = false;
            TestFramework.LogError("110", "Unexpected Exception" + e.ToString());
        }
        return bresult;
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool ComplexStructByValStdCallcaller([In, Out] ComplexStruct argStr);
    private static bool TestMethodForStructComplexStruct_ReversePInvokeByVal_StdCall(ComplexStruct cs)
    {
        TestFramework.BeginScenario("Reverse Pinvoke,By Value,StdCall");
        bool bresult = true;
        try
        {
            //Check the input
            if ((9999 != cs.i) || cs.b || !cs.str.Equals("Native") || (-1 != cs.type.idata) || (3.14159 != cs.type.ddata))
            {
                bresult = false;
                TestFramework.LogError("111", "TestMethod_ReversePInvokeByVal_StdCall. The ComplexStruct is wrong(Managed Side)");
            }
            //Try to Chanage the value
            cs.i = 321;
            cs.b = true;
            cs.str = "Managed";
            cs.type.idata = 123;
            cs.type.ptrdata = (IntPtr)0x120000;
        }
        catch (Exception e)
        {
            bresult = false;
            TestFramework.LogError("112", "Unexpected Exception" + e.ToString());
        }
        return bresult;
    }

    //Reverse Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DoCallBack_MarshalStructComplexStructByVal_Cdecl(ComplexStructByValCdeclcaller caller);
    //Reverse Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool DoCallBack_MarshalStructComplexStructByVal_StdCall(ComplexStructByValStdCallcaller caller);
   
    #endregion
   
    #endregion

    #region Methods implementation
   
    //Reverse P/Invoke By Ref
    private static bool TestMethod_DoCallBack_MarshalStructByRef_Cdecl(StructID structid)
    {
        bool breturn = true;
        try
        {
            switch (structid)
            {
                case StructID.ComplexStructId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructComplexStructByRef_Cdecl...");
                    if (!DoCallBack_MarshalStructComplexStructByRef_Cdecl(new ComplexStructByRefCdeclcaller(TestMethodForStructComplexStruct_ReversePInvokeByRef_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C001", "DoCallBack_MarshalStructComplexStructByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.InnerSequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructInnerSequentialByRef_Cdecl...");
                    if (!DoCallBack_MarshalStructInnerSequentialByRef_Cdecl(new InnerSequentialByRefCdeclcaller(TestMethodForStructInnerSequential_ReversePInvokeByRef_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C002", "DoCallBack_MarshalStructInnerSequentialByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.InnerArraySequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructInnerArraySequentialByRef_Cdecl...");
                    if (!DoCallBack_MarshalStructInnerArraySequentialByRef_Cdecl(
                        new InnerArraySequentialByRefCdeclcaller(TestMethodForStructInnerArraySequential_ReversePInvokeByRef_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C003", "DoCallBack_MarshalStructInnerArraySequentialByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.CharSetAnsiSequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructCharSetAnsiSequentialByRef_Cdecl...");
                    if (!DoCallBack_MarshalStructCharSetAnsiSequentialByRef_Cdecl(
                        new CharSetAnsiSequentialByRefCdeclcaller(TestMethodForStructCharSetAnsiSequential_ReversePInvokeByRef_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C004", "DoCallBack_MarshalStructCharSetAnsiSequentialByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.CharSetUnicodeSequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructCharSetUnicodeSequentialByRef_Cdecl...");
                    if (!DoCallBack_MarshalStructCharSetUnicodeSequentialByRef_Cdecl(
                        new CharSetUnicodeSequentialByRefCdeclcaller(TestMethodForStructCharSetUnicodeSequential_ReversePInvokeByRef_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C005", "DoCallBack_MarshalStructCharSetUnicodeSequentialByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.NumberSequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructNumberSequentialByRef_Cdecl...");
                    if (!DoCallBack_MarshalStructNumberSequentialByRef_Cdecl(new NumberSequentialByRefCdeclcaller(TestMethodForStructNumberSequential_ReversePInvokeByRef_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C006", "DoCallBack_MarshalStructNumberSequentialByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S3Id:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructS3ByRef_Cdecl...");
                    if (!DoCallBack_MarshalStructS3ByRef_Cdecl(new S3ByRefCdeclcaller(TestMethodForStructS3_ReversePInvokeByRef_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C007", "DoCallBack_MarshalStructS3ByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S5Id:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructS5ByRef_Cdecl...");
                    if (!DoCallBack_MarshalStructS5ByRef_Cdecl(new S5ByRefCdeclcaller(TestMethodForStructS5_ReversePInvokeByRef_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C008", "DoCallBack_MarshalStructS5ByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.StringStructSequentialAnsiId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructStringStructSequentialAnsiByRef_Cdecl...");
                    if (!DoCallBack_MarshalStructStringStructSequentialAnsiByRef_Cdecl(
                        new StringStructSequentialAnsiByRefCdeclcaller(TestMethodForStructStringStructSequentialAnsi_ReversePInvokeByRef_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C009", "DoCallBack_MarshalStructStringStructSequentialAnsiByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.StringStructSequentialUnicodeId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructStringStructSequentialUnicodeByRef_Cdecl...");
                    if (!DoCallBack_MarshalStructStringStructSequentialUnicodeByRef_Cdecl(
                        new StringStructSequentialUnicodeByRefCdeclcaller(TestMethodForStructStringStructSequentialUnicode_ReversePInvokeByRef_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C010", "DoCallBack_MarshalStructStringStructSequentialUnicodeByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S8Id:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructS8ByRef_Cdecl...");
                    if (!DoCallBack_MarshalStructS8ByRef_Cdecl(new S8ByRefCdeclcaller(TestMethodForStructS8_ReversePInvokeByRef_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C011", "DoCallBack_MarshalStructS8ByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S9Id:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructS9ByRef_Cdecl...");
                    if (!DoCallBack_MarshalStructS9ByRef_Cdecl(new S9ByRefCdeclcaller(TestMethodForStructS9_ReversePInvokeByRef_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C012", "DoCallBack_MarshalStructS9ByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.IncludeOuterIntergerStructSequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructIncludeOuterIntergerStructSequentialByRef_Cdecl...");
                    if (!DoCallBack_MarshalStructIncludeOuterIntergerStructSequentialByRef_Cdecl(
                        new IncludeOuterIntergerStructSequentialByRefCdeclcaller(TestMethodForStructIncludeOuterIntergerStructSequential_ReversePInvokeByRef_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C013", "DoCallBack_MarshalStructIncludeOuterIntergerStructSequentialByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S11Id:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructS11ByRef_Cdecl...");
                    if (!DoCallBack_MarshalStructS11ByRef_Cdecl(new S11ByRefCdeclcaller(TestMethodForStructS11_ReversePInvokeByRef_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C014", "DoCallBack_MarshalStructS11ByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                default:
                    breturn = false;
                    TestFramework.LogError("D200", "DoCallBack_MarshalStructByRef_Cdecl:The structid (Managed Side) is wrong");
                    break;
            }
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("300", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    private static bool TestMethod_DoCallBack_MarshalStructByRef_StdCall(StructID structid)
    {
        bool breturn = true;
        try
        {
            switch (structid)
            {
                case StructID.ComplexStructId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructComplexStructByRef_StdCall...");
                    if (!DoCallBack_MarshalStructComplexStructByRef_StdCall(new ComplexStructByRefStdCallcaller(TestMethodForStructComplexStruct_ReversePInvokeByRef_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C100", "DoCallBack_MarshalStructComplexStructByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.InnerSequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructInnerSequentialByRef_StdCall...");
                    if (!DoCallBack_MarshalStructInnerSequentialByRef_StdCall(new InnerSequentialByRefStdCallcaller(TestMethodForStructInnerSequential_ReversePInvokeByRef_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C101", "DoCallBack_MarshalStructInnerSequentialByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.InnerArraySequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructInnerArraySequentialByRef_StdCall...");
                    if (!DoCallBack_MarshalStructInnerArraySequentialByRef_StdCall(
                        new InnerArraySequentialByRefStdCallcaller(TestMethodForStructInnerArraySequential_ReversePInvokeByRef_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C102", "DoCallBack_MarshalStructInnerArraySequentialByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.CharSetAnsiSequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructCharSetAnsiSequentialByRef_StdCall...");
                    if (!DoCallBack_MarshalStructCharSetAnsiSequentialByRef_StdCall(
                        new CharSetAnsiSequentialByRefStdCallcaller(TestMethodForStructCharSetAnsiSequential_ReversePInvokeByRef_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C103", "DoCallBack_MarshalStructCharSetAnsiSequentialByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.CharSetUnicodeSequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructCharSetUnicodeSequentialByRef_StdCall...");
                    if (!DoCallBack_MarshalStructCharSetUnicodeSequentialByRef_StdCall(
                        new CharSetUnicodeSequentialByRefStdCallcaller(TestMethodForStructCharSetUnicodeSequential_ReversePInvokeByRef_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C104", "DoCallBack_MarshalStructCharSetUnicodeSequentialByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.NumberSequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructNumberSequentialByRef_StdCall...");
                    if (!DoCallBack_MarshalStructNumberSequentialByRef_StdCall(new NumberSequentialByRefStdCallcaller(TestMethodForStructNumberSequential_ReversePInvokeByRef_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C105", "DoCallBack_MarshalStructNumberSequentialByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S3Id:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructS3ByRef_StdCall...");
                    if (!DoCallBack_MarshalStructS3ByRef_StdCall(new S3ByRefStdCallcaller(TestMethodForStructS3_ReversePInvokeByRef_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C106", "DoCallBack_MarshalStructS3ByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S5Id:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructS5ByRef_StdCall...");
                    if (!DoCallBack_MarshalStructS5ByRef_StdCall(new S5ByRefStdCallcaller(TestMethodForStructS5_ReversePInvokeByRef_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C107", "DoCallBack_MarshalStructS5ByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.StringStructSequentialAnsiId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructStringStructSequentialAnsiByRef_StdCall...");
                    if (!DoCallBack_MarshalStructStringStructSequentialAnsiByRef_StdCall(
                        new StringStructSequentialAnsiByRefStdCallcaller(TestMethodForStructStringStructSequentialAnsi_ReversePInvokeByRef_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C108", "DoCallBack_MarshalStructStringStructSequentialAnsiByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.StringStructSequentialUnicodeId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructStringStructSequentialUnicodeByRef_StdCall...");
                    if (!DoCallBack_MarshalStructStringStructSequentialUnicodeByRef_StdCall(
                        new StringStructSequentialUnicodeByRefStdCallcaller(TestMethodForStructStringStructSequentialUnicode_ReversePInvokeByRef_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C109", "DoCallBack_MarshalStructStringStructSequentialUnicodeByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S8Id:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructS8ByRef_StdCall...");
                    if (!DoCallBack_MarshalStructS8ByRef_StdCall(new S8ByRefStdCallcaller(TestMethodForStructS8_ReversePInvokeByRef_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C110", "DoCallBack_MarshalStructS8ByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S9Id:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructS9ByRef_StdCall...");
                    if (!DoCallBack_MarshalStructS9ByRef_StdCall(new S9ByRefStdCallcaller(TestMethodForStructS9_ReversePInvokeByRef_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C111", "DoCallBack_MarshalStructS9ByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.IncludeOuterIntergerStructSequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructIncludeOuterIntergerStructSequentialByRef_StdCall...");
                    if (!DoCallBack_MarshalStructIncludeOuterIntergerStructSequentialByRef_StdCall(
                        new IncludeOuterIntergerStructSequentialByRefStdCallcaller(TestMethodForStructIncludeOuterIntergerStructSequential_ReversePInvokeByRef_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C112", "DoCallBack_MarshalStructIncludeOuterIntergerStructSequentialByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S11Id:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructS11ByRef_StdCall...");
                    if (!DoCallBack_MarshalStructS11ByRef_StdCall(new S11ByRefStdCallcaller(TestMethodForStructS11_ReversePInvokeByRef_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C113", "DoCallBack_MarshalStructS11ByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                default:
                    breturn = false;
                    TestFramework.LogError("D201", "DoCallBack_MarshalStructByRef_StdCall:The structid (Managed Side) is wrong");
                    break;
            }
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("301", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    private static bool Run_TestMethod_DoCallBack_MarshalStructByRef_Cdecl()
    {
        bool bresult = true;
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_Cdecl(StructID.ComplexStructId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_Cdecl(StructID.InnerSequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_Cdecl(StructID.InnerArraySequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_Cdecl(StructID.CharSetAnsiSequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_Cdecl(StructID.CharSetUnicodeSequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_Cdecl(StructID.NumberSequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_Cdecl(StructID.S3Id);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_Cdecl(StructID.S5Id);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_Cdecl(StructID.StringStructSequentialAnsiId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_Cdecl(StructID.StringStructSequentialUnicodeId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_Cdecl(StructID.S8Id);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_Cdecl(StructID.S9Id);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_Cdecl(StructID.IncludeOuterIntergerStructSequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_Cdecl(StructID.S11Id);
        return bresult;
    }

    private static bool Run_TestMethod_DoCallBack_MarshalStructByRef_StdCall()
    {
        bool bresult = true;
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_StdCall(StructID.ComplexStructId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_StdCall(StructID.InnerSequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_StdCall(StructID.InnerArraySequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_StdCall(StructID.CharSetAnsiSequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_StdCall(StructID.CharSetUnicodeSequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_StdCall(StructID.NumberSequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_StdCall(StructID.S3Id);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_StdCall(StructID.S5Id);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_StdCall(StructID.StringStructSequentialAnsiId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_StdCall(StructID.StringStructSequentialUnicodeId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_StdCall(StructID.S8Id);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_StdCall(StructID.S9Id);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_StdCall(StructID.IncludeOuterIntergerStructSequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByRef_StdCall(StructID.S11Id);
        return bresult;
    }

    //Reverse P/Invoke By Value
    private static bool TestMethod_DoCallBack_MarshalStructByVal_Cdecl(StructID structid)
    {
        bool breturn = true;
        try
        {
            switch (structid)
            {
                case StructID.ComplexStructId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructComplexeStructByVal_Cdecl...");
                    if (!DoCallBack_MarshalStructComplexStructByVal_Cdecl(new ComplexStructByValCdeclcaller(TestMethodForStructComplexStruct_ReversePInvokeByVal_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C200", "DoCallBack_MarshalStructComplexStructByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.InnerSequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructInnerSequentialByVal_Cdecl...");
                    if (!DoCallBack_MarshalStructInnerSequentialByVal_Cdecl(new InnerSequentialByValCdeclcaller(TestMethodForStructInnerSequential_ReversePInvokeByVal_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C201", "DoCallBack_MarshalStructInnerSequentialByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.InnerArraySequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructInnerArraySequentialByVal_Cdecl...");
                    if (!DoCallBack_MarshalStructInnerArraySequentialByVal_Cdecl(
                        new InnerArraySequentialByValCdeclcaller(TestMethodForStructInnerArraySequential_ReversePInvokeByVal_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C202", "DoCallBack_MarshalStructInnerArraySequentialByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.CharSetAnsiSequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructCharSetAnsiSequentialByVal_Cdecl...");
                    if (!DoCallBack_MarshalStructCharSetAnsiSequentialByVal_Cdecl
                        (new CharSetAnsiSequentialByValCdeclcaller(TestMethodForStructCharSetAnsiSequential_ReversePInvokeByVal_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C203", "DoCallBack_MarshalStructCharSetAnsiSequentialByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.CharSetUnicodeSequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructCharSetUnicodeSequentialByVal_Cdecl...");
                    if (!DoCallBack_MarshalStructCharSetUnicodeSequentialByVal_Cdecl(
                        new CharSetUnicodeSequentialByValCdeclcaller(TestMethodForStructCharSetUnicodeSequential_ReversePInvokeByVal_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C204", "DoCallBack_MarshalStructCharSetUnicodeSequentialByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.NumberSequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructNumberSequentialByVal_Cdecl...");
                    if (!DoCallBack_MarshalStructNumberSequentialByVal_Cdecl(new NumberSequentialByValCdeclcaller(TestMethodForStructNumberSequential_ReversePInvokeByVal_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C205", "DoCallBack_MarshalStructNumberSequentialByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S3Id:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructS3ByVal_Cdecl...");
                    if (!DoCallBack_MarshalStructS3ByVal_Cdecl(new S3ByValCdeclcaller(TestMethodForStructS3_ReversePInvokeByVal_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C206", "DoCallBack_MarshalStructS3ByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S5Id:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructS5ByVal_Cdecl...");
                    if (!DoCallBack_MarshalStructS5ByVal_Cdecl(new S5ByValCdeclcaller(TestMethodForStructS5_ReversePInvokeByVal_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C207", "DoCallBack_MarshalStructS5ByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.StringStructSequentialAnsiId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructStringStructSequentialAnsiByVal_Cdecl...");
                    if (!DoCallBack_MarshalStructStringStructSequentialAnsiByVal_Cdecl(
                        new StringStructSequentialAnsiByValCdeclcaller(TestMethodForStructStringStructSequentialAnsi_ReversePInvokeByVal_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C208", "DoCallBack_MarshalStructStringStructSequentialAnsiByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.StringStructSequentialUnicodeId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructStringStructSequentialUnicodeByVal_Cdecl...");
                    if (!DoCallBack_MarshalStructStringStructSequentialUnicodeByVal_Cdecl(
                        new StringStructSequentialUnicodeByValCdeclcaller(TestMethodForStructStringStructSequentialUnicode_ReversePInvokeByVal_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C209", "DoCallBack_MarshalStructStringStructSequentialUnicodeByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S8Id:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructS8ByVal_Cdecl...");
                    if (!DoCallBack_MarshalStructS8ByVal_Cdecl(new S8ByValCdeclcaller(TestMethodForStructS8_ReversePInvokeByVal_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C210", "DoCallBack_MarshalStructS8ByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S9Id:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructS9ByVal_Cdecl...");
                    if (!DoCallBack_MarshalStructS9ByVal_Cdecl(new S9ByValCdeclcaller(TestMethodForStructS9_ReversePInvokeByVal_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C211", "DoCallBack_MarshalStructS9ByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.IncludeOuterIntergerStructSequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructIncludeOuterIntergerStructSequentialByVal_Cdecl...");
                    if (!DoCallBack_MarshalStructIncludeOuterIntergerStructSequentialByVal_Cdecl(
                        new IncludeOuterIntergerStructSequentialByValCdeclcaller(TestMethodForStructIncludeOuterIntergerStructSequential_ReversePInvokeByVal_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C212", "DoCallBack_MarshalStructIncludeOuterIntergerStructSequentialByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S11Id:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructS11ByVal_Cdecl...");
                    if (!DoCallBack_MarshalStructS11ByVal_Cdecl(new S11ByValCdeclcaller(TestMethodForStructS11_ReversePInvokeByVal_Cdecl)))
                    {
                        breturn = false;
                        TestFramework.LogError("C213", "DoCallBack_MarshalStructS11ByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    break;
                default:
                    breturn = false;
                    TestFramework.LogError("D202", "DoCallBack_MarshalStructByVal_Cdecl:The structid (Managed Side) is wrong");
                    break;
            }
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("302", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    private static bool TestMethod_DoCallBack_MarshalStructByVal_StdCall(StructID structid)
    {
        bool breturn = true;
        try
        {
            switch (structid)
            {
                case StructID.ComplexStructId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructComplexStructByVal_StdCall...");
                    if (!DoCallBack_MarshalStructComplexStructByVal_StdCall(new ComplexStructByValStdCallcaller(TestMethodForStructComplexStruct_ReversePInvokeByVal_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C300", "DoCallBack_MarshalStructComplexStructByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.InnerSequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructInnerSequentialByVal_StdCall...");
                    if (!DoCallBack_MarshalStructInnerSequentialByVal_StdCall(new InnerSequentialByValStdCallcaller(TestMethodForStructInnerSequential_ReversePInvokeByVal_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C301", "DoCallBack_MarshalStructInnerSequentialByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.InnerArraySequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructInnerArraySequentialByVal_StdCall...");
                    if (!DoCallBack_MarshalStructInnerArraySequentialByVal_StdCall(
                        new InnerArraySequentialByValStdCallcaller(TestMethodForStructInnerArraySequential_ReversePInvokeByVal_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C302", "DoCallBack_MarshalStructInnerArraySequentialByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.CharSetAnsiSequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructCharSetAnsiSequentialByVal_StdCall...");
                    if (!DoCallBack_MarshalStructCharSetAnsiSequentialByVal_StdCall(
                        new CharSetAnsiSequentialByValStdCallcaller(TestMethodForStructCharSetAnsiSequential_ReversePInvokeByVal_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C303", "DoCallBack_MarshalStructCharSetAnsiSequentialByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.CharSetUnicodeSequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructCharSetUnicodeSequentialByVal_StdCall...");
                    if (!DoCallBack_MarshalStructCharSetUnicodeSequentialByVal_StdCall(
                        new CharSetUnicodeSequentialByValStdCallcaller(TestMethodForStructCharSetUnicodeSequential_ReversePInvokeByVal_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C304", "DoCallBack_MarshalStructCharSetUnicodeSequentialByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.NumberSequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructNumberSequentialByVal_StdCall...");
                    if (!DoCallBack_MarshalStructNumberSequentialByVal_StdCall(new NumberSequentialByValStdCallcaller(TestMethodForStructNumberSequential_ReversePInvokeByVal_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C305", "DoCallBack_MarshalStructNumberSequentialByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S3Id:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructS3ByVal_StdCall...");
                    if (!DoCallBack_MarshalStructS3ByVal_StdCall(new S3ByValStdCallcaller(TestMethodForStructS3_ReversePInvokeByVal_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C306", "DoCallBack_MarshalStructS3ByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S5Id:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructS5ByVal_StdCall...");
                    if (!DoCallBack_MarshalStructS5ByVal_StdCall(new S5ByValStdCallcaller(TestMethodForStructS5_ReversePInvokeByVal_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C307", "DoCallBack_MarshalStructS5ByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.StringStructSequentialAnsiId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructStringStructSequentialAnsiByVal_StdCall...");
                    if (!DoCallBack_MarshalStructStringStructSequentialAnsiByVal_StdCall(
                        new StringStructSequentialAnsiByValStdCallcaller(TestMethodForStructStringStructSequentialAnsi_ReversePInvokeByVal_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C308", "DoCallBack_MarshalStructStringStructSequentialAnsiByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.StringStructSequentialUnicodeId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructStringStructSequentialUnicodeByVal_StdCall...");
                    if (!DoCallBack_MarshalStructStringStructSequentialUnicodeByVal_StdCall(
                        new StringStructSequentialUnicodeByValStdCallcaller(TestMethodForStructStringStructSequentialUnicode_ReversePInvokeByVal_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C309", "DoCallBack_MarshalStructStringStructSequentialUnicodeByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S8Id:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructS8ByVal_StdCall...");
                    if (!DoCallBack_MarshalStructS8ByVal_StdCall(new S8ByValStdCallcaller(TestMethodForStructS8_ReversePInvokeByVal_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C310", "DoCallBack_MarshalStructS8ByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S9Id:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructS9ByVal_StdCall...");
                    if (!DoCallBack_MarshalStructS9ByVal_StdCall(new S9ByValStdCallcaller(TestMethodForStructS9_ReversePInvokeByVal_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C311", "DoCallBack_MarshalStructS9ByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.IncludeOuterIntergerStructSequentialId:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructIncludeOuterIntergerStructSequentialByVal_StdCall...");
                    if (!DoCallBack_MarshalStructIncludeOuterIntergerStructSequentialByVal_StdCall(
                        new IncludeOuterIntergerStructSequentialByValStdCallcaller(TestMethodForStructIncludeOuterIntergerStructSequential_ReversePInvokeByVal_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C312", "DoCallBack_MarshalStructIncludeOuterIntergerStructSequentialByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S11Id:
                    Console.WriteLine("\tCalling ReversePInvoke_MarshalStructS11ByVal_StdCall...");
                    if (!DoCallBack_MarshalStructS11ByVal_StdCall(new S11ByValStdCallcaller(TestMethodForStructS11_ReversePInvokeByVal_StdCall)))
                    {
                        breturn = false;
                        TestFramework.LogError("C313", "DoCallBack_MarshalStructS11ByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    break;
                default:
                    breturn = false;
                    TestFramework.LogError("D203", "DoCallBack_MarshalStructByVal_StdCall:The structid (Managed Side) is wrong");
                    break;
            }
        }
        catch (Exception e)
        {
            breturn = false;
            TestFramework.LogError("303", "Unexpected Exception" + e.ToString());
        }
        return breturn;
    }

    private static bool Run_TestMethod_DoCallBack_MarshalStructByVal_Cdecl()
    {
        bool bresult = true;
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_Cdecl(StructID.ComplexStructId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_Cdecl(StructID.InnerSequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_Cdecl(StructID.InnerArraySequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_Cdecl(StructID.CharSetAnsiSequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_Cdecl(StructID.CharSetUnicodeSequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_Cdecl(StructID.NumberSequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_Cdecl(StructID.S3Id);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_Cdecl(StructID.S5Id);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_Cdecl(StructID.StringStructSequentialAnsiId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_Cdecl(StructID.StringStructSequentialUnicodeId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_Cdecl(StructID.S8Id);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_Cdecl(StructID.S9Id);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_Cdecl(StructID.IncludeOuterIntergerStructSequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_Cdecl(StructID.S11Id);
        return bresult;
    }
   
    private static bool Run_TestMethod_DoCallBack_MarshalStructByVal_StdCall()
    {
        bool bresult = true;
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_StdCall(StructID.ComplexStructId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_StdCall(StructID.InnerSequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_StdCall(StructID.InnerArraySequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_StdCall(StructID.CharSetAnsiSequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_StdCall(StructID.CharSetUnicodeSequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_StdCall(StructID.NumberSequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_StdCall(StructID.S3Id);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_StdCall(StructID.S5Id);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_StdCall(StructID.StringStructSequentialAnsiId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_StdCall(StructID.StringStructSequentialUnicodeId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_StdCall(StructID.S8Id);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_StdCall(StructID.S9Id);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_StdCall(StructID.IncludeOuterIntergerStructSequentialId);
        bresult = bresult && TestMethod_DoCallBack_MarshalStructByVal_StdCall(StructID.S11Id);
        return bresult;
    }
  
    #endregion

    static int Main()
    {
        bool bresult = true;

        //Reverse Pinvoke,ByRef,cdecl
        Console.WriteLine("Run the methods for marshaling struct Reverse P/Invoke ByRef");
        bresult = bresult && Run_TestMethod_DoCallBack_MarshalStructByRef_Cdecl();
        bresult = bresult && Run_TestMethod_DoCallBack_MarshalStructByRef_StdCall();

        //Reverse PInvoke,ByValue,Cdcel
        Console.WriteLine("\nRun the methods for marshaling struct Reverse P/Invoke ByVal");
        bresult = bresult && Run_TestMethod_DoCallBack_MarshalStructByVal_Cdecl();
        bresult = bresult && Run_TestMethod_DoCallBack_MarshalStructByVal_StdCall();

        if (bresult)
        {
            Console.WriteLine("Sucessed!");
        }
        else
        {
            Console.WriteLine("Failed!");
        }

        return bresult ? 100 : 101;
    }
}