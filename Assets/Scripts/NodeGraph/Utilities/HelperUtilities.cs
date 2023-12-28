using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HelperUtilities
{
    /** 빈 문자열인지 확인한다 */
    public static bool ValidateCheckEmptyString(Object ThisObject, string FieldName, string StringToCheck)
    {
        if(StringToCheck == "")
        {
            Debug.Log(FieldName + "is Empty and must contain a value in object" + ThisObject.name.ToString());
            return true;
        }
        
        return false;
    }

    /** 목록이 비어있거나 null 값이 포함되어 있을 경우 - 오류가 있으면 true 반환 */
    public static bool ValidateCheckEnumerableValues(Object ThisObject, string FieldName, IEnumerable EnumerableObjectToCheck)
    {
        bool Error = false;
        int Count = 0;

        foreach(var Item in EnumerableObjectToCheck)
        {
            if(Item == null)
            {
                Debug.Log(FieldName + " has null values in Object " + ThisObject.name.ToString());
                Error = true;
            }
            else
            {
                Count++;
            }
        }

        if(Count == 0)
        {
            Debug.Log(FieldName + " has no values in object " + ThisObject.name.ToString());
            Error = true;
        }

        return Error;
    }
}
