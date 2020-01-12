using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public PlayStyle styleOfPlay;

    public GameObject TopDownCamera;

    public GameObject FirstPersonCamera;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("PlayStyle")) {
        #if UNITY_STANDALONE
            PlayerPrefs.SetString("PlayStyle", PlayStyle.FirstPerson.ToString());
            Debug.Log("Playstyle is set to first person");
        #else
            PlayerPrefs.SetString("PlayStyle", PlayStyle.TopDown.ToString());
            Debug.Log("Playstyle is set to top down");
        #endif
        }

        var style = PlayerPrefs.GetString("PlayStyle");
        var successParse = PlayStyle.TryParse(style, true, out styleOfPlay);
        if (!successParse) {
            Debug.Log($"Couldn't parse playstyle {style}");
            styleOfPlay = PlayStyle.TopDown;
        }

        TopDownCamera.SetActive(styleOfPlay == PlayStyle.TopDown);
        TopDownCamera.GetComponent<Camera>().enabled = styleOfPlay == PlayStyle.TopDown;
        
        FirstPersonCamera.SetActive(styleOfPlay == PlayStyle.FirstPerson);
        FirstPersonCamera.GetComponent<Camera>().enabled = styleOfPlay == PlayStyle.FirstPerson;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
