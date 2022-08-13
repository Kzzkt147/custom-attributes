using UnityEngine;

public class ExampleObject : MonoBehaviour
{
    [CustomAttributes.Header("Example Object", 5f, "red")]
    //---------------------------------------------------------------------------------------
    [CustomAttributes.Separator()]
    
    [CustomAttributes.Header("Tags", 2f, "Silver")]
    [CustomAttributes.Tag] public string myTag = "Untagged";

    //---------------------------------------------------------------------------------------
    [CustomAttributes.Separator()]
    
    [CustomAttributes.Header("Condition Hide")]
    public bool showInt;
    
    [CustomAttributes.ConditionHide("showInt", false)]
    public int myInt;
    
    //---------------------------------------------------------------------------------------
    [CustomAttributes.Separator()] 
    
    [CustomAttributes.Header("Read Only")]
    [CustomAttributes.ReadOnly] public Vector2 readOnlyField = Vector2.up;
    
    //---------------------------------------------------------------------------------------
    [CustomAttributes.Separator()] 
    
    [CustomAttributes.Header("Not Null")]
    [CustomAttributes.NotNull()] public GameObject myObjectReference;
    
    //---------------------------------------------------------------------------------------
    [CustomAttributes.Separator()]
    
    [CustomAttributes.Header("Force Interface")]
    [CustomAttributes.ForceInterface(typeof(IInterfaceExample))] public Object objectWithInterface;
    
    //---------------------------------------------------------------------------------------
    [CustomAttributes.Separator()] 
    
    [CustomAttributes.Header("Button")]
    [CustomAttributes.Button("ButtonMethod")] public string myButton;

    public void ButtonMethod()
    {
        Debug.Log("Button Pressed!");
    }
}
