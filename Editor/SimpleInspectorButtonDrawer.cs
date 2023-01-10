using UnityEngine;
using UnityEditor;
using System.Reflection;
using UnityEditorInternal;
using System.Collections.Generic;

namespace CSH
{
    [CustomPropertyDrawer(typeof(SimpleInspectorButton))]
    public class SimpleInspectorButtonDrawer : PropertyDrawer
    {
        Object target;
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            target = property.serializedObject.targetObject;
            if (GUI.Button(new Rect(new Vector2(position.position.x, position.position.y), new Vector2(position.size.x, position.size.y)), property.FindPropertyRelative("ButtonText").stringValue))
            {
                MethodInfo mInfo = target.GetType().GetMethod(property.FindPropertyRelative("MethodName").stringValue);
                if (mInfo != null)
                {
                    mInfo.Invoke(target, null);
                }
                else
                {
                    Debug.LogError("Method with name " + property.FindPropertyRelative("MethodName").stringValue +
                        " was not found. Chec for spelling errors and make sure the desired method is public");
                }
            }
        }
    }
}