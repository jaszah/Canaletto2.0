using UnityEngine;
using TMPro;

public class ModalManager : MonoBehaviour
{
    public GameObject modalWindow;
    public GameObject header;//miejsce na kluucz
    public GameObject body;//miejsce na klucz

    public static ModalManager instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void ShowModal(string headerKey, string bodyKey)
    {
        this.header.GetComponent<TextLocalizerUI>().key = headerKey;//header key dodać do miejsca na klucz w headerze zamiast dodawać txt
        this.header.GetComponent<TextLocalizerUI>().SetText();

        this.body.GetComponent<TextLocalizerUI>().key = bodyKey;//header key dodać do miejsca na klucz w headerze zamiast dodawać txt
        this.body.GetComponent<TextLocalizerUI>().SetText();
        //this.body.text = bodyKey;//tak jak wyżej

        modalWindow.SetActive(true);
        LeanTween.alpha(modalWindow.GetComponent<RectTransform>(), 0f, 0f);
    }

    public void HideModal()
    {
        if (modalWindow.activeSelf)
        modalWindow.SetActive(false);
        else
        modalWindow.SetActive(true);
    }
}
