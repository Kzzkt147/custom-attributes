using System;
using UnityEngine;

// Add a [ConditionHide()] attribute to a serialized field to hide it if the provided bool is false.
// [ConditionHide("boolName", true)] (The true bool is whether you want to hide the field instead of just greying it out.

namespace CustomAttributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Struct, Inherited = true)]
    public class ConditionHideAttribute : PropertyAttribute
    {
        public readonly string ConditionBoolName;
        public readonly bool HideInInspector;

        public ConditionHideAttribute(string conditionBoolName)
        {
            ConditionBoolName = conditionBoolName;
            HideInInspector = true;
        }

        public ConditionHideAttribute(string conditionBoolName, bool showInInspector)
        {
            ConditionBoolName = conditionBoolName;
            HideInInspector = !showInInspector;
        }
    }
}
