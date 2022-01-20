using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Base : MonoBehaviour
{
    public abstract void Act();

    public virtual string Name()
    {
        return "Base";
    }

    public void OnMouseDown()
    {
        DisplayText();
        Act();
    }

    public virtual void DisplayText()
    {
        Debug.Log($"Hello world from {Name()}!");
    }
}
