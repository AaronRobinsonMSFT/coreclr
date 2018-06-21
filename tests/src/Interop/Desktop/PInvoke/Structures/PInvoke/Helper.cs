using System;
using System.Runtime.InteropServices;

public class Helper
{
    #region methods for InnerSequential struct
    
    // Return new InnerSequential instance 
    public static InnerSequential NewInnerSequential(int f1, float f2, string f3)
    {
        InnerSequential inner = new InnerSequential();
        inner.f1 = f1;
        inner.f2 = f2;
        inner.f3 = f3;
        return inner;
    }
    
    //	Prints InnerSequential  
    public static void PrintInnerSequential(InnerSequential inner, string name)
    {
        Console.WriteLine("\t{0}.f1 = {1}", name, inner.f1);
        Console.WriteLine("\t{0}.f2 = {1}", name, inner.f2);
        Console.WriteLine("\t{0}.f3 = {1}", name, inner.f3);
    }
    
    public static bool ValidateInnerSequential(InnerSequential inner1, InnerSequential inner2, string methodName)
    {
        if (inner1.f1 != inner2.f1 || inner1.f2 != inner2.f2 || inner1.f3 != inner2.f3)
        {
            Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
            Console.WriteLine("\tThe Actual is...");
            PrintInnerSequential(inner1, inner1.ToString());
            Console.WriteLine("\tThe Expected is...");
            PrintInnerSequential(inner2, inner2.ToString());
            return false;
        }
        else
        {
            Console.WriteLine("\tPASSED!");
            return true;
        }
    }
    
    #endregion
    #region methods for InnerExplicit1 struct
    
    // Return new InnerExplicit1 instance 
    public static InnerExplicit1 NewInnerExplicit1(int f1, float f2, string f3)
    {
        InnerExplicit1 inner = new InnerExplicit1();
        inner.f1 = f1;
        inner.f2 = f2;
        inner.f3 = f3;
        return inner;
    }
    
    //	Prints InnerExplicit1  
    public static void PrintInnerExplicit1(InnerExplicit1 inner, string name)
    {
        Console.WriteLine("\t{0}.f1 = {1}", name, inner.f1);
        Console.WriteLine("\t{0}.f2 = {1}", name, inner.f2);
        Console.WriteLine("\t{0}.f3 = {1}", name, inner.f3);
    }
    
    public static bool ValidateInnerExplicit1(InnerExplicit1 inner1, InnerExplicit1 inner2, string methodName)
    {
        if (inner1.f1 != inner2.f1 || inner1.f2 != inner2.f2 || inner1.f3 != inner2.f3)
        {
            Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
            Console.WriteLine("\tThe Actual is...");
            PrintInnerExplicit1(inner1, inner1.ToString());
            Console.WriteLine("\tThe Expected is...");
            PrintInnerExplicit1(inner2, inner2.ToString());
            return false;
        }
        else
        {
            Console.WriteLine("\tPASSED!");
            return true;
        }
    }

    #endregion
    #region methods for InnerExplicit2 struct
    
    // Return new InnerExplicit2 instance 
    public static InnerExplicit2 NewInnerExplicit2(int f1, float f2, string f3)
    {
        InnerExplicit2 inner = new InnerExplicit2();
        inner.f1 = f1;
        inner.f2 = f2;
        inner.f3 = f3;
        return inner;
    }
    
    //	Prints InnerExplicit2  
    public static void PrintInnerExplicit2(InnerExplicit2 inner, string name)
    {
        Console.WriteLine("\t{0}.f1 = {1}", name, inner.f1);
        Console.WriteLine("\t{0}.f2 = {1}", name, inner.f2);
        Console.WriteLine("\t{0}.f3 = {1}", name, inner.f3);
    }
    
    public static bool ValidateInnerExplicit2(InnerExplicit2 inner1, InnerExplicit2 inner2, string methodName)
    {
        if (inner1.f1 != inner2.f1 || inner1.f2 != inner2.f2 || inner1.f3 != inner2.f3)
        {
            Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
            Console.WriteLine("\tThe Actual is...");
            PrintInnerExplicit2(inner1, inner1.ToString());
            Console.WriteLine("\tThe Expected is...");
            PrintInnerExplicit2(inner2, inner2.ToString());
            return false;
        }
        else
        {
            Console.WriteLine("\tPASSED!");
            return true;
        }
    }

    #endregion

    #region methods for InnerArraySequential struct
    
    //	Returns new InnerArraySequential instance; the params are the fields of InnerSequential; 
    //	all the InnerSequential elements have the same field values
    public static InnerArraySequential NewInnerArraySequential(int f1, float f2, string f3)
    {
        InnerArraySequential outer = new InnerArraySequential();
        outer.arr = new InnerSequential[Common.NumArrElements];
        for (int i = 0; i < Common.NumArrElements; i++)
        {
            outer.arr[i].f1 = f1;
            outer.arr[i].f2 = f2;
            outer.arr[i].f3 = f3;
        }
        return outer;
    }
    
    //	Prints InnerArraySequential
    public static void PrintInnerArraySequential(InnerArraySequential outer, string name)
    {
        for (int i = 0; i < Common.NumArrElements; i++)
        {
            Console.WriteLine("\t{0}.arr[{1}].f1 = {2}", name, i, outer.arr[i].f1);
            Console.WriteLine("\t{0}.arr[{1}].f2 = {2}", name, i, outer.arr[i].f2);
            Console.WriteLine("\t{0}.arr[{1}].f3 = {2}", name, i, outer.arr[i].f3);
        }
    }
    
    //	Returns true if the two params have the same fields
    public static bool ValidateInnerArraySequential(InnerArraySequential outer1, InnerArraySequential outer2, string methodName)
    {
        for (int i = 0; i < Common.NumArrElements; i++)
        {
            if (outer1.arr[i].f1 != outer2.arr[i].f1 ||
                outer1.arr[i].f2 != outer2.arr[i].f2 ||
                outer1.arr[i].f3 != outer2.arr[i].f3)
            {
                Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
                Console.WriteLine("\tThe Actual is...");
                Console.WriteLine("\t{0}.arr[{1}].f1 = {2}", outer1.ToString(), i, outer1.arr[i].f1);
                Console.WriteLine("\t{0}.arr[{1}].f2 = {2}", outer1.ToString(), i, outer1.arr[i].f2);
                Console.WriteLine("\t{0}.arr[{1}].f3 = {2}", outer1.ToString(), i, outer1.arr[i].f3);
                Console.WriteLine("\tThe Expected is...");
                Console.WriteLine("\t{0}.arr[{1}].f1 = {2}", outer2.ToString(), i, outer2.arr[i].f1);
                Console.WriteLine("\t{0}.arr[{1}].f2 = {2}", outer2.ToString(), i, outer2.arr[i].f2);
                Console.WriteLine("\t{0}.arr[{1}].f3 = {2}", outer2.ToString(), i, outer2.arr[i].f3);
                return false;
            }
        }
        Console.WriteLine("\tPASSED!");
        return true;
    }

    #endregion
    #region methods for InnerArrayExplicit1 struct
    
    //	Returns new InnerArrayExplicit1 instance; the params are the fields of InnerSequential; 
    //	all the InnerSequential elements have the same field values
    public static InnerArrayExplicit1 NewInnerArrayExplicit1(int f1, float f2, string f3, string f4)
    {
        InnerArrayExplicit1 outer = new InnerArrayExplicit1();
        outer.arr = new InnerSequential[Common.NumArrElements];
        for (int i = 0; i < Common.NumArrElements; i++)
        {
            outer.arr[i].f1 = f1;
            outer.arr[i].f2 = f2;
            outer.arr[i].f3 = f3;
        }
        outer.f4 = f4;
        return outer;
    }
    
    //	Prints InnerArrayExplicit1
    public static void PrintInnerArrayExplicit1(InnerArrayExplicit1 outer, string name)
    {
        for (int i = 0; i < Common.NumArrElements; i++)
        {
            Console.WriteLine("\t{0}.arr[{1}].f1 = {2}", name, i, outer.arr[i].f1);
            Console.WriteLine("\t{0}.arr[{1}].f2 = {2}", name, i, outer.arr[i].f2);
            Console.WriteLine("\t{0}.arr[{1}].f3 = {2}", name, i, outer.arr[i].f3);
        }
        Console.WriteLine("\t{0}.f4 = {1}", name, outer.f4);
    }
    
    //Returns true if the two params have the same fields
    public static bool ValidateInnerArrayExplicit1(InnerArrayExplicit1 outer1, InnerArrayExplicit1 outer2, string methodName)
    {
        for (int i = 0; i < Common.NumArrElements; i++)
        {
            if (outer1.arr[i].f1 != outer2.arr[i].f1)
            {
                Console.WriteLine("\tFAILED! " + methodName + " did not recieve result as expected.");
                Console.WriteLine("\tThe Actual f1 field is...");
                Console.WriteLine("\t{0}.arr[{1}].f1 = {2}", outer1.ToString(), i, outer1.arr[i].f1);
                Console.WriteLine("\tThe Expected f1 field is...");
                Console.WriteLine("\t{0}.arr[{1}].f1 = {2}", outer2.ToString(), i, outer2.arr[i].f1);
                return false;
            }
            if (outer1.arr[i].f2 != outer2.arr[i].f2)
            {
                Console.WriteLine("\tFAILED! " + methodName + " did not recieve result as expected.");
                Console.WriteLine("\tThe Actual f2 field is...");
                Console.WriteLine("\t{0}.arr[{1}].f2 = {2}", outer1.ToString(), i, outer1.arr[i].f2);
                Console.WriteLine("\tThe Expected f2 field is...");
                Console.WriteLine("\t{0}.arr[{1}].f2 = {2}", outer2.ToString(), i, outer2.arr[i].f2);
                return false;
            }
            if (outer1.arr[i].f3 != outer2.arr[i].f3)
            {
                Console.WriteLine("\tFAILED! " + methodName + " did not recieve result as expected.");
                Console.WriteLine("\tThe Actual f3 field is...");
                Console.WriteLine("\t{0}.arr[{1}].f3 = {2}", outer1.ToString(), i, outer1.arr[i].f3);
                Console.WriteLine("\tThe Expected f3 field is...");
                Console.WriteLine("\t{0}.arr[{1}].f3 = {2}", outer2.ToString(), i, outer2.arr[i].f3);
                return false;
            }
        }
        if (outer1.f4 != outer2.f4)
        {
            Console.WriteLine("\tFAILED! " + methodName + " did not recieve result as expected.");
            Console.WriteLine("\tThe Actual f4 field is...");
            Console.WriteLine("\t{0}.f4 = {1}", outer1.ToString(), outer1.f4);
            Console.WriteLine("\tThe Expected f4 field is...");
            Console.WriteLine("\t{0}.f4 = {1}", outer2.ToString(), outer2.f4);
            return false;
        }
        Console.WriteLine("\tPASSED!");
        return true;
    }

    #endregion
    #region methods for InnerArrayExplicit2 struct
    
    //	Returns new InnerArrayExplicit2 instance; the params are the fields of InnerSequential; 
    //	all the InnerSequential elements have the same field values
    public static InnerArrayExplicit2 NewInnerArrayExplicit2(int f1, float f2, string f3, string f4)
    {
        InnerArrayExplicit2 outer = new InnerArrayExplicit2();
        outer.arr = new InnerSequential[Common.NumArrElements];
        for (int i = 0; i < Common.NumArrElements; i++)
        {
            outer.arr[i].f1 = f1;
            outer.arr[i].f2 = f2;
            outer.arr[i].f3 = f3;
        }
        outer.f4 = f4;
        return outer;
    }
    
    //	Prints InnerArrayExplicit2
    public static void PrintInnerArrayExplicit2(InnerArrayExplicit2 outer, string name)
    {
        for (int i = 0; i < Common.NumArrElements; i++)
        {
            Console.WriteLine("\t{0}.arr[{1}].f1 = {2}", name, i, outer.arr[i].f1);
            Console.WriteLine("\t{0}.arr[{1}].f2 = {2}", name, i, outer.arr[i].f2);
            Console.WriteLine("\t{0}.arr[{1}].f3 = {2}", name, i, outer.arr[i].f3);
        }
        Console.WriteLine("\t{0}.f4 = {1}", name, outer.f4);
    }
    
    //	Returns true if the two params have the same fields
    public static bool ValidateInnerArrayExplicit2(InnerArrayExplicit2 outer1, InnerArrayExplicit2 outer2, string methodName)
    {
        for (int i = 0; i < Common.NumArrElements; i++)
        {
            if (outer1.arr[i].f1 != outer2.arr[i].f1 ||
                outer1.arr[i].f2 != outer2.arr[i].f2 ||
                outer1.arr[i].f3 != outer2.arr[i].f3)
            {
                Console.WriteLine("\tFAILED! " + methodName + " did not recieve result as expected.");
                Console.WriteLine("\tThe Actual is...");
                Console.WriteLine("\t{0}.arr[{1}].f1 = {2}", outer1.ToString(), i, outer1.arr[i].f1);
                Console.WriteLine("\t{0}.arr[{1}].f2 = {2}", outer1.ToString(), i, outer1.arr[i].f2);
                Console.WriteLine("\t{0}.arr[{1}].f3 = {2}", outer1.ToString(), i, outer1.arr[i].f3);
                Console.WriteLine("\tThe Expected is...");
                Console.WriteLine("\t{0}.arr[{1}].f1 = {2}", outer2.ToString(), i, outer2.arr[i].f1);
                Console.WriteLine("\t{0}.arr[{1}].f2 = {2}", outer2.ToString(), i, outer2.arr[i].f2);
                Console.WriteLine("\t{0}.arr[{1}].f3 = {2}", outer2.ToString(), i, outer2.arr[i].f3);
                return false;
            }
        }
        if (outer1.f4 != outer2.f4)
        {
            Console.WriteLine("\tFAILED! " + methodName + " did not recieve result as expected.");
            Console.WriteLine("\tThe Actual f4 field is...");
            Console.WriteLine("\t{0}.f4 = {1}", outer1.ToString(), outer1.f4);
            Console.WriteLine("\tThe Expected f4 field is...");
            Console.WriteLine("\t{0}.f4 = {1}", outer2.ToString(), outer2.f4);
            return false;
        }
        Console.WriteLine("\tPASSED!");
        return true;
    }

    #endregion
    #region methods for CharSetAnsiSequential struct

    //return CharSetAnsiSequential struct instance
    public static CharSetAnsiSequential NewCharSetAnsiSequential(string f1, char f2)
    {
        CharSetAnsiSequential str1 = new CharSetAnsiSequential();
        str1.f1 = f1;
        str1.f2 = f2;
        return str1;
    }

    //print the struct CharSetAnsiSequential element
    public static void PrintCharSetAnsiSequential(CharSetAnsiSequential str1, string name)
    {
        Console.WriteLine("\t{0}.f1 = {1}", name, str1.f1);
        Console.WriteLine("\t{0}.f2 = {1}", name, str1.f2);
    }

    //	Returns true if the two params have the same fields
    public static bool ValidateCharSetAnsiSequential(CharSetAnsiSequential str1, CharSetAnsiSequential str2, string methodName)
    {
        if (str1.f1 != str2.f1 || str1.f2 != str2.f2)
        {
            Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
            Console.WriteLine("\tThe Actual is...");
            PrintCharSetAnsiSequential(str1, str1.ToString());
            Console.WriteLine("\tThe Expected is...");
            PrintCharSetAnsiSequential(str2, str2.ToString());
            return false;
        }
        else
        {
            Console.WriteLine("\tPASSED!");
            return true;
        }
    }

    #endregion
    #region methods for CharSetUnicodeSequential struct
   
    //return the struct CharSetUnicodeSequential instance
    public static CharSetUnicodeSequential NewCharSetUnicodeSequential(string f1, char f2)
    {
        CharSetUnicodeSequential str1 = new CharSetUnicodeSequential();
        str1.f1 = f1;
        str1.f2 = f2;
        return str1;
    }
 
    //print the struct CharSetUnicodeSequential element
    public static void PrintCharSetUnicodeSequential(CharSetUnicodeSequential str1, string name)
    {
        Console.WriteLine("\t{0}.f1 = {1}", name, str1.f1);
        Console.WriteLine("\t{0}.f2 = {1}", name, str1.f2);
    }
  
    //	Returns true if the two params have the same fields
    public static bool ValidateCharSetUnicodeSequential(CharSetUnicodeSequential str1, CharSetUnicodeSequential str2, string methodName)
    {
        if (str1.f1 != str2.f1 || str1.f2 != str2.f2)
        {
            Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
            Console.WriteLine("\tThe Actual is...");
            PrintCharSetUnicodeSequential(str1, str1.ToString());
            Console.WriteLine("\tThe Expected is...");
            PrintCharSetUnicodeSequential(str2, str2.ToString());
            return false;
        }
        else
        {
            Console.WriteLine("\tPASSED!");
            return true;
        }
    }

    #endregion

    #region methods for NumberSequential struct
   
    public static NumberSequential NewNumberSequential(int i32, uint ui32, short s1, ushort us1, Byte b, SByte sb,
        Int16 i16, UInt16 ui16, Int64 i64, UInt64 ui64, Single sgl, Double d)
    {
        NumberSequential str1 = new NumberSequential();
        str1.i32 = i32;
        str1.ui32 = ui32;
        str1.s1 = s1;
        str1.us1 = us1;
        str1.b = b;
        str1.sb = sb;
        str1.i16 = i16;
        str1.ui16 = ui16;
        str1.i64 = i64;
        str1.ui64 = ui64;
        str1.sgl = sgl;
        str1.d = d;
        return str1;
    }
   
    public static void PrintNumberSequential(NumberSequential str1, string name)
    {
        Console.WriteLine("\t{0}.i32 = {1}", name, str1.i32);
        Console.WriteLine("\t{0}.ui32 = {1}", name, str1.ui32);
        Console.WriteLine("\t{0}.s1 = {1}", name, str1.s1);
        Console.WriteLine("\t{0}.us1 = {1}", name, str1.us1);
        Console.WriteLine("\t{0}.b = {1}", name, str1.b);
        Console.WriteLine("\t{0}.sb = {1}", name, str1.sb);
        Console.WriteLine("\t{0}.i16 = {1}", name, str1.i16);
        Console.WriteLine("\t{0}.ui16 = {1}", name, str1.ui16);
        Console.WriteLine("\t{0}.i64 = {1}", name, str1.i64);
        Console.WriteLine("\t{0}.ui64 = {1}", name, str1.ui64);
        Console.WriteLine("\t{0}.sgl = {1}", name, str1.sgl);
        Console.WriteLine("\t{0}.d = {1}", name, str1.d);
    }
 
    public static bool ValidateNumberSequential(NumberSequential str1, NumberSequential str2, string methodName)
    {
        if (str1.i32 != str2.i32 || str1.ui32 != str2.ui32 || str1.s1 != str2.s1 ||
            str1.us1 != str2.us1 || str1.b != str2.b || str1.sb != str2.sb || str1.i16 != str2.i16 ||
            str1.ui16 != str2.ui16 || str1.i64 != str2.i64 || str1.ui64 != str2.ui64 ||
            str1.sgl != str2.sgl || str1.d != str2.d)
        {
            Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
            Console.WriteLine("\tThe Actual is...");
            PrintNumberSequential(str1, str1.ToString());
            Console.WriteLine("\tThe Expected is...");
            PrintNumberSequential(str2, str2.ToString());
            return false;
        }
        else
        {
            Console.WriteLine("\tPASSED!");
            return true;
        }
    }

    #endregion
    #region methods for StructSeqWithArrayField struct

    public static StructSeqWithArrayField NewStructSeqWithArrayField(bool flag, string str, int[] vals)
    {
        StructSeqWithArrayField str1 = new StructSeqWithArrayField();
        str1.flag = flag;
        str1.str = str;
        str1.vals = vals;
        return str1;
    }

    public static void PrintStructSeqWithArrayField(StructSeqWithArrayField str1, string name)
    {
        Console.WriteLine("\t{0}.flag = {1}", name, str1.flag);
        Console.WriteLine("\t{0}.flag = {1}", name, str1.str);
        for (int i = 0; i < str1.vals.Length; i++)
        {
            Console.WriteLine("\t{0}.vals[{1}] = {2}", name, i, str1.vals[i]);
        }
    }

    public static bool ValidateStructSeqWithArrayField(StructSeqWithArrayField str1, StructSeqWithArrayField str2, string methodName)
    {
        int iflag = 0;
        if (str1.flag != str2.flag || str1.str != str2.str)
        {
            Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
            Console.WriteLine("\tThe Actual flag field is...");
            Console.WriteLine("\t{0}.flag = {1}", str1.ToString(), str1.flag);
            Console.WriteLine("\t{0}.str = {1}", str1.ToString(), str1.str);
            Console.WriteLine("\tThe Expected is...");
            Console.WriteLine("\t{0}.flag = {1}", str2.ToString(), str2.flag);
            Console.WriteLine("\t{0}.str = {1}", str2.ToString(), str2.str);
            return false;
        }
        for (int i = 0; i < 256; i++)
        {
            if (str1.vals[i] != str2.vals[i])
            {
                Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
                Console.WriteLine("\tThe Actual vals field is...");
                Console.WriteLine("\t{0}.vals[{1}] = {2}", str1.ToString(), i, str1.vals[i]);
                Console.WriteLine("\tThe Expected vals field is...");
                Console.WriteLine("\t{0}.vals[{1}] = {2}", str2.ToString(), i, str2.vals[i]);
                iflag++;
            }
        }
        if (iflag != 0)
        {
            return false;
        }
        Console.WriteLine("\tPASSED!");
        return true;
    }

    #endregion
    #region methods for StructSeqWithEnumField struct

    public static StructSeqWithEnumField NewStructSeqWithEnumField(int age, string name, Enum1 ef)
    {
        S4 s4 = new S4();
        s4.age = age;
        s4.name = name;

        StructSeqWithEnumField s5 = new StructSeqWithEnumField();
        s5.s4 = s4;
        s5.ef = ef;

        return s5;
    }

    public static void PrintStructSeqWithEnumField(StructSeqWithEnumField str1, string name)
    {
        Console.WriteLine("\t{0}.s4.age = {1}", str1.s4.age);
        Console.WriteLine("\t{0}.s4.name = {1}", str1.s4.name);
        Console.WriteLine("\t{0}.ef = {1}", str1.ef.ToString());
    }

    public static bool ValidateStructSeqWithEnumField(StructSeqWithEnumField str1, StructSeqWithEnumField str2, string methodName)
    {
        if (str1.s4.age != str2.s4.age || str1.s4.name != str2.s4.name)
        {
            Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
            Console.WriteLine("\tThe Actual s4 field is...");
            Console.WriteLine("\t{0}.s4.age = {1}", str1.ToString(), str1.s4.age);
            Console.WriteLine("\t{0}.s4.name = {1}", str1.ToString(), str1.s4.name);
            Console.WriteLine("\tThe Expected s4 field is...");
            Console.WriteLine("\t{0}.s4.age = {1}", str2.ToString(), str2.s4.age);
            Console.WriteLine("\t{0}.s4.name = {1}", str2.ToString(), str2.s4.name);
            return false;
        }
        if (str1.ef != str2.ef)
        {
            Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
            Console.WriteLine("\tThe Actual ef field is...");
            Console.WriteLine("\t{0}.ef = {1}", str1.ToString(), str1.ef);
            Console.WriteLine("\tThe Expected s4 field is...");
            Console.WriteLine("\t{0}.ef = {1}", str2.ToString(), str2.ef);
            return false;
        }
        Console.WriteLine("\tPASSED!");
        return true;
    }

    #endregion
    #region methods for StringStructSequentialAnsi struct

    public static StringStructSequentialAnsi NewStringStructSequentialAnsi(string first, string last)
    {
        StringStructSequentialAnsi s6 = new StringStructSequentialAnsi();
        s6.first = first;
        s6.last = last;

        return s6;
    }

    public static void PrintStringStructSequentialAnsi(StringStructSequentialAnsi str1, string name)
    {
        Console.WriteLine("\t{0}.first = {1}", name, str1.first);
        Console.WriteLine("\t{0}.last = {1}", name, str1.last);
    }

    public static bool ValidateStringStructSequentialAnsi(StringStructSequentialAnsi str1, StringStructSequentialAnsi str2, string methodName)
    {
        if (str1.first != str2.first || str1.last != str2.last)
        {
            Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
            Console.WriteLine("\tThe Actual is...");
            PrintStringStructSequentialAnsi(str1, str1.ToString());
            Console.WriteLine("\tThe Expected is...");
            PrintStringStructSequentialAnsi(str2, str2.ToString());
            return false;
        }
        else
        {
            Console.WriteLine("\tPASSED!");
            return true;
        }
    }

    #endregion
    #region methods for StringStructSequentialUnicode struct

    public static StringStructSequentialUnicode NewStringStructSequentialUnicode(string first, string last)
    {
        StringStructSequentialUnicode s7 = new StringStructSequentialUnicode();
        s7.first = first;
        s7.last = last;

        return s7;
    }

    public static void PrintStringStructSequentialUnicode(StringStructSequentialUnicode str1, string name)
    {
        Console.WriteLine("\t{0}.first = {1}", name, str1.first);
        Console.WriteLine("\t{0}.last = {1}", name, str1.last);
    }

    public static bool ValidateStringStructSequentialUnicode(StringStructSequentialUnicode str1, StringStructSequentialUnicode str2, string methodName)
    {
        if (str1.first != str2.first || str1.last != str2.last)
        {
            Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
            Console.WriteLine("\tThe Actual is...");
            PrintStringStructSequentialUnicode(str1, str1.ToString());
            Console.WriteLine("\tThe Expected is...");
            PrintStringStructSequentialUnicode(str2, str2.ToString());
            return false;
        }
        else
        {
            Console.WriteLine("\tPASSED!");
            return true;
        }
    }

    #endregion
    #region methods for PritypeStructSeqWithUnmanagedType struct

    public static PritypeStructSeqWithUnmanagedType NewPritypeStructSeqWithUnmanagedType(string name, bool gender, /*decimal wage, */
        UInt16 jobNum, /*int i32, uint ui32,*/ sbyte mySByte)
    {
        PritypeStructSeqWithUnmanagedType s8 = new PritypeStructSeqWithUnmanagedType();
        s8.name = name;
        s8.gender = gender;
        //s8.wage = wage;
        s8.jobNum = jobNum;
        //s8.i32 = i32;
        //s8.ui32 = ui32;
        s8.mySByte = mySByte;
        return s8;
    }

    public static void PrintPritypeStructSeqWithUnmanagedType(PritypeStructSeqWithUnmanagedType str1, string name)
    {
        Console.WriteLine("\t{0}.name = {1}", name, str1.name);
        Console.WriteLine("\t{0}.gender = {1}", name, str1.gender);
        //Console.WriteLine("\t{0}.wage = {1}", name, str1.wage);
        Console.WriteLine("\t{0}.jobNum = {1}", name, str1.jobNum);
        //Console.WriteLine("\t{0}.i32 = {1}", name, str1.i32);//In ProjectN V1, we dont support MarshalAs Error 
        //Console.WriteLine("\t{0}.ui32 = {1}", name, str1.ui32);
        Console.WriteLine("\t{0}.mySByte = {1}", name, str1.mySByte);
    }

    public static bool ValidatePritypeStructSeqWithUnmanagedType(PritypeStructSeqWithUnmanagedType str1, PritypeStructSeqWithUnmanagedType str2, string methodName)
    {
        if (str1.name != str2.name || str1.gender != str2.gender ||
            /*str1.wage != str2.wage ||*/ str1.jobNum != str2.jobNum ||
            /*str1.i32 != str2.i32 || str1.ui32 != str2.ui32 ||*/ str1.mySByte != str2.mySByte)
        {
            Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
            Console.WriteLine("\tThe Actual is...");
            PrintPritypeStructSeqWithUnmanagedType(str1, str1.ToString());
            Console.WriteLine("\tThe Expected is...");
            PrintPritypeStructSeqWithUnmanagedType(str2, str2.ToString());
            return false;
        }
        Console.WriteLine("\tPASSED!");
        return true;

    }

    #endregion
    #region methods for StructSequentialWithDelegateField struct

    public static StructSequentialWithDelegateField NewStructSequentialWithDelegateField(/*int i32,*/ TestDelegate1 testDel1)
    {
        StructSequentialWithDelegateField s9 = new StructSequentialWithDelegateField();
        //s9.i32 = i32;
        s9.myDelegate1 = testDel1;
        return s9;
    }

    public static bool ValidateStructSequentialWithDelegateField(StructSequentialWithDelegateField str1, StructSequentialWithDelegateField str2, string methodName)
    {
        if (/*str1.i32 != str2.i32 || */str1.myDelegate1 != str2.myDelegate1)
        {
            Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
            Console.WriteLine("\tThe Actual is...");
            //Console.WriteLine("\t{0}.i32 = {1}", str1.ToString(), str1.i32);
            Console.WriteLine("\t{0}.myDelegate1 = {1}", str1.ToString(), str1.myDelegate1);
            Console.WriteLine("\tThe Expected is...");
            //Console.WriteLine("\t{0}.i32 = {1}", str2.ToString(), str2.i32);
            Console.WriteLine("\t{0}.myDelegate1 = {1}", str2.ToString(), str2.myDelegate1);
            return false;
        }
        Console.WriteLine("\tPASSED!");
        return true;
    }

    #endregion
    #region methods for IncludeOuterIntergerStructSequential struct

    public static IncludeOuterIntergerStructSequential NewIncludeOuterIntergerStructSequential(int i321, int i322)
    {
        IncludeOuterIntergerStructSequential s10 = new IncludeOuterIntergerStructSequential();
        s10.s.s_int.i = i321;
        s10.s.i = i322;
        return s10;
    }

    public static void PrintIncludeOuterIntergerStructSequential(IncludeOuterIntergerStructSequential str1, string name)
    {
        Console.WriteLine("\t{0}.s.s_int.i = {1}", name, str1.s.s_int.i);
        Console.WriteLine("\t{0}.s.i = {1}", name, str1.s.i);
    }

    public static bool ValidateIncludeOuterIntergerStructSequential(IncludeOuterIntergerStructSequential str1, IncludeOuterIntergerStructSequential str2, string methodName)
    {
        if (str1.s.s_int.i != str2.s.s_int.i || str1.s.i != str2.s.i)
        {
            Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
            Console.WriteLine("\tThe Actual is...");
            PrintIncludeOuterIntergerStructSequential(str1, str1.ToString());
            Console.WriteLine("\tThe Expected is...");
            PrintIncludeOuterIntergerStructSequential(str2, str2.ToString());
            return false;
        }
        else
        {
            Console.WriteLine("\tPASSED!");
            return true;
        }
    }

    #endregion
    #region methods for StructSequentialWithPointerField struct

    unsafe public static void PrintStructSequentialWithPointerField(StructSequentialWithPointerField str1, string name)
    {
        Console.WriteLine("\t{0}.i32 = {1}", name, (int)(str1.i32));
        Console.WriteLine("\t{0}.i = {1}", name, str1.i);
    }

    unsafe public static StructSequentialWithPointerField NewStructSequentialWithPointerField(int* i32, int i)
    {
        StructSequentialWithPointerField s11 = new StructSequentialWithPointerField();
        s11.i32 = i32;
        s11.i = i;
        return s11;
    }

    unsafe public static bool ValidateStructSequentialWithPointerField(StructSequentialWithPointerField str1, StructSequentialWithPointerField str2, string methodName)
    {
        if (str1.i32 != str2.i32 || str1.i != str2.i)
        {
            Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
            Console.WriteLine("\tThe Actual is...");
            PrintStructSequentialWithPointerField(str1, str1.ToString());
            Console.WriteLine("\tThe Expected is...");
            PrintStructSequentialWithPointerField(str2, str2.ToString());
            return false;
        }
        Console.WriteLine("\tPASSED!");
        return true;
    }

    #endregion

    #region methods for NumberExplicit struct

    public static NumberExplicit NewNumberExplicit(int i32, uint ui32, IntPtr iPtr, UIntPtr uiPtr, short s, ushort us, byte b, sbyte sb, long l, ulong ul, float f, double d)
    {
        NumberExplicit u = new NumberExplicit();
        u.i32 = i32;
        u.ui32 = ui32;
        u.iPtr = iPtr;
        u.uiPtr = uiPtr;
        u.s = s;
        u.us = us;
        u.b = b;
        u.sb = sb;
        u.l = l;
        u.ul = ul;
        u.f = f;
        u.d = d;

        return u;
    }

    public static void PrintNumberExplicit(NumberExplicit str1, string name)
    {
        Console.WriteLine("\t{0}.i32 = {1}", name, str1.i32);
        Console.WriteLine("\t{0}.ui32 = {1}", name, str1.ui32);
        Console.WriteLine("\t{0}.iPtr = {1}", name, str1.iPtr);
        Console.WriteLine("\t{0}.uiPtr = {1}", name, str1.uiPtr);
        Console.WriteLine("\t{0}.s = {1}", name, str1.s);
        Console.WriteLine("\t{0}.us = {1}", name, str1.us);
        Console.WriteLine("\t{0}.b = {1}", name, str1.b);
        Console.WriteLine("\t{0}.sb = {1}", name, str1.sb);
        Console.WriteLine("\t{0}.l = {1}", name, str1.l);
        Console.WriteLine("\t{0}.ul = {1}", name, str1.ul);
        Console.WriteLine("\t{0}.f = {1}", name, str1.f);
        Console.WriteLine("\t{0}.d = {1}", name, str1.d);
    }

    public static bool ValidateNumberExplicit(NumberExplicit str1, NumberExplicit str2, string methodName)
    {
        if (str1.i32 != str2.i32 || str1.ui32 != str2.ui32 || str1.iPtr != str2.iPtr ||
            str1.uiPtr != str2.uiPtr || str1.s != str2.s || str1.us != str2.us ||
            str1.b != str2.b || str1.sb != str2.sb || str1.l != str2.l || str1.ul != str2.ul ||
            str1.f != str2.f || str1.d != str2.d)
        {
            Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
            Console.WriteLine("\tThe Actual is...");
            PrintNumberExplicit(str1, str1.ToString());
            Console.WriteLine("\tThe Expected is...");
            PrintNumberExplicit(str2, str2.ToString());
            return false;
        }
        Console.WriteLine("\tPASSED!");
        return true;
    }

    #endregion
    #region methods for ByteStructPack2Explicit struct

    public static ByteStructPack2Explicit NewByteStructPack2Explicit(byte b1, byte b2)
    {
        ByteStructPack2Explicit u1 = new ByteStructPack2Explicit();
        u1.b1 = b1;
        u1.b2 = b2;

        return u1;
    }

    public static void PrintByteStructPack2Explicit(ByteStructPack2Explicit str1, string name)
    {
        Console.WriteLine("\t{0}.b1 = {1}", name, str1.b1);
        Console.WriteLine("\t{0}.b2 = {1}", name, str1.b2);
    }

    public static bool ValidateByteStructPack2Explicit(ByteStructPack2Explicit str1, ByteStructPack2Explicit str2, string methodName)
    {
        if (str1.b1 != str2.b1 || str1.b2 != str2.b2)
        {
            Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
            Console.WriteLine("\tThe Actual is...");
            PrintByteStructPack2Explicit(str1, str1.ToString());
            Console.WriteLine("\tThe Expected is...");
            PrintByteStructPack2Explicit(str2, str2.ToString());
            return false;
        }
        else
        {
            Console.WriteLine("\tPASSED!");
            return true;
        }
    }

    #endregion
    #region methods for ShortStructPack4Explicit struct

    public static ShortStructPack4Explicit NewShortStructPack4Explicit(short s1, short s2)
    {
        ShortStructPack4Explicit u2 = new ShortStructPack4Explicit();
        u2.s1 = s1;
        u2.s2 = s2;

        return u2;
    }

    public static void PrintShortStructPack4Explicit(ShortStructPack4Explicit str1, string name)
    {
        Console.WriteLine("\t{0}.s1 = {1}", name, str1.s1);
        Console.WriteLine("\t{0}.s2 = {1}", name, str1.s2);
    }

    public static bool ValidateShortStructPack4Explicit(ShortStructPack4Explicit str1, ShortStructPack4Explicit str2, string methodName)
    {
        if (str1.s1 != str2.s1 || str1.s2 != str2.s2)
        {
            Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
            Console.WriteLine("\tThe Actual is...");
            PrintShortStructPack4Explicit(str1, str1.ToString());
            Console.WriteLine("\tThe Expected is...");
            PrintShortStructPack4Explicit(str2, str2.ToString());
            return false;
        }
        else
        {
            Console.WriteLine("\tPASSED!");
            return true;
        }
    }

    #endregion
    #region methods for IntStructPack8Explicit struct

    public static IntStructPack8Explicit NewIntStructPack8Explicit(int i1, int i2)
    {
        IntStructPack8Explicit u3 = new IntStructPack8Explicit();
        u3.i1 = i1;
        u3.i2 = i2;

        return u3;
    }

    public static void PrintIntStructPack8Explicit(IntStructPack8Explicit str1, string name)
    {
        Console.WriteLine("\t{0}.i1 = {1}", name, str1.i1);
        Console.WriteLine("\t{0}.i2 = {1}", name, str1.i2);
    }

    public static bool ValidateIntStructPack8Explicit(IntStructPack8Explicit str1, IntStructPack8Explicit str2, string methodName)
    {
        if (str1.i1 != str2.i1 || str1.i2 != str2.i2)
        {
            Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
            Console.WriteLine("\tThe Actual is...");
            PrintIntStructPack8Explicit(str1, str1.ToString());
            Console.WriteLine("\tThe Expected is...");
            PrintIntStructPack8Explicit(str2, str2.ToString());
            return false;
        }
        else
        {
            Console.WriteLine("\tPASSED!");
            return true;
        }
    }

    #endregion
    #region methods for LongStructPack16Explicit struct

    public static LongStructPack16Explicit NewLongStructPack16Explicit(long l1, long l2)
    {
        LongStructPack16Explicit u4 = new LongStructPack16Explicit();
        u4.l1 = l1;
        u4.l2 = l2;

        return u4;
    }

    public static void PrintLongStructPack16Explicit(LongStructPack16Explicit str1, string name)
    {
        Console.WriteLine("\t{0}.l1 = {1}", name, str1.l1);
        Console.WriteLine("\t{0}.l2 = {1}", name, str1.l2);
    }

    public static bool ValidateLongStructPack16Explicit(LongStructPack16Explicit str1, LongStructPack16Explicit str2, string methodName)
    {
        if (str1.l1 != str2.l1 || str1.l2 != str2.l2)
        {
            Console.WriteLine("\tFAILED! " + methodName + "did not recieve result as expected.");
            Console.WriteLine("\tThe Actual is...");
            PrintLongStructPack16Explicit(str1, str1.ToString());
            Console.WriteLine("\tThe Expected is...");
            PrintLongStructPack16Explicit(str2, str2.ToString());
            return false;
        }
        else
        {
            Console.WriteLine("\tPASSED!");
            return true;
        }
    }

    #endregion
    #region MethodsForStringExplicit

    public static StringExplicit NewStringExplicit(String str1, String str2, String str3)
    {
        StringExplicit strexp = new StringExplicit();
        strexp.str1 = str1;
        strexp.str2 = str2;
        strexp.charr = str3;
        return strexp;
    }

    public static void PrintStringExplicit(StringExplicit strexp, string name)
    {
        Console.WriteLine("\t{0}.str1 = {1}", name, strexp.str1);
        Console.WriteLine("\t{0}.str2 = {1}", name, strexp.str2);
        Console.WriteLine("\t{0}.str3 = {1}", name, strexp.charr);
    }

    public static bool ValidateStringExplicit(StringExplicit s1, StringExplicit s2, string methodName)
    {
        if (!((s1.str1).Equals(s2.str1)) || !((s1.str2).Equals(s2.str2)))
        {
            return false;
        }
        else
        {
            Console.WriteLine("\tPASSED!");
            return true;
        }
    }

    #endregion
}