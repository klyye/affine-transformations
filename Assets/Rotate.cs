using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : Transformation
{
    public override void Apply()
    {
        var val = float.Parse(input.text);
        target.transform.RotateAround(Vector3.zero, Vector3.forward, val);
    }
}
