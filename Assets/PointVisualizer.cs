using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class PointVisualizer : MonoBehaviour
{
    private TMP_Text textComponent;
    [SerializeField] private Transform toFollow;
    private Camera cam;
    
    void Awake()
    {
        textComponent = GetComponent<TMP_Text>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        var pos = toFollow.position;
        transform.position = cam.WorldToScreenPoint(pos + Vector3.up * 0.5f);
        textComponent.text = $"({Math.Round(pos.x, 3)}, {Math.Round(pos.y, 3)})";
    }
}
