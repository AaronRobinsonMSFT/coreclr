using System;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Collections.Generic;


// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components by default.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("41DDB0BD-1E88-4B0C-BD23-FD3B7E4037A8")]

/// <summary>
/// Interface with ComImport.
/// </summary>
[ComImport]
[Guid("52E5F852-BD3E-4DF2-8826-E1EC39557943")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IInterfaceComImport
{
    int Foo();
}

/// <summary>
/// Interface visible with ComVisible(true).
/// </summary>
[ComVisible(true)]
[Guid("8FDE13DC-F917-44FF-AAC8-A638FD27D647")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IInterfaceVisibleTrue
{
    int Foo();
}

/// <summary>
/// Interface not visible with ComVisible(false).
/// </summary>
[ComVisible(false)]
[Guid("0A2EF649-371D-4480-B0C7-07F455C836D3")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IInterfaceVisibleFalse
{
    int Foo();
}

/// <summary>
/// Interface not visible without ComVisible().
/// </summary>
[Guid("FB504D72-39C4-457F-ACF4-3E5D8A31AAE4")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IInterfaceWithoutVisible
{
    int Foo();
}

/// <summary>
/// Interface not public.
/// </summary>
[ComVisible(true)]
[Guid("11320010-13FA-4B40-8580-8CF92EE70774")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
interface IInterfaceNotPublic
{
    int Foo();
}

/// <summary>
/// Generic interface with ComVisible(true).
/// </summary>
[ComVisible(true)]
[Guid("BA4B32D4-1D73-4605-AD0A-900A31E75BC3")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IInterfaceGenericVisibleTrue<T>
{
    T Foo();
}

/// <summary>
/// Generic class for guid generator.
/// </summary>
public class GenericClassW2Pars <T1,T2>
{
    T1 Foo(T2 a) { return default(T1); }
}

/// <summary>
/// Derived interface visible with ComVisible(true) and GUID.
/// </summary>
[ComVisible(true)]
[Guid("FE62A5B9-34C4-4EAF-AF0A-1AD390B15BDB")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IDerivedInterfaceVisibleTrueGuid
{
    int Foo();
}

/// <summary>
/// Derived interface visible with ComVisible(true) wothout GUID.
/// </summary>
[ComVisible(true)]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IDerivedInterfaceVisibleTrueNoGuid
{
    int Foo1(UInt16 int16Val, bool boolVal);
    int Foo5(Int32 int32Val);
}

/// <summary>
/// Derived interface without visibility and without GUID.
/// </summary>
public interface IDerivedInterfaceWithoutVisibleNoGuid
{
    int Foo7(Int32 int32Val);
}

/// <summary>
/// Interface visible with ComVisible(true) and without Custom Attribute Guid.
/// Note that in this test, change the method sequence in the interface will 
///  change the GUID and could reduce the test efficiency.
/// </summary>
[ComVisible(true)]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IInterfaceVisibleTrueNoGuid : IDerivedInterfaceVisibleTrueGuid, IDerivedInterfaceVisibleTrueNoGuid, IDerivedInterfaceWithoutVisibleNoGuid
{
    int Foo1(UInt16 int16Val, bool boolVal);
    new int Foo();
    int Foo2(string str, out int outIntVal, IntPtr intPtrVal, int[] arrayVal, byte inByteVal = 0, int inIntVal = 0);
    int Foo3(ref short refShortVal, params byte[] paramsList);
    int Foo4(ref List<short> refShortVal, GenericClassW2Pars<int, short> genericClass, params object[] paramsList);
}

/// <summary>
/// Interface not visible and without Custom Attribute Guid.
/// </summary>
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IInterfaceNotVisibleNoGuid
{
    int Foo();
}

/// <summary>
/// Interface visible with ComVisible(true), without Custom Attribute Guid and a generic method.
/// </summary>
[ComVisible(true)]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IInterfaceVisibleTrueNoGuidGeneric
{
    int Foo<T>(T genericVal);
}

/// <summary>
/// Interface visible with ComVisible(true), without Custom Attribute Guid and a method with a parameter which is a generic interface.
/// </summary>
[ComVisible(true)]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IInterfaceVisibleTrueNoGuidGenericInterface
{
    int Foo();
    int Foo9(List<int> listInt);
    int Foo10(ICollection<int> intCollection, ICollection<string> stringCollection);
}

/// <summary>
/// Interface with ComImport derived from an interface with ComImport.
/// </summary>
[ComImport]
[Guid("943759D7-3552-43AD-9C4D-CC2F787CF36E")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IInterfaceComImport_ComImport : IInterfaceComImport
{
    new int Foo();
}

/// <summary>
/// Interface with ComVisible(true) derived from an interface with ComImport.
/// </summary>
[ComVisible(true)]
[Guid("75DE245B-0CE3-4B07-8761-328906C750B7")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IInterfaceVisibleTrue_ComImport : IInterfaceComImport
{
    new int Foo();
}

/// <summary>
/// Interface with ComVisible(false) derived from an interface with ComImport.
/// </summary>
[ComVisible(false)]
[Guid("C73D96C3-B005-42D6-93F5-E30AEE08C66C")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IInterfaceVisibleFalse_ComImport : IInterfaceComImport
{
    new int Foo();
}

/// <summary>
/// Interface with ComVisible(true) derived from an interface with ComVisible(true).
/// </summary>
[ComVisible(true)]
[Guid("60B3917B-9CC2-40F2-A975-CD6898DA697F")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IInterfaceVisibleTrue_VisibleTrue : IInterfaceVisibleTrue
{
    new int Foo();
}

/// <summary>
/// Interface with ComVisible(false) derived from an interface with ComVisible(true).
/// </summary>
[ComVisible(false)]
[Guid("2FC59DDB-B1D0-4678-93AF-6A48E838B705")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IInterfaceVisibleFalse_VisibleTrue : IInterfaceVisibleTrue
{
    new int Foo();
}

/// <summary>
/// Interface with ComVisible(true) derived from an interface with ComVisible(false).
/// </summary>
[ComVisible(true)]
[Guid("C82C25FC-FBAD-4EA9-BED1-343C887464B5")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IInterfaceVisibleTrue_VisibleFalse : IInterfaceVisibleFalse
{
    new int Foo();
}

/// <summary>
/// Interface with ComVisible(true) derived from an not public interface.
/// </summary>
[ComVisible(true)]
[Guid("8A4C1691-5615-4762-8568-481DC671F9CE")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
interface IInterfaceNotPublic_VisibleTrue : IInterfaceVisibleTrue
{
    new int Foo();
}


/// <summary>
/// Class visible with ComVisible(true).
/// </summary>
[ComVisible(true)]
[Guid("48FC2EFC-C7ED-4E02-8D02-F05B6A439FC9")]
public sealed class ClassVisibleTrueServer :
    IInterfaceComImport, IInterfaceVisibleTrue, IInterfaceVisibleFalse, IInterfaceWithoutVisible, IInterfaceNotPublic, 
    IInterfaceVisibleTrueNoGuid, IInterfaceNotVisibleNoGuid, IInterfaceVisibleTrueNoGuidGenericInterface,
    IInterfaceComImport_ComImport, IInterfaceVisibleTrue_ComImport, IInterfaceVisibleFalse_ComImport,
    IInterfaceVisibleTrue_VisibleTrue, IInterfaceVisibleFalse_VisibleTrue, IInterfaceVisibleTrue_VisibleFalse, IInterfaceNotPublic_VisibleTrue
{
    int IInterfaceComImport.Foo() { return 1; }
    int IInterfaceVisibleTrue.Foo() { return 2; }
    int IInterfaceVisibleFalse.Foo() { return 3; }
    int IInterfaceWithoutVisible.Foo() { return 4; }
    int IInterfaceNotPublic.Foo() { return 5; }

    int IInterfaceVisibleTrueNoGuid.Foo() { return 6; }
    int IInterfaceVisibleTrueNoGuid.Foo1(UInt16 int16Val, bool boolVal) { return 7; }
    int IInterfaceVisibleTrueNoGuid.Foo2(string str, out int outIntVal, IntPtr intPtrVal, int[] arrayVal, byte inByteVal = 0, int inIntVal = 0) 
    {
        outIntVal = 10; 
        return 8; 
    }
    int IInterfaceVisibleTrueNoGuid.Foo3(ref short refShortVal, params byte[] paramsList) { return 9; }
    int IInterfaceVisibleTrueNoGuid.Foo4(ref List<short> refShortVal, GenericClassW2Pars<int, short> genericClass, params object[] paramsList) { return 10; }
    int IDerivedInterfaceVisibleTrueGuid.Foo() { return 12; }
    int IDerivedInterfaceVisibleTrueNoGuid.Foo1(UInt16 int16Val, bool boolVal) { return 13; }
    int IDerivedInterfaceVisibleTrueNoGuid.Foo5(Int32 int32Val) { return 14; }
    int IDerivedInterfaceWithoutVisibleNoGuid.Foo7(Int32 int32Val) { return 15; }
    int IInterfaceNotVisibleNoGuid.Foo() { return 16; }
    int IInterfaceVisibleTrueNoGuidGenericInterface.Foo() { return 17; }
    int IInterfaceVisibleTrueNoGuidGenericInterface.Foo9(List<int> listInt) { return 18; }
    int IInterfaceVisibleTrueNoGuidGenericInterface.Foo10(ICollection<int> intCollection, ICollection<string> stringCollection) { return 19; }
    
    int IInterfaceComImport_ComImport.Foo() { return 101; }
    int IInterfaceVisibleTrue_ComImport.Foo() { return 102; }
    int IInterfaceVisibleFalse_ComImport.Foo() { return 103; }
    int IInterfaceVisibleTrue_VisibleTrue.Foo() { return 104; }
    int IInterfaceVisibleFalse_VisibleTrue.Foo() { return 105; }
    int IInterfaceVisibleTrue_VisibleFalse.Foo() { return 106; }
    int IInterfaceNotPublic_VisibleTrue.Foo() { return 107; }

    int Foo() { return 9; }
}

/// <summary>
/// Class not visible with ComVisible(false).
/// </summary>
[ComVisible(false)]
[Guid("6DF17EC1-A8F4-4693-B195-EDB27DF00170")]
public sealed class ClassVisibleFalseServer :
    IInterfaceComImport, IInterfaceVisibleTrue, IInterfaceVisibleFalse, IInterfaceWithoutVisible, IInterfaceNotPublic
{
    int IInterfaceComImport.Foo() { return 120; }
    int IInterfaceVisibleTrue.Foo() { return 121; }
    int IInterfaceVisibleFalse.Foo() { return 122; }
    int IInterfaceWithoutVisible.Foo() { return 123; }
    int IInterfaceNotPublic.Foo() { return 124; }
    int Foo() { return 129; }
}

/// <summary>
/// Class not visible without ComVisible().
/// </summary>
[Guid("A57430B8-E0C1-486E-AE57-A15D6A729F99")]
public sealed class ClassWithoutVisibleServer :
    IInterfaceComImport, IInterfaceVisibleTrue, IInterfaceVisibleFalse, IInterfaceWithoutVisible, IInterfaceNotPublic
{
    int IInterfaceComImport.Foo() { return 130; }
    int IInterfaceVisibleTrue.Foo() { return 131; }
    int IInterfaceVisibleFalse.Foo() { return 132; }
    int IInterfaceWithoutVisible.Foo() { return 133; }
    int IInterfaceNotPublic.Foo() { return 134; }
    int Foo() { return 139; }
}

/// <summary>
/// Generic visible class with ComVisible(true).
/// </summary>
[ComVisible(true)]
[Guid("3CD290FA-1CD0-4370-B8E6-5A573F78C9F7")]
public sealed class ClassGenericServer<T> : IInterfaceVisibleTrue, IInterfaceGenericVisibleTrue<T>, IInterfaceComImport
{
    int IInterfaceComImport.Foo() { return 140; }
    int IInterfaceVisibleTrue.Foo() { return 141; }
    T IInterfaceGenericVisibleTrue<T>.Foo() { return default(T); }
    T Foo() { return default(T); }
}

/// <summary>
/// Class visible with ComVisible(true) and without Custom Attribute Guid.
/// Note that in this test, change the method sequence in the interface will 
///  change the GUID and could broke the test or reduce the test efficiency.
/// </summary>
[ComVisible(true)]
public sealed class ClassVisibleTrueServerNoGuid : IInterfaceVisibleTrue
{
    int IInterfaceVisibleTrue.Foo() { return 150; }

    private int privateVal;
}

public class ComVisibleServer
{
    public static int Main()
    {
        RunComVisibleTests();
        
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

    /// <summary>
    /// Nested interface with ComImport.
    /// </summary>
    [ComImport]
    [Guid("1D927BC5-1530-4B8E-A183-995425CE4A0A")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface INestedInterfaceComImport
    {
        int Foo();
    }

    /// <summary>
    /// Nested interface visible with ComVisible(true).
    /// </summary>
    [ComVisible(true)]
    [Guid("39209692-2568-4B1E-A6C8-A5C7F141D278")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface INestedInterfaceVisibleTrue
    {
        int Foo();
    }

    /// <summary>
    /// Nested interface not visible with ComVisible(false).
    /// </summary>
    [ComVisible(false)]
    [Guid("1CE4B033-4927-447A-9F91-998357B32ADF")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface INestedInterfaceVisibleFalse
    {
        int Foo();
    }

    /// <summary>
    /// Nested interface not visible without ComVisible().
    /// </summary>
    [Guid("C770422A-C363-49F1-AAA1-3EC81A452816")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface INestedInterfaceWithoutVisible
    {
        int Foo();
    }

    /// <summary>
    /// Nested interface not public.
    /// </summary>
    [ComVisible(true)]
    [Guid("F776FF8A-0673-49C2-957A-33C2576062ED")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface INestedInterfaceNotPublic
    {
        int Foo();
    }

    /// <summary>
    /// Nested visible interface with ComVisible(true).
    /// </summary>
    public class NestedClass
    {
        [ComVisible(true)]
        [Guid("B31B4EC1-3B59-41C4-B3A0-CF89638CB837")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        public interface INestedInterfaceNestedInClass
        {
            int Foo();
        }

        [ComVisible(true)]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        public interface INestedInterfaceNestedInClassNoGuid
        {
            int Foo();
        }
    }

    /// <summary>
    /// Generic interface with ComVisible(true).
    /// </summary>
    [ComVisible(true)]
    [Guid("D7A8A196-5D85-4C85-94E4-8344ED2C7277")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface INestedInterfaceGenericVisibleTrue<T>
    {
        T Foo();
    }

    /// <summary>
    /// Nested interface with ComImport derived from an interface with ComImport.
    /// </summary>
    [ComImport]
    [Guid("C57D849A-A1A9-4CDC-A609-789D79F9332C")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface INestedInterfaceComImport_ComImport : INestedInterfaceComImport
    {
        new int Foo();
    }

    /// <summary>
    /// Nested interface with ComVisible(true) derived from an interface with ComImport.
    /// </summary>
    [ComVisible(true)]
    [Guid("81F28686-F257-4B7E-A47F-57C9775BE2CE")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface INestedInterfaceVisibleTrue_ComImport : INestedInterfaceComImport
    {
        new int Foo();
    }

    /// <summary>
    /// Nested interface with ComVisible(false) derived from an interface with ComImport.
    /// </summary>
    [ComVisible(false)]
    [Guid("FAAB7E6C-8548-429F-AD34-0CEC3EBDD7B7")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface INestedInterfaceVisibleFalse_ComImport : INestedInterfaceComImport
    {
        new int Foo();
    }

    /// <summary>
    /// Nested interface with ComVisible(true) derived from an interface with ComVisible(true).
    /// </summary>
    [ComVisible(true)]
    [Guid("BEFD79A9-D8E6-42E4-8228-1892298460D7")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface INestedInterfaceVisibleTrue_VisibleTrue : INestedInterfaceVisibleTrue
    {
        new int Foo();
    }

    /// <summary>
    /// Nested interface with ComVisible(false) derived from an interface with ComVisible(true).
    /// </summary>
    [ComVisible(false)]
    [Guid("5C497454-EA83-4F79-B990-4EB28505E801")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface INestedInterfaceVisibleFalse_VisibleTrue : INestedInterfaceVisibleTrue
    {
        new int Foo();
    }

    /// <summary>
    /// Nested interface with ComVisible(true) derived from an interface with ComVisible(false).
    /// </summary>
    [ComVisible(true)]
    [Guid("A17CF08F-EEC4-4EA5-B12C-5A603101415D")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface INestedInterfaceVisibleTrue_VisibleFalse : INestedInterfaceVisibleFalse
    {
        new int Foo();
    }

    /// <summary>
    /// Nested interface with ComVisible(true) derived from an not public interface.
    /// </summary>
    [ComVisible(true)]
    [Guid("40B723E9-E1BE-4F55-99CD-D2590D191A53")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface INestedInterfaceNotPublic_VisibleTrue : INestedInterfaceVisibleTrue
    {
        new int Foo();
    }

    /// <summary>
    /// Nested interface visible with ComVisible(true) without Guid.
    /// </summary>
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface INestedInterfaceVisibleTrueNoGuid
    {
        int Foo();
    }


    /// <summary>
    /// Nested class visible with ComVisible(true).
    /// </summary>
    [ComVisible(true)]
    [Guid("CF681980-CE6D-421E-8B21-AEAE3F1B7DAC")]
    public sealed class NestedClassVisibleTrueServer : 
        INestedInterfaceComImport, INestedInterfaceVisibleTrue, INestedInterfaceVisibleFalse, INestedInterfaceWithoutVisible, INestedInterfaceNotPublic,
        INestedInterfaceVisibleTrueNoGuid, NestedClass.INestedInterfaceNestedInClassNoGuid,
        NestedClass.INestedInterfaceNestedInClass, INestedInterfaceComImport_ComImport, INestedInterfaceVisibleTrue_ComImport, INestedInterfaceVisibleFalse_ComImport,
        INestedInterfaceVisibleTrue_VisibleTrue, INestedInterfaceVisibleFalse_VisibleTrue, INestedInterfaceVisibleTrue_VisibleFalse, INestedInterfaceNotPublic_VisibleTrue
    {
        int INestedInterfaceComImport.Foo() { return 10; }
        int INestedInterfaceVisibleTrue.Foo() { return 11; }
        int INestedInterfaceVisibleFalse.Foo() { return 12; }
        int INestedInterfaceWithoutVisible.Foo() { return 13; }
        int INestedInterfaceNotPublic.Foo() { return 14; }

        int INestedInterfaceVisibleTrueNoGuid.Foo() { return 50; }
        int NestedClass.INestedInterfaceNestedInClassNoGuid.Foo() { return 51; }

        int NestedClass.INestedInterfaceNestedInClass.Foo() { return 110; }
        int INestedInterfaceComImport_ComImport.Foo() { return 111; }
        int INestedInterfaceVisibleTrue_ComImport.Foo() { return 112; }
        int INestedInterfaceVisibleFalse_ComImport.Foo() { return 113; }
        int INestedInterfaceVisibleTrue_VisibleTrue.Foo() { return 114; }
        int INestedInterfaceVisibleFalse_VisibleTrue.Foo() { return 115; }
        int INestedInterfaceVisibleTrue_VisibleFalse.Foo() { return 116; }
        int INestedInterfaceNotPublic_VisibleTrue.Foo() { return 117; }

        int Foo() { return 19; }
    }

    /// <summary>
    /// Nested class not visible with ComVisible(false).
    /// </summary>
    [ComVisible(false)]
    [Guid("6DF17EC1-A8F4-4693-B195-EDB27DF00170")]
    public sealed class NestedClassVisibleFalseServer : 
        INestedInterfaceComImport, INestedInterfaceVisibleTrue, INestedInterfaceVisibleFalse, INestedInterfaceWithoutVisible, INestedInterfaceNotPublic
    {
        int INestedInterfaceComImport.Foo() { return 20; }
        int INestedInterfaceVisibleTrue.Foo() { return 21; }
        int INestedInterfaceVisibleFalse.Foo() { return 22; }
        int INestedInterfaceWithoutVisible.Foo() { return 23; }
        int INestedInterfaceNotPublic.Foo() { return 24; }
        int Foo() { return 29; }
    }

    /// <summary>
    /// Nested class not visible without ComVisible().
    /// </summary>
    [Guid("A57430B8-E0C1-486E-AE57-A15D6A729F99")]
    public sealed class NestedClassWithoutVisibleServer : 
        INestedInterfaceComImport, INestedInterfaceVisibleTrue, INestedInterfaceVisibleFalse, INestedInterfaceWithoutVisible, INestedInterfaceNotPublic
    {
        int INestedInterfaceComImport.Foo() { return 30; }
        int INestedInterfaceVisibleTrue.Foo() { return 31; }
        int INestedInterfaceVisibleFalse.Foo() { return 32; }
        int INestedInterfaceWithoutVisible.Foo() { return 33; }
        int INestedInterfaceNotPublic.Foo() { return 34; }
        int Foo() { return 39; }
    }

    /// <summary>
    /// Generic visible nested class with ComVisible(true).
    /// </summary>
    [ComVisible(true)]
    [Guid("CAFBD2FF-710A-4E83-9229-42FA16963424")]
    public sealed class NestedClassGenericServer<T> : INestedInterfaceVisibleTrue, INestedInterfaceGenericVisibleTrue<T>, INestedInterfaceComImport
    {
        int INestedInterfaceComImport.Foo() { return 40; }
        int INestedInterfaceVisibleTrue.Foo() { return 41; }
        T INestedInterfaceGenericVisibleTrue<T>.Foo() { return default(T); }
        T Foo() { return default(T); }
    }


    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_InterfaceComImport([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_InterfaceVisibleTrue([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);
    
    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_InterfaceVisibleFalse([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);
    
    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_InterfaceWithoutVisible([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_InterfaceNotPublic([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_InterfaceVisibleTrueNoGuid([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_InterfaceVisibleTrueNoGuidGenericInterface([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_InterfaceNotVisibleNoGuid([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_InterfaceGenericVisibleTrue([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_InterfaceComImport_ComImport([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_InterfaceVisibleTrue_ComImport([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_InterfaceVisibleFalse_ComImport([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_InterfaceVisibleTrue_VisibleTrue([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_InterfaceVisibleFalse_VisibleTrue([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_InterfaceVisibleTrue_VisibleFalse([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_InterfaceNotPublic_VisibleTrue([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_NestedInterfaceComImport([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_NestedInterfaceVisibleTrue([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_NestedInterfaceVisibleFalse([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_NestedInterfaceWithoutVisible([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_NestedInterfaceNotPublic([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);
    
    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_NestedInterfaceNestedInClass([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_NestedInterfaceNestedInClassNoGuid([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_NestedInterfaceVisibleTrueNoGuid([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_NestedInterfaceGenericVisibleTrue([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_NestedInterfaceComImport_ComImport([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_NestedInterfaceVisibleTrue_ComImport([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_NestedInterfaceVisibleFalse_ComImport([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_NestedInterfaceVisibleTrue_VisibleTrue([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_NestedInterfaceVisibleFalse_VisibleTrue([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_NestedInterfaceVisibleTrue_VisibleFalse([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    [DllImport("ComVisibleClient")]
    public static extern int CCWTest_NestedInterfaceNotPublic_VisibleTrue([MarshalAs(UnmanagedType.IUnknown)] object unk, out int fooSuccessVal);

    /// <summary>
    /// Test case set for ComVisible. The assembly is set as [assembly: ComVisible(false)]
    /// </summary>
    /// <returns></returns>
    private static void RunComVisibleTests()
    {
        int fooSuccessVal = 0;
        //
        // Tests for class with ComVisible(true)
        //
        TestHelper.BeginScenario("Class with ComVisible(true)");
        ClassVisibleTrueServer visibleBaseClass = new ClassVisibleTrueServer();

        TestHelper.BeginSubScenario("CCWTest_InterfaceComImport");
        TestHelper.Assert(Helpers.S_OK, CCWTest_InterfaceComImport((object)visibleBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(1, fooSuccessVal, "COM method didn't return the expected value.");
        
        TestHelper.BeginSubScenario("CCWTest_InterfaceVisibleTrue");
        TestHelper.Assert(Helpers.S_OK, CCWTest_InterfaceVisibleTrue((object)visibleBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(2, fooSuccessVal, "COM method didn't return the expected value.");
        
        TestHelper.BeginSubScenario("CCWTest_InterfaceVisibleFalse");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_InterfaceVisibleFalse((object)visibleBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");
        
        TestHelper.BeginSubScenario("CCWTest_InterfaceWithoutVisible");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_InterfaceWithoutVisible((object)visibleBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");
        
        TestHelper.BeginSubScenario("CCWTest_InterfaceNotPublic");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_InterfaceNotPublic((object)visibleBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");

#if BUG1044264
        TestHelper.BeginSubScenario("CCWTest_InterfaceVisibleTrueNoGuid");
        TestHelper.Assert(Helpers.S_OK, CCWTest_InterfaceVisibleTrueNoGuid((object)visibleBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(6, fooSuccessVal, "COM method didn't return the expected value.");

        TestHelper.BeginSubScenario("CCWTest_InterfaceVisibleTrueNoGuidGenericInterface");
        TestHelper.Assert(Helpers.COR_E_GENERICMETHOD, CCWTest_InterfaceVisibleTrueNoGuidGenericInterface((object)visibleBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");
#endif //BUG1044264

        TestHelper.BeginSubScenario("CCWTest_InterfaceNotVisibleNoGuid");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_InterfaceNotVisibleNoGuid((object)visibleBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");

        //
        // Tests for nested Interface in a class with ComVisible(true)
        //
        TestHelper.BeginScenario("Nested Interface in a class with ComVisible(true)");
        
        TestHelper.BeginSubScenario("CCWTest_InterfaceComImport_ComImport");
        TestHelper.Assert(Helpers.S_OK, CCWTest_InterfaceComImport_ComImport((object)visibleBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(101, fooSuccessVal, "COM method didn't return the expected value.");
        
        TestHelper.BeginSubScenario("CCWTest_InterfaceVisibleTrue_ComImport");
        TestHelper.Assert(Helpers.S_OK, CCWTest_InterfaceVisibleTrue_ComImport((object)visibleBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(102, fooSuccessVal, "COM method didn't return the expected value.");
        
        TestHelper.BeginSubScenario("CCWTest_InterfaceVisibleFalse_ComImport");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_InterfaceVisibleFalse_ComImport((object)visibleBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");
        
        TestHelper.BeginSubScenario("CCWTest_InterfaceVisibleTrue_VisibleTrue");
        TestHelper.Assert(Helpers.S_OK, CCWTest_InterfaceVisibleTrue_VisibleTrue((object)visibleBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(104, fooSuccessVal, "COM method didn't return the expected value.");
        
        TestHelper.BeginSubScenario("CCWTest_InterfaceVisibleFalse_VisibleTrue");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_InterfaceVisibleFalse_VisibleTrue((object)visibleBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");
        
        TestHelper.BeginSubScenario("CCWTest_InterfaceVisibleTrue_VisibleFalse");
        TestHelper.Assert(Helpers.S_OK, CCWTest_InterfaceVisibleTrue_VisibleFalse((object)visibleBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(106, fooSuccessVal, "COM method didn't return the expected value.");
        
        TestHelper.BeginSubScenario("CCWTest_InterfaceNotPublic_VisibleTrue");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_InterfaceNotPublic_VisibleTrue((object)visibleBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");

        //
        // Tests for class with ComVisible(false)
        //
        TestHelper.BeginScenario("Class with ComVisible(false)");
        ClassVisibleFalseServer visibleFalseBaseClass = new ClassVisibleFalseServer();

        TestHelper.BeginSubScenario("CCWTest_InterfaceComImport");
        TestHelper.Assert(Helpers.S_OK, CCWTest_InterfaceComImport((object)visibleFalseBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(120, fooSuccessVal, "COM method didn't return the expected value.");
        
        TestHelper.BeginSubScenario("CCWTest_InterfaceVisibleTrue");
        TestHelper.Assert(Helpers.S_OK, CCWTest_InterfaceVisibleTrue((object)visibleFalseBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(121, fooSuccessVal, "COM method didn't return the expected value.");
        
        TestHelper.BeginSubScenario("CCWTest_InterfaceVisibleFalse");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_InterfaceVisibleFalse((object)visibleFalseBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");
        
        TestHelper.BeginSubScenario("CCWTest_InterfaceWithoutVisible");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_InterfaceWithoutVisible((object)visibleFalseBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");
        
        TestHelper.BeginSubScenario("CCWTest_InterfaceNotPublic");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_InterfaceNotPublic((object)visibleFalseBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");

        //
        // Tests for class without ComVisible()
        //
        TestHelper.BeginScenario("Class without ComVisible()");
        ClassWithoutVisibleServer withoutVisibleBaseClass = new ClassWithoutVisibleServer();

        TestHelper.BeginSubScenario("CCWTest_InterfaceComImport");
        TestHelper.Assert(Helpers.S_OK, CCWTest_InterfaceComImport((object)withoutVisibleBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(130, fooSuccessVal, "COM method didn't return the expected value.");
        
        TestHelper.BeginSubScenario("CCWTest_InterfaceVisibleTrue");
        TestHelper.Assert(Helpers.S_OK, CCWTest_InterfaceVisibleTrue((object)withoutVisibleBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(131, fooSuccessVal, "COM method didn't return the expected value.");
        
        TestHelper.BeginSubScenario("CCWTest_InterfaceVisibleFalse");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_InterfaceVisibleFalse((object)withoutVisibleBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");
        
        TestHelper.BeginSubScenario("CCWTest_InterfaceWithoutVisible");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_InterfaceWithoutVisible((object)withoutVisibleBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");
        
        TestHelper.BeginSubScenario("CCWTest_InterfaceNotPublic");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_InterfaceNotPublic((object)withoutVisibleBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");


        //
        // Tests for generic class with ComVisible(true)
        //
        TestHelper.BeginScenario("Generic class with ComVisible(true)");
        ClassGenericServer<int> genericServer = new ClassGenericServer<int>();

        TestHelper.BeginSubScenario("CCWTest_InterfaceComImport");
        TestHelper.Assert(Helpers.S_OK, CCWTest_InterfaceComImport((object)genericServer, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(140, fooSuccessVal, "COM method didn't return the expected value.");
        
        TestHelper.BeginSubScenario("CCWTest_InterfaceVisibleTrue");
        TestHelper.Assert(Helpers.S_OK, CCWTest_InterfaceVisibleTrue((object)genericServer, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(141, fooSuccessVal, "COM method didn't return the expected value.");
        
#if BUG1037160
        TestHelper.BeginSubScenario("CCWTest_InterfaceGenericVisibleTrue");
        TestHelper.Assert(Helpers.COR_E_INVALIDOPERATION, CCWTest_InterfaceGenericVisibleTrue((object)genericServer, out fooSuccessVal), "Returned diferent exception than the expected COR_E_INVALIDOPERATION.");
#endif //BUG1037160

        //
        // Tests for nested class with ComVisible(true)
        //
        TestHelper.BeginScenario("Nested class with ComVisible(true)");
        NestedClassVisibleTrueServer visibleNestedBaseClass = new NestedClassVisibleTrueServer();
        
        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceComImport");
        TestHelper.Assert(Helpers.S_OK, CCWTest_NestedInterfaceComImport((object)visibleNestedBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(10, fooSuccessVal, "COM method didn't return the expected value.");

        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceVisibleTrue");
        TestHelper.Assert(Helpers.S_OK, CCWTest_NestedInterfaceVisibleTrue((object)visibleNestedBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(11, fooSuccessVal, "COM method didn't return the expected value.");

        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceVisibleFalse");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_NestedInterfaceVisibleFalse((object)visibleNestedBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");
        
        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceWithoutVisible");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_NestedInterfaceWithoutVisible((object)visibleNestedBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");
        
        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceNotPublic");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_NestedInterfaceNotPublic((object)visibleNestedBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");

        //
        // Tests for nested Interface in a nested class with ComVisible(true)
        //
        TestHelper.BeginScenario("Nested Interface in a nested class with ComVisible(true)");

        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceNestedInClass");
        TestHelper.Assert(Helpers.S_OK, CCWTest_NestedInterfaceNestedInClass((object)visibleNestedBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(110, fooSuccessVal, "COM method didn't return the expected value.");

#if BUG1044264
        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceVisibleTrueNoGuid");
        TestHelper.Assert(Helpers.S_OK, CCWTest_NestedInterfaceVisibleTrueNoGuid((object)visibleNestedBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(50, fooSuccessVal, "COM method didn't return the expected value.");

        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceNestedInClassNoGuid");
        TestHelper.Assert(Helpers.S_OK, CCWTest_NestedInterfaceNestedInClassNoGuid((object)visibleNestedBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(51, fooSuccessVal, "COM method didn't return the expected value.");
#endif //BUG1044264

        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceComImport_ComImport");
        TestHelper.Assert(Helpers.S_OK, CCWTest_NestedInterfaceComImport_ComImport((object)visibleNestedBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(111, fooSuccessVal, "COM method didn't return the expected value.");

        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceVisibleTrue_ComImport");
        TestHelper.Assert(Helpers.S_OK, CCWTest_NestedInterfaceVisibleTrue_ComImport((object)visibleNestedBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(112, fooSuccessVal, "COM method didn't return the expected value.");

        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceVisibleFalse_ComImport");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_NestedInterfaceVisibleFalse_ComImport((object)visibleNestedBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");

        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceVisibleTrue_VisibleTrue");
        TestHelper.Assert(Helpers.S_OK, CCWTest_NestedInterfaceVisibleTrue_VisibleTrue((object)visibleNestedBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(114, fooSuccessVal, "COM method didn't return the expected value.");

        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceVisibleFalse_VisibleTrue");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_NestedInterfaceVisibleFalse_VisibleTrue((object)visibleNestedBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");
        
        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceVisibleTrue_VisibleFalse");
        TestHelper.Assert(Helpers.S_OK, CCWTest_NestedInterfaceVisibleTrue_VisibleFalse((object)visibleNestedBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(116, fooSuccessVal, "COM method didn't return the expected value.");

        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceNotPublic_VisibleTrue");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_NestedInterfaceNotPublic_VisibleTrue((object)visibleNestedBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");

        //
        // Tests for nested class with ComVisible(false)
        //
        TestHelper.BeginScenario("Nested class with ComVisible(false)");
        NestedClassVisibleFalseServer visibleFalseNestedBaseClass = new NestedClassVisibleFalseServer();
        
        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceComImport");
        TestHelper.Assert(Helpers.S_OK, CCWTest_NestedInterfaceComImport((object)visibleFalseNestedBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(20, fooSuccessVal, "COM method didn't return the expected value.");

        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceVisibleTrue");
        TestHelper.Assert(Helpers.S_OK, CCWTest_NestedInterfaceVisibleTrue((object)visibleFalseNestedBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(21, fooSuccessVal, "COM method didn't return the expected value.");

        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceVisibleFalse");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_NestedInterfaceVisibleFalse((object)visibleFalseNestedBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");

        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceWithoutVisible");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_NestedInterfaceWithoutVisible((object)visibleFalseNestedBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");

        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceNotPublic");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_NestedInterfaceNotPublic((object)visibleFalseNestedBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");

        //
        // Tests for nested class without ComVisible()
        //
        TestHelper.BeginScenario("Nested class without ComVisible()");
        NestedClassWithoutVisibleServer withoutVisibleNestedBaseClass = new NestedClassWithoutVisibleServer();
        
        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceComImport");
        TestHelper.Assert(Helpers.S_OK, CCWTest_NestedInterfaceComImport((object)withoutVisibleNestedBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(30, fooSuccessVal, "COM method didn't return the expected value.");

        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceVisibleTrue");
        TestHelper.Assert(Helpers.S_OK, CCWTest_NestedInterfaceVisibleTrue((object)withoutVisibleNestedBaseClass, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(31, fooSuccessVal, "COM method didn't return the expected value.");

        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceVisibleFalse");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_NestedInterfaceVisibleFalse((object)withoutVisibleNestedBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");

        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceWithoutVisible");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_NestedInterfaceWithoutVisible((object)withoutVisibleNestedBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");

        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceNotPublic");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_NestedInterfaceNotPublic((object)withoutVisibleNestedBaseClass, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");

        //
        // Tests for generic nested class with ComVisible(true)
        //
        TestHelper.BeginScenario("Nested generic class with ComVisible(true)");
        NestedClassGenericServer<int> nestedGenericServer = new NestedClassGenericServer<int>();
        
        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceComImport");
        TestHelper.Assert(Helpers.S_OK, CCWTest_NestedInterfaceComImport((object)nestedGenericServer, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(40, fooSuccessVal, "COM method didn't return the expected value.");

        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceVisibleTrue");
        TestHelper.Assert(Helpers.S_OK, CCWTest_NestedInterfaceVisibleTrue((object)nestedGenericServer, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(41, fooSuccessVal, "COM method didn't return the expected value.");

        TestHelper.BeginSubScenario("CCWTest_NestedInterfaceGenericVisibleTrue");
        TestHelper.Assert(Helpers.E_NOINTERFACE, CCWTest_NestedInterfaceGenericVisibleTrue((object)nestedGenericServer, out fooSuccessVal), "Returned diferent exception than the expected E_NOINTERFACE.");

        //
        // Tests for class with ComVisible(true) without Custom Attribute Guid.
        //
        TestHelper.BeginScenario("Class with ComVisible(true) without GUID");
        ClassVisibleTrueServerNoGuid visibleBaseClassNoGuid = new ClassVisibleTrueServerNoGuid();

        TestHelper.BeginSubScenario("CCWTest_InterfaceVisibleTrue");
        TestHelper.Assert(Helpers.S_OK, CCWTest_InterfaceVisibleTrue((object)visibleBaseClassNoGuid, out fooSuccessVal), "COM method thrown an unexpected exception.");
        TestHelper.Assert(150, fooSuccessVal, "COM method didn't return the expected value.");


        //
        // Tests for get the GetTypeInfo().GUID for Interface and class without Custom Attribute Guid.
        //
        TestHelper.BeginScenario("GetTypeInfo().GUID for Interface and Class without GUID");

#if BUG1034221
        TestHelper.BeginSubScenario("IInterfaceVisibleTrueNoGuid.GUID");
        TestHelper.Assert(typeof(IInterfaceVisibleTrueNoGuid).GetTypeInfo().GUID == new Guid("ad50a327-d23a-38a4-9d6e-b32b32acf572"),
            typeof(IInterfaceVisibleTrueNoGuid).GetTypeInfo() + " returns a wrong GUID {" + typeof(IInterfaceVisibleTrueNoGuid).GetTypeInfo().GUID + "}");

        TestHelper.BeginSubScenario("IInterfaceNotVisibleNoGuid.GUID");
        TestHelper.Assert(typeof(IInterfaceNotVisibleNoGuid).GetTypeInfo().GUID == new Guid("b45587ec-9671-35bc-8b8e-f6bfb18a4d3a"),
            typeof(IInterfaceNotVisibleNoGuid).GetTypeInfo() + " returns a wrong GUID {" + typeof(IInterfaceNotVisibleNoGuid).GetTypeInfo().GUID + "}");

        TestHelper.BeginSubScenario("IDerivedInterfaceVisibleTrueNoGuid.GUID");
        TestHelper.Assert(typeof(IDerivedInterfaceVisibleTrueNoGuid).GetTypeInfo().GUID == new Guid("c3f73319-f6b3-3ef6-a095-8cb04fb8cf8b"),
            typeof(IDerivedInterfaceVisibleTrueNoGuid).GetTypeInfo() + " returns a wrong GUID {" + typeof(IDerivedInterfaceVisibleTrueNoGuid).GetTypeInfo().GUID + "}");

        TestHelper.BeginSubScenario("IInterfaceVisibleTrueNoGuidGeneric.GUID");
        TestHelper.Assert(typeof(IInterfaceVisibleTrueNoGuidGeneric).GetTypeInfo().GUID == new Guid("50c0a59c-b6e1-36dd-b488-a905b54910d4"),
            typeof(IInterfaceVisibleTrueNoGuidGeneric).GetTypeInfo() + " returns a wrong GUID {" + typeof(IInterfaceVisibleTrueNoGuidGeneric).GetTypeInfo().GUID + "}");

        TestHelper.BeginSubScenario("IInterfaceVisibleTrueNoGuidGenericInterface.GUID");
        TestHelper.Assert(typeof(IInterfaceVisibleTrueNoGuidGenericInterface).GetTypeInfo().GUID == new Guid("384f0b5c-28d0-368c-8c7e-5e31a84a5c84"),
            typeof(IInterfaceVisibleTrueNoGuidGenericInterface).GetTypeInfo() + " returns a wrong GUID {" + typeof(IInterfaceVisibleTrueNoGuidGenericInterface).GetTypeInfo().GUID + "}");

        TestHelper.BeginSubScenario("ClassVisibleTrueServerNoGuid.GUID");
        TestHelper.Assert(typeof(ClassVisibleTrueServerNoGuid).GetTypeInfo().GUID == new Guid("afb3aafc-75bc-35d3-be41-a399c2701929"),
            typeof(ClassVisibleTrueServerNoGuid).GetTypeInfo() + " returns a wrong GUID {" + typeof(ClassVisibleTrueServerNoGuid).GetTypeInfo().GUID + "}");

        TestHelper.BeginSubScenario("INestedInterfaceNestedInClassNoGuid.GUID");
        TestHelper.Assert(typeof(NestedClass.INestedInterfaceNestedInClassNoGuid).GetTypeInfo().GUID == new Guid("486bcec9-904d-3445-871c-e7084a52eb1a"),
            typeof(NestedClass.INestedInterfaceNestedInClassNoGuid).GetTypeInfo() + " returns a wrong GUID {" + typeof(NestedClass.INestedInterfaceNestedInClassNoGuid).GetTypeInfo().GUID + "}");

        TestHelper.BeginSubScenario("INestedInterfaceVisibleTrueNoGuid.GUID");
        TestHelper.Assert(typeof(INestedInterfaceVisibleTrueNoGuid).GetTypeInfo().GUID == new Guid("0ea2cb33-db9f-3655-9240-47ef1dea0f1e"),
            typeof(INestedInterfaceVisibleTrueNoGuid).GetTypeInfo() + " returns a wrong GUID {" + typeof(INestedInterfaceVisibleTrueNoGuid).GetTypeInfo().GUID + "}");

#endif //BUG1034221

    }
}