using System;
using UnityEngine;

namespace CustomAttributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class NotNullAttribute : PropertyAttribute
    {
    
    }
}
