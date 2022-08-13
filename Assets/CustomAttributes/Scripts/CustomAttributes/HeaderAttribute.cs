using System;
using UnityEngine;

namespace CustomAttributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class HeaderAttribute : PropertyAttribute
    {
        public readonly string Header;

        public readonly string ColorString;

        public readonly Color Color;

        public readonly float TextHeightIncrease;

        public HeaderAttribute(string header, float textHeightIncrease = 2f, string colorString = "Silver")
        {
            Header = header;
            ColorString = colorString;
            TextHeightIncrease = Mathf.Max(1, textHeightIncrease);

            if (ColorUtility.TryParseHtmlString(colorString, out var newColor))
            {
                Color = newColor;
                return;
            }

            Color = new Color(173, 216, 230);
            ColorString = "LightBlue";
        }
    }
}
