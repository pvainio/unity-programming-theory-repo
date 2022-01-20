using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// INHERITANCE
public class Cube : Base
{
    private bool spinning;

    void Update()
    {
        if (spinning)
        {
            transform.Rotate(Vector3.up, 30 * Time.deltaTime);
        }
    }

    override
    public void Act()
    {
        spinning = !spinning;
    }

    public override string Name()
    {
        return "Cube";
    }
}
