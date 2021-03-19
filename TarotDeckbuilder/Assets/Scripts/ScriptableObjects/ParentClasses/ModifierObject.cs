using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public abstract class ModifierObject : ScriptableObject
{
    public enum ModifierType { }
    public ModifierType modType;

    [Header("Variables for Children")]
    public string modName;
    [TextArea(10, 5)]
    public string modDescription;
    public Image modImage;

}
