using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : Base
{

    private Renderer _renderer;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private float rnd()
    {
        return Random.Range(0.0f, 1.0f);
    }

    public override void Act()
    {
        _renderer.material.color = new Color(rnd(), rnd(), rnd(), 1f);
    }

    public override string Name()
    {
        return "Sphere";
    }
}
