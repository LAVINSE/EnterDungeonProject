using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoomNodeTypeListSO", menuName = "Scriptable Objects/Dungeon/Room Node Type List")]
public class RoomNodeTypeListSO : ScriptableObject
{
    #region 변수
    public List<RoomNodeTypeSO> TypeList;
    #endregion // 변수

    #region UnityEditor
#if UNITY_EDITOR
    /** 변경 사항 체크 */
    private void OnValidate()
    {
        // null 값인지, 빈 리스트인지 확인
        HelperUtilities.ValidateCheckEnumerableValues(this, nameof(TypeList), TypeList);
    }
#endif // UNITY_EDITOR
    #endregion // UnityEditor
}
