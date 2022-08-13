using UnityEditor;
using UnityEngine;

namespace CustomAttributes
{
    [CustomPropertyDrawer(typeof(NotNullAttribute))]
    public class NotNullPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            if (property.objectReferenceValue == null)
            {
                GUI.backgroundColor = Color.red;
            }
            
            EditorGUI.PropertyField(position, property, GUIContent.none);
            
            EditorGUI.EndProperty();
        }
    }
}
