using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour {

    private const string GUIDE_NAME_KEY = "guide_name";

    public static void SaveGuideName(string name)
    {
        PlayerPrefs.SetString(GUIDE_NAME_KEY, name);
    }

    public static string GetGuideName()
    {
        return PlayerPrefs.GetString(GUIDE_NAME_KEY, "Don");
    }
}
