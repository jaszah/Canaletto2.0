using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextLocalizerUI : MonoBehaviour
{
    TextMeshProUGUI textField;

    public string key;
    public bool onStart = true;

    private void Start()
    {
        if (onStart)
        {
            SetText();
        }
    }

    public void SetText()
    {
        textField = GetComponent<TextMeshProUGUI>();
        string value = LocalizationSystem.GetLocalisedValue(key);
        textField.text = value;
    }
}
