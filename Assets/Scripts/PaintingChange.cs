﻿using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PaintingChange : MonoBehaviour
{
    public int pNumber;
    public static string exSceneName = "ExploreScene1";

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
        TextLocalizerUI txtLocalizer = GameObject.Find("PaintingDesc").GetComponent<TextLocalizerUI>();

        switch (pNumber)
        {
            case 1:
                bigButtonImg.text = pNumber.ToString();
                bigImg.sprite = smolImg.sprite;

                txtLocalizer.key = "p_desc_two";
                txtLocalizer.SetText();

                exSceneName = "ExploreScene" + pNumber.ToString();

                ExplorationMode.sceneNumber = pNumber - 1;
                break;

            case 2:
                bigButtonImg.text = pNumber.ToString();
                bigImg.sprite = smolImg.sprite;

                exSceneName = "ExploreScene" + pNumber.ToString();
                bigButtonDesc.text = pDescriptions[1];

                ExplorationMode.sceneNumber = pNumber - 1;
                break;

            case 3:
                bigButtonImg.text = pNumber.ToString();
                bigImg.sprite = smolImg.sprite;

                exSceneName = "ExploreScene" + pNumber.ToString();
                bigButtonDesc.text = pDescriptions[2];

                ExplorationMode.sceneNumber = pNumber - 1;
                break;

            case 4:
                bigButtonImg.text = pNumber.ToString();
                bigImg.sprite = smolImg.sprite;

                exSceneName = "ExploreScene" + pNumber.ToString();
                bigButtonDesc.text = pDescriptions[3];

                ExplorationMode.sceneNumber = pNumber - 1;
                break;

            case 5:
                bigButtonImg.text = pNumber.ToString();
                bigImg.sprite = smolImg.sprite;

                exSceneName = "ExploreScene" + pNumber.ToString();
                bigButtonDesc.text = pDescriptions[4];

                ExplorationMode.sceneNumber = pNumber - 1;
                break;
        }
    }
}
