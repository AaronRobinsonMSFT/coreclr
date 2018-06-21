#include <wtypes.h>
#include <oaidl.h>
#include <iostream>

DECIMAL g_DECIMAL_MaxValue = { 0, { 0, 0 }, 0xffffffff, 0xffffffff, 0xffffffffffffffff };
DECIMAL g_DECIMAL_MinValue  = { 0, { 0, DECIMAL_NEG }, 0xffffffff, 0xffffffff, 0xffffffffffffffff };
DECIMAL g_DECIMAL_Zero = { 0 };

CY g_CY_MaxValue = { 0xffffffff, 0x7fffffff };
CY g_CY_MinValue = { 0x00000000, 0x80000000 };
CY g_CY_Zero = { 0 };

typedef struct _Stru_Seq_DecAsStructAsFld
{
    int number;
    DECIMAL dec;
} Stru_Seq_DecAsStructAsFld;

typedef struct _Stru_Exp_DecAsCYAsFld
{
    WCHAR wc;
    CY cy;
} Stru_Exp_DecAsCYAsFld;

typedef struct _Stru_Seq_DecAsLPStructAsFld
{
    DOUBLE dblVal;
    CHAR cVal;
    DECIMAL* dec;
} Stru_Seq_DecAsLPStructAsFld;

// As Struct
typedef bool (*Fp_Dec)(DECIMAL*);
typedef DECIMAL (*Fp_RetDec)();
typedef bool (*Fp_Stru_Seq_DecAsStructAsFld)(Stru_Seq_DecAsStructAsFld*);
// As CY
typedef bool (*Fp_CY)(CY*);
typedef CY (*Fp_RetCY)();
typedef bool (*Fp_Stru_Exp_DecAsCYAsFld)(Stru_Exp_DecAsCYAsFld*);
// As LPStruct
typedef bool (*Fp_DecAsLPStruct)(DECIMAL**);
typedef DECIMAL* (*Fp_RetDecAsLPStruct)();
typedef bool (*Fp_Stru_Seq_DecAsLPStructAsFld)(Stru_Seq_DecAsLPStructAsFld*);

void DecDisplay(const DECIMAL& dec)
{
    std::cout << "\twReserved" << "\t\t" << dec.wReserved << "\n"
        << "\tscale" << "\t\t" << dec.scale << "\n"
        << "\tsign" << "\t\t" << dec.sign << "\n"
        << "\tsignscale" << "\t\t" << dec.signscale << "\n"
        << "\tHi32" << "\t\t" << dec.Hi32 << "\n"
        << "\tLo32" << "\t\t" << dec.Lo32 << "\n"
        << "\tMid32" << "\t\t" << dec.Mid32 << "\n"
        << "\tLo64" << "\t\t" << dec.Lo64 << std::endl;
}

template<typename T>
bool operator==(const T& t1, const T& t2)
{
    return 0 == memcmp((void*)&t1, (void*)&t2, sizeof(T));
}

template<typename T>
bool Equals(LPCSTR err_id, T expected, T actual)
{
    if(expected == actual)
        return true;
    else
    {
        std::cout << "\t#Native Side Err# -- " << err_id 
            << "\n\tExpected = " << expected << std::endl;
        std::wcout << "\tActual is = " << actual << std::endl;

        return false;
    }
}

bool IntEqualsToExpected(LPCSTR err_id, int number, int expected)
{
    
    if(number == expected)
    {
        return true;
    }
    else
    {
        std::wcout << "\t#Native Side Err# -- " << err_id 
                  << "\n\tnumber Expected = " << expected << std::endl;

        std::wcout << "\tnumber Actual is = " << number << std::endl;

        return false;
    }
}
bool DecEqualsToExpected(LPCSTR err_id, const DECIMAL& expected, const DECIMAL& actual)
{
    if(expected == actual)
        return true;
    else
    {
        std::cout << "\t#Native Side Err # -- " << err_id 
            << "DECIMAL Expected is :" << std::endl;
        DecDisplay(expected);

        std::cout << "\t" << "____________________________________" << std::endl;

        std::cout << "\tDECIMAL Actual is :" << std::endl;
        DecDisplay(actual);

        return false;
    }
}

bool CYEqualsToExpected(LPCSTR err_id, const CY& expected, const CY& actual)
{
    if(expected == actual)
        return true;
    else
    {
        std::cout << "\t#Native Side Err# -- " << err_id 
            << "\n\tCY Expected is :" << "Hi = " << expected.Hi
            << "Lo = " << expected.Lo << std::endl;

        std::cout << "\tCY Actual is :" << "Hi = " << actual.Hi
            << "Lo = " << actual.Lo << std::endl;

        return false;
    }
}

template<typename T>
T* RetSpecificTypeInstancePtr(T tVal)
{
    T* lpT = (T*)CoTaskMemAlloc(sizeof(T));
    *lpT = tVal;
    return lpT;
}

// As Struct
extern "C" __declspec(dllexport) BOOL __cdecl ReverseCall_TakeDecByInOutRef(Fp_Dec fp)
{
    DECIMAL* lpDec = RetSpecificTypeInstancePtr(g_DECIMAL_MaxValue);

    if((*fp)(lpDec))
        return DecEqualsToExpected("001.01", g_DECIMAL_MinValue, *lpDec);
    else
        return false;
}

extern "C" __declspec(dllexport) BOOL __stdcall ReverseCall_TakeDecByOutRef(Fp_Dec fp)
{
    DECIMAL* lpDec = RetSpecificTypeInstancePtr(g_DECIMAL_MaxValue);

    if((*fp)(lpDec))
        return DecEqualsToExpected("001.02", g_DECIMAL_Zero, *lpDec);
    else
        return false;
}

extern "C" __declspec(dllexport) BOOL ReverseCall_DecRet(Fp_RetDec fp)
{
    return DecEqualsToExpected("001.03", g_DECIMAL_MinValue, (*fp)());
}

extern "C" __declspec(dllexport) BOOL __cdecl ReverseCall_TakeStru_Seq_DecAsStructAsFldByInOutRef(Fp_Stru_Seq_DecAsStructAsFld fp)
{
    Stru_Seq_DecAsStructAsFld s = { 1, g_DECIMAL_MaxValue };

    if((*fp)(&s))
        return DecEqualsToExpected("001.04", g_DECIMAL_MinValue, s.dec) && IntEqualsToExpected("001.05", s.number, 2);
    else
        return false;
}

// As CY
extern "C" __declspec(dllexport) BOOL __cdecl ReverseCall_TakeCYByInOutRef(Fp_CY fp)
{
    CY* lpCy = RetSpecificTypeInstancePtr(g_CY_MaxValue);

    if((*fp)(lpCy))
        return CYEqualsToExpected("002.01", g_CY_MinValue, *lpCy);
    else
        return false;
}

extern "C" __declspec(dllexport) BOOL __stdcall ReverseCall_TakeCYByOutRef(Fp_CY fp)
{
    CY* lpCy = RetSpecificTypeInstancePtr(g_CY_MaxValue);

    if((*fp)(lpCy))
        return CYEqualsToExpected("002.02", g_CY_Zero, *lpCy);
    else
        return false;
}

extern "C" __declspec(dllexport) BOOL ReverseCall_CYRet(Fp_RetCY fp)
{
    return CYEqualsToExpected("002.03", g_CY_MinValue, (*fp)());
}

extern "C" __declspec(dllexport) BOOL __cdecl ReverseCall_TakeStru_Exp_DecAsCYAsFldByOutRef(Fp_Stru_Exp_DecAsCYAsFld fp)
{
    Stru_Exp_DecAsCYAsFld s = { 0 };

    if((*fp)(&s))
        return CYEqualsToExpected("002.04", g_CY_MaxValue, s.cy) && Equals("002.05", L'C', s.wc);
    else
        return false;
}

// As LPStrcut
extern "C" __declspec(dllexport) BOOL __cdecl ReverseCall_TakeDecByInOutRefAsLPStruct(Fp_DecAsLPStruct fp)
{
    DECIMAL* lpDec = RetSpecificTypeInstancePtr(g_DECIMAL_MaxValue);
    DECIMAL**    lppDec = &lpDec;

    if((*fp)(lppDec))
        return DecEqualsToExpected("003.01", g_DECIMAL_MinValue, **lppDec);
    else
        return false;
}

extern "C" __declspec(dllexport) BOOL __stdcall ReverseCall_TakeDecByOutRefAsLPStruct(Fp_DecAsLPStruct fp)
{
    DECIMAL* lpDecAsLPStruct = RetSpecificTypeInstancePtr(g_DECIMAL_MaxValue);
    DECIMAL** lppDecAsLPStruct = &lpDecAsLPStruct;

    if((*fp)(lppDecAsLPStruct))
        return DecEqualsToExpected("003.02", g_DECIMAL_Zero, **lppDecAsLPStruct);
    else
        return false;
}

extern "C" __declspec(dllexport) BOOL ReverseCall_DecAsLPStructRet(Fp_RetDecAsLPStruct fp)
{
    return DecEqualsToExpected("003.03", g_DECIMAL_MinValue, *(*fp)());
}

extern "C" __declspec(dllexport) BOOL __cdecl ReverseCall_TakeStru_Seq_DecAsLPStructAsFldByInOutRef(Fp_Stru_Seq_DecAsLPStructAsFld fp)
{
    DECIMAL* lpDec = RetSpecificTypeInstancePtr(g_DECIMAL_MaxValue);
    Stru_Seq_DecAsLPStructAsFld s = { 1.23, 'I',  lpDec};

    if((*fp)(&s))
        return DecEqualsToExpected("003.04", g_DECIMAL_MinValue, *s.dec) 
        && Equals("001.05", 3.21, s.dblVal) 
        && Equals("001.06", 'M', s.cVal);
    else
        return false;
}

//************** ReverseCall Return Int From Net **************//
typedef int (*Fp_RetInt)();
extern "C" __declspec(dllexport) BOOL ReverseCall_IntRet(Fp_RetInt fp)
{
    return 0x12345678 == (*fp)();
}
