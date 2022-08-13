using UnityEditor;
using UnityEngine;

namespace CustomAttributes
{
    [CustomPropertyDrawer(typeof(SeparatorAttribute))]
    public class SeparatorPropertyDrawer : DecoratorDrawer
    {
        public override float GetHeight()
        {
            var separatorAttribute = attribute as SeparatorAttribute;
            return Mathf.Max(separatorAttribute.Padding, separatorAttribute.Thickness);
        }

        public override void OnGUI(Rect position)
        {
            var separatorAttribute = attribute as SeparatorAttribute;

            position.height = separatorAttribute.Thickness;
            position.y += separatorAttribute.Padding * 0.5f;
            
            EditorGUI.DrawRect(position, EditorGUIUtility.isProSkin ? new Color(.3f,.3f,.3f,1) : new Color(.7f,.7f,.7f,1f));
        }
    }
}
