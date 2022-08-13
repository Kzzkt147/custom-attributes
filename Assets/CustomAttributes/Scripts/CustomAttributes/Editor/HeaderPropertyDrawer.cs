using UnityEngine;
using UnityEditor;

namespace CustomAttributes
{
    [CustomPropertyDrawer(typeof(HeaderAttribute))]
    public class HeaderPropertyDrawer : DecoratorDrawer
    {
        public override void OnGUI(Rect position)
        {
            if (attribute is not HeaderAttribute headerAttribute) return;

            position = EditorGUI.IndentedRect(position);
            position.yMin += EditorGUIUtility.singleLineHeight * (headerAttribute.TextHeightIncrease - 0.5f);

            var style = new GUIStyle(EditorStyles.label) { richText = true };

            var label =
                new GUIContent($"<color={headerAttribute.ColorString}><size={style.fontSize + headerAttribute.TextHeightIncrease}><b>{headerAttribute.Header}</b></size></color>");
            
            EditorGUI.LabelField(position, label, style);
        }

        public override float GetHeight()
        {
            var headerAttribute = attribute as HeaderAttribute;
            return EditorGUIUtility.singleLineHeight * (headerAttribute?.TextHeightIncrease + 0.5f ?? 0);
        }
    }
}