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
  
    //For Delegate Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool InnerSequentialByRefDelegateCdecl([In, Out]ref InnerSequential argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool InnerSequentialByRefDelegateStdCall([In, Out]ref InnerSequential argStr);
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructInnerSequentialByRef_Cdecl([In, Out]ref InnerSequential argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern InnerSequentialByRefDelegateCdecl Get_MarshalStructInnerSequentialByRef_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructInnerSequentialByRef_StdCall([In, Out]ref InnerSequential argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern InnerSequentialByRefDelegateStdCall Get_MarshalStructInnerSequentialByRef_StdCall_FuncPtr();
  
    #endregion
  
    #region PassByValue
   
    //For Delegate Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool InnerSequentialByValDelegateCdecl([In, Out] InnerSequential argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool InnerSequentialByValDelegateStdCall([In, Out] InnerSequential argStr);
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructInnerSequentialByVal_Cdecl([In, Out] InnerSequential argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern InnerSequentialByValDelegateCdecl Get_MarshalStructInnerSequentialByVal_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructInnerSequentialByVal_StdCall([In, Out] InnerSequential argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern InnerSequentialByValDelegateStdCall Get_MarshalStructInnerSequentialByVal_StdCall_FuncPtr();
  
    #endregion

    #endregion

    #region Methods for the struct InnerArraySequential declaration
   
    #region PassByRef
  
    //For Delegate Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool InnerArraySequentialByRefDelegateCdecl([In, Out]ref InnerArraySequential argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool InnerArraySequentialByRefDelegateStdCall([In, Out]ref InnerArraySequential argStr);
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructInnerArraySequentialByRef_Cdecl([In, Out]ref InnerArraySequential argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern InnerArraySequentialByRefDelegateCdecl Get_MarshalStructInnerArraySequentialByRef_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructInnerArraySequentialByRef_StdCall([In, Out]ref InnerArraySequential argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern InnerArraySequentialByRefDelegateStdCall Get_MarshalStructInnerArraySequentialByRef_StdCall_FuncPtr();
 
    #endregion
  
    #region PassByValue
 
    //For Delegate Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool InnerArraySequentialByValDelegateCdecl([In, Out] InnerArraySequential argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool InnerArraySequentialByValDelegateStdCall([In, Out] InnerArraySequential argStr);
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructInnerArraySequentialByVal_Cdecl([In, Out] InnerArraySequential argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern InnerArraySequentialByValDelegateCdecl Get_MarshalStructInnerArraySequentialByVal_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructInnerArraySequentialByVal_StdCall([In, Out] InnerArraySequential argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern InnerArraySequentialByValDelegateStdCall Get_MarshalStructInnerArraySequentialByVal_StdCall_FuncPtr();

    #endregion
  
    #endregion

    #region Methods for the struct CharSetAnsiSequential declaration
  
    #region PassByRef
  
    //For Delegate Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool CharSetAnsiSequentialByRefDelegateCdecl([In, Out]ref CharSetAnsiSequential argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool CharSetAnsiSequentialByRefDelegateStdCall([In, Out]ref CharSetAnsiSequential argStr);
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructCharSetAnsiSequentialByRef_Cdecl([In, Out]ref CharSetAnsiSequential argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern CharSetAnsiSequentialByRefDelegateCdecl Get_MarshalStructCharSetAnsiSequentialByRef_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructCharSetAnsiSequentialByRef_StdCall([In, Out]ref CharSetAnsiSequential argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern CharSetAnsiSequentialByRefDelegateStdCall Get_MarshalStructCharSetAnsiSequentialByRef_StdCall_FuncPtr();
  
    #endregion
  
    #region PassByValue
   
    //For Delegate Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool CharSetAnsiSequentialByValDelegateCdecl([In, Out] CharSetAnsiSequential argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool CharSetAnsiSequentialByValDelegateStdCall([In, Out] CharSetAnsiSequential argStr);
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructCharSetAnsiSequentialByVal_Cdecl([In, Out] CharSetAnsiSequential argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern CharSetAnsiSequentialByValDelegateCdecl Get_MarshalStructCharSetAnsiSequentialByVal_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructCharSetAnsiSequentialByVal_StdCall([In, Out] CharSetAnsiSequential argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern CharSetAnsiSequentialByValDelegateStdCall Get_MarshalStructCharSetAnsiSequentialByVal_StdCall_FuncPtr();
   
    #endregion
  
    #endregion

    #region Methods for the struct CharSetUnicodeSequential declaration
  
    #region PassByRef
  
    //For Delegate Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool CharSetUnicodeSequentialByRefDelegateCdecl([In, Out]ref CharSetUnicodeSequential argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool CharSetUnicodeSequentialByRefDelegateStdCall([In, Out]ref CharSetUnicodeSequential argStr);
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructCharSetUnicodeSequentialByRef_Cdecl([In, Out]ref CharSetUnicodeSequential argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern CharSetUnicodeSequentialByRefDelegateCdecl Get_MarshalStructCharSetUnicodeSequentialByRef_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructCharSetUnicodeSequentialByRef_StdCall([In, Out]ref CharSetUnicodeSequential argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern CharSetUnicodeSequentialByRefDelegateStdCall Get_MarshalStructCharSetUnicodeSequentialByRef_StdCall_FuncPtr();
  
    #endregion
 
    #region PassByValue
  
    //For Delegate Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool CharSetUnicodeSequentialByValDelegateCdecl([In, Out] CharSetUnicodeSequential argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool CharSetUnicodeSequentialByValDelegateStdCall([In, Out] CharSetUnicodeSequential argStr);
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructCharSetUnicodeSequentialByVal_Cdecl([In, Out] CharSetUnicodeSequential argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern CharSetUnicodeSequentialByValDelegateCdecl Get_MarshalStructCharSetUnicodeSequentialByVal_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructCharSetUnicodeSequentialByVal_StdCall([In, Out] CharSetUnicodeSequential argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern CharSetUnicodeSequentialByValDelegateStdCall Get_MarshalStructCharSetUnicodeSequentialByVal_StdCall_FuncPtr();
  
    #endregion
  
    #endregion

    #region Methods for the struct NumberSequential declaration

    #region PassByRef
 
    //For Delegate Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool NumberSequentialByRefDelegateCdecl([In, Out]ref NumberSequential argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool NumberSequentialByRefDelegateStdCall([In, Out]ref NumberSequential argStr);
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructNumberSequentialByRef_Cdecl([In, Out]ref NumberSequential argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern NumberSequentialByRefDelegateCdecl Get_MarshalStructNumberSequentialByRef_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructNumberSequentialByRef_StdCall([In, Out]ref NumberSequential argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern NumberSequentialByRefDelegateStdCall Get_MarshalStructNumberSequentialByRef_StdCall_FuncPtr();
   
    #endregion
   
    #region PassByValue
  
    //For Delegate Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool NumberSequentialByValDelegateCdecl([In, Out] NumberSequential argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool NumberSequentialByValDelegateStdCall([In, Out] NumberSequential argStr);
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructNumberSequentialByVal_Cdecl([In, Out] NumberSequential argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern NumberSequentialByValDelegateCdecl Get_MarshalStructNumberSequentialByVal_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructNumberSequentialByVal_StdCall([In, Out] NumberSequential argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern NumberSequentialByValDelegateStdCall Get_MarshalStructNumberSequentialByVal_StdCall_FuncPtr();
   
    #endregion

    #endregion

    #region Methods for the struct S3 declaration

    #region PassByRef
  
    //For Delegate Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool S3ByRefDelegateCdecl([In, Out]ref S3 argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool S3ByRefDelegateStdCall([In, Out]ref S3 argStr);
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructS3ByRef_Cdecl([In, Out]ref S3 argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern S3ByRefDelegateCdecl Get_MarshalStructS3ByRef_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructS3ByRef_StdCall([In, Out]ref S3 argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern S3ByRefDelegateStdCall Get_MarshalStructS3ByRef_StdCall_FuncPtr();
   
    #endregion
   
    #region PassByValue
   
    //For Delegate Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool S3ByValDelegateCdecl([In, Out] S3 argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool S3ByValDelegateStdCall([In, Out] S3 argStr);
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructS3ByVal_Cdecl([In, Out] S3 argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern S3ByValDelegateCdecl Get_MarshalStructS3ByVal_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructS3ByVal_StdCall([In, Out] S3 argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern S3ByValDelegateStdCall Get_MarshalStructS3ByVal_StdCall_FuncPtr();
  
    #endregion

    #endregion

    #region Methods for the struct S5 declaration

    #region PassByRef
   
    //For Delegate Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool S5ByRefDelegateCdecl([In, Out]ref S5 argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool S5ByRefDelegateStdCall([In, Out]ref S5 argStr);
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructS5ByRef_Cdecl([In, Out]ref S5 argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern S5ByRefDelegateCdecl Get_MarshalStructS5ByRef_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructS5ByRef_StdCall([In, Out]ref S5 argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern S5ByRefDelegateStdCall Get_MarshalStructS5ByRef_StdCall_FuncPtr();
   
    #endregion
   
    #region PassByValue
    
    //For Delegate Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool S5ByValDelegateCdecl([In, Out] S5 argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool S5ByValDelegateStdCall([In, Out] S5 argStr);
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructS5ByVal_Cdecl([In, Out] S5 argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern S5ByValDelegateCdecl Get_MarshalStructS5ByVal_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructS5ByVal_StdCall([In, Out] S5 argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern S5ByValDelegateStdCall Get_MarshalStructS5ByVal_StdCall_FuncPtr();
   
    #endregion

    #endregion

    #region Methods for the struct StringStructSequentialAnsi declaration

    #region PassByRef
    
    //For Delegate Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool StringStructSequentialAnsiByRefDelegateCdecl([In, Out]ref StringStructSequentialAnsi argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool StringStructSequentialAnsiByRefDelegateStdCall([In, Out]ref StringStructSequentialAnsi argStr);
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructStringStructSequentialAnsiByRef_Cdecl([In, Out]ref StringStructSequentialAnsi argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern StringStructSequentialAnsiByRefDelegateCdecl Get_MarshalStructStringStructSequentialAnsiByRef_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructStringStructSequentialAnsiByRef_StdCall([In, Out]ref StringStructSequentialAnsi argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern StringStructSequentialAnsiByRefDelegateStdCall Get_MarshalStructStringStructSequentialAnsiByRef_StdCall_FuncPtr();
   
    #endregion
  
    #region PassByValue
   
    //For Delegate Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool StringStructSequentialAnsiByValDelegateCdecl([In, Out] StringStructSequentialAnsi argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool StringStructSequentialAnsiByValDelegateStdCall([In, Out] StringStructSequentialAnsi argStr);
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructStringStructSequentialAnsiByVal_Cdecl([In, Out] StringStructSequentialAnsi argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern StringStructSequentialAnsiByValDelegateCdecl Get_MarshalStructStringStructSequentialAnsiByVal_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructStringStructSequentialAnsiByVal_StdCall([In, Out] StringStructSequentialAnsi argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern StringStructSequentialAnsiByValDelegateStdCall Get_MarshalStructStringStructSequentialAnsiByVal_StdCall_FuncPtr();
    
    #endregion

    #endregion

    #region Methods for the struct StringStructSequentialUnicode declaration

    #region PassByRef
    
    //For Delegate Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool StringStructSequentialUnicodeByRefDelegateCdecl([In, Out]ref StringStructSequentialUnicode argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool StringStructSequentialUnicodeByRefDelegateStdCall([In, Out]ref StringStructSequentialUnicode argStr);
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructStringStructSequentialUnicodeByRef_Cdecl([In, Out]ref StringStructSequentialUnicode argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern StringStructSequentialUnicodeByRefDelegateCdecl Get_MarshalStructStringStructSequentialUnicodeByRef_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructStringStructSequentialUnicodeByRef_StdCall([In, Out]ref StringStructSequentialUnicode argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern StringStructSequentialUnicodeByRefDelegateStdCall Get_MarshalStructStringStructSequentialUnicodeByRef_StdCall_FuncPtr();
   
    #endregion
   
    #region PassByValue
  
    //For Delegate Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool StringStructSequentialUnicodeByValDelegateCdecl([In, Out] StringStructSequentialUnicode argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool StringStructSequentialUnicodeByValDelegateStdCall([In, Out] StringStructSequentialUnicode argStr);
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructStringStructSequentialUnicodeByVal_Cdecl([In, Out] StringStructSequentialUnicode argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern StringStructSequentialUnicodeByValDelegateCdecl Get_MarshalStructStringStructSequentialUnicodeByVal_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructStringStructSequentialUnicodeByVal_StdCall([In, Out] StringStructSequentialUnicode argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern StringStructSequentialUnicodeByValDelegateStdCall Get_MarshalStructStringStructSequentialUnicodeByVal_StdCall_FuncPtr();
   
    #endregion

    #endregion

    #region Methods for the struct S8 declaration

    #region PassByRef
   
    //For Delegate Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool S8ByRefDelegateCdecl([In, Out]ref S8 argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool S8ByRefDelegateStdCall([In, Out]ref S8 argStr);
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructS8ByRef_Cdecl([In, Out]ref S8 argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern S8ByRefDelegateCdecl Get_MarshalStructS8ByRef_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructS8ByRef_StdCall([In, Out]ref S8 argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern S8ByRefDelegateStdCall Get_MarshalStructS8ByRef_StdCall_FuncPtr();
   
    #endregion
   
    #region PassByValue
   
    //For Delegate Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool S8ByValDelegateCdecl([In, Out] S8 argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool S8ByValDelegateStdCall([In, Out] S8 argStr);
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructS8ByVal_Cdecl([In, Out] S8 argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern S8ByValDelegateCdecl Get_MarshalStructS8ByVal_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructS8ByVal_StdCall([In, Out] S8 argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern S8ByValDelegateStdCall Get_MarshalStructS8ByVal_StdCall_FuncPtr();
  
    #endregion

    #endregion

    #region Methods for the struct S9 declaration

    #region PassByRef
   
    //For Delegate Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool S9ByRefDelegateCdecl([In, Out]ref S9 argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool S9ByRefDelegateStdCall([In, Out]ref S9 argStr);
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructS9ByRef_Cdecl([In, Out]ref S9 argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern S9ByRefDelegateCdecl Get_MarshalStructS9ByRef_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructS9ByRef_StdCall([In, Out]ref S9 argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern S9ByRefDelegateStdCall Get_MarshalStructS9ByRef_StdCall_FuncPtr();
   
    #endregion
   
    #region PassByValue
   
    //For Delegate Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool S9ByValDelegateCdecl([In, Out] S9 argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool S9ByValDelegateStdCall([In, Out] S9 argStr);
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructS9ByVal_Cdecl([In, Out] S9 argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern S9ByValDelegateCdecl Get_MarshalStructS9ByVal_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructS9ByVal_StdCall([In, Out] S9 argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern S9ByValDelegateStdCall Get_MarshalStructS9ByVal_StdCall_FuncPtr();
   
    #endregion

    #endregion

    #region Methods for the struct IncludeOuterIntergerStructSequential declaration

    #region PassByRef
 
    //For Delegate Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool IncludeOuterIntergerStructSequentialByRefDelegateCdecl([In, Out]ref IncludeOuterIntergerStructSequential argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool IncludeOuterIntergerStructSequentialByRefDelegateStdCall([In, Out]ref IncludeOuterIntergerStructSequential argStr);
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructIncludeOuterIntergerStructSequentialByRef_Cdecl([In, Out]ref IncludeOuterIntergerStructSequential argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern IncludeOuterIntergerStructSequentialByRefDelegateCdecl Get_MarshalStructIncludeOuterIntergerStructSequentialByRef_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructIncludeOuterIntergerStructSequentialByRef_StdCall([In, Out]ref IncludeOuterIntergerStructSequential argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern IncludeOuterIntergerStructSequentialByRefDelegateStdCall Get_MarshalStructIncludeOuterIntergerStructSequentialByRef_StdCall_FuncPtr();
 
    #endregion
    
    #region PassByValue
   
    //For Delegate Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool IncludeOuterIntergerStructSequentialByValDelegateCdecl([In, Out] IncludeOuterIntergerStructSequential argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool IncludeOuterIntergerStructSequentialByValDelegateStdCall([In, Out] IncludeOuterIntergerStructSequential argStr);
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructIncludeOuterIntergerStructSequentialByVal_Cdecl([In, Out] IncludeOuterIntergerStructSequential argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern IncludeOuterIntergerStructSequentialByValDelegateCdecl Get_MarshalStructIncludeOuterIntergerStructSequentialByVal_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructIncludeOuterIntergerStructSequentialByVal_StdCall([In, Out] IncludeOuterIntergerStructSequential argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern IncludeOuterIntergerStructSequentialByValDelegateStdCall Get_MarshalStructIncludeOuterIntergerStructSequentialByVal_StdCall_FuncPtr();
   
    #endregion

    #endregion

    #region Methods for the struct S11 declaration

    #region PassByRef
  
    //For Delegate Pinvoke ByRef
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool S11ByRefDelegateCdecl([In, Out]ref S11 argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool S11ByRefDelegateStdCall([In, Out]ref S11 argStr);
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructS11ByRef_Cdecl([In, Out]ref S11 argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern S11ByRefDelegateCdecl Get_MarshalStructS11ByRef_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructS11ByRef_StdCall([In, Out]ref S11 argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern S11ByRefDelegateStdCall Get_MarshalStructS11ByRef_StdCall_FuncPtr();
  
    #endregion
  
    #region PassByValue
   
    //For Delegate Pinvoke ByVal
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool S11ByValDelegateCdecl([In, Out] S11 argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool S11ByValDelegateStdCall([In, Out] S11 argStr);
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructS11ByVal_Cdecl([In, Out] S11 argStr);
    //Delegate PInvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern S11ByValDelegateCdecl Get_MarshalStructS11ByVal_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructS11ByVal_StdCall([In, Out] S11 argStr);
    //Delegate PInvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern S11ByValDelegateStdCall Get_MarshalStructS11ByVal_StdCall_FuncPtr();
   
    #endregion

    #endregion

    #region Methods for the struct ComplexStruct declaration

    #region PassByRef
   
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool ComplexStructByRefDelegateCdecl([In, Out]ref ComplexStruct argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool ComplexStructByRefDelegateStdCall([In, Out]ref ComplexStruct argStr);
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructComplexStructByRef_Cdecl([In, Out]ref ComplexStruct argStr);
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern ComplexStructByRefDelegateCdecl Get_MarshalStructComplexStructByRef_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructComplexStructByRef_StdCall([In, Out]ref ComplexStruct argStr);
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern ComplexStructByRefDelegateStdCall Get_MarshalStructComplexStructByRef_StdCall_FuncPtr();

    #endregion

    #region PassByValue
 
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool ComplexStructByValDelegateCdecl([In, Out] ComplexStruct argStr);
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool ComplexStructByValDelegateStdCall([In, Out] ComplexStruct argStr);
    //////////////////////////////////////////////////////////////////////////////////////////////////////
    //Pinvoke,cdecl
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MarshalStructComplexStructByVal_Cdecl([In, Out] ComplexStruct argStr);
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern ComplexStructByValDelegateCdecl Get_MarshalStructComplexStructByVal_Cdecl_FuncPtr();
    //Pinvoke,stdcall
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool MarshalStructComplexStructByVal_StdCall([In, Out] ComplexStruct argStr);
    [DllImport("SeqPInvokeNative.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.FunctionPtr)]
    public static extern ComplexStructByValDelegateStdCall Get_MarshalStructComplexStructByVal_StdCall_FuncPtr();
  
    #endregion

    #endregion

    #region Methods implementation
    
    //By Ref
    //Delegate P/Invoke 
    unsafe private static bool TestMethod_DelegatePInvoke_MarshalByRef_Cdecl(StructID structid)
    {
        bool breturn = true;
        TestFramework.BeginScenario("Delegate PInvoke,By Ref,Cdecl");
        try
        {
            switch (structid)
            {
                case StructID.ComplexStructId:
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructComplexStructByRef_Cdecl...");
                    ComplexStruct cs = new ComplexStruct();
                    cs.i = 321;
                    cs.b = true;
                    cs.str = "Managed";
                    cs.type.idata = 123;
                    cs.type.ptrdata = (IntPtr)0x120000;

                    ComplexStructByRefDelegateCdecl caller1 = Get_MarshalStructComplexStructByRef_Cdecl_FuncPtr();
                    if (!caller1(ref cs))
                    {
                        breturn = false;
                        TestFramework.LogError("A001", "DelegatePInvoke_MarshalStructComplexStructByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if((9999 != cs.i) || cs.b || !cs.str.Equals("Native") || (-1 != cs.type.idata) || (3.14159 != cs.type.ddata))
                    {
                        breturn = false;
                        TestFramework.LogError("A002", "DelegatePInvoke_MarshalStructComplexStructByRef_Cdecl:The ComplexStruct value (Managed Side) is wrong");
                    }
                    break;
                case StructID.InnerSequentialId:
                    InnerSequential source_is = Helper.NewInnerSequential(1, 1.0F, "some string");
                    InnerSequential change_is = Helper.NewInnerSequential(77, 77.0F, "changed string");

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructInnerSequentialByRef_Cdecl...");
                    InnerSequentialByRefDelegateCdecl caller2 = Get_MarshalStructInnerSequentialByRef_Cdecl_FuncPtr();
                    if (!caller2(ref source_is))
                    {
                        breturn = false;
                        TestFramework.LogError("A003", "DelegatePInvoke_MarshalStructInnerSequentialByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if(!Helper.ValidateInnerSequential(source_is, change_is, "DelegatePInvoke_MarshalStructInnerSequentialByRef_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("A004", "DelegatePInvoke_MarshalStructInnerSequentialByRef_Cdecl:The InnerSequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.InnerArraySequentialId:
                    InnerArraySequential source_ias = Helper.NewInnerArraySequential(1, 1.0F, "some string");
                    InnerArraySequential change_ias = Helper.NewInnerArraySequential(77, 77.0F, "changed string");

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructInnerArraySequentialByRef_Cdecl...");
                    InnerArraySequentialByRefDelegateCdecl caller3 = Get_MarshalStructInnerArraySequentialByRef_Cdecl_FuncPtr();
                    if (!caller3(ref source_ias))
                    {
                        breturn = false;
                        TestFramework.LogError("A005", "DelegatePInvoke_MarshalStructInnerArraySequentialByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if(!Helper.ValidateInnerArraySequential(source_ias, change_ias, "DelegatePInvoke_MarshalStructInnerArraySequentialByRef_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("A006", "DelegatePInvoke_MarshalStructInnerArraySequentialByRef_Cdecl:The InnerArraySequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.CharSetAnsiSequentialId:
                    CharSetAnsiSequential source_csas = Helper.NewCharSetAnsiSequential("some string", 'c');
                    CharSetAnsiSequential change_csas = Helper.NewCharSetAnsiSequential("change string", 'n');

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructCharSetAnsiSequentialByRef_Cdecl...");
                    CharSetAnsiSequentialByRefDelegateCdecl caller4 = Get_MarshalStructCharSetAnsiSequentialByRef_Cdecl_FuncPtr();
                    if (!caller4(ref source_csas))
                    {
                        breturn = false;
                        TestFramework.LogError("A007", "DelegatePInvoke_MarshalStructCharSetAnsiSequentialByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if(!Helper.ValidateCharSetAnsiSequential(source_csas, change_csas, "DelegatePInvoke_MarshalStructCharSetAnsiSequentialByRef_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("A008", "DelegatePInvoke_MarshalStructCharSetAnsiSequentialByRef_Cdecl:The CharSetAnsiSequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.CharSetUnicodeSequentialId:
                    CharSetUnicodeSequential source_csus = Helper.NewCharSetUnicodeSequential("some string", 'c');
                    CharSetUnicodeSequential change_csus = Helper.NewCharSetUnicodeSequential("change string", 'n');

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructCharSetUnicodeSequentialByRef_Cdecl...");
                    CharSetUnicodeSequentialByRefDelegateCdecl caller5 = Get_MarshalStructCharSetUnicodeSequentialByRef_Cdecl_FuncPtr();
                    if (!caller5(ref source_csus))
                    {
                        breturn = false;
                        TestFramework.LogError("A009", "DelegatePInvoke_MarshalStructCharSetUnicodeSequentialByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if(!Helper.ValidateCharSetUnicodeSequential(source_csus, change_csus, "DelegatePInvoke_MarshalStructCharSetUnicodeSequentialByRef_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("A010", "DelegatePInvoke_MarshalStructCharSetUnicodeSequentialByRef_Cdecl:The CharSetUnicodeSequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.NumberSequentialId:
                    NumberSequential source_ns = Helper.NewNumberSequential(Int32.MinValue, UInt32.MaxValue, short.MinValue, ushort.MaxValue, byte.MinValue, 
                        sbyte.MaxValue, Int16.MinValue, UInt16.MaxValue, -1234567890, 1234567890, 32.0F, 3.2);
                    NumberSequential change_ns = Helper.NewNumberSequential(0, 32, 0, 16, 0, 8, 0, 16, 0, 64, 64.0F, 6.4);

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructNumberSequentialByRef_Cdecl...");
                    NumberSequentialByRefDelegateCdecl caller6 = Get_MarshalStructNumberSequentialByRef_Cdecl_FuncPtr();
                    if (!caller6(ref source_ns))
                    {
                        breturn = false;
                        TestFramework.LogError("A011", "DelegatePInvoke_MarshalStructNumberSequentialByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if(!Helper.ValidateNumberSequential(source_ns, change_ns, "DelegatePInvoke_MarshalStructNumberSequentialByRef_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("A012", "DelegatePInvoke_MarshalStructNumberSequentialByRef_Cdecl:The NumberSequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S3Id:
                    int[] iarr = new int[256];
                    int[] icarr = new int[256];
                    Helper.InitialArray(iarr, icarr);

                    S3 sourceS3 = Helper.NewS3(true, "some string", iarr);
                    S3 changeS3 = Helper.NewS3(false, "change string", icarr);

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructS3ByRef_Cdecl...");
                    S3ByRefDelegateCdecl caller7 = Get_MarshalStructS3ByRef_Cdecl_FuncPtr();
                    if (!caller7(ref sourceS3))
                    {
                        breturn = false;
                        TestFramework.LogError("A013", "DelegatePInvoke_MarshalStructS3ByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if(!Helper.ValidateS3(sourceS3, changeS3, "DelegatePInvoke_MarshalStructS3ByRef_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("A014", "DelegatePInvoke_MarshalStructS3ByRef_Cdecl:The S3 value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S5Id:
                    Enum1 enums = Enum1.e1;
                    Enum1 enumch = Enum1.e2;
                    S5 sourceS5 = Helper.NewS5(32, "some string", enums);
                    S5 changeS5 = Helper.NewS5(64, "change string", enumch);

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructS5ByRef_Cdecl...");
                    S5ByRefDelegateCdecl caller8 = Get_MarshalStructS5ByRef_Cdecl_FuncPtr();
                    if (!caller8(ref sourceS5))
                    {
                        breturn = false;
                        TestFramework.LogError("A015", "DelegatePInvoke_MarshalStructS5ByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if(!Helper.ValidateS5(sourceS5, changeS5, "DelegatePInvoke_MarshalStructS5ByRef_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("A016", "DelegatePInvoke_MarshalStructS5ByRef_Cdecl:The S5 value (Managed Side) is wrong");
                    }
                    break;
                case StructID.StringStructSequentialAnsiId:
                    strOne = new String('a', 512);
                    strTwo = new String('b', 512);
                    StringStructSequentialAnsi source_sssa = Helper.NewStringStructSequentialAnsi(strOne, strTwo);
                    StringStructSequentialAnsi change_sssa = Helper.NewStringStructSequentialAnsi(strTwo, strOne);

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructStringStructSequentialAnsiByRef_Cdecl...");
                    StringStructSequentialAnsiByRefDelegateCdecl caller9 = Get_MarshalStructStringStructSequentialAnsiByRef_Cdecl_FuncPtr();
                    if (!caller9(ref source_sssa))
                    {
                        breturn = false;
                        TestFramework.LogError("A017", "DelegatePInvoke_MarshalStructStringStructSequentialAnsiByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if(!Helper.ValidateStringStructSequentialAnsi(source_sssa, change_sssa, "DelegatePInvoke_MarshalStructStringStructSequentialAnsiByRef_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("A018", "DelegatePInvoke_MarshalStructStringStructSequentialAnsiByRef_Cdecl:The StringStructSequentialAnsi value (Managed Side) is wrong");
                    }
                    break;
                case StructID.StringStructSequentialUnicodeId:
                    strOne = new String('a', 256);
                    strTwo = new String('b', 256);
                    StringStructSequentialUnicode source_sssu = Helper.NewStringStructSequentialUnicode(strOne, strTwo);
                    StringStructSequentialUnicode change_sssu = Helper.NewStringStructSequentialUnicode(strTwo, strOne);

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructStringStructSequentialUnicodeByRef_Cdecl...");
                    StringStructSequentialUnicodeByRefDelegateCdecl caller10 = Get_MarshalStructStringStructSequentialUnicodeByRef_Cdecl_FuncPtr();
                    if (!caller10(ref source_sssu))
                    {
                        breturn = false;
                        TestFramework.LogError("A019", "DelegatePInvoke_MarshalStructStringStructSequentialUnicodeByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if(!Helper.ValidateStringStructSequentialUnicode(source_sssu, change_sssu, "DelegatePInvoke_MarshalStructStringStructSequentialUnicodeByRef_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("A020", "DelegatePInvoke_MarshalStructStringStructSequentialUnicodeByRef_Cdecl:The StringStructSequentialUnicode value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S8Id:
                    S8 sourceS8 = Helper.NewS8("hello", true, 10, 128, 128, 32);
                    S8 changeS8 = Helper.NewS8("world", false, 1, 256, 256, 64);
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructS8ByRef_Cdecl...");
                    S8ByRefDelegateCdecl caller11 = Get_MarshalStructS8ByRef_Cdecl_FuncPtr();
                    if (!caller11(ref sourceS8))
                    {
                        breturn = false;
                        TestFramework.LogError("A021", "DelegatePInvoke_MarshalStructS8ByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if(!Helper.ValidateS8(sourceS8, changeS8, "DelegatePInvoke_MarshalStructS8ByRef_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("A022", "DelegatePInvoke_MarshalStructS8ByRef_Cdecl:The S8 value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S9Id:
                    S9 sourceS9 = Helper.NewS9(128, new TestDelegate1(testMethod));
                    S9 changeS9 = Helper.NewS9(256, null);
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructS9ByRef_Cdecl...");
                    S9ByRefDelegateCdecl caller12 = Get_MarshalStructS9ByRef_Cdecl_FuncPtr();
                    if (!caller12(ref sourceS9))
                    {
                        breturn = false;
                        TestFramework.LogError("A023", "DelegatePInvoke_MarshalStructS9ByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if(!Helper.ValidateS9(sourceS9, changeS9, "DelegatePInvoke_MarshalStructS9ByRef_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("A024", "DelegatePInvoke_MarshalStructS9ByRef_Cdecl:The S9 value (Managed Side) is wrong");
                    }
                    break;
                case StructID.IncludeOuterIntergerStructSequentialId:
                    IncludeOuterIntergerStructSequential sourceIncludeOuterIntergerStructSequential = Helper.NewIncludeOuterIntergerStructSequential(32, 32);
                    IncludeOuterIntergerStructSequential changeIncludeOuterIntergerStructSequential = Helper.NewIncludeOuterIntergerStructSequential(64, 64);
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructIncludeOuterIntergerStructSequentialByRef_Cdecl...");
                    IncludeOuterIntergerStructSequentialByRefDelegateCdecl caller13 = Get_MarshalStructIncludeOuterIntergerStructSequentialByRef_Cdecl_FuncPtr();
                    if (!caller13(ref sourceIncludeOuterIntergerStructSequential))
                    {
                        breturn = false;
                        TestFramework.LogError("A025", "DelegatePInvoke_MarshalStructIncludeOuterIntergerStructSequentialByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if(!Helper.ValidateIncludeOuterIntergerStructSequential(sourceIncludeOuterIntergerStructSequential, 
                        changeIncludeOuterIntergerStructSequential, "DelegatePInvoke_MarshalStructIncludeOuterIntergerStructSequentialByRef_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("A026", "DelegatePInvoke_MarshalStructIncludeOuterIntergerStructSequentialByRef_Cdecl:The IncludeOuterIntergerStructSequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S11Id:
                    S11 sourceS11 = Helper.NewS11((int*)(32), 32);
                    S11 changeS11 = Helper.NewS11((int*)(64), 64);
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructS11ByRef_Cdecl...");
                    S11ByRefDelegateCdecl caller14 = Get_MarshalStructS11ByRef_Cdecl_FuncPtr();
                    if (!caller14(ref sourceS11))
                    {
                        breturn = false;
                        TestFramework.LogError("A027", "DelegatePInvoke_MarshalStructS11ByRef_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if(!Helper.ValidateS11(sourceS11, changeS11, "DelegatePInvoke_MarshalStructS11ByRef_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("A028", "DelegatePInvoke_MarshalStructS11ByRef_Cdecl:The S11 value (Managed Side) is wrong");
                    }
                    break;
                default:
                    breturn = false;
                    TestFramework.LogError("D001", "TestMethod_DelegatePInvoke_MarshalByRef_Cdecl:The structid (Managed Side) is wrong");
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

    unsafe private static bool TestMethod_DelegatePInvoke_MarshalByRef_StdCall(StructID structid)
    {
        bool breturn = true;
        TestFramework.BeginScenario("Delegate PInvoke,By Ref,StdCall");
        try
        {
            switch (structid)
            {
                case StructID.ComplexStructId:
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructComplexStructByRef_StdCall...");
                    ComplexStruct cs = new ComplexStruct();
                    cs.i = 321;
                    cs.b = true;
                    cs.str = "Managed";
                    cs.type.idata = 123;
                    cs.type.ptrdata = (IntPtr)0x120000;

                    ComplexStructByRefDelegateStdCall caller1 = Get_MarshalStructComplexStructByRef_StdCall_FuncPtr();
                    if (!caller1(ref cs))
                    {
                        breturn = false;
                        TestFramework.LogError("B001", "DelegatePInvoke_MarshalStructComplexStructByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if((9999 != cs.i) || cs.b || !cs.str.Equals("Native") || (-1 != cs.type.idata) || (3.14159 != cs.type.ddata))
                    {
                        breturn = false;
                        TestFramework.LogError("B002", "DelegatePInvoke_MarshalStructComplexStructByRef_StdCall:The ComplexStruct value (Managed Side) is wrong");
                    }
                    break;
                case StructID.InnerSequentialId:
                    InnerSequential source_is = Helper.NewInnerSequential(1, 1.0F, "some string");
                    InnerSequential change_is = Helper.NewInnerSequential(77, 77.0F, "changed string");

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructInnerSequentialByRef_StdCall...");
                    InnerSequentialByRefDelegateStdCall caller2 = Get_MarshalStructInnerSequentialByRef_StdCall_FuncPtr();
                    if (!caller2(ref source_is))
                    {
                        breturn = false;
                        TestFramework.LogError("B003", "DelegatePInvoke_MarshalStructInnerSequentialByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if(!Helper.ValidateInnerSequential(source_is, change_is, "DelegatePInvoke_MarshalStructInnerSequentialByRef_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("B004", "DelegatePInvoke_MarshalStructInnerSequentialByRef_StdCall:The InnerSequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.InnerArraySequentialId:
                    InnerArraySequential source_ias = Helper.NewInnerArraySequential(1, 1.0F, "some string");
                    InnerArraySequential change_ias = Helper.NewInnerArraySequential(77, 77.0F, "changed string");

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructInnerArraySequentialByRef_StdCall...");
                    InnerArraySequentialByRefDelegateStdCall caller3 = Get_MarshalStructInnerArraySequentialByRef_StdCall_FuncPtr();
                    if (!caller3(ref source_ias))
                    {
                        breturn = false;
                        TestFramework.LogError("B005", "DelegatePInvoke_MarshalStructInnerArraySequentialByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if(!Helper.ValidateInnerArraySequential(source_ias, change_ias, "DelegatePInvoke_MarshalStructInnerArraySequentialByRef_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("B006", "DelegatePInvoke_MarshalStructInnerArraySequentialByRef_StdCall:The InnerArraySequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.CharSetAnsiSequentialId:
                    CharSetAnsiSequential source_csas = Helper.NewCharSetAnsiSequential("some string", 'c');
                    CharSetAnsiSequential change_csas = Helper.NewCharSetAnsiSequential("change string", 'n');

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructCharSetAnsiSequentialByRef_StdCall...");
                    CharSetAnsiSequentialByRefDelegateStdCall caller4 = Get_MarshalStructCharSetAnsiSequentialByRef_StdCall_FuncPtr();
                    if (!caller4(ref source_csas))
                    {
                        breturn = false;
                        TestFramework.LogError("B007", "DelegatePInvoke_MarshalStructCharSetAnsiSequentialByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if(!Helper.ValidateCharSetAnsiSequential(source_csas, change_csas, "DelegatePInvoke_MarshalStructCharSetAnsiSequentialByRef_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("B008", "DelegatePInvoke_MarshalStructCharSetAnsiSequentialByRef_StdCall:The CharSetAnsiSequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.CharSetUnicodeSequentialId:
                    CharSetUnicodeSequential source_csus = Helper.NewCharSetUnicodeSequential("some string", 'c');
                    CharSetUnicodeSequential change_csus = Helper.NewCharSetUnicodeSequential("change string", 'n');

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructCharSetUnicodeSequentialByRef_StdCall...");
                    CharSetUnicodeSequentialByRefDelegateStdCall caller5 = Get_MarshalStructCharSetUnicodeSequentialByRef_StdCall_FuncPtr();
                    if (!caller5(ref source_csus))
                    {
                        breturn = false;
                        TestFramework.LogError("B009", "DelegatePInvoke_MarshalStructCharSetUnicodeSequentialByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if(!Helper.ValidateCharSetUnicodeSequential(source_csus, change_csus, "DelegatePInvoke_MarshalStructCharSetUnicodeSequentialByRef_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("B010", "DelegatePInvoke_MarshalStructCharSetUnicodeSequentialByRef_StdCall:The CharSetUnicodeSequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.NumberSequentialId:
                    NumberSequential source_ns = Helper.NewNumberSequential(Int32.MinValue, UInt32.MaxValue, short.MinValue, ushort.MaxValue, byte.MinValue, 
                        sbyte.MaxValue, Int16.MinValue, UInt16.MaxValue, -1234567890, 1234567890, 32.0F, 3.2);
                    NumberSequential change_ns = Helper.NewNumberSequential(0, 32, 0, 16, 0, 8, 0, 16, 0, 64, 64.0F, 6.4);

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructNumberSequentialByRef_StdCall...");
                    NumberSequentialByRefDelegateStdCall caller6 = Get_MarshalStructNumberSequentialByRef_StdCall_FuncPtr();
                    if (!caller6(ref source_ns))
                    {
                        breturn = false;
                        TestFramework.LogError("B011", "DelegatePInvoke_MarshalStructNumberSequentialByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateNumberSequential(source_ns, change_ns, "DelegatePInvoke_MarshalStructNumberSequentialByRef_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("B012", "DelegatePInvoke_MarshalStructNumberSequentialByRef_StdCall:The NumberSequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S3Id:
                    int[] iarr = new int[256];
                    int[] icarr = new int[256];
                    Helper.InitialArray(iarr, icarr);

                    S3 sourceS3 = Helper.NewS3(true, "some string", iarr);
                    S3 changeS3 = Helper.NewS3(false, "change string", icarr);

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructS3ByRef_StdCall...");
                    S3ByRefDelegateStdCall caller7 = Get_MarshalStructS3ByRef_StdCall_FuncPtr();
                    if (!caller7(ref sourceS3))
                    {
                        breturn = false;
                        TestFramework.LogError("B013", "DelegatePInvoke_MarshalStructS3ByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateS3(sourceS3, changeS3, "DelegatePInvoke_MarshalStructS3ByRef_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("B014", "DelegatePInvoke_MarshalStructS3ByRef_StdCall:The S3 value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S5Id:
                    Enum1 enums = Enum1.e1;
                    Enum1 enumch = Enum1.e2;
                    S5 sourceS5 = Helper.NewS5(32, "some string", enums);
                    S5 changeS5 = Helper.NewS5(64, "change string", enumch);

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructS5ByRef_StdCall...");
                    S5ByRefDelegateStdCall caller8 = Get_MarshalStructS5ByRef_StdCall_FuncPtr();
                    if (!caller8(ref sourceS5))
                    {
                        breturn = false;
                        TestFramework.LogError("B015", "DelegatePInvoke_MarshalStructS5ByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateS5(sourceS5, changeS5, "DelegatePInvoke_MarshalStructS5ByRef_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("B016", "DelegatePInvoke_MarshalStructS5ByRef_StdCall:The S5 value (Managed Side) is wrong");
                    }
                    break;
                case StructID.StringStructSequentialAnsiId:
                    strOne = new String('a', 512);
                    strTwo = new String('b', 512);
                    StringStructSequentialAnsi source_sssa = Helper.NewStringStructSequentialAnsi(strOne, strTwo);
                    StringStructSequentialAnsi change_sssa = Helper.NewStringStructSequentialAnsi(strTwo, strOne);

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructStringStructSequentialAnsiByRef_StdCall...");
                    StringStructSequentialAnsiByRefDelegateStdCall caller9 = Get_MarshalStructStringStructSequentialAnsiByRef_StdCall_FuncPtr();
                    if (!caller9(ref source_sssa))
                    {
                        breturn = false;
                        TestFramework.LogError("B017", "DelegatePInvoke_MarshalStructStringStructSequentialAnsiByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateStringStructSequentialAnsi(source_sssa, change_sssa, "DelegatePInvoke_MarshalStructStringStructSequentialAnsiByRef_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("B018", "DelegatePInvoke_MarshalStructStringStructSequentialAnsiByRef_StdCall:The StringStructSequentialAnsi value (Managed Side) is wrong");
                    }
                    break;
                case StructID.StringStructSequentialUnicodeId:
                    strOne = new String('a', 256);
                    strTwo = new String('b', 256);
                    StringStructSequentialUnicode source_sssu = Helper.NewStringStructSequentialUnicode(strOne, strTwo);
                    StringStructSequentialUnicode change_sssu = Helper.NewStringStructSequentialUnicode(strTwo, strOne);

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructStringStructSequentialUnicodeByRef_StdCall...");
                    StringStructSequentialUnicodeByRefDelegateStdCall caller10 = Get_MarshalStructStringStructSequentialUnicodeByRef_StdCall_FuncPtr();
                    if (!caller10(ref source_sssu))
                    {
                        breturn = false;
                        TestFramework.LogError("B019", "DelegatePInvoke_MarshalStructStringStructSequentialUnicodeByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateStringStructSequentialUnicode(source_sssu, change_sssu, "DelegatePInvoke_MarshalStructStringStructSequentialUnicodeByRef_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("B020", "DelegatePInvoke_MarshalStructStringStructSequentialUnicodeByRef_StdCall:The StringStructSequentialUnicode value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S8Id:
                    S8 sourceS8 = Helper.NewS8("hello", true, 10, 128, 128, 32);
                    S8 changeS8 = Helper.NewS8("world", false, 1, 256, 256, 64);
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructS8ByRef_StdCall...");
                    S8ByRefDelegateStdCall caller11 = Get_MarshalStructS8ByRef_StdCall_FuncPtr();
                    if (!caller11(ref sourceS8))
                    {
                        breturn = false;
                        TestFramework.LogError("B021", "DelegatePInvoke_MarshalStructS8ByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateS8(sourceS8, changeS8, "DelegatePInvoke_MarshalStructS8ByRef_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("B022", "DelegatePInvoke_MarshalStructS8ByRef_StdCall:The S8 value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S9Id:
                    S9 sourceS9 = Helper.NewS9(128, new TestDelegate1(testMethod));
                    S9 changeS9 = Helper.NewS9(256, null);
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructS9ByRef_StdCall...");
                    S9ByRefDelegateStdCall caller12 = Get_MarshalStructS9ByRef_StdCall_FuncPtr();
                    if (!caller12(ref sourceS9))
                    {
                        breturn = false;
                        TestFramework.LogError("B023", "DelegatePInvoke_MarshalStructS9ByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateS9(sourceS9, changeS9, "DelegatePInvoke_MarshalStructS9ByRef_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("B024", "DelegatePInvoke_MarshalStructS9ByRef_StdCall:The S9 value (Managed Side) is wrong");
                    }
                    break;
                case StructID.IncludeOuterIntergerStructSequentialId:
                    IncludeOuterIntergerStructSequential sourceIncludeOuterIntergerStructSequential = Helper.NewIncludeOuterIntergerStructSequential(32, 32);
                    IncludeOuterIntergerStructSequential changeIncludeOuterIntergerStructSequential = Helper.NewIncludeOuterIntergerStructSequential(64, 64);
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructIncludeOuterIntergerStructSequentialByRef_StdCall...");
                    IncludeOuterIntergerStructSequentialByRefDelegateStdCall caller13 = Get_MarshalStructIncludeOuterIntergerStructSequentialByRef_StdCall_FuncPtr();
                    if (!caller13(ref sourceIncludeOuterIntergerStructSequential))
                    {
                        breturn = false;
                        TestFramework.LogError("B025", "DelegatePInvoke_MarshalStructIncludeOuterIntergerStructSequentialByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateIncludeOuterIntergerStructSequential(sourceIncludeOuterIntergerStructSequential, 
                        changeIncludeOuterIntergerStructSequential, "DelegatePInvoke_MarshalStructIncludeOuterIntergerStructSequentialByRef_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("B026", "DelegatePInvoke_MarshalStructIncludeOuterIntergerStructSequentialByRef_StdCall:The IncludeOuterIntergerStructSequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S11Id:
                    S11 sourceS11 = Helper.NewS11((int*)(32), 32);
                    S11 changeS11 = Helper.NewS11((int*)(64), 64);
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructS11ByRef_StdCall...");
                    S11ByRefDelegateStdCall caller14 = Get_MarshalStructS11ByRef_StdCall_FuncPtr();
                    if (!caller14(ref sourceS11))
                    {
                        breturn = false;
                        TestFramework.LogError("B027", "DelegatePInvoke_MarshalStructS11ByRef_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateS11(sourceS11, changeS11, "DelegatePInvoke_MarshalStructS11ByRef_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("B028", "DelegatePInvoke_MarshalStructS11ByRef_StdCall:The S11 value (Managed Side) is wrong");
                    }
                    break;
                default:
                    breturn = false;
                    TestFramework.LogError("F002", "TestMethod_DelegatePInvoke_MarshalByRef_StdCall:The structid (Managed Side) is wrong");
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

    unsafe private static bool TestMethod_DelegatePInvoke_MarshalByVal_Cdecl(StructID structid)
    {
        bool breturn = true;
        TestFramework.BeginScenario("Delegate PInvoke,By Value,Cdecl");
        try
        {
            switch (structid)
            {
                case StructID.ComplexStructId:
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructComplexStructByVal_Cdecl...");
                    ComplexStruct cs = new ComplexStruct();
                    cs.i = 321;
                    cs.b = true;
                    cs.str = "Managed";
                    cs.type.idata = 123;
                    cs.type.ptrdata = (IntPtr)0x120000;

                    ComplexStructByValDelegateCdecl caller1 = Get_MarshalStructComplexStructByVal_Cdecl_FuncPtr();
                    if (!caller1(cs))
                    {
                        breturn = false;
                        TestFramework.LogError("C001", "TestMethod_DelegatePInvoke_MarshalByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if ((321 != cs.i) || !cs.b || !cs.str.Equals("Managed") || (123 != cs.type.idata) || (0x120000 != (int)cs.type.ptrdata))
                    {
                        breturn = false;
                        TestFramework.LogError("C002", "TestMethod_PInvokeByVal_Cdecl(Managed Side):The ComplexStruct value (Managed Side) is wrong");
                    }
                    break;
                case StructID.InnerSequentialId:
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructInnerSequentialByVal_Cdecl...");
                    InnerSequential source_is = Helper.NewInnerSequential(1, 1.0F, "some string");
                    InnerSequential clone_is1 = Helper.NewInnerSequential(1, 1.0F, "some string");

                    InnerSequentialByValDelegateCdecl caller2 = Get_MarshalStructInnerSequentialByVal_Cdecl_FuncPtr();
                    if (!caller2(source_is))
                    {
                        breturn = false;
                        TestFramework.LogError("C003", "DelegatePInvoke_MarshalStructInnerSequentialByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateInnerSequential(source_is, clone_is1, "DelegatePInvoke_MarshalStructInnerSequentialByVal_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("C004", "DelegatePInvoke_MarshalStructInnerSequentialByVal_Cdecl:The InnerSequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.InnerArraySequentialId:
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructInnerArraySequentialByVal_Cdecl...");
                    InnerArraySequential source_ias = Helper.NewInnerArraySequential(1, 1.0F, "some string");
                    InnerArraySequential clone_ias = Helper.NewInnerArraySequential(1, 1.0F, "some string");

                    InnerArraySequentialByValDelegateCdecl caller3 = Get_MarshalStructInnerArraySequentialByVal_Cdecl_FuncPtr();
                    if (!caller3(source_ias))
                    {
                        breturn = false;
                        TestFramework.LogError("C005", "DelegatePInvoke_MarshalStructInnerArraySequentialByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateInnerArraySequential(source_ias, clone_ias, "DelegatePInvoke_MarshalStructInnerArraySequentialByVal_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("C006", "DelegatePInvoke_MarshalStructInnerArraySequentialByVal_Cdecl:The InnerArraySequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.CharSetAnsiSequentialId:
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructCharSetAnsiSequentialByVal_Cdecl...");
                    CharSetAnsiSequential source_csas = Helper.NewCharSetAnsiSequential("some string", 'c');
                    CharSetAnsiSequential clone_csas = Helper.NewCharSetAnsiSequential("some string", 'c');

                    CharSetAnsiSequentialByValDelegateCdecl caller4 = Get_MarshalStructCharSetAnsiSequentialByVal_Cdecl_FuncPtr();
                    if (!caller4(source_csas))
                    {
                        breturn = false;
                        TestFramework.LogError("C007", "DelegatePInvoke_MarshalStructCharSetAnsiSequentialByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateCharSetAnsiSequential(source_csas, clone_csas, "DelegatePInvoke_MarshalStructCharSetAnsiSequentialByVal_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("C008", "DelegatePInvoke_MarshalStructCharSetAnsiSequentialByVal_Cdecl:The CharSetAnsiSequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.CharSetUnicodeSequentialId:
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructCharSetUnicodeSequentialByVal_Cdecl...");
                    CharSetUnicodeSequential source_csus = Helper.NewCharSetUnicodeSequential("some string", 'c');
                    CharSetUnicodeSequential clone_csus = Helper.NewCharSetUnicodeSequential("some string", 'c');

                    CharSetUnicodeSequentialByValDelegateCdecl caller5 = Get_MarshalStructCharSetUnicodeSequentialByVal_Cdecl_FuncPtr();
                    if (!caller5(source_csus))
                    {
                        breturn = false;
                        TestFramework.LogError("C009", "DelegatePInvoke_MarshalStructCharSetUnicodeSequentialByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateCharSetUnicodeSequential(source_csus, clone_csus, "DelegatePInvoke_MarshalStructCharSetUnicodeSequentialByVal_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("C010", "DelegatePInvoke_MarshalStructCharSetUnicodeSequentialByVal_Cdecl:The CharSetUnicodeSequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.NumberSequentialId:
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructNumberSequentialByVal_Cdecl...");
                    NumberSequential source_ns = Helper.NewNumberSequential(Int32.MinValue, UInt32.MaxValue, short.MinValue, ushort.MaxValue, byte.MinValue, 
                        sbyte.MaxValue, Int16.MinValue, UInt16.MaxValue, -1234567890, 1234567890, 32.0F, 3.2);
                    NumberSequential clone_ns = Helper.NewNumberSequential(Int32.MinValue, UInt32.MaxValue, short.MinValue, ushort.MaxValue, byte.MinValue, 
                        sbyte.MaxValue, Int16.MinValue, UInt16.MaxValue, -1234567890, 1234567890, 32.0F, 3.2);

                    NumberSequentialByValDelegateCdecl caller6 = Get_MarshalStructNumberSequentialByVal_Cdecl_FuncPtr();
                    if (!caller6(source_ns))
                    {
                        breturn = false;
                        TestFramework.LogError("C011", "DelegatePInvoke_MarshalStructNumberSequentialByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateNumberSequential(source_ns, clone_ns, "DelegatePInvoke_MarshalStructNumberSequentialByVal_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("C012", "DelegatePInvoke_MarshalStructNumberSequentialByVal_Cdecl:The NumberSequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S3Id:
                    int[] iarr = new int[256];
                    int[] icarr = new int[256];
                    Helper.InitialArray(iarr, icarr);

                    S3 sourceS3 = Helper.NewS3(true, "some string", iarr);
                    S3 cloneS3 = Helper.NewS3(true, "some string", iarr);

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructS3ByVal_Cdecl...");
                    S3ByValDelegateCdecl caller7 = Get_MarshalStructS3ByVal_Cdecl_FuncPtr();
                    if (!caller7(sourceS3))
                    {
                        breturn = false;
                        TestFramework.LogError("C013", "DelegatePInvoke_MarshalStructS3ByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateS3(sourceS3, cloneS3, "DelegatePInvoke_MarshalStructS3ByVal_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("C014", "DelegatePInvoke_MarshalStructS3ByVal_Cdecl:The S3 value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S5Id:
                    Enum1 enums = Enum1.e1;
                    S5 sourceS5 = Helper.NewS5(32, "some string", enums);
                    S5 cloneS5 = Helper.NewS5(32, "some string", enums);

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructS5ByVal_Cdecl...");
                    S5ByValDelegateCdecl caller8 = Get_MarshalStructS5ByVal_Cdecl_FuncPtr();
                    if (!caller8(sourceS5))
                    {
                        breturn = false;
                        TestFramework.LogError("C015", "DelegatePInvoke_MarshalStructS5ByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateS5(sourceS5, cloneS5, "DelegatePInvoke_MarshalStructS5ByVal_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("C016", "DelegatePInvoke_MarshalStructS5ByVal_Cdecl:The S5 value (Managed Side) is wrong");
                    }
                    break;
                case StructID.StringStructSequentialAnsiId:
                    strOne = new String('a', 512);
                    strTwo = new String('b', 512);
                    StringStructSequentialAnsi source_sssa = Helper.NewStringStructSequentialAnsi(strOne, strTwo);
                    StringStructSequentialAnsi clone_sssa = Helper.NewStringStructSequentialAnsi(strOne, strTwo);

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructStringStructSequentialAnsiByVal_Cdecl...");
                    StringStructSequentialAnsiByValDelegateCdecl caller9 = Get_MarshalStructStringStructSequentialAnsiByVal_Cdecl_FuncPtr();
                    if (!caller9(source_sssa))
                    {
                        breturn = false;
                        TestFramework.LogError("C017", "DelegatePInvoke_MarshalStructStringStructSequentialAnsiByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateStringStructSequentialAnsi(source_sssa, clone_sssa, "DelegatePInvoke_MarshalStructStringStructSequentialAnsiByVal_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("C018", "DelegatePInvoke_MarshalStructStringStructSequentialAnsiByVal_Cdecl:The StringStructSequentialAnsi value (Managed Side) is wrong");
                    }
                    break;
                case StructID.StringStructSequentialUnicodeId:
                    strOne = new String('a', 256);
                    strTwo = new String('b', 256);
                    StringStructSequentialUnicode source_sssu = Helper.NewStringStructSequentialUnicode(strOne, strTwo);
                    StringStructSequentialUnicode clone_sssu = Helper.NewStringStructSequentialUnicode(strOne, strTwo);

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructStringStructSequentialUnicodeByVal_Cdecl...");
                    StringStructSequentialUnicodeByValDelegateCdecl caller10 = Get_MarshalStructStringStructSequentialUnicodeByVal_Cdecl_FuncPtr();
                    if (!caller10(source_sssu))
                    {
                        breturn = false;
                        TestFramework.LogError("C019", "DelegatePInvoke_MarshalStructStringStructSequentialUnicodeByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateStringStructSequentialUnicode(source_sssu, clone_sssu, "DelegatePInvoke_MarshalStructStringStructSequentialUnicodeByVal_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("C020", "DelegatePInvoke_MarshalStructStringStructSequentialUnicodeByVal_Cdecl:The StringStructSequentialUnicode value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S8Id:
                    S8 sourceS8 = Helper.NewS8("hello", true, 10, 128, 128, 32);
                    S8 cloneS8 = Helper.NewS8("hello", true, 10, 128, 128, 32);
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructS8ByVal_Cdecl...");
                    S8ByValDelegateCdecl caller11 = Get_MarshalStructS8ByVal_Cdecl_FuncPtr();
                    if (!caller11(sourceS8))
                    {
                        breturn = false;
                        TestFramework.LogError("C021", "DelegatePInvoke_MarshalStructS8ByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateS8(sourceS8, cloneS8, "DelegatePInvoke_MarshalStructS8ByVal_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("C022", "DelegatePInvoke_MarshalStructS8ByVal_Cdecl:The S8 value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S9Id:
                    S9 sourceS9 = Helper.NewS9(128, new TestDelegate1(testMethod));
                    S9 cloneS9 = Helper.NewS9(128, new TestDelegate1(testMethod));
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructS9ByVal_Cdecl...");
                    S9ByValDelegateCdecl caller12 = Get_MarshalStructS9ByVal_Cdecl_FuncPtr();
                    if (!caller12(sourceS9))
                    {
                        breturn = false;
                        TestFramework.LogError("C023", "DelegatePInvoke_MarshalStructS9ByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateS9(sourceS9, cloneS9, "DelegatePInvoke_MarshalStructS9ByVal_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("C024", "DelegatePInvoke_MarshalStructS9ByVal_Cdecl:The S9 value (Managed Side) is wrong");
                    }
                    break;
                case StructID.IncludeOuterIntergerStructSequentialId:
                    IncludeOuterIntergerStructSequential sourceIncludeOuterIntergerStructSequential = Helper.NewIncludeOuterIntergerStructSequential(32, 32);
                    IncludeOuterIntergerStructSequential cloneIncludeOuterIntergerStructSequential = Helper.NewIncludeOuterIntergerStructSequential(32, 32);
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructIncludeOuterIntergerStructSequentialByVal_Cdecl...");
                    IncludeOuterIntergerStructSequentialByValDelegateCdecl caller13 = Get_MarshalStructIncludeOuterIntergerStructSequentialByVal_Cdecl_FuncPtr();
                    if (!caller13(sourceIncludeOuterIntergerStructSequential))
                    {
                        breturn = false;
                        TestFramework.LogError("C025", "DelegatePInvoke_MarshalStructIncludeOuterIntergerStructSequentialByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateIncludeOuterIntergerStructSequential(sourceIncludeOuterIntergerStructSequential, 
                        cloneIncludeOuterIntergerStructSequential, "DelegatePInvoke_MarshalStructIncludeOuterIntergerStructSequentialByVal_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("C026", "DelegatePInvoke_MarshalStructIncludeOuterIntergerStructSequentialByVal_Cdecl:The IncludeOuterIntergerStructSequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S11Id:
                    S11 sourceS11 = Helper.NewS11((int*)(32), 32);
                    S11 cloneS11 = Helper.NewS11((int*)(32), 32);
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructS11ByVal_Cdecl...");
                    S11ByValDelegateCdecl caller14 = Get_MarshalStructS11ByVal_Cdecl_FuncPtr();
                    if (!caller14(sourceS11))
                    {
                        breturn = false;
                        TestFramework.LogError("C027", "DelegatePInvoke_MarshalStructS11ByVal_Cdecl:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateS11(sourceS11, cloneS11, "DelegatePInvoke_MarshalStructS11ByVal_Cdecl"))
                    {
                        breturn = false;
                        TestFramework.LogError("C028", "DelegatePInvoke_MarshalStructS11ByVal_Cdecl:The S11 value (Managed Side) is wrong");
                    }
                    break;
                default:
                    breturn = false;
                    TestFramework.LogError("F003", "TestMethod_DelegatePInvoke_MarshalByVal_Cdecl:The structid (Managed Side) is wrong");
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

    unsafe private static bool TestMethod_DelegatePInvoke_MarshalByVal_StdCall(StructID structid)
    {
        bool breturn = true;
        TestFramework.BeginScenario("Delegate PInvoke,By Value,StdCall");
        try
        {
            switch (structid)
            {
                case StructID.ComplexStructId:
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructComplexStructByVal_StdCall...");
                    ComplexStruct cs = new ComplexStruct();
                    cs.i = 321;
                    cs.b = true;
                    cs.str = "Managed";
                    cs.type.idata = 123;
                    cs.type.ptrdata = (IntPtr)0x120000;

                    ComplexStructByValDelegateStdCall caller1 = Get_MarshalStructComplexStructByVal_StdCall_FuncPtr();
                    if (!caller1(cs))
                    {
                        breturn = false;
                        TestFramework.LogError("D001", "TestMethod_DelegatePInvoke_MarshalByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if ((321 != cs.i) || !cs.b || !cs.str.Equals("Managed") || (123 != cs.type.idata) || (0x120000 != (int)cs.type.ptrdata))
                    {
                        breturn = false;
                        TestFramework.LogError("D002", "TestMethod_PInvokeByVal_StdCall(Managed Side):The ComplexStruct value (Managed Side) is wrong");
                    }
                    break;
                case StructID.InnerSequentialId:
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructInnerSequentialByVal_StdCall...");
                    InnerSequential source_is = Helper.NewInnerSequential(1, 1.0F, "some string");
                    InnerSequential clone_is1 = Helper.NewInnerSequential(1, 1.0F, "some string");

                    InnerSequentialByValDelegateStdCall caller2 = Get_MarshalStructInnerSequentialByVal_StdCall_FuncPtr();
                    if (!caller2(source_is))
                    {
                        breturn = false;
                        TestFramework.LogError("D003", "DelegatePInvoke_MarshalStructInnerSequentialByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateInnerSequential(source_is, clone_is1, "DelegatePInvoke_MarshalStructInnerSequentialByVal_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("D004", "DelegatePInvoke_MarshalStructInnerSequentialByVal_StdCall:The InnerSequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.InnerArraySequentialId:
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructInnerArraySequentialByVal_StdCall...");
                    InnerArraySequential source_ias = Helper.NewInnerArraySequential(1, 1.0F, "some string");
                    InnerArraySequential clone_ias = Helper.NewInnerArraySequential(1, 1.0F, "some string");

                    InnerArraySequentialByValDelegateStdCall caller3 = Get_MarshalStructInnerArraySequentialByVal_StdCall_FuncPtr();
                    if (!caller3(source_ias))
                    {
                        breturn = false;
                        TestFramework.LogError("D005", "DelegatePInvoke_MarshalStructInnerArraySequentialByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateInnerArraySequential(source_ias, clone_ias, "DelegatePInvoke_MarshalStructInnerArraySequentialByVal_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("D006", "DelegatePInvoke_MarshalStructInnerArraySequentialByVal_StdCall:The InnerArraySequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.CharSetAnsiSequentialId:
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructCharSetAnsiSequentialByVal_StdCall...");
                    CharSetAnsiSequential source_csas = Helper.NewCharSetAnsiSequential("some string", 'c');
                    CharSetAnsiSequential clone_csas = Helper.NewCharSetAnsiSequential("some string", 'c');

                    CharSetAnsiSequentialByValDelegateStdCall caller4 = Get_MarshalStructCharSetAnsiSequentialByVal_StdCall_FuncPtr();
                    if (!caller4(source_csas))
                    {
                        breturn = false;
                        TestFramework.LogError("D007", "DelegatePInvoke_MarshalStructCharSetAnsiSequentialByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateCharSetAnsiSequential(source_csas, clone_csas, "DelegatePInvoke_MarshalStructCharSetAnsiSequentialByVal_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("D008", "DelegatePInvoke_MarshalStructCharSetAnsiSequentialByVal_StdCall:The CharSetAnsiSequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.CharSetUnicodeSequentialId:
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructCharSetUnicodeSequentialByVal_StdCall...");
                    CharSetUnicodeSequential source_csus = Helper.NewCharSetUnicodeSequential("some string", 'c');
                    CharSetUnicodeSequential clone_csus = Helper.NewCharSetUnicodeSequential("some string", 'c');

                    CharSetUnicodeSequentialByValDelegateStdCall caller5 = Get_MarshalStructCharSetUnicodeSequentialByVal_StdCall_FuncPtr();
                    if (!caller5(source_csus))
                    {
                        breturn = false;
                        TestFramework.LogError("D009", "DelegatePInvoke_MarshalStructCharSetUnicodeSequentialByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateCharSetUnicodeSequential(source_csus, clone_csus, "DelegatePInvoke_MarshalStructCharSetUnicodeSequentialByVal_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("D010", "DelegatePInvoke_MarshalStructCharSetUnicodeSequentialByVal_StdCall:The CharSetUnicodeSequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.NumberSequentialId:
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructNumberSequentialByVal_StdCall...");
                    NumberSequential source_ns = Helper.NewNumberSequential(Int32.MinValue, UInt32.MaxValue, short.MinValue, ushort.MaxValue, byte.MinValue, 
                        sbyte.MaxValue, Int16.MinValue, UInt16.MaxValue, -1234567890, 1234567890, 32.0F, 3.2);
                    NumberSequential clone_ns = Helper.NewNumberSequential(Int32.MinValue, UInt32.MaxValue, short.MinValue, ushort.MaxValue, byte.MinValue, 
                        sbyte.MaxValue, Int16.MinValue, UInt16.MaxValue, -1234567890, 1234567890, 32.0F, 3.2);

                    NumberSequentialByValDelegateStdCall caller6 = Get_MarshalStructNumberSequentialByVal_StdCall_FuncPtr();
                    if (!caller6(source_ns))
                    {
                        breturn = false;
                        TestFramework.LogError("D011", "DelegatePInvoke_MarshalStructNumberSequentialByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateNumberSequential(source_ns, clone_ns, "DelegatePInvoke_MarshalStructNumberSequentialByVal_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("D012", "DelegatePInvoke_MarshalStructNumberSequentialByVal_StdCall:The NumberSequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S3Id:
                    int[] iarr = new int[256];
                    int[] icarr = new int[256];
                    Helper.InitialArray(iarr, icarr);

                    S3 sourceS3 = Helper.NewS3(true, "some string", iarr);
                    S3 cloneS3 = Helper.NewS3(true, "some string", iarr);

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructS3ByVal_StdCall...");
                    S3ByValDelegateStdCall caller7 = Get_MarshalStructS3ByVal_StdCall_FuncPtr();
                    if (!caller7(sourceS3))
                    {
                        breturn = false;
                        TestFramework.LogError("D013", "DelegatePInvoke_MarshalStructS3ByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateS3(sourceS3, cloneS3, "DelegatePInvoke_MarshalStructS3ByVal_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("D014", "DelegatePInvoke_MarshalStructS3ByVal_StdCall:The S3 value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S5Id:
                    Enum1 enums = Enum1.e1;
                    S5 sourceS5 = Helper.NewS5(32, "some string", enums);
                    S5 cloneS5 = Helper.NewS5(32, "some string", enums);

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructS5ByVal_StdCall...");
                    S5ByValDelegateStdCall caller8 = Get_MarshalStructS5ByVal_StdCall_FuncPtr();
                    if (!caller8(sourceS5))
                    {
                        breturn = false;
                        TestFramework.LogError("D015", "DelegatePInvoke_MarshalStructS5ByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateS5(sourceS5, cloneS5, "DelegatePInvoke_MarshalStructS5ByVal_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("D016", "DelegatePInvoke_MarshalStructS5ByVal_StdCall:The S5 value (Managed Side) is wrong");
                    }
                    break;
                case StructID.StringStructSequentialAnsiId:
                    strOne = new String('a', 512);
                    strTwo = new String('b', 512);
                    StringStructSequentialAnsi source_sssa = Helper.NewStringStructSequentialAnsi(strOne, strTwo);
                    StringStructSequentialAnsi clone_sssa = Helper.NewStringStructSequentialAnsi(strOne, strTwo);

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructStringStructSequentialAnsiByVal_StdCall...");
                    StringStructSequentialAnsiByValDelegateStdCall caller9 = Get_MarshalStructStringStructSequentialAnsiByVal_StdCall_FuncPtr();
                    if (!caller9(source_sssa))
                    {
                        breturn = false;
                        TestFramework.LogError("D017", "DelegatePInvoke_MarshalStructStringStructSequentialAnsiByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateStringStructSequentialAnsi(source_sssa, clone_sssa, "DelegatePInvoke_MarshalStructStringStructSequentialAnsiByVal_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("D018", "DelegatePInvoke_MarshalStructStringStructSequentialAnsiByVal_StdCall:The StringStructSequentialAnsi value (Managed Side) is wrong");
                    }
                    break;
                case StructID.StringStructSequentialUnicodeId:
                    strOne = new String('a', 256);
                    strTwo = new String('b', 256);
                    StringStructSequentialUnicode source_sssu = Helper.NewStringStructSequentialUnicode(strOne, strTwo);
                    StringStructSequentialUnicode clone_sssu = Helper.NewStringStructSequentialUnicode(strOne, strTwo);

                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructStringStructSequentialUnicodeByVal_StdCall...");
                    StringStructSequentialUnicodeByValDelegateStdCall caller10 = Get_MarshalStructStringStructSequentialUnicodeByVal_StdCall_FuncPtr();
                    if (!caller10(source_sssu))
                    {
                        breturn = false;
                        TestFramework.LogError("D019", "DelegatePInvoke_MarshalStructStringStructSequentialUnicodeByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateStringStructSequentialUnicode(source_sssu, clone_sssu, "DelegatePInvoke_MarshalStructStringStructSequentialUnicodeByVal_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("D020", "DelegatePInvoke_MarshalStructStringStructSequentialUnicodeByVal_StdCall:The StringStructSequentialUnicode value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S8Id:
                    S8 sourceS8 = Helper.NewS8("hello", true, 10, 128, 128, 32);
                    S8 cloneS8 = Helper.NewS8("hello", true, 10, 128, 128, 32);
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructS8ByVal_StdCall...");
                    S8ByValDelegateStdCall caller11 = Get_MarshalStructS8ByVal_StdCall_FuncPtr();
                    if (!caller11(sourceS8))
                    {
                        breturn = false;
                        TestFramework.LogError("D021", "DelegatePInvoke_MarshalStructS8ByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateS8(sourceS8, cloneS8, "DelegatePInvoke_MarshalStructS8ByVal_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("D022", "DelegatePInvoke_MarshalStructS8ByVal_StdCall:The S8 value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S9Id:
                    S9 sourceS9 = Helper.NewS9(128, new TestDelegate1(testMethod));
                    S9 cloneS9 = Helper.NewS9(128, new TestDelegate1(testMethod));
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructS9ByVal_StdCall...");
                    S9ByValDelegateStdCall caller12 = Get_MarshalStructS9ByVal_StdCall_FuncPtr();
                    if (!caller12(sourceS9))
                    {
                        breturn = false;
                        TestFramework.LogError("D023", "DelegatePInvoke_MarshalStructS9ByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateS9(sourceS9, cloneS9, "DelegatePInvoke_MarshalStructS9ByVal_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("D024", "DelegatePInvoke_MarshalStructS9ByVal_StdCall:The S9 value (Managed Side) is wrong");
                    }
                    break;
                case StructID.IncludeOuterIntergerStructSequentialId:
                    IncludeOuterIntergerStructSequential sourceIncludeOuterIntergerStructSequential = Helper.NewIncludeOuterIntergerStructSequential(32, 32);
                    IncludeOuterIntergerStructSequential cloneIncludeOuterIntergerStructSequential = Helper.NewIncludeOuterIntergerStructSequential(32, 32);
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructIncludeOuterIntergerStructSequentialByVal_StdCall...");
                    IncludeOuterIntergerStructSequentialByValDelegateStdCall caller13 = Get_MarshalStructIncludeOuterIntergerStructSequentialByVal_StdCall_FuncPtr();
                    if (!caller13(sourceIncludeOuterIntergerStructSequential))
                    {
                        breturn = false;
                        TestFramework.LogError("D025", "DelegatePInvoke_MarshalStructIncludeOuterIntergerStructSequentialByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateIncludeOuterIntergerStructSequential(sourceIncludeOuterIntergerStructSequential, 
                        cloneIncludeOuterIntergerStructSequential, "DelegatePInvoke_MarshalStructIncludeOuterIntergerStructSequentialByVal_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("D026", "DelegatePInvoke_MarshalStructIncludeOuterIntergerStructSequentialByVal_StdCall:The IncludeOuterIntergerStructSequential value (Managed Side) is wrong");
                    }
                    break;
                case StructID.S11Id:
                    S11 sourceS11 = Helper.NewS11((int*)(32), 32);
                    S11 cloneS11 = Helper.NewS11((int*)(32), 32);
                    Console.WriteLine("\tCalling DelegatePInvoke_MarshalStructS11ByVal_StdCall...");
                    S11ByValDelegateStdCall caller14 = Get_MarshalStructS11ByVal_StdCall_FuncPtr();
                    if (!caller14(sourceS11))
                    {
                        breturn = false;
                        TestFramework.LogError("D027", "DelegatePInvoke_MarshalStructS11ByVal_StdCall:The return value (Managed Side) is wrong");
                    }
                    else if (!Helper.ValidateS11(sourceS11, cloneS11, "DelegatePInvoke_MarshalStructS11ByVal_StdCall"))
                    {
                        breturn = false;
                        TestFramework.LogError("D028", "DelegatePInvoke_MarshalStructS11ByVal_StdCall:The S11 value (Managed Side) is wrong");
                    }
                    break;
                default:
                    breturn = false;
                    TestFramework.LogError("F004", "TestMethod_DelegatePInvoke_MarshalByVal_StdCall:The structid (Managed Side) is wrong");
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

    #endregion

    #region By Ref
   
    unsafe private static bool Run_TestMethod_DelegatePInvoke_MarshalByRef_Cdecl()
    {
        bool bresult = true;
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_Cdecl(StructID.ComplexStructId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_Cdecl(StructID.InnerSequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_Cdecl(StructID.InnerArraySequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_Cdecl(StructID.CharSetAnsiSequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_Cdecl(StructID.CharSetUnicodeSequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_Cdecl(StructID.NumberSequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_Cdecl(StructID.S3Id);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_Cdecl(StructID.S5Id);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_Cdecl(StructID.StringStructSequentialAnsiId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_Cdecl(StructID.StringStructSequentialUnicodeId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_Cdecl(StructID.S8Id);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_Cdecl(StructID.S9Id);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_Cdecl(StructID.IncludeOuterIntergerStructSequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_Cdecl(StructID.S11Id);
        return bresult;
    }
   
    unsafe private static bool Run_TestMethod_DelegatePInvoke_MarshalByRef_StdCall()
    {
        bool bresult = true;
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_StdCall(StructID.ComplexStructId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_StdCall(StructID.InnerSequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_StdCall(StructID.InnerArraySequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_StdCall(StructID.CharSetAnsiSequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_StdCall(StructID.CharSetUnicodeSequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_StdCall(StructID.NumberSequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_StdCall(StructID.S3Id);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_StdCall(StructID.S5Id);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_StdCall(StructID.StringStructSequentialAnsiId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_StdCall(StructID.StringStructSequentialUnicodeId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_StdCall(StructID.S8Id);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_StdCall(StructID.S9Id);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_StdCall(StructID.IncludeOuterIntergerStructSequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByRef_StdCall(StructID.S11Id);
        return bresult;
    }
  
    #endregion

    #region By Value
   
    unsafe private static bool Run_TestMethod_DelegatePInvoke_MarshalByVal_Cdecl()
    {
        bool bresult = true;
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_Cdecl(StructID.ComplexStructId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_Cdecl(StructID.InnerSequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_Cdecl(StructID.InnerArraySequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_Cdecl(StructID.CharSetAnsiSequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_Cdecl(StructID.CharSetUnicodeSequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_Cdecl(StructID.NumberSequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_Cdecl(StructID.S3Id);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_Cdecl(StructID.S5Id);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_Cdecl(StructID.StringStructSequentialAnsiId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_Cdecl(StructID.StringStructSequentialUnicodeId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_Cdecl(StructID.S8Id);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_Cdecl(StructID.S9Id);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_Cdecl(StructID.IncludeOuterIntergerStructSequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_Cdecl(StructID.S11Id);
        return bresult;
    }
    
    unsafe private static bool Run_TestMethod_DelegatePInvoke_MarshalByVal_StdCall()
    {
        bool bresult = true;
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_StdCall(StructID.ComplexStructId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_StdCall(StructID.InnerSequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_StdCall(StructID.InnerArraySequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_StdCall(StructID.CharSetAnsiSequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_StdCall(StructID.CharSetUnicodeSequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_StdCall(StructID.NumberSequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_StdCall(StructID.S3Id);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_StdCall(StructID.S5Id);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_StdCall(StructID.StringStructSequentialAnsiId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_StdCall(StructID.StringStructSequentialUnicodeId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_StdCall(StructID.S8Id);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_StdCall(StructID.S9Id);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_StdCall(StructID.IncludeOuterIntergerStructSequentialId);
        bresult = bresult && TestMethod_DelegatePInvoke_MarshalByVal_StdCall(StructID.S11Id);
        return bresult;
    }
    
    #endregion

    static int Main()
    {
        bool bresult = true;

        Console.WriteLine("\nRun the methods for marshaling structure Delegate P/Invoke ByRef");
        bresult = bresult && Run_TestMethod_DelegatePInvoke_MarshalByRef_Cdecl();
        bresult = bresult && Run_TestMethod_DelegatePInvoke_MarshalByRef_StdCall();

        Console.WriteLine("\nRun the methods for marshaling structure Delegate P/Invoke ByVal/n");
        bresult = bresult && Run_TestMethod_DelegatePInvoke_MarshalByVal_Cdecl();
        bresult = bresult && Run_TestMethod_DelegatePInvoke_MarshalByVal_StdCall();

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