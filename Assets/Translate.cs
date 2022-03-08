using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : Transformation
{
    [SerializeField] private Vector3 axis;

    public override void Apply()
    {
        var val = float.Parse(input.text);
        target.transform.position += axis * val;
    }
}
