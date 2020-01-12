using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void SetPlayStyle(string style) {
        PlayerPrefs.SetString("PlayStyle", style);
    }

    public void LoadScene(int scene) {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }
}
