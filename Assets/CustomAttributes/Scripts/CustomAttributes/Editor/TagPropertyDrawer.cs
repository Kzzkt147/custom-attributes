using UnityEditor;
using UnityEngine;

namespace CustomAttributes
{
    [CustomPropertyDrawer(typeof(TagAttribute))]
    public class TagPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property == null) return;

            if (property.propertyType != SerializedPropertyType.String)
            {
                Debug.LogError($"{nameof(TagAttribute)} only supports string fields.");
                return;
            }

            using (new EditorGUI.PropertyScope(position, label, property))
            {
                using (var changeCheckScope = new EditorGUI.ChangeCheckScope())
                {
                    property.stringValue = EditorGUI.TagField(position, label, property.stringValue);

                    if (changeCheckScope.changed)
                    {
                        property.serializedObject?.ApplyModifiedProperties();
                    }
                }
            }
        }
    }
}
