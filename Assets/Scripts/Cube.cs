using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// INHERITANCE
public class Cube : Base
{
    private bool spinning;

    // ENCAPSULATION
    public bool Spinning { get { return spinning; } set { Debug.Log("Not supported from outside"); } }

    void Update()
    {
        if (spinning)
        {
            transform.Rotate(Vector3.up, 30 * Time.deltaTime);
        }
    }

    // ABSTRACTION
    // POLYMORPHISM
    public override void Act()
    {
        spinning = !spinning;
    }

    // POLYMORPHISM
    public override string Name()
    {
        return "Cube";
    }
}
