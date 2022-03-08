using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Scale : MonoBehaviour
{
    private Button applyButton;

    private TMP_InputField input;

    [SerializeField] private bool isX; // true for scale on X false for Y i'm short on time

    private TransformTarget target;

    // Start is called before the first frame update
    void Awake()
    {
        applyButton = GetComponentInChildren<Button>();
        input = GetComponentInChildren<TMP_InputField>();
        target = FindObjectOfType<TransformTarget>();
        applyButton.onClick.AddListener(Apply);
    }

    public void Apply()
    {
        var val = float.Parse(input.text);
        // Matrix4x4 mat;
        if (isX) // this is ass, if i had more time i would use some sort of vector representing axis
        {
            // mat = new Matrix4x4(
            //     new Vector4(val, 0, 0, 0), 
            //     new Vector4(0, 1, 0, 0),
            //     new Vector4(0, 0, 1, 0),
            //     new Vector4(0, 0, 0, 1)
            //     );
            var origScale = target.transform.localScale;
            target.transform.localScale = new Vector3(origScale.x * val, origScale.y, origScale.z);
        }
        else
        {
            // mat = new Matrix4x4(
            //     new Vector4(1, 0, 0, 0), 
            //     new Vector4(0, val, 0, 0),
            //     new Vector4(0, 0, 1, 0),
            //     new Vector4(0, 0, 0, 1)
            //     );
            var origScale = target.transform.localScale;
            target.transform.localScale = new Vector3(origScale.x, val * origScale.y, origScale.z);
        }
    }
}