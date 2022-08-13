using UnityEditor;
using UnityEngine;

namespace CustomAttributes
{
    [CustomPropertyDrawer(typeof(ForceInterfaceAttribute))]
    public class ForceInterfacePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.propertyType != SerializedPropertyType.ObjectReference)
            {
                EditorGUI.LabelField(position, "Use an object reference for ForceInterfaceAttribute");
                return;
            }

            var forceAttribute = (ForceInterfaceAttribute)attribute;
            EditorGUI.BeginProperty(position, label, property);
            EditorGUI.BeginChangeCheck();

            var obj = EditorGUI.ObjectField(position, label, property.objectReferenceValue, typeof(Object), !EditorUtility.IsPersistent(property.serializedObject.targetObject));

            if (!EditorGUI.EndChangeCheck()) return;

            if (obj == null)
            {
                property.objectReferenceValue = null;
            }
            else if (forceAttribute.InterfaceType.IsInstanceOfType(obj))
            {
                property.objectReferenceValue = obj;
            }
            else if (obj is GameObject)
            {
                var component = (MonoBehaviour)((GameObject)obj).GetComponent(forceAttribute.InterfaceType);
                if (component != null)
                {
                    property.objectReferenceValue = component;
                }
            }
        
            EditorGUI.EndProperty();
        }
    }
}
