﻿using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(MonsterGroupPosition))]
public class MonsterGroupPositionEditor : Editor {


    void OnEnable()
    {
        labelStyle = new GUIStyle
        {
            fontSize = 22
        };
        labelStyle.normal.textColor = Color.green;
    }
    private GUIStyle labelStyle;
    private readonly string label = "怪物点";


    void OnSceneGUI()
    {
        var t = this.target  as MonsterGroupPosition;
        var defaultColor = Handles.color;
        Handles.color = Color.green;
        Handles.Label(t.transform.position+ (Vector3.up)*0.5f, label, labelStyle);
        Handles.ArrowHandleCap(1, t.transform.position, t.transform.rotation,t.radius, EventType.MouseDrag);
        Handles.color = defaultColor;
    }
}
