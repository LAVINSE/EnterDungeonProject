using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// 커스텀 에디터
public class RoomNodeGraphEditor : EditorWindow
{
    #region 변수
    private GUIStyle RoomNodeStyle;

    // Node 레이아웃 값
    private const float NodeWidth = 160f;
    private const float NodeHeight = 75f;
    private const int NodePadding = 25;
    private const int NodeBorder = 12;
    #endregion // 변수

    #region 함수
    [MenuItem("Room Node Graph Editor", menuItem = "Window/Dungeon Editor/Room Node Graph Editor")]
    private static void OpenWindow()
    {
        // 창 띄우기
        GetWindow<RoomNodeGraphEditor>("Room Node Graph Editor");
    }

    private void OnEnable()
    {
        RoomNodeStyle = new GUIStyle();
        // 배경 조정
        RoomNodeStyle.normal.background = EditorGUIUtility.Load("node1") as Texture2D;
        // 텍스트 색상 조정
        RoomNodeStyle.normal.textColor = Color.white;
        // 테두리 조정
        RoomNodeStyle.padding = new RectOffset(NodePadding, NodePadding, NodePadding, NodePadding);
        RoomNodeStyle.border = new RectOffset(NodeBorder, NodeBorder, NodeBorder, NodeBorder);
    }

    /** 에디터 그리기 */
    private void OnGUI()
    {
        // 고정된 스크린 사이즈의 블록
        GUILayout.BeginArea(new Rect(new Vector2(100f, 100f), new Vector2(NodeWidth, NodeHeight)), RoomNodeStyle);
        EditorGUILayout.LabelField("Node 1");
        GUILayout.EndArea();

        GUILayout.BeginArea(new Rect(new Vector2(300f, 300f), new Vector2(NodeWidth, NodeHeight)), RoomNodeStyle);
        EditorGUILayout.LabelField("Node 1");
        GUILayout.EndArea();
    }
    #endregion // 함수
}
