using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomNodeSO : ScriptableObject
{
    [HideInInspector] public string Id;
    [HideInInspector] public List<string> ParentRoomNodeIdList = new List<string>();
    [HideInInspector] public List<string> ChildRoomNodeIdList = new List<string>();
    [HideInInspector] public RoomNodeGraphSO RoomNodeGraph;
    [HideInInspector] public RoomNodeTypeListSO RoomNodeTypeList;
    public RoomNodeTypeSO RoomNodeType;
}
