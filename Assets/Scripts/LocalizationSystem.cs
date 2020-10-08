using System.Collections.Generic;
using UnityEngine;

public class LocalizationSystem : MonoBehaviour
{
    public enum Language
    {
        Polish,
        English
    }

    public static Language language = Language.English;

    public static Dictionary<string, string> localisedPL;
    public static Dictionary<string, string> localisedEN;

    public static bool isInit;

    public static void Init()
    {
        CSVLoader csvLoader = new CSVLoader();
        csvLoader.LoadCSV();

        localisedPL = csvLoader.GetDictionaryValues("pl");
        localisedEN = csvLoader.GetDictionaryValues("en");

        isInit = true;
    }

    public static string GetLocalisedValue(string key)
    {
        if (!isInit) { Init(); }

        string value = key;

        switch (language)
        {
            case Language.Polish:
                localisedPL.TryGetValue(key, out value);
                break;
            case Language.English:
                localisedEN.TryGetValue(key, out value);
                break;
        }

        return value;
    }
}