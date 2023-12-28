using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoomNodeType", menuName = "Scriptable Objects/Dungeon/Room Node Type")]
public class RoomNodeTypeSO : ScriptableObject
{
    #region 변수
    public string RoomNodeTypeName; // 방 노드타입 이름

    public bool DisplayInNodeGraphEditor = true; // 노드 그래프 편집기에 표시해야되는 방 노드 타입 지정
    public bool IsCorridor; // 한가지 타입은 복도
    public bool IsCorridorsNS; // 한가지 타입은 복도 남북
    public bool IsCorridorEW; // 한가지 타입은 복도 동서
    public bool IsEntrance; // 한가지 타입은 입구
    public bool IsBossRoom; // 한가지 타입은 보스방
    public bool IsNone; // 기본값
    #endregion 변수

    #region UnityEditor
#if UNITY_EDITOR
    /** 변경 사항 체크 */
    private void OnValidate()
    {
        // 빈 문자열인지 확인
        HelperUtilities.ValidateCheckEmptyString(this, nameof(RoomNodeTypeName), RoomNodeTypeName);
    }
#endif // UNITY_EDITOR
    #endregion // UnityEditor

    #region 함수
    #endregion // 함수
}
