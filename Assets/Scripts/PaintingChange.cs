using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
//using UnityEditor;
//using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PaintingChange : MonoBehaviour
{
    public int pNumber;
    public static string exSceneName;

    public Image smolImg;
    public Image bigImg;
    public TextMeshProUGUI bigButtonImg;
    public TextMeshProUGUI bigButtonDesc;

    public string[] pDescriptions = { "Obraz pierwszy opis. Obraz pierwszy opis. Obraz pierwszy opis. Obraz pierwszy opis. " +
            "Obraz pierwszy opis. Obraz pierwszy opis. Obraz pierwszy opis. Obraz pierwszy opis. " +
            "Obraz pierwszy opis. Obraz pierwszy opis. Obraz pierwszy opis. Obraz pierwszy opis. ",
            "Obraz drugi opis. Obraz drugi opis. Obraz drugi opis. Obraz drugi opis. " +
            "Obraz drugi opis. Obraz drugi opis. Obraz drugi opis. Obraz drugi opis. " +
            "Obraz drugi opis. Obraz drugi opis. Obraz drugi opis. Obraz drugi opis. ",
            "Obraz trzeci opis. Obraz trzeci opis. Obraz trzeci opis. Obraz trzeci opis. " +
            "Obraz trzeci opis. Obraz trzeci opis. Obraz trzeci opis. Obraz trzeci opis. " +
            "Obraz trzeci opis. Obraz trzeci opis. Obraz trzeci opis. Obraz trzeci opis. ",
            "Obraz czwarty opis. Obraz czwarty opis. Obraz czwarty opis. Obraz czwarty opis. " +
            "Obraz czwarty opis. Obraz czwarty opis. Obraz czwarty opis. Obraz czwarty opis. " +
            "Obraz czwarty opis. Obraz czwarty opis. Obraz czwarty opis. Obraz czwarty opis. ",
            "Obraz piąty opis. Obraz piąty opis. Obraz piąty opis. Obraz piąty opis. " +
            "Obraz piąty opis. Obraz piąty opis. Obraz piąty opis. Obraz piąty opis. " +
            "Obraz piąty opis. Obraz piąty opis. Obraz piąty opis. Obraz piąty opis. "};

    public void PChange()
    {
        switch (pNumber)
        {
            case 1:
                bigButtonImg.text = pNumber.ToString();
                bigImg.sprite = smolImg.sprite;

                exSceneName = "ExploreScene" + pNumber.ToString();
                bigButtonDesc.text = pDescriptions[0];
                break;

            case 2:
                bigButtonImg.text = pNumber.ToString();
                bigImg.sprite = smolImg.sprite;

                exSceneName = "ExploreScene" + pNumber.ToString();
                bigButtonDesc.text = pDescriptions[1];
                break;

            case 3:
                bigButtonImg.text = pNumber.ToString();
                bigImg.sprite = smolImg.sprite;

                exSceneName = "ExploreScene" + pNumber.ToString();
                bigButtonDesc.text = pDescriptions[2];
                break; ;

            case 4:
                bigButtonImg.text = pNumber.ToString();
                bigImg.sprite = smolImg.sprite;

                exSceneName = "ExploreScene" + pNumber.ToString();
                bigButtonDesc.text = pDescriptions[3];
                break;

            case 5:
                bigButtonImg.text = pNumber.ToString();
                bigImg.sprite = smolImg.sprite;

                exSceneName = "ExploreScene" + pNumber.ToString();
                bigButtonDesc.text = pDescriptions[4];
                break;
        }
    }
}
