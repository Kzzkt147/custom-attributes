using System;
using UnityEngine;

namespace CustomAttributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class SeparatorAttribute : PropertyAttribute
    {
        public readonly int Thickness;
        public readonly float Padding;

        public SeparatorAttribute(int thickness = 5, float padding = 10)
        {
            Thickness = thickness;
            Padding = padding;
        }
    }
}
