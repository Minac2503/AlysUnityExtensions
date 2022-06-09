﻿using UnityEditor;
using UnityEngine;

namespace NS {
	public class ReadOnly : PropertyAttribute
	{
	
	}
#if UNITY_EDITOR
    [CustomPropertyDrawer(typeof(ReadOnly))]
	public class ROD : PropertyDrawer
	{
		public override float GetPropertyHeight(SerializedProperty property,
			GUIContent label)
		{
			return EditorGUI.GetPropertyHeight(property, label, true);
		}
	
		public override void OnGUI(Rect position,
			SerializedProperty property,
			GUIContent label)
		{
			GUI.enabled = false;
			EditorGUI.PropertyField(position, property, label, true);
			GUI.enabled = true;
		}
	}
#endif
}