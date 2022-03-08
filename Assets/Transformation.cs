using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class Transformation : MonoBehaviour
{
    protected Button applyButton;

    protected TMP_InputField input;

    protected TransformTarget target;
    
    // Start is called before the first frame update
    void Awake()
    {
        applyButton = GetComponentInChildren<Button>();
        input = GetComponentInChildren<TMP_InputField>();
        input.characterValidation = TMP_InputField.CharacterValidation.Decimal;
        target = FindObjectOfType<TransformTarget>();
        applyButton.onClick.AddListener(Apply);
    }

    public abstract void Apply();
}
