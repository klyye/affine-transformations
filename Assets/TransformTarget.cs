using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTarget : MonoBehaviour
{
    public void ResetPosition()
    {
        var trans = transform;
        trans.localScale = Vector3.one * 2;
        trans.position = Vector3.zero;
        // trans.RotateAround(Vector3.zero, Vector3.forward, 45);
        trans.rotation = Quaternion.identity;
    }

    private void Start()
    {
        ResetPosition();
    }
}
