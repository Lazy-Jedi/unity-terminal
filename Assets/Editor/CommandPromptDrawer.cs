#if UNITY_EDITOR
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// [CustomPropertyDrawer(typeof())]
public class CommandPromptDrawer : PropertyDrawer
{
    #region VARIABLES
    #endregion

    #region UNITY METHODS

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        base.OnGUI(position, property, label);
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return base.GetPropertyHeight(property, label);
    }

    #endregion

    #region METHODS
    #endregion
}
#endif