using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Scale : Transformation
{

    [SerializeField] private bool isX; // true for scale on X false for Y i'm short on time

    public void ScaleAround(GameObject target, Vector3 pivot, Vector3 newScale)
    {
        Vector3 A = target.transform.localPosition;
        Vector3 B = pivot;
     
        Vector3 C = A - B; // diff from object pivot to desired pivot/origin
     
        float RS = newScale.x / target.transform.localScale.x; // relative scale factor
     
        // calc final position post-scale
        Vector3 FP = B + C * RS;
     
        // finally, actually perform the scale/translation
        target.transform.localScale = newScale;
        target.transform.localPosition = FP;
    }
 

    public override void Apply()
    {
        var val = float.Parse(input.text);
        if (isX) // this is ass, if i had more time i would use some sort of vector representing axis
        {
            var origScale = target.transform.localScale;
            var newScale = new Vector3(origScale.x * val, origScale.y, origScale.z);
            ScaleAround(target.gameObject, Vector3.zero, newScale);
        }
        else
        {
            var origScale = target.transform.localScale;
            var newScale = new Vector3(origScale.x, val * origScale.y, origScale.z);
            ScaleAround(target.gameObject, Vector3.zero, newScale);
        }
    }
}